using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PausasActivas
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnPin;

        // Stats bar
        private Panel panelStats;
        private Label lblStatTotalLabel;
        private Label lblStatTotal;
        private Label lblStatFavoritoLabel;
        private Label lblStatFavorito;
        private Label lblStatUltimoLabel;
        private Label lblStatUltimo;

        // Module cards
        private Guna.UI2.WinForms.Guna2ShadowPanel panelTemporizadores;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelOsteo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelSaludMental;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelSedentarismo;

        private Label lblTempTitulo;
        private Label lblTempDesc;
        private Label lblTempStat;
        private Label lblOsteoTitulo;
        private Label lblOsteoDesc;
        private Label lblOsteoStat;
        private Label lblMentalTitulo;
        private Label lblMentalDesc;
        private Label lblMentalStat;
        private Label lblSedTitulo;
        private Label lblSedDesc;
        private Label lblSedStat;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            components = new System.ComponentModel.Container();

            // ═══════════════════════════════════════════════════════
            //  INSTANTIATE ALL CONTROLS
            // ═══════════════════════════════════════════════════════
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            picLogo = new PictureBox();
            btnPin = new Guna.UI2.WinForms.Guna2Button();

            panelStats = new Panel();
            lblStatTotalLabel = new Label();
            lblStatTotal = new Label();
            lblStatFavoritoLabel = new Label();
            lblStatFavorito = new Label();
            lblStatUltimoLabel = new Label();
            lblStatUltimo = new Label();

            panelTemporizadores = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelOsteo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelSaludMental = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panelSedentarismo = new Guna.UI2.WinForms.Guna2ShadowPanel();

            lblTempTitulo = new Label();
            lblTempDesc = new Label();
            lblTempStat = new Label();
            lblOsteoTitulo = new Label();
            lblOsteoDesc = new Label();
            lblOsteoStat = new Label();
            lblMentalTitulo = new Label();
            lblMentalDesc = new Label();
            lblMentalStat = new Label();
            lblSedTitulo = new Label();
            lblSedDesc = new Label();
            lblSedStat = new Label();

            btnTemporizadores = new Guna.UI2.WinForms.Guna2Button();
            btnOsteo = new Guna.UI2.WinForms.Guna2Button();
            btnSaludMental = new Guna.UI2.WinForms.Guna2Button();
            btnSedentarismo = new Guna.UI2.WinForms.Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            panelTemporizadores.SuspendLayout();
            panelOsteo.SuspendLayout();
            panelSaludMental.SuspendLayout();
            panelSedentarismo.SuspendLayout();
            SuspendLayout();

            // ═══════════════════════════════════════════════════════
            //  HEADER PANEL (125px height, generous spacing)
            // ═══════════════════════════════════════════════════════
            panelHeader.BackColor = Color.FromArgb(171, 217, 244);
            panelHeader.Controls.Add(btnPin);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(920, 125);
            panelHeader.TabIndex = 0;

            // ── picLogo ──────────────────────────────────────────
            picLogo.Location = new Point(28, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(72, 72);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;

            // ── lblTitulo ────────────────────────────────────────
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblTitulo.Location = new Point(110, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Software Ergonómico";

            // ── lblSubtitulo ─────────────────────────────────────
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(60, 60, 120);
            lblSubtitulo.Location = new Point(120, 76);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Text = "Ergonomía y Factores Humanos";

            // ── btnPin ───────────────────────────────────────────
            btnPin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPin.Animated = true;
            btnPin.BorderRadius = 12;
            btnPin.CustomizableEdges = cePin1;
            btnPin.FillColor = Color.Transparent;
            btnPin.Font = new Font("Segoe UI Emoji", 14F);
            btnPin.ForeColor = Color.FromArgb(16, 3, 99);
            btnPin.HoverState.FillColor = Color.FromArgb(140, 195, 235);
            btnPin.Location = new Point(850, 18);
            btnPin.Name = "btnPin";
            btnPin.ShadowDecoration.CustomizableEdges = cePin2;
            btnPin.Size = new Size(50, 42);
            btnPin.TabIndex = 99;
            btnPin.Text = "📌";
            btnPin.Click += btnPin_Click;

            // ═══════════════════════════════════════════════════════
            //  STATS BAR (compact summary strip below header)
            // ═══════════════════════════════════════════════════════
            panelStats.BackColor = Color.FromArgb(235, 245, 252);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 125);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(920, 60);
            panelStats.TabIndex = 1;
            panelStats.Controls.Add(lblStatTotalLabel);
            panelStats.Controls.Add(lblStatTotal);
            panelStats.Controls.Add(lblStatFavoritoLabel);
            panelStats.Controls.Add(lblStatFavorito);
            panelStats.Controls.Add(lblStatUltimoLabel);
            panelStats.Controls.Add(lblStatUltimo);

            // ── Stats: Total sessions ────────────────────────────
            lblStatTotalLabel.AutoSize = true;
            lblStatTotalLabel.Font = new Font("Segoe UI", 8F);
            lblStatTotalLabel.ForeColor = Color.FromArgb(100, 110, 140);
            lblStatTotalLabel.Location = new Point(30, 8);
            lblStatTotalLabel.Text = "TOTAL";

            lblStatTotal.AutoSize = true;
            lblStatTotal.Font = new Font("Segoe UI Semibold", 12F);
            lblStatTotal.ForeColor = Color.FromArgb(16, 3, 99);
            lblStatTotal.Location = new Point(28, 28);
            lblStatTotal.Text = "0 sesiones";

            // ── Stats: Favorite module ───────────────────────────
            lblStatFavoritoLabel.AutoSize = true;
            lblStatFavoritoLabel.Font = new Font("Segoe UI", 8F);
            lblStatFavoritoLabel.ForeColor = Color.FromArgb(100, 110, 140);
            lblStatFavoritoLabel.Location = new Point(320, 8);
            lblStatFavoritoLabel.Text = "MÁS USADO";

            lblStatFavorito.AutoSize = true;
            lblStatFavorito.Font = new Font("Segoe UI Semibold", 12F);
            lblStatFavorito.ForeColor = Color.FromArgb(16, 3, 99);
            lblStatFavorito.Location = new Point(318, 28);
            lblStatFavorito.Text = "—";

            // ── Stats: Last used ─────────────────────────────────
            lblStatUltimoLabel.AutoSize = true;
            lblStatUltimoLabel.Font = new Font("Segoe UI", 8F);
            lblStatUltimoLabel.ForeColor = Color.FromArgb(100, 110, 140);
            lblStatUltimoLabel.Location = new Point(640, 8);
            lblStatUltimoLabel.Text = "ÚLTIMO USO";

            lblStatUltimo.AutoSize = true;
            lblStatUltimo.Font = new Font("Segoe UI Semibold", 12F);
            lblStatUltimo.ForeColor = Color.FromArgb(16, 3, 99);
            lblStatUltimo.Location = new Point(638, 28);
            lblStatUltimo.Text = "—";

            // ═══════════════════════════════════════════════════════
            //  MODULE CARDS — 2×2 GRID (spacious padding & layout)
            //  Layout: 30px margin, 20px gap between cards
            //  Card size: 420×215, starting Y=205
            // ═══════════════════════════════════════════════════════

            int cardW = 420;
            int cardH = 215;
            int marginX = 30;
            int gapX = 20;
            int startY = 205;
            int gapY = 24;
            int col2X = marginX + cardW + gapX;
            int row2Y = startY + cardH + gapY;

            // ── panelTemporizadores ──────────────────────────────
            panelTemporizadores.BackColor = Color.Transparent;
            panelTemporizadores.FillColor = Color.FromArgb(248, 250, 255);
            panelTemporizadores.Location = new Point(marginX, startY);
            panelTemporizadores.Name = "panelTemporizadores";
            panelTemporizadores.Radius = 18;
            panelTemporizadores.ShadowColor = Color.FromArgb(180, 200, 220);
            panelTemporizadores.ShadowDepth = 20;
            panelTemporizadores.Size = new Size(cardW, cardH);
            panelTemporizadores.TabIndex = 1;
            panelTemporizadores.Controls.Add(lblTempTitulo);
            panelTemporizadores.Controls.Add(lblTempDesc);
            panelTemporizadores.Controls.Add(lblTempStat);

            lblTempTitulo.AutoSize = true;
            lblTempTitulo.Font = new Font("Segoe UI Semibold", 13.5F);
            lblTempTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblTempTitulo.Location = new Point(28, 24);
            lblTempTitulo.Text = "⏱️ Temporizadores y Alertas";

            lblTempDesc.AutoSize = true;
            lblTempDesc.Font = new Font("Segoe UI", 9.5F);
            lblTempDesc.ForeColor = Color.FromArgb(100, 110, 140);
            lblTempDesc.Location = new Point(30, 68);
            lblTempDesc.Text = "Configura recordatorios de pausas activas";

            lblTempStat.AutoSize = true;
            lblTempStat.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTempStat.ForeColor = Color.FromArgb(109, 158, 226);
            lblTempStat.Location = new Point(30, 108);
            lblTempStat.Text = "0 usos";

            // ── panelOsteo ───────────────────────────────────────
            panelOsteo.BackColor = Color.Transparent;
            panelOsteo.FillColor = Color.FromArgb(248, 250, 255);
            panelOsteo.Location = new Point(col2X, startY);
            panelOsteo.Name = "panelOsteo";
            panelOsteo.Radius = 18;
            panelOsteo.ShadowColor = Color.FromArgb(180, 200, 220);
            panelOsteo.ShadowDepth = 20;
            panelOsteo.Size = new Size(cardW, cardH);
            panelOsteo.TabIndex = 2;
            panelOsteo.Controls.Add(lblOsteoTitulo);
            panelOsteo.Controls.Add(lblOsteoDesc);
            panelOsteo.Controls.Add(lblOsteoStat);

            lblOsteoTitulo.AutoSize = true;
            lblOsteoTitulo.Font = new Font("Segoe UI Semibold", 13.5F);
            lblOsteoTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblOsteoTitulo.Location = new Point(28, 24);
            lblOsteoTitulo.Text = "🦴 Prevención Osteomuscular";

            lblOsteoDesc.AutoSize = true;
            lblOsteoDesc.Font = new Font("Segoe UI", 9.5F);
            lblOsteoDesc.ForeColor = Color.FromArgb(100, 110, 140);
            lblOsteoDesc.Location = new Point(30, 68);
            lblOsteoDesc.Text = "Ejercicios de estiramiento guiados";

            lblOsteoStat.AutoSize = true;
            lblOsteoStat.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblOsteoStat.ForeColor = Color.FromArgb(109, 158, 226);
            lblOsteoStat.Location = new Point(30, 108);
            lblOsteoStat.Text = "0 usos";

            // ── panelSaludMental ─────────────────────────────────
            panelSaludMental.BackColor = Color.Transparent;
            panelSaludMental.FillColor = Color.FromArgb(248, 250, 255);
            panelSaludMental.Location = new Point(marginX, row2Y);
            panelSaludMental.Name = "panelSaludMental";
            panelSaludMental.Radius = 18;
            panelSaludMental.ShadowColor = Color.FromArgb(180, 200, 220);
            panelSaludMental.ShadowDepth = 20;
            panelSaludMental.Size = new Size(cardW, cardH);
            panelSaludMental.TabIndex = 3;
            panelSaludMental.Controls.Add(lblMentalTitulo);
            panelSaludMental.Controls.Add(lblMentalDesc);
            panelSaludMental.Controls.Add(lblMentalStat);

            lblMentalTitulo.AutoSize = true;
            lblMentalTitulo.Font = new Font("Segoe UI Semibold", 13.5F);
            lblMentalTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblMentalTitulo.Location = new Point(28, 24);
            lblMentalTitulo.Text = "🧠 Salud Mental";

            lblMentalDesc.AutoSize = true;
            lblMentalDesc.Font = new Font("Segoe UI", 9.5F);
            lblMentalDesc.ForeColor = Color.FromArgb(100, 110, 140);
            lblMentalDesc.Location = new Point(30, 68);
            lblMentalDesc.Text = "Ejercicios de respiración y relajación";

            lblMentalStat.AutoSize = true;
            lblMentalStat.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblMentalStat.ForeColor = Color.FromArgb(109, 158, 226);
            lblMentalStat.Location = new Point(30, 108);
            lblMentalStat.Text = "0 usos";

            // ── panelSedentarismo ────────────────────────────────
            panelSedentarismo.BackColor = Color.Transparent;
            panelSedentarismo.FillColor = Color.FromArgb(248, 250, 255);
            panelSedentarismo.Location = new Point(col2X, row2Y);
            panelSedentarismo.Name = "panelSedentarismo";
            panelSedentarismo.Radius = 18;
            panelSedentarismo.ShadowColor = Color.FromArgb(180, 200, 220);
            panelSedentarismo.ShadowDepth = 20;
            panelSedentarismo.Size = new Size(cardW, cardH);
            panelSedentarismo.TabIndex = 4;
            panelSedentarismo.Controls.Add(lblSedTitulo);
            panelSedentarismo.Controls.Add(lblSedDesc);
            panelSedentarismo.Controls.Add(lblSedStat);

            lblSedTitulo.AutoSize = true;
            lblSedTitulo.Font = new Font("Segoe UI Semibold", 13.5F);
            lblSedTitulo.ForeColor = Color.FromArgb(16, 3, 99);
            lblSedTitulo.Location = new Point(28, 24);
            lblSedTitulo.Text = "🏃 Anti-Sedentarismo";

            lblSedDesc.AutoSize = true;
            lblSedDesc.Font = new Font("Segoe UI", 9.5F);
            lblSedDesc.ForeColor = Color.FromArgb(100, 110, 140);
            lblSedDesc.Location = new Point(30, 68);
            lblSedDesc.Text = "Hidratación y movimiento activo";

            lblSedStat.AutoSize = true;
            lblSedStat.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSedStat.ForeColor = Color.FromArgb(109, 158, 226);
            lblSedStat.Location = new Point(30, 108);
            lblSedStat.Text = "0 usos";

            // ═══════════════════════════════════════════════════════
            //  BUTTONS — inside each card, bottom-right
            // ═══════════════════════════════════════════════════════
            int btnW = 160;
            int btnH = 44;
            int btnX = cardW - btnW - 28;
            int btnY = cardH - btnH - 22;

            // ── btnTemporizadores ────────────────────────────────
            btnTemporizadores.Animated = true;
            btnTemporizadores.BorderRadius = 12;
            btnTemporizadores.CustomizableEdges = ce1;
            btnTemporizadores.FillColor = Color.FromArgb(16, 3, 99);
            btnTemporizadores.Font = new Font("Segoe UI Semibold", 9.5F);
            btnTemporizadores.ForeColor = Color.White;
            btnTemporizadores.HoverState.FillColor = Color.FromArgb(109, 158, 226);
            btnTemporizadores.Location = new Point(btnX, btnY);
            btnTemporizadores.Name = "btnTemporizadores";
            btnTemporizadores.ShadowDecoration.CustomizableEdges = ce2;
            btnTemporizadores.Size = new Size(btnW, btnH);
            btnTemporizadores.TabIndex = 5;
            btnTemporizadores.Text = "INGRESAR →";
            btnTemporizadores.Click += btnTemporizadores_Click;
            panelTemporizadores.Controls.Add(btnTemporizadores);

            // ── btnOsteo ─────────────────────────────────────────
            btnOsteo.Animated = true;
            btnOsteo.BorderRadius = 12;
            btnOsteo.CustomizableEdges = ce3;
            btnOsteo.FillColor = Color.FromArgb(16, 3, 99);
            btnOsteo.Font = new Font("Segoe UI Semibold", 9.5F);
            btnOsteo.ForeColor = Color.White;
            btnOsteo.HoverState.FillColor = Color.FromArgb(109, 158, 226);
            btnOsteo.Location = new Point(btnX, btnY);
            btnOsteo.Name = "btnOsteo";
            btnOsteo.ShadowDecoration.CustomizableEdges = ce4;
            btnOsteo.Size = new Size(btnW, btnH);
            btnOsteo.TabIndex = 6;
            btnOsteo.Text = "INGRESAR →";
            btnOsteo.Click += btnOsteo_Click;
            panelOsteo.Controls.Add(btnOsteo);

            // ── btnSaludMental ───────────────────────────────────
            btnSaludMental.Animated = true;
            btnSaludMental.BorderRadius = 12;
            btnSaludMental.CustomizableEdges = ce5;
            btnSaludMental.FillColor = Color.FromArgb(16, 3, 99);
            btnSaludMental.Font = new Font("Segoe UI Semibold", 9.5F);
            btnSaludMental.ForeColor = Color.White;
            btnSaludMental.HoverState.FillColor = Color.FromArgb(109, 158, 226);
            btnSaludMental.Location = new Point(btnX, btnY);
            btnSaludMental.Name = "btnSaludMental";
            btnSaludMental.ShadowDecoration.CustomizableEdges = ce6;
            btnSaludMental.Size = new Size(btnW, btnH);
            btnSaludMental.TabIndex = 7;
            btnSaludMental.Text = "INGRESAR →";
            btnSaludMental.Click += btnSaludMental_Click;
            panelSaludMental.Controls.Add(btnSaludMental);

            // ── btnSedentarismo ──────────────────────────────────
            btnSedentarismo.Animated = true;
            btnSedentarismo.BorderRadius = 12;
            btnSedentarismo.CustomizableEdges = ce7;
            btnSedentarismo.FillColor = Color.FromArgb(16, 3, 99);
            btnSedentarismo.Font = new Font("Segoe UI Semibold", 9.5F);
            btnSedentarismo.ForeColor = Color.White;
            btnSedentarismo.HoverState.FillColor = Color.FromArgb(109, 158, 226);
            btnSedentarismo.Location = new Point(btnX, btnY);
            btnSedentarismo.Name = "btnSedentarismo";
            btnSedentarismo.ShadowDecoration.CustomizableEdges = ce8;
            btnSedentarismo.Size = new Size(btnW, btnH);
            btnSedentarismo.TabIndex = 8;
            btnSedentarismo.Text = "INGRESAR →";
            btnSedentarismo.Click += btnSedentarismo_Click;
            panelSedentarismo.Controls.Add(btnSedentarismo);

            // ═══════════════════════════════════════════════════════
            //  MAIN FORM
            // ═══════════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 253);
            ClientSize = new Size(920, 685);

            Controls.Add(panelSedentarismo);
            Controls.Add(panelSaludMental);
            Controls.Add(panelOsteo);
            Controls.Add(panelTemporizadores);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software Ergonómico";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelTemporizadores.ResumeLayout(false);
            panelTemporizadores.PerformLayout();
            panelOsteo.ResumeLayout(false);
            panelOsteo.PerformLayout();
            panelSaludMental.ResumeLayout(false);
            panelSaludMental.PerformLayout();
            panelSedentarismo.ResumeLayout(false);
            panelSedentarismo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            ResumeLayout(false);
        }
    }
}
