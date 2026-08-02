using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
namespace PausasActivas.Modulos
{
    public partial class FormRecuperacion : Form
    {
        public FormRecuperacion()
        {
            InitializeComponent();
            ConectarEventosRespiracion();
            IniciarRespiracionRecuperacion();
            PausarRespiracionRecuperacion();
            CargarPreferencias();
        }


        private readonly (string Nombre, int Duracion, float EscalaInicio, float EscalaFin)[] _fasesRecuperacion =
            new (string, int, float, float)[]
            {
                ("Inhala", 3, ESCALA_MINIMA_REC, 1f),
                ("Retén",  3, 1f,                1f),
                ("Exhala", 6, 1f,                ESCALA_MINIMA_REC),
            };

        private const float ESCALA_MINIMA_REC = 0.55f;

        private System.Windows.Forms.Timer _timerRecuperacion;
        private int _indiceFaseRecuperacion = 0;
        private double _segundosFaseActualRecuperacion = 0;
        private bool _respirandoEnCursoRecuperacion = false;

        private Size _tamanoOriginalCirculoRecuperacion;
        private Point _centroOriginalCirculoRecuperacion;

        private WaveOutEvent _salidaAudioRecuperacion;
        private AudioFileReader _lectorAudioRecuperacion;
        private LoopStream _loopAudioRecuperacion;
        private readonly string _carpetaSonidosRecuperacion = Path.Combine(Application.StartupPath, "Sonidos");
        
        private string _sonidoActual = "";
        
        private static readonly string rutaPreferencias = Path.Combine(Application.StartupPath, "Data", "saludmental_data.json");
        
        private class PreferenciasSaludMental
        {
            public int Volumen { get; set; } = 50;
            public string SonidoSeleccionado { get; set; } = "";
        }
        
