using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    partial class FormRelajacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolver = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolverShadow = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            btnPin = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            label1 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            botonInhala = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            btninhala = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            lblinhala = new Label();
            label7 = new Label();
            lblcontador = new Label();
            btniniciar = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btnsin = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            btnnaturaleza = new Guna.UI2.WinForms.Guna2Button();
            btnlluvia = new Guna.UI2.WinForms.Guna2Button();
            btncampanas = new Guna.UI2.WinForms.Guna2Button();
            barravolumen = new Guna.UI2.WinForms.Guna2TrackBar();
            lblvolumen = new Label();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(171, 217, 244);
            panel1.Controls.Add(btnPin);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 120);
            panel1.TabIndex = 0;
            // 
            // btnPin
            // 
            btnPin.Animated = true;
            btnPin.BorderRadius = 12;
            btnPin.CustomizableEdges = cePin1;
            btnPin.FillColor = Color.Transparent;
            btnPin.Font = new Font("Segoe UI Emoji", 14F);
            btnPin.ForeColor = Color.FromArgb(16, 3, 99);
            btnPin.HoverState.FillColor = Color.FromArgb(140, 195, 235);
            btnPin.Location = new Point(840, 20);
            btnPin.Name = "btnPin";
            btnPin.ShadowDecoration.CustomizableEdges = cePin2;
            btnPin.Size = new Size(50, 42);
            btnPin.TabIndex = 99;
            btnPin.Text = "📌";
            btnPin.Click += btnPin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 3, 99);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(383, 91);
            label1.TabIndex = 1;
            label1.Text = "Respiración";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.FillColor = Color.AliceBlue;
            guna2ShadowPanel1.Location = new Point(88, 193);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(250, 120);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSlateGray;
            label5.Location = new Point(13, 78);
            label5.Name = "label5";
            label5.Size = new Size(218, 25);
            label5.TabIndex = 5;
            label5.Text = "Calma el sistema nervioso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(13, 12);
            label3.Name = "label3";
            label3.Size = new Size(221, 32);
            label3.TabIndex = 7;
            label3.Text = "Relajación profunda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(91, 53);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 6;
            label4.Text = " 4-7-8";
            // 
            // botonInhala
            // 
            botonInhala.DisabledState.BorderColor = Color.DarkGray;
            botonInhala.DisabledState.CustomBorderColor = Color.DarkGray;
            botonInhala.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botonInhala.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botonInhala.FillColor = Color.LightSteelBlue;
            botonInhala.Font = new Font("Segoe UI", 9F);
            botonInhala.ForeColor = Color.White;
            botonInhala.Location = new Point(62, 459);
            botonInhala.Name = "botonInhala";
            botonInhala.ShadowDecoration.CustomizableEdges = customizableEdges1;
            botonInhala.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            botonInhala.Size = new Size(222, 222);
            botonInhala.TabIndex = 2;
            // 
            // guna2CircleButton2
            // 
            guna2CircleButton2.BackColor = Color.Transparent;
            guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton2.FillColor = Color.FromArgb(109, 158, 226);
            guna2CircleButton2.Font = new Font("Segoe UI", 9F);
            guna2CircleButton2.ForeColor = Color.Transparent;
            guna2CircleButton2.Location = new Point(88, 488);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(170, 170);
            guna2CircleButton2.TabIndex = 3;
            guna2CircleButton2.Text = "guna2CircleButton2";
            guna2CircleButton2.UseTransparentBackground = true;
            // 
            // btninhala
            // 
            btninhala.BackColor = Color.Transparent;
            btninhala.DisabledState.BorderColor = Color.DarkGray;
            btninhala.DisabledState.CustomBorderColor = Color.DarkGray;
            btninhala.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btninhala.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btninhala.FillColor = Color.FromArgb(47, 128, 237);
            btninhala.Font = new Font("Segoe UI", 9F);
            btninhala.ForeColor = Color.White;
            btninhala.Location = new Point(110, 519);
            btninhala.Name = "btninhala";
            btninhala.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btninhala.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btninhala.Size = new Size(120, 120);
            btninhala.TabIndex = 4;
            btninhala.Text = "Inhala";
            btninhala.UseTransparentBackground = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 384);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 5;
            label2.Text = "FASE";
            // 
            // lblinhala
            // 
            lblinhala.AutoSize = true;
            lblinhala.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinhala.Location = new Point(383, 409);
            lblinhala.Name = "lblinhala";
            lblinhala.Size = new Size(105, 45);
            lblinhala.TabIndex = 6;
            lblinhala.Text = "Inhala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 464);
            label7.Name = "label7";
            label7.Size = new Size(432, 25);
            label7.TabIndex = 7;
            label7.Text = "Inspira lentamente por la nariz llenando el diafragma.";
            // 
            // lblcontador
            // 
            lblcontador.AutoSize = true;
            lblcontador.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontador.Location = new Point(383, 500);
            lblcontador.Name = "lblcontador";
            lblcontador.Size = new Size(68, 60);
            lblcontador.TabIndex = 8;
            lblcontador.Text = "0s";
            // 
            // btniniciar
            // 
            btniniciar.CustomizableEdges = customizableEdges4;
            btniniciar.DisabledState.BorderColor = Color.DarkGray;
            btniniciar.DisabledState.CustomBorderColor = Color.DarkGray;
            btniniciar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btniniciar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btniniciar.FillColor = Color.FromArgb(171, 217, 244);
            btniniciar.Font = new Font("Segoe UI", 9F);
            btniniciar.ForeColor = Color.FromArgb(16, 3, 99);
            btniniciar.Location = new Point(383, 565);
            btniniciar.Name = "btniniciar";
            btniniciar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btniniciar.Size = new Size(128, 40);
            btniniciar.TabIndex = 9;
            btniniciar.Text = "Iniciar";
            btniniciar.Click += btniniciar_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 198, 211);
            panel2.Location = new Point(383, 618);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 10);
            panel2.TabIndex = 10;
            // 
            // btnsin
            // 
            btnsin.BorderRadius = 10;
            btnsin.CustomizableEdges = customizableEdges6;
            btnsin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsin.FillColor = Color.FromArgb(171, 217, 244);
            btnsin.BorderRadius = 12;
            btnsin.Font = new Font("Segoe UI", 9F);
            btnsin.ForeColor = Color.FromArgb(16, 3, 99);
            btnsin.Location = new Point(383, 672);
            btnsin.Name = "btnsin";
            btnsin.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnsin.Size = new Size(128, 38);
            btnsin.TabIndex = 11;
            btnsin.Text = "Sin sonido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 634);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 12;
            label9.Text = "Sonido ambiental";
            // 
            // btnnaturaleza
            // 
            btnnaturaleza.BorderRadius = 10;
            btnnaturaleza.CustomizableEdges = customizableEdges8;
            btnnaturaleza.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnnaturaleza.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnnaturaleza.FillColor = Color.FromArgb(171, 217, 244);
            btnnaturaleza.BorderRadius = 12;
            btnnaturaleza.Font = new Font("Segoe UI", 9F);
            btnnaturaleza.ForeColor = Color.FromArgb(16, 3, 99);
            btnnaturaleza.Location = new Point(532, 672);
            btnnaturaleza.Name = "btnnaturaleza";
            btnnaturaleza.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnnaturaleza.Size = new Size(128, 38);
            btnnaturaleza.TabIndex = 13;
            btnnaturaleza.Text = "Naturaleza";
            // 
            // btnlluvia
            // 
            btnlluvia.BorderRadius = 10;
            btnlluvia.CustomizableEdges = customizableEdges10;
            btnlluvia.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlluvia.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlluvia.FillColor = Color.FromArgb(171, 217, 244);
            btnlluvia.BorderRadius = 12;
            btnlluvia.Font = new Font("Segoe UI", 9F);
            btnlluvia.ForeColor = Color.FromArgb(16, 3, 99);
            btnlluvia.Location = new Point(678, 672);
            btnlluvia.Name = "btnlluvia";
            btnlluvia.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnlluvia.Size = new Size(128, 38);
            btnlluvia.TabIndex = 14;
            btnlluvia.Text = "Lluvia";
            // 
            // btncampanas
            // 
            btncampanas.BorderRadius = 10;
            btncampanas.CustomizableEdges = customizableEdges12;
            btncampanas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncampanas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncampanas.FillColor = Color.FromArgb(171, 217, 244);
            btncampanas.BorderRadius = 12;
            btncampanas.Font = new Font("Segoe UI", 9F);
            btncampanas.ForeColor = Color.FromArgb(16, 3, 99);
            btncampanas.Location = new Point(383, 716);
            btncampanas.Name = "btncampanas";
            btncampanas.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btncampanas.Size = new Size(128, 38);
            btncampanas.TabIndex = 15;
            btncampanas.Text = "Campanas";
            // 
            // barravolumen
            // 
            barravolumen.Location = new Point(383, 777);
            barravolumen.Name = "barravolumen";
            barravolumen.Size = new Size(450, 34);
            barravolumen.TabIndex = 16;
            barravolumen.ThumbColor = Color.Navy;
            barravolumen.Value = 40;
            // 
            // lblvolumen
            // 
            lblvolumen.AutoSize = true;
            lblvolumen.Location = new Point(839, 777);
            lblvolumen.Name = "lblvolumen";
            lblvolumen.Size = new Size(47, 25);
            lblvolumen.TabIndex = 17;
            lblvolumen.Text = "40%";
            // 
            // btnVolver
            // 
            btnVolver.Animated = true;
            btnVolver.BorderRadius = 12;
            btnVolver.CustomizableEdges = ceVolver;
            btnVolver.FillColor = Color.Transparent;
            btnVolver.Font = new Font("Segoe UI", 10F);
            btnVolver.ForeColor = Color.FromArgb(91, 104, 140);
            btnVolver.HoverState.FillColor = Color.FromArgb(230, 240, 250);
            btnVolver.HoverState.ForeColor = Color.FromArgb(16, 3, 99);
            btnVolver.Location = new Point(20, 785);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ceVolverShadow;
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 99;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // FormRelajacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(913, 845);
            Controls.Add(btnVolver);
            Controls.Add(lblvolumen);
            Controls.Add(barravolumen);
            Controls.Add(btncampanas);
            Controls.Add(btnlluvia);
            Controls.Add(btnnaturaleza);
            Controls.Add(label9);
            Controls.Add(btnsin);
            Controls.Add(panel2);
            Controls.Add(btniniciar);
            Controls.Add(lblcontador);
            Controls.Add(label7);
            Controls.Add(lblinhala);
            Controls.Add(label2);
            Controls.Add(btninhala);
            Controls.Add(guna2CircleButton2);
            Controls.Add(botonInhala);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRelajacion";
            Text = "FormRelajacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CircleButton botonInhala;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton btninhala;
        private Label label2;
        private Label lblinhala;
        private Label label7;
        private Label lblcontador;
        private Guna.UI2.WinForms.Guna2Button btniniciar;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnsin;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button btnnaturaleza;
        private Guna.UI2.WinForms.Guna2Button btnlluvia;
        private Guna.UI2.WinForms.Guna2Button btncampanas;
        private Guna.UI2.WinForms.Guna2TrackBar barravolumen;
        private Label lblvolumen;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2Button btnPin;
    }
}