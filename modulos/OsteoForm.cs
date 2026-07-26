using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

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

        private System.Windows.Forms.ProgressBar TemporizadorBar;

        public OsteoForm()
        {
            InitializeComponent();
            this.Text = "Prevención Osteomuscular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // TODO Equipo 2: construir la UI aquí
        }

        private void BotonMuñeca_Click(object sender, System.EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            botonCuello = new Guna.UI2.WinForms.Guna2Button();
            BotonMuñeca = new Guna.UI2.WinForms.Guna2Button();
            BotonEspalda = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            LabelEstiramiento = new Label();
            TemporizadorBar = new ProgressBar();
            LabelPaso = new Label();
            BotonSiguiente = new Guna.UI2.WinForms.Guna2Button();
            BotonPausa = new Guna.UI2.WinForms.Guna2Button();
            BotonAnterior = new Guna.UI2.WinForms.Guna2Button();
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
            botonCuello.CustomizableEdges = customizableEdges13;
            botonCuello.DisabledState.BorderColor = Color.DarkGray;
            botonCuello.DisabledState.CustomBorderColor = Color.DarkGray;
            botonCuello.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botonCuello.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botonCuello.FillColor = Color.FromArgb(109, 158, 226);
            botonCuello.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCuello.ForeColor = Color.Black;
            botonCuello.Location = new Point(89, 117);
            botonCuello.Name = "botonCuello";
            botonCuello.ShadowDecoration.CustomizableEdges = customizableEdges14;
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
            BotonMuñeca.CustomizableEdges = customizableEdges15;
            BotonMuñeca.DisabledState.BorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonMuñeca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonMuñeca.FillColor = Color.FromArgb(109, 158, 226);
            BotonMuñeca.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonMuñeca.ForeColor = Color.Black;
            BotonMuñeca.Location = new Point(352, 117);
            BotonMuñeca.Name = "BotonMuñeca";
            BotonMuñeca.ShadowDecoration.CustomizableEdges = customizableEdges16;
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
            BotonEspalda.CustomizableEdges = customizableEdges17;
            BotonEspalda.DisabledState.BorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonEspalda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonEspalda.FillColor = Color.FromArgb(109, 158, 226);
            BotonEspalda.Font = new Font("Nunito Sans Normal", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEspalda.ForeColor = Color.Black;
            BotonEspalda.Location = new Point(627, 117);
            BotonEspalda.Name = "BotonEspalda";
            BotonEspalda.ShadowDecoration.CustomizableEdges = customizableEdges18;
            BotonEspalda.Size = new Size(221, 79);
            BotonEspalda.TabIndex = 4;
            BotonEspalda.Text = "Espalda";
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
            LabelEstiramiento.Size = new Size(598, 45);
            LabelEstiramiento.TabIndex = 7;
            LabelEstiramiento.Text = "Estiramiento de (Cambia con los botones)";
            // 
            // TemporizadorBar
            // 
            TemporizadorBar.Location = new Point(50, 479);
            TemporizadorBar.Name = "TemporizadorBar";
            TemporizadorBar.Size = new Size(373, 70);
            TemporizadorBar.TabIndex = 8;
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
            BotonSiguiente.CustomizableEdges = customizableEdges19;
            BotonSiguiente.DisabledState.BorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonSiguiente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonSiguiente.FillColor = Color.FromArgb(109, 158, 226);
            BotonSiguiente.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonSiguiente.ForeColor = Color.Black;
            BotonSiguiente.Location = new Point(579, 620);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges20;
            BotonSiguiente.Size = new Size(159, 65);
            BotonSiguiente.TabIndex = 12;
            BotonSiguiente.Text = "Siguiente >";
            // 
            // BotonPausa
            // 
            BotonPausa.Animated = true;
            BotonPausa.BackColor = Color.Transparent;
            BotonPausa.BorderRadius = 20;
            BotonPausa.CustomizableEdges = customizableEdges21;
            BotonPausa.DisabledState.BorderColor = Color.DarkGray;
            BotonPausa.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonPausa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonPausa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonPausa.FillColor = Color.FromArgb(109, 158, 226);
            BotonPausa.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonPausa.ForeColor = Color.Black;
            BotonPausa.Location = new Point(427, 620);
            BotonPausa.Name = "BotonPausa";
            BotonPausa.ShadowDecoration.CustomizableEdges = customizableEdges22;
            BotonPausa.Size = new Size(146, 65);
            BotonPausa.TabIndex = 11;
            BotonPausa.Text = "II Pausar";
            // 
            // BotonAnterior
            // 
            BotonAnterior.Animated = true;
            BotonAnterior.BackColor = Color.Transparent;
            BotonAnterior.BorderRadius = 20;
            BotonAnterior.CustomizableEdges = customizableEdges23;
            BotonAnterior.DisabledState.BorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonAnterior.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonAnterior.FillColor = Color.FromArgb(109, 158, 226);
            BotonAnterior.Font = new Font("Nunito Sans Normal", 14F, FontStyle.Bold);
            BotonAnterior.ForeColor = Color.Black;
            BotonAnterior.Location = new Point(271, 620);
            BotonAnterior.Name = "BotonAnterior";
            BotonAnterior.ShadowDecoration.CustomizableEdges = customizableEdges24;
            BotonAnterior.Size = new Size(150, 65);
            BotonAnterior.TabIndex = 10;
            BotonAnterior.Text = "< Anterior";
            // 
            // OsteoForm
            // 
            BackColor = Color.FromArgb(243, 248, 253);
            ClientSize = new Size(934, 697);
            Controls.Add(BotonSiguiente);
            Controls.Add(BotonPausa);
            Controls.Add(BotonAnterior);
            Controls.Add(LabelPaso);
            Controls.Add(TemporizadorBar);
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
        private void botonCuello_Click(object sender, System.EventArgs e)
        {
            

            LabelEstiramiento.Text = "Estiramiento de Cuello";
            LabelPaso.Text = "Paso 1 de 3";
        }
    }
}
