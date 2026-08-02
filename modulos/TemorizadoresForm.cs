using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text.Json;

namespace PausasActivas.Modulos
{
    public class TemorizadoresForm : Form
    {
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PBPomodoro;
        private Label labelTiempo;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button BInicioPausa;
        private Guna.UI2.WinForms.Guna2Button BReiniciar;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private Label labelMicropausa;
        private Label labelRetoDeMovimiento;
        private Label label7;
        private Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.IContainer components;

        // Timer dedicado para la Regla 20/20/20
        private System.Windows.Forms.Timer timerMicropausa;

        // Timer dedicado para el Reto de movimiento
        private System.Windows.Forms.Timer timerReto;

        // Notificación suave para avisos de cambio de fase
        private NotifyIcon notificacionSuave;

        public TemorizadoresForm()
        {
            InitializeComponent();

            //  Inicialización de la notificación suave
            notificacionSuave = new NotifyIcon();
            notificacionSuave.Icon = System.Drawing.SystemIcons.Information;
            notificacionSuave.Visible = true;

            // Configuración de la regla 20/20/20
            guna2ProgressBar1.Minimum = 0;
            guna2ProgressBar1.Maximum = tiempoMicropausa;
            guna2ProgressBar1.Value = 0;

            timerMicropausa = new System.Windows.Forms.Timer();
            timerMicropausa.Interval = 1000;
            timerMicropausa.Tick += timerMicropausa_Tick;
            // Ya no se inicia aquí: ahora arranca junto con el cronómetro principal (BInicioPausa_Click)

            // Configuración del reto de movimiento
            guna2ProgressBar2.Minimum = 0;
            guna2ProgressBar2.Maximum = tiempoReto;
            guna2ProgressBar2.Value = 0;

            timerReto = new System.Windows.Forms.Timer();
            timerReto.Interval = 1000;
            timerReto.Tick += timerReto_Tick;
            // Ya no se inicia aquí: ahora arranca junto con el cronómetro principal (BInicioPausa_Click)

            CargarDatos();
        }

        private static readonly string rutaArchivo = Path.Combine(Application.StartupPath, "Data", "temporizadores_data.json");

        //Variables a utilizar
        int tiempoRestante = 3600; //los 60 minutos en segundos
        int tiempoMicropausa = 1200; //20 minutos en segundos para la regla 20/20/20
        int tiempoReto = 1800; //30 minutos en segundos para el reto de movimiento

