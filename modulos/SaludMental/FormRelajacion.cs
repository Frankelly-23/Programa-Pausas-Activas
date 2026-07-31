using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public partial class FormRelajacion : Form
    {
        public FormRelajacion()
        {
            InitializeComponent();
            ConectarEventosRespiracion();
            IniciarRespiracion();
            PausarRespiracion();
        }

       
        private const int SEG_FIN_INHALA = 4;
        private const int SEG_FIN_RETEN = 7;
        private const int SEG_FIN_EXHALA = 8;

        private System.Windows.Forms.Timer _timerRespiracion;
        private double _segundosTranscurridos = 0;
        private bool _respirandoEnCurso = false;

        private Size _tamanoOriginalCirculo;
        private Point _centroOriginalCirculo;
        private const float ESCALA_MINIMA = 0.55f; 

        private WaveOutEvent _salidaAudio;
        private AudioFileReader _lectorAudio;
        private LoopStream _loopAudio;
        private readonly string _carpetaSonidos = Path.Combine(Application.StartupPath, "Sonidos");

        private void ConectarEventosRespiracion()
        {
            _tamanoOriginalCirculo = btninhala.Size;
            _centroOriginalCirculo = new Point(
                btninhala.Left + btninhala.Width / 2,
                btninhala.Top + btninhala.Height / 2);

            _timerRespiracion = new System.Windows.Forms.Timer { Interval = 50 };
            _timerRespiracion.Tick += TimerRespiracion_Tick;
           
            btnsin.Click += btnsin_Click;
            btnnaturaleza.Click += btnnaturaleza_Click;
            btnlluvia.Click += btnlluvia_Click;
            btncampanas.Click += btncampana_Click;
            barravolumen.Scroll += barravolumen_Scroll;
            lblvolumen.Text = barravolumen.Value + "%";
        }

        private void IniciarRespiracion()
        {
            _respirandoEnCurso = true;
            _segundosTranscurridos = 0;

            lblinhala.Text = "Inhala";
            btninhala.Text = "Inhala";
            lblcontador.Text = "0s";
            btniniciar.Text = "Pausar";

            _timerRespiracion.Start();
        }

        private void PausarRespiracion()
        {
            _respirandoEnCurso = false;
            _timerRespiracion.Stop();
            btniniciar.Text = "Iniciar";
        }

        private void TimerRespiracion_Tick(object sender, EventArgs e)
        {
            _segundosTranscurridos += 0.05; 

            string fase;
            float escala; 

            if (_segundosTranscurridos < SEG_FIN_INHALA)
            {
                fase = "Inhala";
                double progreso = _segundosTranscurridos / SEG_FIN_INHALA;
                escala = Suavizar(ESCALA_MINIMA, 1f, progreso);
            }
            else if (_segundosTranscurridos < SEG_FIN_RETEN)
            {
                fase = "Retén";
                escala = 1f; 
            }
            else if (_segundosTranscurridos < SEG_FIN_EXHALA)
            {
                fase = "Exhala";
                double progreso = (_segundosTranscurridos - SEG_FIN_RETEN)
                                   / (SEG_FIN_EXHALA - SEG_FIN_RETEN);
                escala = Suavizar(1f, ESCALA_MINIMA, progreso);
            }
            else
            {
                _timerRespiracion.Stop();
                _respirandoEnCurso = false;
                RedimensionarCirculo(1f); 
                lblcontador.Text = SEG_FIN_EXHALA + "s";

                MessageBox.Show(
                    "Respiración completa",
                    "Ejercicio finalizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblinhala.Text = "Inhala";
                btninhala.Text = "Inhala";
                lblcontador.Text = "0s";
                btniniciar.Text = "Iniciar";
                return;
            }

            if (lblinhala.Text != fase)
            {
                lblinhala.Text = fase;
                btninhala.Text = fase;
            }

            lblcontador.Text = (int)Math.Floor(_segundosTranscurridos) + "s";

            RedimensionarCirculo(escala);
        }

        private float Suavizar(float desde, float hasta, double progreso)
        {
            progreso = Math.Max(0, Math.Min(1, progreso));
            double suave = 0.5 - 0.5 * Math.Cos(progreso * Math.PI);
            return (float)(desde + (hasta - desde) * suave);
        }

        private void RedimensionarCirculo(float escala)
        {
            int nuevoAncho = (int)(_tamanoOriginalCirculo.Width * escala);
            int nuevoAlto = (int)(_tamanoOriginalCirculo.Height * escala);

            btninhala.Size = new Size(nuevoAncho, nuevoAlto);
            btninhala.Location = new Point(
                _centroOriginalCirculo.X - nuevoAncho / 2,
                _centroOriginalCirculo.Y - nuevoAlto / 2);
        }

        private void btnsin_Click(object sender, EventArgs e) => DetenerSonido();

        private void btnnaturaleza_Click(object sender, EventArgs e) => ReproducirSonido("naturaleza");

        private void btnlluvia_Click(object sender, EventArgs e) => ReproducirSonido("lluvia");

        private void btncampana_Click(object sender, EventArgs e) => ReproducirSonido("campanas");

        private void ReproducirSonido(string nombreSinExtension)
        {
            DetenerSonido();

            string ruta = BuscarArchivoSonido(nombreSinExtension);
            if (ruta == null)
            {
                MessageBox.Show(
                    $"No se encontró el archivo de sonido '{nombreSinExtension}' en:\n{_carpetaSonidos}",
                    "Sonido no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _lectorAudio = new AudioFileReader(ruta) { Volume = barravolumen.Value / 100f };
                _loopAudio = new LoopStream(_lectorAudio) { EnableLooping = true };

                _salidaAudio = new WaveOutEvent();
                _salidaAudio.Init(_loopAudio);
                _salidaAudio.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo reproducir el sonido: " + ex.Message,
                    "Error de audio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuscarArchivoSonido(string nombreSinExtension)
        {
            if (!Directory.Exists(_carpetaSonidos)) return null;

            foreach (var ext in new[] { ".mp3", ".wav" })
            {
                string candidato = Path.Combine(_carpetaSonidos, nombreSinExtension + ext);
                if (File.Exists(candidato)) return candidato;
            }
            return null;
        }

        private void DetenerSonido()
        {
            _salidaAudio?.Stop();
            _salidaAudio?.Dispose();
            _salidaAudio = null;

            _loopAudio?.Dispose();
            _loopAudio = null;

            _lectorAudio?.Dispose();
            _lectorAudio = null;
        }

        private void barravolumen_Scroll(object sender, EventArgs e)
        {
            lblvolumen.Text = barravolumen.Value + "%";
            if (_lectorAudio != null)
            {
                _lectorAudio.Volume = barravolumen.Value / 100f;
            }
        }

        private void LiberarRecursosRespiracion()
        {
            _timerRespiracion?.Stop();
            DetenerSonido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btniniciar_Click_1(object sender, EventArgs e)
        {
            if (_respirandoEnCurso)
            {
                PausarRespiracion();
                return;
            }

            IniciarRespiracion();

        }
    }
}



        
    