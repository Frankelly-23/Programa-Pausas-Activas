using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using PausasActivas.Modulos;

namespace PausasActivas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
                InitializeComponent();
                string logoPath = Path.Combine(Application.StartupPath, "images", "uce_logo.png");
                if (File.Exists(logoPath))
                    picLogo.Image = Image.FromFile(logoPath);
        }

        // ── Equipo 1 ──────────────────────────────────────────
        private void btnTemporizadores_Click(object sender, EventArgs e)
        {
            using (var modulo = new TemorizadoresForm())
                modulo.ShowDialog(this);

        }

        // ── Equipo 2 ──────────────────────────────────────────
        private void btnOsteo_Click(object sender, EventArgs e)
        {
            using (var modulo = new OsteoForm())
                modulo.ShowDialog(this);
        }

        // ── Equipo 3 ──────────────────────────────────────────
        private void btnSaludMental_Click(object sender, EventArgs e)
        {
            using (var modulo = new SaludMentalForm())
                modulo.ShowDialog(this);
        }

        // ── Equipo 4 ──────────────────────────────────────────
        private void btnSedentarismo_Click(object sender, EventArgs e)
        {
            using (var modulo = new SedentarismoForm())
                modulo.ShowDialog(this);
        }

        // ── Botón Pin (Always on top) ──────────────────────────
        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? Color.FromArgb(16, 3, 99) : Color.Transparent;
            btnPin.ForeColor = this.TopMost ? Color.White : Color.FromArgb(16, 3, 99);
        }
    }
}
