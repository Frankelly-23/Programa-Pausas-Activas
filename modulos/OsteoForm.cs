using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace PausasActivas.Modulos


{
    public class OsteoForm : System.Windows.Forms.Form
    {
        private Guna.UI2.WinForms.Guna2Button BotonAnterior;

        private Guna.UI2.WinForms.Guna2Button botonCuello;

        private Guna.UI2.WinForms.Guna2Button BotonEspalda;

        private Guna.UI2.WinForms.Guna2Button BotonMuñeca;

        private Guna.UI2.WinForms.Guna2Button BotonPausa;

        private Guna.UI2.WinForms.Guna2Button BotonSiguiente;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label LabelPaso;

        private System.Windows.Forms.Label LabelEstiramiento;

        private System.Windows.Forms.PictureBox pictureBox1;
        private Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar TemporizadorBar;
        private System.ComponentModel.IContainer components;

        public OsteoForm()
        {
            InitializeComponent();
            this.Text = "Prevención Osteomuscular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // TODO Equipo 2: construir la UI aquí
        }


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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            botonCuello = new Guna.UI2.WinForms.Guna2Button();
            BotonMuñeca = new Guna.UI2.WinForms.Guna2Button();
            BotonEspalda = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            LabelEstiramiento = new Label();
            LabelPaso = new Label();
            BotonSiguiente = new Guna.UI2.WinForms.Guna2Button();
            BotonPausa = new Guna.UI2.WinForms.Guna2Button();
            BotonAnterior = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new Timer(components);
            TemporizadorBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lora", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 3, 99);
            label1.Location = new Point(171, 21);
            label1.Name = "label1";
            label1.Size = new Size(618, 71);
            label1.TabIndex = 0;
            label1.Text = "Prevencion Osteomuscular";
            // 
            // botonCuello
            // 
            botonCuello.Animated = true;
            botonCuello.BackColor = Color.Transparent;
            botonCuello.BorderRadius = 20;
            botonCuello.CustomizableEdges = customizableEdges1;
            botonCuello.DisabledState.BorderColor = Color.DarkGray;
            botonCuello.DisabledState.CustomBorderColor = Color.DarkGray;
            botonCuello.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botonCuello.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botonCuello.FillColor = Color.FromArgb(109, 158, 226);
            botonCuello.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCuello.ForeColor = Color.Black;
            botonCuello.Location = new Point(89, 117);
            botonCuello.Name = "botonCuello";
            botonCuello.ShadowDecoration.CustomizableEdges = customizableEdges2;
            botonCuello.Size = new Size(221, 79);
            botonCuello.TabIndex = 2;
            botonCuello.Text = "Cuello";
            botonCuello.Click += botonCuello_Click;
            // 
            // BotonMuñeca
            // 
            BotonMuñeca.Animated = true;
            BotonMuñeca.BackColor = Color.Transparent;
            BotonMuñeca.BorderRadius = 20;
            BotonMuñeca.CustomizableEdges = customizableEdges3;
            BotonMuñeca.DisabledState.BorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonMuñeca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonMuñeca.FillColor = Color.FromArgb(109, 158, 226);
            BotonMuñeca.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonMuñeca.ForeColor = Color.Black;
            BotonMuñeca.Location = new Point(352, 117);
            BotonMuñeca.Name = "BotonMuñeca";
            BotonMuñeca.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BotonMuñeca.Size = new Size(221, 79);
            BotonMuñeca.TabIndex = 3;
            BotonMuñeca.Text = "Muñecas";
            BotonMuñeca.Click += BotonMuñeca_Click;
            // 
            // BotonEspalda
            // 
            BotonEspalda.Animated = true;
            BotonEspalda.BackColor = Color.Transparent;
            BotonEspalda.BorderRadius = 20;
            BotonEspalda.CustomizableEdges = customizableEdges5;
            BotonEspalda.DisabledState.BorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonEspalda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonEspalda.FillColor = Color.FromArgb(109, 158, 226);
            BotonEspalda.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEspalda.ForeColor = Color.Black;
            BotonEspalda.Location = new Point(627, 117);
            BotonEspalda.Name = "BotonEspalda";
            BotonEspalda.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BotonEspalda.Size = new Size(221, 79);
            BotonEspalda.TabIndex = 4;
            BotonEspalda.Text = "Espalda";
            BotonEspalda.Click += BotonEspalda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 162);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LabelEstiramiento
            // 
            LabelEstiramiento.AutoSize = true;
            LabelEstiramiento.Font = new Font("Lora", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEstiramiento.ForeColor = Color.FromArgb(16, 3, 99);
            LabelEstiramiento.Location = new Point(41, 413);
            LabelEstiramiento.Name = "LabelEstiramiento";
            LabelEstiramiento.Size = new Size(398, 45);
            LabelEstiramiento.TabIndex = 7;
            LabelEstiramiento.Text = "Seleccione un estiramiento";
            // 
            // LabelPaso
            // 
            LabelPaso.AutoSize = true;
            LabelPaso.Font = new Font("Lora", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPaso.ForeColor = Color.FromArgb(16, 3, 99);
            LabelPaso.Location = new Point(50, 552);
            LabelPaso.Name = "LabelPaso";
            LabelPaso.Size = new Size(146, 36);
            LabelPaso.TabIndex = 9;
            LabelPaso.Text = "Paso _ de _";
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.Animated = true;
            BotonSiguiente.BackColor = Color.Transparent;
            BotonSiguiente.BorderRadius = 20;
            BotonSiguiente.CustomizableEdges = customizableEdges7;
            BotonSiguiente.DisabledState.BorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonSiguiente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonSiguiente.Enabled = false;
            BotonSiguiente.FillColor = Color.FromArgb(109, 158, 226);
            BotonSiguiente.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonSiguiente.ForeColor = Color.Black;
            BotonSiguiente.Location = new Point(579, 620);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BotonSiguiente.Size = new Size(159, 65);
            BotonSiguiente.TabIndex = 12;
            BotonSiguiente.Text = "Siguiente >";
            BotonSiguiente.Click += BotonSiguiente_Click;
            // 
            // BotonPausa
            // 
            BotonPausa.Animated = true;
            BotonPausa.BackColor = Color.Transparent;
            BotonPausa.BorderRadius = 20;
            BotonPausa.CustomizableEdges = customizableEdges9;
            BotonPausa.DisabledState.BorderColor = Color.DarkGray;
            BotonPausa.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonPausa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonPausa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonPausa.Enabled = false;
            BotonPausa.FillColor = Color.FromArgb(109, 158, 226);
            BotonPausa.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonPausa.ForeColor = Color.Black;
            BotonPausa.Location = new Point(427, 620);
            BotonPausa.Name = "BotonPausa";
            BotonPausa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BotonPausa.Size = new Size(146, 65);
            BotonPausa.TabIndex = 11;
            BotonPausa.Text = "II Pausar";
            BotonPausa.Click += BotonPausa_Click;
            // 
            // BotonAnterior
            // 
            BotonAnterior.Animated = true;
            BotonAnterior.BackColor = Color.Transparent;
            BotonAnterior.BorderRadius = 20;
            BotonAnterior.CustomizableEdges = customizableEdges11;
            BotonAnterior.DisabledState.BorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonAnterior.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonAnterior.Enabled = false;
            BotonAnterior.FillColor = Color.FromArgb(109, 158, 226);
            BotonAnterior.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonAnterior.ForeColor = Color.Black;
            BotonAnterior.Location = new Point(271, 620);
            BotonAnterior.Name = "BotonAnterior";
            BotonAnterior.ShadowDecoration.CustomizableEdges = customizableEdges12;
            BotonAnterior.Size = new Size(150, 65);
            BotonAnterior.TabIndex = 10;
            BotonAnterior.Text = "< Anterior";
            BotonAnterior.Click += BotonAnterior_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TemporizadorBar
            // 
            TemporizadorBar.BorderRadius = 20;
            TemporizadorBar.CustomizableEdges = customizableEdges13;
            TemporizadorBar.FillColor = Color.FromArgb(190, 198, 211);
            TemporizadorBar.Location = new Point(50, 479);
            TemporizadorBar.Name = "TemporizadorBar";
            TemporizadorBar.ProgressColor = Color.FromArgb(109, 157, 226);
            TemporizadorBar.ProgressColor2 = Color.FromArgb(15, 3, 98);
            TemporizadorBar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            TemporizadorBar.Size = new Size(473, 70);
            TemporizadorBar.Style = ProgressBarStyle.Continuous;
            TemporizadorBar.TabIndex = 13;
            TemporizadorBar.Text = "guna2ProgressBar1";
            TemporizadorBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // OsteoForm
            // 
            BackColor = Color.FromArgb(243, 248, 253);
            ClientSize = new Size(934, 697);
            Controls.Add(TemporizadorBar);
            Controls.Add(BotonSiguiente);
            Controls.Add(BotonPausa);
            Controls.Add(BotonAnterior);
            Controls.Add(LabelPaso);
            Controls.Add(LabelEstiramiento);
            Controls.Add(pictureBox1);
            Controls.Add(BotonEspalda);
            Controls.Add(BotonMuñeca);
            Controls.Add(botonCuello);
            Controls.Add(label1);
            Name = "OsteoForm";
            Text = "Osteo";
            Load += OsteoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void OsteoForm_Load(object sender, System.EventArgs e)
        {

        }


        //Manejo de imagenes aquí yts
        int paso;
        int paso_total;
        private void botonCuello_Click(object sender, System.EventArgs e)

        {
            // Configuración inicial para el estiramiento de cuello
            paso = 1;
            paso_total = 5;

            BotonAnterior.Enabled = true;
            BotonSiguiente.Enabled = true;
            BotonPausa.Enabled = true;

            LabelEstiramiento.Text = "Estiramiento de Cuello";
            TemporizadorBar.Minimum = 0;
            TemporizadorBar.Maximum = 70; // 7 segundos
            TemporizadorBar.Value = 0;

            timer1.Start();
            timer1.Interval = 100;

            LabelPaso.Text = $"Paso {paso} de {paso_total}";
        }

        private void BotonMuñeca_Click(object sender, System.EventArgs e)
        {
            paso = 1;
            paso_total = 5;

            BotonAnterior.Enabled = true;
            BotonSiguiente.Enabled = true;
            BotonPausa.Enabled = true;

            LabelEstiramiento.Text = "Estiramiento de muñecas";
            TemporizadorBar.Minimum = 0;
            TemporizadorBar.Maximum = 70; // 7 segundos
            TemporizadorBar.Value = 0;

            timer1.Start();
            timer1.Interval = 100;

            LabelPaso.Text = $"Paso {paso} de {paso_total}";
        }

        private void BotonEspalda_Click(object sender, System.EventArgs e)
        {
            paso = 1;
            paso_total = 5;

            BotonAnterior.Enabled = true;
            BotonSiguiente.Enabled = true;
            BotonPausa.Enabled = true;

            LabelEstiramiento.Text = "Estiramiento de Espalda";
            TemporizadorBar.Minimum = 0;
            TemporizadorBar.Maximum = 70; // 7 segundos
            TemporizadorBar.Value = 0;

            timer1.Start();
            timer1.Interval = 100;

            LabelPaso.Text = $"Paso {paso} de {paso_total}";
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {


            if (TemporizadorBar.Value < TemporizadorBar.Maximum)
            {
                TemporizadorBar.Value++;
            }
            else
            {
                paso++;

                if (paso > paso_total)
                {
                    timer1.Stop();
                    return;
                }

                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                TemporizadorBar.Value = 0;
            }
        }

        private void BotonPausa_Click(object sender, System.EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                BotonPausa.Text = "▶ Reanudar";
            }
            else
            {
                timer1.Start();
                BotonPausa.Text = "II Pausar";
            }
        }

        private void BotonSiguiente_Click(object sender, System.EventArgs e)
        {
            if (paso > 0 && paso < paso_total)
            {
                paso++;
                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                //reiniciar el temporizador
                TemporizadorBar.Value = 0;
            }

        }

        private void BotonAnterior_Click(object sender, System.EventArgs e)
        {
            if (paso > 1 && paso <= paso_total)
            {
                paso--;
                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                //reiniciar el temporizador
                TemporizadorBar.Value = 0;
            }
        }

       
    }
}