        // Lista de retos de movimiento para variar la sugerencia
        private readonly string[] retosMovimiento = new string[]
        {
            "🚶 Camina 5 minutos por tu espacio.",
            "🏃 Trota en el mismo lugar durante 1 minuto.",
            "🪜 Sube y baja escaleras un par de veces.",
            "🤸 Haz 15 sentadillas.",
            "🧍 Ponte de pie y estira brazos y piernas.",
            "🕺 Baila tu canción favorita durante 2 minutos."
        };
        private Random randomReto = new Random();

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolver = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolverShadow = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Panel();
            btnPin = new Guna.UI2.WinForms.Guna2Button();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            PBPomodoro = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            labelTiempo = new Label();
            BInicioPausa = new Guna.UI2.WinForms.Guna2Button();
            BReiniciar = new Guna.UI2.WinForms.Guna2Button();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            label3 = new Label();
            label4 = new Label();
            guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            labelMicropausa = new Label();
            labelRetoDeMovimiento = new Label();
            label7 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            PBPomodoro.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(171, 217, 244);
            panelHeader.Controls.Add(btnPin);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 80;
            panelHeader.Name = "panelHeader";
            panelHeader.TabIndex = 0;
            // 
            // btnPin
            // 
            btnPin.Animated = true;
            btnPin.BorderRadius = 12;
            btnPin.CustomizableEdges = cePin1;
            btnPin.FillColor = System.Drawing.Color.Transparent;
            btnPin.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            btnPin.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            btnPin.HoverState.FillColor = System.Drawing.Color.FromArgb(140, 195, 235);
            btnPin.Location = new System.Drawing.Point(650, 18);
            btnPin.Name = "btnPin";
            btnPin.ShadowDecoration.CustomizableEdges = cePin2;
            btnPin.Size = new System.Drawing.Size(50, 42);
            btnPin.TabIndex = 99;
            btnPin.Text = "📌";
            btnPin.Click += btnPin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label1.Location = new System.Drawing.Point(20, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 43);
            label1.TabIndex = 1;
            label1.Text = "Temporizadores";
            // 
            // PBPomodoro
            // 
            PBPomodoro.Controls.Add(label2);
            PBPomodoro.Controls.Add(labelTiempo);
            PBPomodoro.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
            PBPomodoro.Font = new System.Drawing.Font("Segoe UI", 12F);
            PBPomodoro.ForeColor = System.Drawing.Color.FromArgb(109, 158, 226);
            PBPomodoro.Location = new System.Drawing.Point(82, 222);
            PBPomodoro.Maximum = 3600;
            PBPomodoro.Minimum = 0;
            PBPomodoro.Name = "PBPomodoro";
            PBPomodoro.ProgressColor = System.Drawing.Color.FromArgb(109, 158, 226);
            PBPomodoro.ProgressColor2 = System.Drawing.Color.FromArgb(109, 158, 226);
            PBPomodoro.ShadowDecoration.CustomizableEdges = customizableEdges1;
            PBPomodoro.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            PBPomodoro.Size = new System.Drawing.Size(224, 224);
            PBPomodoro.TabIndex = 2;
            PBPomodoro.Text = "guna2CircleProgressBar1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(67, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "ENFOQUE";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.BackColor = System.Drawing.Color.Transparent;
            labelTiempo.Font = new System.Drawing.Font("Segoe UI", 33F);
            labelTiempo.Location = new System.Drawing.Point(46, 60);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new System.Drawing.Size(164, 74);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "60:00";
            // 
            // BInicioPausa
            // 
            BInicioPausa.BorderRadius = 12;
            BInicioPausa.CustomizableEdges = customizableEdges2;
            BInicioPausa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BInicioPausa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BInicioPausa.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BInicioPausa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BInicioPausa.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            BInicioPausa.FocusedColor = System.Drawing.Color.White;
            BInicioPausa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BInicioPausa.ForeColor = System.Drawing.Color.White;
            BInicioPausa.Location = new System.Drawing.Point(440, 247);
            BInicioPausa.Name = "BInicioPausa";
            BInicioPausa.ShadowDecoration.CustomizableEdges = customizableEdges3;
            BInicioPausa.Size = new System.Drawing.Size(166, 66);
            BInicioPausa.TabIndex = 3;
            BInicioPausa.Text = "⏩ Iniciar";
            BInicioPausa.Click += BInicioPausa_Click;
            // 
            // BReiniciar
            // 
            BReiniciar.BorderRadius = 12;
            BReiniciar.CustomizableEdges = customizableEdges4;
            BReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BReiniciar.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BReiniciar.FocusedColor = System.Drawing.Color.White;
            BReiniciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            BReiniciar.ForeColor = System.Drawing.Color.White;
            BReiniciar.Location = new System.Drawing.Point(440, 334);
            BReiniciar.Name = "BReiniciar";
            BReiniciar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            BReiniciar.Size = new System.Drawing.Size(166, 66);
            BReiniciar.TabIndex = 4;
            BReiniciar.Text = "🔄 Reiniciar";
            BReiniciar.Click += BReiniciar_Click;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.BackColor = System.Drawing.Color.FromArgb(91, 104, 140);
            guna2ProgressBar1.CustomizableEdges = customizableEdges6;
            guna2ProgressBar1.Location = new System.Drawing.Point(39, 553);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(109, 158, 226);
            guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(109, 158, 226);
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ProgressBar1.Size = new System.Drawing.Size(638, 25);
            guna2ProgressBar1.TabIndex = 5;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ProgressBar1.ValueChanged += guna2ProgressBar1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label3.Location = new System.Drawing.Point(39, 523);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(231, 27);
            label3.TabIndex = 6;
            label3.Text = "👁️ Regla 20 / 20 /20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label4.Location = new System.Drawing.Point(29, 592);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(250, 27);
            label4.TabIndex = 8;
            label4.Text = "👣 Reto de movimiento";
            // 
            // guna2ProgressBar2
            // 
            guna2ProgressBar2.BackColor = System.Drawing.Color.FromArgb(91, 104, 140);
            guna2ProgressBar2.CustomizableEdges = customizableEdges8;
            guna2ProgressBar2.Location = new System.Drawing.Point(39, 622);
            guna2ProgressBar2.Name = "guna2ProgressBar2";
            guna2ProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(128, 128, 255);
            guna2ProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(128, 128, 255);
            guna2ProgressBar2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ProgressBar2.Size = new System.Drawing.Size(638, 20);
            guna2ProgressBar2.TabIndex = 7;
            guna2ProgressBar2.Text = "guna2ProgressBar2";
            guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ProgressBar2.ValueChanged += guna2ProgressBar2_ValueChanged;
            // 
            // labelMicropausa
            // 
            labelMicropausa.AutoSize = true;
            labelMicropausa.BackColor = System.Drawing.Color.Transparent;
            labelMicropausa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelMicropausa.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            labelMicropausa.Location = new System.Drawing.Point(476, 528);
            labelMicropausa.Name = "labelMicropausa";
            labelMicropausa.Size = new System.Drawing.Size(237, 20);
            labelMicropausa.TabIndex = 9;
            labelMicropausa.Text = "Próxima micropausa en 20:00";
            labelMicropausa.Click += labelMicropausa_Click;
            // 
            // labelRetoDeMovimiento
            // 
            labelRetoDeMovimiento.AutoSize = true;
            labelRetoDeMovimiento.BackColor = System.Drawing.Color.Transparent;
            labelRetoDeMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelRetoDeMovimiento.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            labelRetoDeMovimiento.Location = new System.Drawing.Point(525, 597);
            labelRetoDeMovimiento.Name = "labelRetoDeMovimiento";
            labelRetoDeMovimiento.Size = new System.Drawing.Size(177, 20);
            labelRetoDeMovimiento.TabIndex = 10;
            labelRetoDeMovimiento.Text = "Próximo reto en 30:00";
            labelRetoDeMovimiento.Click += labelRetoDeMovimiento_Click;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label7.Location = new System.Drawing.Point(50, 135);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(376, 48);
            label7.TabIndex = 11;
            label7.Text = "🔔 Recibiras una notificación suave 2 minutos antes de cada cambio de fase.";
            // 
            // btnVolver
            // 
            btnVolver.Animated = true;
            btnVolver.BorderRadius = 12;
            btnVolver.CustomizableEdges = ceVolver;
            btnVolver.FillColor = System.Drawing.Color.Transparent;
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnVolver.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            btnVolver.HoverState.FillColor = System.Drawing.Color.FromArgb(230, 240, 250);
            btnVolver.HoverState.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            btnVolver.Location = new System.Drawing.Point(15, 650);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ceVolverShadow;
            btnVolver.Size = new System.Drawing.Size(120, 40);
            btnVolver.TabIndex = 99;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // TemorizadoresForm
            // 
            BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            ClientSize = new System.Drawing.Size(725, 700);
            Controls.Add(panelHeader);
            Controls.Add(label7);
            Controls.Add(labelRetoDeMovimiento);
            Controls.Add(BInicioPausa);
            Controls.Add(label4);
            Controls.Add(PBPomodoro);
            Controls.Add(BReiniciar);
            Controls.Add(guna2ProgressBar2);
            Controls.Add(labelMicropausa);
            Controls.Add(label3);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(btnVolver);
            Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TemorizadoresForm";
            Text = "Temporizadores y Alarmas";
            // >>> NUEVO: liberar el NotifyIcon al cerrar el formulario
            FormClosed += TemorizadoresForm_FormClosed;
            PBPomodoro.ResumeLayout(false);
            PBPomodoro.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante <= 0)
            {
                Reset();
                SystemSounds.Asterisk.Play();
                MessageBox.Show("⭐¡Tiempo terminado!⭐", " 🔔 Notificación");
            }
            else
            {
                tiempoRestante--;
                PBPomodoro.Value += 1;

                int minutos = tiempoRestante / 60;
                int segundos = tiempoRestante % 60;

                labelTiempo.Text = $"{minutos:00}:{segundos:00}";

                // >>> NUEVO: Notificación suave 2 minutos antes del cambio de fase
                if (tiempoRestante == 120)
                {
                    notificacionSuave.ShowBalloonTip(
                        3000,
                        "🔔 Cambio de fase próximo",
                        "Quedan 2 minutos para el cambio de fase del cronómetro principal.",
                        ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                }
            }
        }
        private void BReiniciar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BInicioPausa_Click(object sender, EventArgs e)
        {
            if (BInicioPausa.Text == "⏩ Iniciar" || BInicioPausa.Text == "⏩ Reanudar")
            {
                SystemSounds.Asterisk.Play();
                BInicioPausa.Text = "⏸️ Pausar";

                // Al iniciar/reanudar el cronómetro principal, también arrancan
                // la regla 20/20/20 y el reto de movimiento.
                timer.Start();
                timerMicropausa.Start();
                timerReto.Start();
            }
            else
            {
                BInicioPausa.Text = "⏩ Reanudar";

                // Al pausar el cronómetro principal, también se pausan
                // la regla 20/20/20 y el reto de movimiento.
                timer.Stop();
                timerMicropausa.Stop();
                timerReto.Stop();
            }
        }

