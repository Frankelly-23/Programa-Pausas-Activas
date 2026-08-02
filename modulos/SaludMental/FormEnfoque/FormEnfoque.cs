using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace PausasActivas.Modulos
{
    public partial class FormEnfoque : Form
    {
        public FormEnfoque()
        {
            InitializeComponent();
            ConectarEventosRespiracion();
            IniciarRespiracionEnfoque();
            PausarRespiracionEnfoque();
        }

        private const float ESCALA_MINIMA_ENF = 0.55f;

        private readonly (string Nombre, int Duracion, float EscalaInicio, float EscalaFin)[] _fasesEnfoque =
            new (string, int, float, float)[]
            {
                ("Inhala", 4, ESCALA_MINIMA_ENF, 1f),
                ("Retén",  4, 1f,                1f),
                ("Exhala", 4, 1f,                ESCALA_MINIMA_ENF),
                ("Pausa",  4, ESCALA_MINIMA_ENF, ESCALA_MINIMA_ENF),
            };

        private System.Windows.Forms.Timer _timerEnfoque;
        private int _indiceFaseEnfoque = 0;
        private double _segundosFaseActualEnfoque = 0;
        private bool _respirandoEnCursoEnfoque = false;

        private Size _tamanoOriginalCirculoEnfoque;
        private Point _centroOriginalCirculoEnfoque;

        private WaveOutEvent _salidaAudioEnfoque;
        private AudioFileReader _lectorAudioEnfoque;
        private LoopStream _loopAudioEnfoque;
        private readonly string _carpetaSonidosEnfoque = Path.Combine(Application.StartupPath, "Sonidos");

        private void ConectarEventosRespiracion()
        {
            _tamanoOriginalCirculoEnfoque = btninhala.Size;
            _centroOriginalCirculoEnfoque = new Point(
                btninhala.Left + btninhala.Width / 2,
                btninhala.Top + btninhala.Height / 2);

            _timerEnfoque = new System.Windows.Forms.Timer { Interval = 50 };
            _timerEnfoque.Tick += TimerEnfoque_Tick;

            btniniciar.Click += btniniciar_Click;
            btnsin.Click += btnsin_Click;
            btnnaturaleza.Click += btnnaturaleza_Click;
            btnlluvia.Click += btnlluvia_Click;
            btncampana.Click += btncampana_Click;
            barravolumen.Scroll += barravolumen_Scroll;

            lblvolumen.Text = barravolumen.Value + "%";
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (_respirandoEnCursoEnfoque)
            {
                PausarRespiracionEnfoque();
                return;
            }
            IniciarRespiracionEnfoque();
        }

        private void IniciarRespiracionEnfoque()
        {
            _respirandoEnCursoEnfoque = true;
            _indiceFaseEnfoque = 0;
            _segundosFaseActualEnfoque = 0;

            var faseInicial = _fasesEnfoque[0];
            lblinhala.Text = faseInicial.Nombre;
            btninhala.Text = faseInicial.Nombre;
            lblcontador.Text = "0s";
            btniniciar.Text = "Pausar";

            _timerEnfoque.Start();
        }

        private void PausarRespiracionEnfoque()
        {
            _respirandoEnCursoEnfoque = false;
            _timerEnfoque.Stop();
            btniniciar.Text = "Iniciar";
        }

        private void TimerEnfoque_Tick(object sender, EventArgs e)
        {
            _segundosFaseActualEnfoque += 0.05;

            var fase = _fasesEnfoque[_indiceFaseEnfoque];

            if (_segundosFaseActualEnfoque >= fase.Duracion)
            {

                if (_indiceFaseEnfoque == _fasesEnfoque.Length - 1)
                {
                    _timerEnfoque.Stop();
                    _respirandoEnCursoEnfoque = false;
                    RedimensionarCirculoEnfoque(ESCALA_MINIMA_ENF);
                    lblcontador.Text = fase.Duracion + "s";

                    MessageBox.Show(
                        "Respiración completa",
                        "Ejercicio finalizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    var faseInicial = _fasesEnfoque[0];
                    lblinhala.Text = faseInicial.Nombre;
                    btninhala.Text = faseInicial.Nombre;
                    lblcontador.Text = "0s";
                    btniniciar.Text = "Iniciar";
                    RedimensionarCirculoEnfoque(faseInicial.EscalaInicio);
                    return;
                }


                _indiceFaseEnfoque++;
                _segundosFaseActualEnfoque = 0;
                fase = _fasesEnfoque[_indiceFaseEnfoque];

                lblinhala.Text = fase.Nombre;
                btninhala.Text = fase.Nombre;
            }


            lblcontador.Text = (int)Math.Floor(_segundosFaseActualEnfoque) + "s";

            double progreso = fase.Duracion == 0 ? 1 : _segundosFaseActualEnfoque / fase.Duracion;
            float escala = SuavizarEnfoque(fase.EscalaInicio, fase.EscalaFin, progreso);
            RedimensionarCirculoEnfoque(escala);
        }

        private float SuavizarEnfoque(float desde, float hasta, double progreso)
        {
            progreso = Math.Max(0, Math.Min(1, progreso));
            double suave = 0.5 - 0.5 * Math.Cos(progreso * Math.PI);
            return (float)(desde + (hasta - desde) * suave);
        }

        private void RedimensionarCirculoEnfoque(float escala)
        {
            int nuevoAncho = (int)(_tamanoOriginalCirculoEnfoque.Width * escala);
            int nuevoAlto = (int)(_tamanoOriginalCirculoEnfoque.Height * escala);

            btninhala.Size = new Size(nuevoAncho, nuevoAlto);
            btninhala.Location = new Point(
                _centroOriginalCirculoEnfoque.X - nuevoAncho / 2,
                _centroOriginalCirculoEnfoque.Y - nuevoAlto / 2);
        }

        private void btnsin_Click(object sender, EventArgs e) => DetenerSonidoEnfoque();

        private void btnnaturaleza_Click(object sender, EventArgs e) => ReproducirSonidoEnfoque("naturaleza");

        private void btnlluvia_Click(object sender, EventArgs e) => ReproducirSonidoEnfoque("lluvia");

        private void btncampana_Click(object sender, EventArgs e) => ReproducirSonidoEnfoque("campanas");

        private void ReproducirSonidoEnfoque(string nombreSinExtension)
        {
            DetenerSonidoEnfoque();

            string ruta = BuscarArchivoSonidoEnfoque(nombreSinExtension);
            if (ruta == null)
            {
                MessageBox.Show(
                    $"No se encontró el archivo de sonido '{nombreSinExtension}' en:\n{_carpetaSonidosEnfoque}",
                    "Sonido no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _lectorAudioEnfoque = new AudioFileReader(ruta) { Volume = barravolumen.Value / 100f };
                _loopAudioEnfoque = new LoopStream(_lectorAudioEnfoque) { EnableLooping = true };

                _salidaAudioEnfoque = new WaveOutEvent();
                _salidaAudioEnfoque.Init(_loopAudioEnfoque);
                _salidaAudioEnfoque.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo reproducir el sonido: " + ex.Message,
                    "Error de audio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuscarArchivoSonidoEnfoque(string nombreSinExtension)
        {
            if (!Directory.Exists(_carpetaSonidosEnfoque)) return null;

            foreach (var ext in new[] { ".mp3", ".wav" })
            {
                string candidato = Path.Combine(_carpetaSonidosEnfoque, nombreSinExtension + ext);
                if (File.Exists(candidato)) return candidato;
            }
            return null;
        }

        private void DetenerSonidoEnfoque()
        {
            _salidaAudioEnfoque?.Stop();
            _salidaAudioEnfoque?.Dispose();
            _salidaAudioEnfoque = null;

            _loopAudioEnfoque?.Dispose();
            _loopAudioEnfoque = null;

            _lectorAudioEnfoque?.Dispose();
            _lectorAudioEnfoque = null;
        }

        private void barravolumen_Scroll(object sender, EventArgs e)
        {
            lblvolumen.Text = barravolumen.Value + "%";
            if (_lectorAudioEnfoque != null)
            {
                _lectorAudioEnfoque.Volume = barravolumen.Value / 100f;
            }
        }

        private void LiberarRecursosRespiracion()
        {
            _timerEnfoque?.Stop();
            DetenerSonidoEnfoque();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            LiberarRecursosRespiracion();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? Color.FromArgb(16, 3, 99) : Color.Transparent;
            btnPin.ForeColor = this.TopMost ? Color.White : Color.FromArgb(16, 3, 99);
        }
    }
}
