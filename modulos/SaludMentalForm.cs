using System;
using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public partial class SaludMentalForm : Form
    {
        public SaludMentalForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var relajacion = new FormRelajacion())
            {
                relajacion.ShowDialog(this);
            }
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var enfoque = new FormEnfoque())
            {
                enfoque.ShowDialog(this);
            }
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var recuperacion = new FormRecuperacion())
            {
                recuperacion.ShowDialog(this);
            }
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? System.Drawing.Color.FromArgb(16, 3, 99) : System.Drawing.Color.Transparent;
            btnPin.ForeColor = this.TopMost ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(16, 3, 99);
        }
    }
}
