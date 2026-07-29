using System;
using System.Windows.Forms;
using PausasActivas.Modulos;

namespace PausasActivas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
                InitializeComponent();
        }

        // ── Equipo 1 ──────────────────────────────────────────
        private void btnTemporizadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemorizadoresForm tempForm = new TemorizadoresForm();
            tempForm.ShowDialog();

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
    }
}