        private void GuardarPreferencias()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaPreferencias));
                var prefs = new PreferenciasSaludMental
                {
                    Volumen = barravolumen.Value,
                    SonidoSeleccionado = _sonidoActual ?? ""
                };
                string json = System.Text.Json.JsonSerializer.Serialize(prefs, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaPreferencias, json);
            }
            catch { }
        }

        private void CargarPreferencias()
        {
            try
            {
                if (File.Exists(rutaPreferencias))
                {
                    string json = File.ReadAllText(rutaPreferencias);
                    var prefs = System.Text.Json.JsonSerializer.Deserialize<PreferenciasSaludMental>(json);
                    if (prefs != null)
                    {
                        barravolumen.Value = Math.Max(0, Math.Min(100, prefs.Volumen));
                        lblvolumen.Text = barravolumen.Value + "%";
                    }
                }
            }
            catch { }
        }

        private void ConectarEventosRespiracion()
        {
            _tamanoOriginalCirculoRecuperacion = btninhala.Size;
            _centroOriginalCirculoRecuperacion = new Point(
                btninhala.Left + btninhala.Width / 2,
                btninhala.Top + btninhala.Height / 2);

            _timerRecuperacion = new System.Windows.Forms.Timer { Interval = 50 };
            _timerRecuperacion.Tick += TimerRecuperacion_Tick;

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
            if (_respirandoEnCursoRecuperacion)
            {
                PausarRespiracionRecuperacion();
                return;
            }
            IniciarRespiracionRecuperacion();
        }

        private void IniciarRespiracionRecuperacion()
        {
            _respirandoEnCursoRecuperacion = true;
            _indiceFaseRecuperacion = 0;
            _segundosFaseActualRecuperacion = 0;

            var faseInicial = _fasesRecuperacion[0];
            lblinhala.Text = faseInicial.Nombre;
            btninhala.Text = faseInicial.Nombre;
            lblcontador.Text = "0s";
            btniniciar.Text = "Pausar";

            _timerRecuperacion.Start();
        }

        private void PausarRespiracionRecuperacion()
        {
            _respirandoEnCursoRecuperacion = false;
            _timerRecuperacion.Stop();
            btniniciar.Text = "Iniciar";
        }

        private void TimerRecuperacion_Tick(object sender, EventArgs e)
        {
            _segundosFaseActualRecuperacion += 0.05;

            var fase = _fasesRecuperacion[_indiceFaseRecuperacion];

            if (_segundosFaseActualRecuperacion >= fase.Duracion)
            {
                if (_indiceFaseRecuperacion == _fasesRecuperacion.Length - 1)
                {
                    _timerRecuperacion.Stop();
                    _respirandoEnCursoRecuperacion = false;
                    RedimensionarCirculoRecuperacion(1f);
                    lblcontador.Text = fase.Duracion + "s";

                    MessageBox.Show(
                        "Respiración completa",
                        "Ejercicio finalizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    var faseInicial = _fasesRecuperacion[0];
                    lblinhala.Text = faseInicial.Nombre;
                    btninhala.Text = faseInicial.Nombre;
                    lblcontador.Text = "0s";
                    btniniciar.Text = "Iniciar";
                    return;
                }

                _indiceFaseRecuperacion++;
                _segundosFaseActualRecuperacion = 0;
                fase = _fasesRecuperacion[_indiceFaseRecuperacion];

                lblinhala.Text = fase.Nombre;
                btninhala.Text = fase.Nombre;
            }

            lblcontador.Text = (int)Math.Floor(_segundosFaseActualRecuperacion) + "s";

            double progreso = fase.Duracion == 0 ? 1 : _segundosFaseActualRecuperacion / fase.Duracion;
            float escala = SuavizarRecuperacion(fase.EscalaInicio, fase.EscalaFin, progreso);
            RedimensionarCirculoRecuperacion(escala);
        }

        private float SuavizarRecuperacion(float desde, float hasta, double progreso)
        {
            progreso = Math.Max(0, Math.Min(1, progreso));
            double suave = 0.5 - 0.5 * Math.Cos(progreso * Math.PI);
            return (float)(desde + (hasta - desde) * suave);
        }

        private void RedimensionarCirculoRecuperacion(float escala)
        {
            int nuevoAncho = (int)(_tamanoOriginalCirculoRecuperacion.Width * escala);
            int nuevoAlto = (int)(_tamanoOriginalCirculoRecuperacion.Height * escala);

            btninhala.Size = new Size(nuevoAncho, nuevoAlto);
            btninhala.Location = new Point(
                _centroOriginalCirculoRecuperacion.X - nuevoAncho / 2,
                _centroOriginalCirculoRecuperacion.Y - nuevoAlto / 2);
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            DetenerSonidoRecuperacion();
            _sonidoActual = "sin";
        }

        private void btnnaturaleza_Click(object sender, EventArgs e)
        {
            ReproducirSonidoRecuperacion("naturaleza");
            _sonidoActual = "naturaleza";
        }

        private void btnlluvia_Click(object sender, EventArgs e)
        {
            ReproducirSonidoRecuperacion("lluvia");
            _sonidoActual = "lluvia";
        }

        private void btncampana_Click(object sender, EventArgs e)
        {
            ReproducirSonidoRecuperacion("campanas");
            _sonidoActual = "campanas";
        }

        private void ReproducirSonidoRecuperacion(string nombreSinExtension)
        {
            DetenerSonidoRecuperacion();

            string ruta = BuscarArchivoSonidoRecuperacion(nombreSinExtension);
            if (ruta == null)
            {
                MessageBox.Show(
                    $"No se encontró el archivo de sonido '{nombreSinExtension}' en:\n{_carpetaSonidosRecuperacion}",
                    "Sonido no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _lectorAudioRecuperacion = new AudioFileReader(ruta) { Volume = barravolumen.Value / 100f };
                _loopAudioRecuperacion = new LoopStream(_lectorAudioRecuperacion) { EnableLooping = true };

                _salidaAudioRecuperacion = new WaveOutEvent();
                _salidaAudioRecuperacion.Init(_loopAudioRecuperacion);
                _salidaAudioRecuperacion.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo reproducir el sonido: " + ex.Message,
                    "Error de audio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuscarArchivoSonidoRecuperacion(string nombreSinExtension)
        {
            if (!Directory.Exists(_carpetaSonidosRecuperacion)) return null;

            foreach (var ext in new[] { ".mp3", ".wav" })
            {
                string candidato = Path.Combine(_carpetaSonidosRecuperacion, nombreSinExtension + ext);
                if (File.Exists(candidato)) return candidato;
            }
            return null;
        }

        private void DetenerSonidoRecuperacion()
        {
            _salidaAudioRecuperacion?.Stop();
            _salidaAudioRecuperacion?.Dispose();
            _salidaAudioRecuperacion = null;

            _loopAudioRecuperacion?.Dispose();
            _loopAudioRecuperacion = null;

            _lectorAudioRecuperacion?.Dispose();
            _lectorAudioRecuperacion = null;
        }

        private void barravolumen_Scroll(object sender, EventArgs e)
        {
            lblvolumen.Text = barravolumen.Value + "%";
            if (_lectorAudioRecuperacion != null)
            {
                _lectorAudioRecuperacion.Volume = barravolumen.Value / 100f;
            }
        }
        private void LiberarRecursosRespiracion()
        {
            _timerRecuperacion?.Stop();
            DetenerSonidoRecuperacion();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            GuardarPreferencias();
            base.OnFormClosing(e);
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
