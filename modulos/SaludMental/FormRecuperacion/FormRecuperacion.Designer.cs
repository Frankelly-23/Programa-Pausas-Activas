using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    partial class FormRecuperacion
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
            lblvolumen = new Label();
            barravolumen = new Guna.UI2.WinForms.Guna2TrackBar();
            btncampana = new Guna.UI2.WinForms.Guna2Button();
            btnlluvia = new Guna.UI2.WinForms.Guna2Button();
            btnnaturaleza = new Guna.UI2.WinForms.Guna2Button();
            label9 = new Label();
            btnsin = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btniniciar = new Guna.UI2.WinForms.Guna2Button();
            lblcontador = new Label();
            label7 = new Label();
            lblinhala = new Label();
            label2 = new Label();
            btninhala = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            guna2ShadowPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnVolver.Location = new Point(20, 790);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ceVolverShadow;
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 99;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // lblvolumen
            // 
            lblvolumen.AutoSize = true;
            lblvolumen.Location = new Point(839, 800);
            lblvolumen.Name = "lblvolumen";
            lblvolumen.Size = new Size(47, 25);
            lblvolumen.TabIndex = 55;
            lblvolumen.Text = "40%";
            // 
            // barravolumen
            // 
            barravolumen.Location = new Point(383, 800);
            barravolumen.Name = "barravolumen";
            barravolumen.Size = new Size(450, 34);
            barravolumen.TabIndex = 54;
            barravolumen.ThumbColor = Color.Navy;
            barravolumen.Value = 40;
            // 
            // btncampana
            // 
            btncampana.BorderRadius = 10;
            btncampana.CustomizableEdges = customizableEdges1;
            btncampana.DisabledState.BorderColor = Color.DarkGray;
            btncampana.DisabledState.CustomBorderColor = Color.DarkGray;
            btncampana.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncampana.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncampana.FillColor = Color.FromArgb(171, 217, 244);
            btncampana.BorderRadius = 12;
            btncampana.Font = new Font("Segoe UI", 9F);
            btncampana.ForeColor = Color.FromArgb(16, 3, 99);
            btncampana.Location = new Point(383, 739);
            btncampana.Name = "btncampana";
            btncampana.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btncampana.Size = new Size(128, 38);
            btncampana.TabIndex = 53;
            btncampana.Text = "Campanas";
            // 
            // btnlluvia
            // 
            btnlluvia.BorderRadius = 10;
            btnlluvia.CustomizableEdges = customizableEdges3;
            btnlluvia.DisabledState.BorderColor = Color.DarkGray;
            btnlluvia.DisabledState.CustomBorderColor = Color.DarkGray;
            btnlluvia.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlluvia.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlluvia.FillColor = Color.FromArgb(171, 217, 244);
            btnlluvia.BorderRadius = 12;
            btnlluvia.Font = new Font("Segoe UI", 9F);
            btnlluvia.ForeColor = Color.FromArgb(16, 3, 99);
            btnlluvia.Location = new Point(678, 695);
            btnlluvia.Name = "btnlluvia";
            btnlluvia.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnlluvia.Size = new Size(128, 38);
            btnlluvia.TabIndex = 52;
            btnlluvia.Text = "Lluvia";
            // 
            // btnnaturaleza
            // 
            btnnaturaleza.BorderRadius = 10;
            btnnaturaleza.CustomizableEdges = customizableEdges5;
            btnnaturaleza.DisabledState.BorderColor = Color.DarkGray;
            btnnaturaleza.DisabledState.CustomBorderColor = Color.DarkGray;
            btnnaturaleza.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnnaturaleza.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnnaturaleza.FillColor = Color.FromArgb(171, 217, 244);
            btnnaturaleza.BorderRadius = 12;
            btnnaturaleza.Font = new Font("Segoe UI", 9F);
            btnnaturaleza.ForeColor = Color.FromArgb(16, 3, 99);
            btnnaturaleza.Location = new Point(532, 695);
            btnnaturaleza.Name = "btnnaturaleza";
            btnnaturaleza.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnnaturaleza.Size = new Size(128, 38);
            btnnaturaleza.TabIndex = 51;
            btnnaturaleza.Text = "Naturaleza";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 657);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 50;
            label9.Text = "Sonido ambiental";
            // 
            // btnsin
            // 
            btnsin.BorderRadius = 10;
            btnsin.CustomizableEdges = customizableEdges7;
            btnsin.DisabledState.BorderColor = Color.DarkGray;
            btnsin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsin.FillColor = Color.FromArgb(171, 217, 244);
            btnsin.BorderRadius = 12;
            btnsin.Font = new Font("Segoe UI", 9F);
            btnsin.ForeColor = Color.FromArgb(16, 3, 99);
            btnsin.Location = new Point(383, 695);
            btnsin.Name = "btnsin";
            btnsin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnsin.Size = new Size(128, 38);
            btnsin.TabIndex = 49;
            btnsin.Text = "Sin sonido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 198, 211);
            panel2.Location = new Point(383, 641);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 10);
            panel2.TabIndex = 48;
            // 
            // btniniciar
            // 
            btniniciar.CustomizableEdges = customizableEdges9;
            btniniciar.DisabledState.BorderColor = Color.DarkGray;
            btniniciar.DisabledState.CustomBorderColor = Color.DarkGray;
            btniniciar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btniniciar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btniniciar.FillColor = Color.FromArgb(171, 217, 244);
            btniniciar.Font = new Font("Segoe UI", 9F);
            btniniciar.ForeColor = Color.FromArgb(16, 3, 99);
            btniniciar.Location = new Point(383, 588);
            btniniciar.Name = "btniniciar";
            btniniciar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btniniciar.Size = new Size(128, 40);
            btniniciar.TabIndex = 47;
            btniniciar.Text = "Iniciar";
            // 
            // lblcontador
            // 
            lblcontador.AutoSize = true;
            lblcontador.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcontador.Location = new Point(383, 511);
            lblcontador.Name = "lblcontador";
            lblcontador.Size = new Size(68, 60);
            lblcontador.TabIndex = 46;
            lblcontador.Text = "0s";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 487);
            label7.Name = "label7";
            label7.Size = new Size(301, 50);
            label7.TabIndex = 45;
            label7.Text = "Exhala lentamente liberando tensión.\r\n\r\n";
            // 
            // lblinhala
            // 
            lblinhala.AutoSize = true;
            lblinhala.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinhala.Location = new Point(374, 432);
            lblinhala.Name = "lblinhala";
            lblinhala.Size = new Size(105, 45);
            lblinhala.TabIndex = 44;
            lblinhala.Text = "Inhala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 407);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 43;
            label2.Text = "FASE";
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
            btninhala.Location = new Point(113, 540);
            btninhala.Name = "btninhala";
            btninhala.RightToLeft = RightToLeft.No;
            btninhala.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btninhala.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btninhala.Size = new Size(120, 120);
            btninhala.TabIndex = 42;
            btninhala.Text = "Inhala";
            btninhala.UseTransparentBackground = true;
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
            guna2CircleButton2.Location = new Point(88, 511);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(170, 170);
            guna2CircleButton2.TabIndex = 41;
            guna2CircleButton2.Text = "guna2CircleButton2";
            guna2CircleButton2.UseTransparentBackground = true;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.LightSteelBlue;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(62, 482);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(222, 222);
            guna2CircleButton1.TabIndex = 40;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.FillColor = Color.AliceBlue;
            guna2ShadowPanel1.Location = new Point(88, 216);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(250, 120);
            guna2ShadowPanel1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSlateGray;
            label5.Location = new Point(25, 78);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 5;
            label5.Text = "Reset rápido entre tareas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 7;
            label3.Text = "Recuperación exprés\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(101, 53);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 6;
            label4.Text = "3-3-6\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(171, 217, 244);
            panel1.Controls.Add(btnPin);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 120);
            panel1.TabIndex = 38;
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
            // FormRecuperacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 852);
            Controls.Add(btnVolver);
            Controls.Add(lblvolumen);
            Controls.Add(barravolumen);
            Controls.Add(btncampana);
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
            Controls.Add(guna2CircleButton1);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRecuperacion";
            Text = "FormRecuperacion";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Label lblvolumen;
        private Guna.UI2.WinForms.Guna2TrackBar barravolumen;
        private Guna.UI2.WinForms.Guna2Button btncampana;
        private Guna.UI2.WinForms.Guna2Button btnlluvia;
        private Guna.UI2.WinForms.Guna2Button btnnaturaleza;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button btnsin;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btniniciar;
        private Label lblcontador;
        private Label label7;
        private Label lblinhala;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btninhala;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPin;
    }
}