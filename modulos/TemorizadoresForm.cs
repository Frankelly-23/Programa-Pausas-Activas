using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics.Eventing.Reader;

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
        private Label label5;
        private Label label6;
        private Label label7;
        private MenuStrip menuStrip1;
        private Timer timer;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem salirToolStripMenuItem;

        public TemorizadoresForm()
        {
            InitializeComponent();
        }

        //Variables a utilizar
        int tiempoRestante = 3600; //los 60 minutos en segundos
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            timer = new Timer(components);
            PBPomodoro.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label1.Location = new System.Drawing.Point(39, 51);
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
            PBPomodoro.Location = new System.Drawing.Point(82, 192);
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
            BInicioPausa.BorderRadius = 20;
            BInicioPausa.CustomizableEdges = customizableEdges2;
            BInicioPausa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BInicioPausa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BInicioPausa.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BInicioPausa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BInicioPausa.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            BInicioPausa.FocusedColor = System.Drawing.Color.White;
            BInicioPausa.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BInicioPausa.ForeColor = System.Drawing.Color.White;
            BInicioPausa.Location = new System.Drawing.Point(440, 217);
            BInicioPausa.Name = "BInicioPausa";
            BInicioPausa.ShadowDecoration.CustomizableEdges = customizableEdges3;
            BInicioPausa.Size = new System.Drawing.Size(166, 66);
            BInicioPausa.TabIndex = 3;
            BInicioPausa.Text = "⏩ Iniciar";
            BInicioPausa.Click += BInicioPausa_Click;
            // 
            // BReiniciar
            // 
            BReiniciar.BorderRadius = 20;
            BReiniciar.CustomizableEdges = customizableEdges4;
            BReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BReiniciar.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            BReiniciar.FocusedColor = System.Drawing.Color.White;
            BReiniciar.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BReiniciar.ForeColor = System.Drawing.Color.White;
            BReiniciar.Location = new System.Drawing.Point(440, 304);
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
            guna2ProgressBar1.Location = new System.Drawing.Point(39, 523);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2ProgressBar1.Size = new System.Drawing.Size(638, 25);
            guna2ProgressBar1.TabIndex = 5;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label3.Location = new System.Drawing.Point(39, 493);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(231, 27);
            label3.TabIndex = 6;
            label3.Text = "👁️ Regla 20 / 20 /20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label4.Location = new System.Drawing.Point(29, 551);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(250, 27);
            label4.TabIndex = 8;
            label4.Text = "👣 Reto de movimiento";
            // 
            // guna2ProgressBar2
            // 
            guna2ProgressBar2.BackColor = System.Drawing.Color.FromArgb(91, 104, 140);
            guna2ProgressBar2.CustomizableEdges = customizableEdges8;
            guna2ProgressBar2.Location = new System.Drawing.Point(39, 592);
            guna2ProgressBar2.Name = "guna2ProgressBar2";
            guna2ProgressBar2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ProgressBar2.Size = new System.Drawing.Size(638, 20);
            guna2ProgressBar2.TabIndex = 7;
            guna2ProgressBar2.Text = "guna2ProgressBar2";
            guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label5.Location = new System.Drawing.Point(440, 493);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(237, 20);
            label5.TabIndex = 9;
            label5.Text = "Próxima micropausa en 00:00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label6.Location = new System.Drawing.Point(499, 558);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(178, 20);
            label6.TabIndex = 10;
            label6.Text = "Próximo reto en 00:00";
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label7.Location = new System.Drawing.Point(50, 105);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(376, 48);
            label7.TabIndex = 11;
            label7.Text = "🔔 Recibiras una notificación suave cada 2 minutos antes de cada cambio de fase.";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(109, 158, 226);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(725, 29);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // TemorizadoresForm
            // 
            BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            ClientSize = new System.Drawing.Size(725, 669);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BInicioPausa);
            Controls.Add(label4);
            Controls.Add(PBPomodoro);
            Controls.Add(BReiniciar);
            Controls.Add(guna2ProgressBar2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Controls.Add(guna2ProgressBar1);
            Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "TemorizadoresForm";
            PBPomodoro.ResumeLayout(false);
            PBPomodoro.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante <= 0)
            {
                Reset();
                SystemSounds.Beep.Play();
                MessageBox.Show("⭐¡Tiempo terminado!⭐", " 🔔 Notificación");
            }
            else
            {
                tiempoRestante--;
                PBPomodoro.Value += 1;

                int minutos = tiempoRestante / 60;
                int segundos = tiempoRestante % 60;

                labelTiempo.Text = $"{minutos:00}:{segundos:00}";
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
                BInicioPausa.Text = "⏸️ Pausar";
                timer.Start();
            }
            else 
            {
                BInicioPausa.Text = "⏩ Reanudar";
                timer.Stop();
            }
        }

        //Metodo para resetear los controles
        private void Reset()
        {
            timer.Dispose();
            labelTiempo.Text = "60:00";
            PBPomodoro.Value = 0;
            BInicioPausa.Text = "⏩ Iniciar";
            tiempoRestante = 3600;
        }
    }
}