        //Metodo para resetear los controles
        private void Reset()
        {
            // Se detienen los tres timers en vez de Dispose(), para poder
            // volver a iniciarlos con el botón "Iniciar" sin errores.
            timer.Stop();
            timerMicropausa.Stop();
            timerReto.Stop();

            // Reinicio del cronómetro principal
            labelTiempo.Text = "60:00";
            PBPomodoro.Value = 0;
            BInicioPausa.Text = "⏩ Iniciar";
            tiempoRestante = 3600;

            // Reinicio de la regla 20/20/20
            tiempoMicropausa = 1200;
            guna2ProgressBar1.Value = 0;

            // Reinicio del reto de movimiento
            tiempoReto = 1800;
            guna2ProgressBar2.Value = 0;
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            int minutos = tiempoMicropausa / 60;
            int segundos = tiempoMicropausa % 60;
            labelMicropausa.Text = $"Próxima micropausa en {minutos:00}:{segundos:00}";
        }

        private void labelMicropausa_Click(object sender, EventArgs e)
        {
            tiempoMicropausa = 1200;
            guna2ProgressBar1.Value = 0;
        }

        // Tick del timer para la Regla 20/20/20
        private void timerMicropausa_Tick(object sender, EventArgs e)
        {
            if (tiempoMicropausa <= 0)
            {
                tiempoMicropausa = 1200; // reinicia a 20 minutos
                guna2ProgressBar1.Value = 0;
                SystemSounds.Asterisk.Play();
                MessageBox.Show(
                    "👁️ Mira algo a unos 20 pies (6 metros) de distancia durante 20 segundos.",
                    "🔔 Regla 20/20/20");
            }
            else
            {
                tiempoMicropausa--;
                guna2ProgressBar1.Value += 1;
            }
        }

