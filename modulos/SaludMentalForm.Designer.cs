using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    partial class SaludMentalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolver = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolverShadow = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            btnPin = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            guna2ShadowPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(171, 217, 244);
            panel1.Controls.Add(btnPin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 130);
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
            btnPin.Location = new Point(1270, 20);
            btnPin.Name = "btnPin";
            btnPin.ShadowDecoration.CustomizableEdges = cePin2;
            btnPin.Size = new Size(50, 42);
            btnPin.TabIndex = 99;
            btnPin.Text = "📌";
            btnPin.Click += btnPin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 3, 99);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(265, 32);
            label2.TabIndex = 1;
            label2.Text = "Módulo salud cognitiva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 3, 99);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(442, 60);
            label1.TabIndex = 1;
            label1.Text = "Software Ergonómico";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label6);
            guna2ShadowPanel1.Controls.Add(label7);
            guna2ShadowPanel1.Controls.Add(label8);
            guna2ShadowPanel1.FillColor = Color.AliceBlue;
            guna2ShadowPanel1.Location = new Point(505, 304);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 20;
            guna2ShadowPanel1.ShadowColor = Color.Gray;
            guna2ShadowPanel1.ShadowDepth = 30;
            guna2ShadowPanel1.Size = new Size(300, 170);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSlateGray;
            label6.Location = new Point(62, 126);
            label6.Name = "label6";
            label6.Size = new Size(178, 21);
            label6.TabIndex = 5;
            label6.Text = "Mejora la concentración";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(62, 81);
            label7.Name = "label7";
            label7.Size = new Size(168, 25);
            label7.TabIndex = 6;
            label7.Text = "Respiración 4-4-4-4";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(65, 34);
            label8.Name = "label8";
            label8.Size = new Size(165, 32);
            label8.TabIndex = 7;
            label8.Text = "Enfoque activo";
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(label9);
            guna2ShadowPanel2.Controls.Add(label11);
            guna2ShadowPanel2.Controls.Add(label10);
            guna2ShadowPanel2.FillColor = Color.AliceBlue;
            guna2ShadowPanel2.Location = new Point(935, 304);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 20;
            guna2ShadowPanel2.ShadowColor = Color.Gray;
            guna2ShadowPanel2.ShadowDepth = 30;
            guna2ShadowPanel2.Size = new Size(300, 170);
            guna2ShadowPanel2.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSlateGray;
            label9.Location = new Point(27, 126);
            label9.Name = "label9";
            label9.Size = new Size(253, 25);
            label9.TabIndex = 5;
            label9.Text = "Recupera energía rápidamente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(37, 34);
            label11.Name = "label11";
            label11.Size = new Size(225, 32);
            label11.TabIndex = 7;
            label11.Text = "Recuperación exprés";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SlateGray;
            label10.Location = new Point(68, 81);
            label10.Name = "label10";
            label10.Size = new Size(167, 28);
            label10.TabIndex = 6;
            label10.Text = "Respiración 3-3-6";
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.Controls.Add(label5);
            guna2ShadowPanel3.Controls.Add(label4);
            guna2ShadowPanel3.Controls.Add(label3);
            guna2ShadowPanel3.FillColor = Color.AliceBlue;
            guna2ShadowPanel3.Location = new Point(69, 304);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 20;
            guna2ShadowPanel3.ShadowColor = Color.Gray;
            guna2ShadowPanel3.ShadowDepth = 30;
            guna2ShadowPanel3.Size = new Size(300, 170);
            guna2ShadowPanel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSlateGray;
            label5.Location = new Point(30, 126);
            label5.Name = "label5";
            label5.Size = new Size(251, 25);
            label5.TabIndex = 4;
            label5.Text = "Reduce el estrés y la ansiedad ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(71, 81);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 4;
            label4.Text = "Respiración 4-7-8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(40, 34);
            label3.Name = "label3";
            label3.Size = new Size(221, 32);
            label3.TabIndex = 4;
            label3.Text = "Relajación profunda";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 12;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(171, 217, 244);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(16, 3, 99);
            guna2Button1.Location = new Point(80, 514);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(270, 68);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "INGRESAR";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 12;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(171, 217, 244);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.FromArgb(16, 3, 99);
            guna2Button2.Location = new Point(519, 514);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(270, 68);
            guna2Button2.TabIndex = 5;
            guna2Button2.Text = "INGRESAR";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 12;
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(171, 217, 244);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.FromArgb(16, 3, 99);
            guna2Button3.Location = new Point(945, 514);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(270, 68);
            guna2Button3.TabIndex = 6;
            guna2Button3.Text = "INGRESAR";
            guna2Button3.Click += guna2Button3_Click;
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
            btnVolver.Location = new Point(15, 660);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ceVolverShadow;
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 99;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // SaludMentalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1344, 712);
            Controls.Add(btnVolver);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(guna2ShadowPanel3);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaludMentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salud Mental";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            guna2ShadowPanel3.ResumeLayout(false);
            guna2ShadowPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Label label3;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2Button btnPin;
    }
}
