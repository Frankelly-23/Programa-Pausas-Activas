using System.Drawing;
using System.Windows.Forms;

namespace PausasActivas
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelTemporizadores;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelOsteo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelSaludMental;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelSedentarismo;
        private Label lblTempTitulo;
        private Label lblTempDesc;
        private Label lblOsteoTitulo;
        private Label lblOsteoDesc;
        private Label lblMentalTitulo;
        private Label lblMentalDesc;
        private Label lblSedTitulo;
        private Label lblSedDesc;
        private Guna.UI2.WinForms.Guna2Button btnTemporizadores;
        private Guna.UI2.WinForms.Guna2Button btnOsteo;
        private Guna.UI2.WinForms.Guna2Button btnSaludMental;
        private Guna.UI2.WinForms.Guna2Button btnSedentarismo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            components = new System.ComponentModel.Container();

            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();

            panelTemporizadores = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelOsteo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelSaludMental = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelSedentarismo = new Guna.UI2.WinForms.Guna2ShadowPanel();

            lblTempTitulo = new Label();
            lblTempDesc = new Label();
            lblOsteoTitulo = new Label();
            lblOsteoDesc = new Label();
            lblMentalTitulo = new Label();
            lblMentalDesc = new Label();
            lblSedTitulo = new Label();
            lblSedDesc = new Label();

            btnTemporizadores = new Guna.UI2.WinForms.Guna2Button();
            btnOsteo = new Guna.UI2.WinForms.Guna2Button();
            btnSaludMental = new Guna.UI2.WinForms.Guna2Button();
            btnSedentarismo = new Guna.UI2.WinForms.Guna2Button();

            panelHeader.SuspendLayout();
            panelTemporizadores.SuspendLayout();
            panelOsteo.SuspendLayout();
            panelSaludMental.SuspendLayout();
            panelSedentarismo.SuspendLayout();
            SuspendLayout();

            // ── panelHeader ──────────────────────────────────────
            panelHeader.BackColor = Color.FromArgb(171, 217, 244);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 130);
            panelHeader.TabIndex = 0;

            // ── lblTitulo ────────────────────────────────────────
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblTitulo.Location = new Point(270, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Software Ergonómico";

            // ── lblSubtitulo ─────────────────────────────────────
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblSubtitulo.Location = new Point(310, 80);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(290, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione un módulo";

            // ── panelTemporizadores ──────────────────────────────
            panelTemporizadores.BackColor = Color.Transparent;
            panelTemporizadores.Controls.Add(lblTempTitulo);
            panelTemporizadores.Controls.Add(lblTempDesc);
            panelTemporizadores.FillColor = Color.AliceBlue;
            panelTemporizadores.Location = new Point(40, 160);
            panelTemporizadores.Name = "panelTemporizadores";
            panelTemporizadores.Radius = 20;
            panelTemporizadores.ShadowColor = Color.Gray;
            panelTemporizadores.ShadowDepth = 30;
            panelTemporizadores.Size = new Size(380, 140);
            panelTemporizadores.TabIndex = 1;

            // ── lblTempTitulo ────────────────────────────────────
            lblTempTitulo.AutoSize = true;
            lblTempTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTempTitulo.ForeColor = Color.MidnightBlue;
            lblTempTitulo.Location = new Point(30, 25);
            lblTempTitulo.Name = "lblTempTitulo";
            lblTempTitulo.Size = new Size(250, 32);
            lblTempTitulo.TabIndex = 0;
            lblTempTitulo.Text = "⏱️ Temporizadores y Alertas";

            // ── lblTempDesc ──────────────────────────────────────
            lblTempDesc.AutoSize = true;
            lblTempDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTempDesc.ForeColor = Color.SlateGray;
            lblTempDesc.Location = new Point(30, 70);
            lblTempDesc.Name = "lblTempDesc";
            lblTempDesc.Size = new Size(300, 25);
            lblTempDesc.TabIndex = 1;
            lblTempDesc.Text = "Configura recordatorios de pausas activas";

            // ── panelOsteo ───────────────────────────────────────
            panelOsteo.BackColor = Color.Transparent;
            panelOsteo.Controls.Add(lblOsteoTitulo);
            panelOsteo.Controls.Add(lblOsteoDesc);
            panelOsteo.FillColor = Color.AliceBlue;
            panelOsteo.Location = new Point(470, 160);
            panelOsteo.Name = "panelOsteo";
            panelOsteo.Radius = 20;
            panelOsteo.ShadowColor = Color.Gray;
            panelOsteo.ShadowDepth = 30;
            panelOsteo.Size = new Size(380, 140);
            panelOsteo.TabIndex = 2;

            // ── lblOsteoTitulo ───────────────────────────────────
            lblOsteoTitulo.AutoSize = true;
            lblOsteoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOsteoTitulo.ForeColor = Color.MidnightBlue;
            lblOsteoTitulo.Location = new Point(30, 25);
            lblOsteoTitulo.Name = "lblOsteoTitulo";
            lblOsteoTitulo.Size = new Size(300, 32);
            lblOsteoTitulo.TabIndex = 0;
            lblOsteoTitulo.Text = "🦴 Prevención Osteomuscular";

            // ── lblOsteoDesc ─────────────────────────────────────
            lblOsteoDesc.AutoSize = true;
            lblOsteoDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOsteoDesc.ForeColor = Color.SlateGray;
            lblOsteoDesc.Location = new Point(30, 70);
            lblOsteoDesc.Name = "lblOsteoDesc";
            lblOsteoDesc.Size = new Size(300, 25);
            lblOsteoDesc.TabIndex = 1;
            lblOsteoDesc.Text = "Ejercicios de estiramiento guiados";

            // ── panelSaludMental ─────────────────────────────────
            panelSaludMental.BackColor = Color.Transparent;
            panelSaludMental.Controls.Add(lblMentalTitulo);
            panelSaludMental.Controls.Add(lblMentalDesc);
            panelSaludMental.FillColor = Color.AliceBlue;
            panelSaludMental.Location = new Point(40, 360);
            panelSaludMental.Name = "panelSaludMental";
            panelSaludMental.Radius = 20;
            panelSaludMental.ShadowColor = Color.Gray;
            panelSaludMental.ShadowDepth = 30;
            panelSaludMental.Size = new Size(380, 140);
            panelSaludMental.TabIndex = 3;

            // ── lblMentalTitulo ──────────────────────────────────
            lblMentalTitulo.AutoSize = true;
            lblMentalTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMentalTitulo.ForeColor = Color.MidnightBlue;
            lblMentalTitulo.Location = new Point(30, 25);
            lblMentalTitulo.Name = "lblMentalTitulo";
            lblMentalTitulo.Size = new Size(200, 32);
            lblMentalTitulo.TabIndex = 0;
            lblMentalTitulo.Text = "🧠 Salud Mental";

            // ── lblMentalDesc ────────────────────────────────────
            lblMentalDesc.AutoSize = true;
            lblMentalDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMentalDesc.ForeColor = Color.SlateGray;
            lblMentalDesc.Location = new Point(30, 70);
            lblMentalDesc.Name = "lblMentalDesc";
            lblMentalDesc.Size = new Size(300, 25);
            lblMentalDesc.TabIndex = 1;
            lblMentalDesc.Text = "Ejercicios de respiración y relajación";

            // ── panelSedentarismo ────────────────────────────────
            panelSedentarismo.BackColor = Color.Transparent;
            panelSedentarismo.Controls.Add(lblSedTitulo);
            panelSedentarismo.Controls.Add(lblSedDesc);
            panelSedentarismo.FillColor = Color.AliceBlue;
            panelSedentarismo.Location = new Point(470, 360);
            panelSedentarismo.Name = "panelSedentarismo";
            panelSedentarismo.Radius = 20;
            panelSedentarismo.ShadowColor = Color.Gray;
            panelSedentarismo.ShadowDepth = 30;
            panelSedentarismo.Size = new Size(380, 140);
            panelSedentarismo.TabIndex = 4;

            // ── lblSedTitulo ─────────────────────────────────────
            lblSedTitulo.AutoSize = true;
            lblSedTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSedTitulo.ForeColor = Color.MidnightBlue;
            lblSedTitulo.Location = new Point(30, 25);
            lblSedTitulo.Name = "lblSedTitulo";
            lblSedTitulo.Size = new Size(250, 32);
            lblSedTitulo.TabIndex = 0;
            lblSedTitulo.Text = "🏃 Anti-Sedentarismo";

            // ── lblSedDesc ───────────────────────────────────────
            lblSedDesc.AutoSize = true;
            lblSedDesc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSedDesc.ForeColor = Color.SlateGray;
            lblSedDesc.Location = new Point(30, 70);
            lblSedDesc.Name = "lblSedDesc";
            lblSedDesc.Size = new Size(300, 25);
            lblSedDesc.TabIndex = 1;
            lblSedDesc.Text = "Combate el sedentarismo laboral";

            // ── btnTemporizadores ────────────────────────────────
            btnTemporizadores.BorderRadius = 12;
            btnTemporizadores.CustomizableEdges = ce1;
            btnTemporizadores.DisabledState.BorderColor = Color.DarkGray;
            btnTemporizadores.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTemporizadores.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTemporizadores.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTemporizadores.FillColor = Color.FromArgb(171, 217, 244);
            btnTemporizadores.Font = new Font("Segoe UI", 9F);
            btnTemporizadores.ForeColor = Color.FromArgb(16, 3, 99);
            btnTemporizadores.Location = new Point(95, 315);
            btnTemporizadores.Name = "btnTemporizadores";
            btnTemporizadores.ShadowDecoration.CustomizableEdges = ce2;
            btnTemporizadores.Size = new Size(270, 45);
            btnTemporizadores.TabIndex = 5;
            btnTemporizadores.Text = "INGRESAR";
            btnTemporizadores.Click += btnTemporizadores_Click;

            // ── btnOsteo ─────────────────────────────────────────
            btnOsteo.BorderRadius = 12;
            btnOsteo.CustomizableEdges = ce3;
            btnOsteo.DisabledState.BorderColor = Color.DarkGray;
            btnOsteo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOsteo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOsteo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOsteo.FillColor = Color.FromArgb(171, 217, 244);
            btnOsteo.Font = new Font("Segoe UI", 9F);
            btnOsteo.ForeColor = Color.FromArgb(16, 3, 99);
            btnOsteo.Location = new Point(525, 315);
            btnOsteo.Name = "btnOsteo";
            btnOsteo.ShadowDecoration.CustomizableEdges = ce4;
            btnOsteo.Size = new Size(270, 45);
            btnOsteo.TabIndex = 6;
            btnOsteo.Text = "INGRESAR";
            btnOsteo.Click += btnOsteo_Click;

            // ── btnSaludMental ───────────────────────────────────
            btnSaludMental.BorderRadius = 12;
            btnSaludMental.CustomizableEdges = ce5;
            btnSaludMental.DisabledState.BorderColor = Color.DarkGray;
            btnSaludMental.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaludMental.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaludMental.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaludMental.FillColor = Color.FromArgb(171, 217, 244);
            btnSaludMental.Font = new Font("Segoe UI", 9F);
            btnSaludMental.ForeColor = Color.FromArgb(16, 3, 99);
            btnSaludMental.Location = new Point(95, 515);
            btnSaludMental.Name = "btnSaludMental";
            btnSaludMental.ShadowDecoration.CustomizableEdges = ce6;
            btnSaludMental.Size = new Size(270, 45);
            btnSaludMental.TabIndex = 7;
            btnSaludMental.Text = "INGRESAR";
            btnSaludMental.Click += btnSaludMental_Click;

            // ── btnSedentarismo ──────────────────────────────────
            btnSedentarismo.BorderRadius = 12;
            btnSedentarismo.CustomizableEdges = ce7;
            btnSedentarismo.DisabledState.BorderColor = Color.DarkGray;
            btnSedentarismo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSedentarismo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSedentarismo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSedentarismo.FillColor = Color.FromArgb(171, 217, 244);
            btnSedentarismo.Font = new Font("Segoe UI", 9F);
            btnSedentarismo.ForeColor = Color.FromArgb(16, 3, 99);
            btnSedentarismo.Location = new Point(525, 515);
            btnSedentarismo.Name = "btnSedentarismo";
            btnSedentarismo.ShadowDecoration.CustomizableEdges = ce8;
            btnSedentarismo.Size = new Size(270, 45);
            btnSedentarismo.TabIndex = 8;
            btnSedentarismo.Text = "INGRESAR";
            btnSedentarismo.Click += btnSedentarismo_Click;

            // ── MainForm ─────────────────────────────────────────
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            Controls.Add(btnSedentarismo);
            Controls.Add(btnSaludMental);
            Controls.Add(btnOsteo);
            Controls.Add(btnTemporizadores);
            Controls.Add(panelSedentarismo);
            Controls.Add(panelSaludMental);
            Controls.Add(panelOsteo);
            Controls.Add(panelTemporizadores);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software Ergonómico";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTemporizadores.ResumeLayout(false);
            panelTemporizadores.PerformLayout();
            panelOsteo.ResumeLayout(false);
            panelOsteo.PerformLayout();
            panelSaludMental.ResumeLayout(false);
            panelSaludMental.PerformLayout();
            panelSedentarismo.ResumeLayout(false);
            panelSedentarismo.PerformLayout();
            ResumeLayout(false);
        }
    }
}