        private void labelRetoDeMovimiento_Click(object sender, EventArgs e)
        {
            tiempoReto = 1800;
            guna2ProgressBar2.Value = 0;
        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {
            int minutos = tiempoReto / 60;
            int segundos = tiempoReto % 60;
            labelRetoDeMovimiento.Text = $"Próximo reto en {minutos:00}:{segundos:00}";
        }

        // Tick del timer para el Reto de movimiento
        private void timerReto_Tick(object sender, EventArgs e)
        {
            if (tiempoReto <= 0)
            {
                tiempoReto = 1800; // reinicia a 30 minutos
                guna2ProgressBar2.Value = 0;
                SystemSounds.Asterisk.Play();

                string reto = retosMovimiento[randomReto.Next(retosMovimiento.Length)];
                MessageBox.Show(reto, "🏃 Reto de movimiento");
            }
            else
            {
                tiempoReto--;
                guna2ProgressBar2.Value += 1;
            }
        }

        
        private void TemorizadoresForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuardarDatos();
            notificacionSuave.Dispose();
            // TODO(Frankelly) Equipo 1: construir la UI aquí
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? System.Drawing.Color.FromArgb(16, 3, 99) : System.Drawing.Color.Transparent;
            btnPin.ForeColor = this.TopMost ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(16, 3, 99);
        }
        private Guna.UI2.WinForms.Guna2Button btnPin;

        private void GuardarDatos()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));
                var datos = new DatosTemporizadores
                {
                    TiempoRestante = tiempoRestante,
                    TiempoMicropausa = tiempoMicropausa,
                    TiempoReto = tiempoReto,
                    TimerActivo = timer.Enabled,
                    FechaGuardado = DateTime.Now
                };
                string json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, json);
            }
            catch { }
        }

        private bool CargarDatos()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);
                    var datos = JsonSerializer.Deserialize<DatosTemporizadores>(json);
                    if (datos != null)
                    {
                        tiempoRestante = datos.TiempoRestante;
                        tiempoMicropausa = datos.TiempoMicropausa;
                        tiempoReto = datos.TiempoReto;

                        // If timers were active, subtract elapsed time
                        if (datos.TimerActivo)
                        {
                            int elapsed = (int)(DateTime.Now - datos.FechaGuardado).TotalSeconds;
                            tiempoRestante = Math.Max(0, tiempoRestante - elapsed);
                            tiempoMicropausa = Math.Max(0, tiempoMicropausa - elapsed);
                            tiempoReto = Math.Max(0, tiempoReto - elapsed);
                        }

                        // Update UI
                        int minutos = tiempoRestante / 60;
                        int segundos = tiempoRestante % 60;
                        labelTiempo.Text = $"{minutos:00}:{segundos:00}";
                        PBPomodoro.Maximum = 3600;
                        PBPomodoro.Value = Math.Min(3600 - tiempoRestante, 3600);

                        guna2ProgressBar1.Maximum = 1200;
                        guna2ProgressBar1.Value = Math.Min(1200 - tiempoMicropausa, 1200);

                        guna2ProgressBar2.Maximum = 1800;
                        guna2ProgressBar2.Value = Math.Min(1800 - tiempoReto, 1800);

                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        private class DatosTemporizadores
        {
            public int TiempoRestante { get; set; }
            public int TiempoMicropausa { get; set; }
            public int TiempoReto { get; set; }
            public bool TimerActivo { get; set; }
            public DateTime FechaGuardado { get; set; }
        }
    }
}