using System;
using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormRelajacion relajacion = new FormRelajacion();
            relajacion.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormEnfoque enfoque = new FormEnfoque();
            enfoque.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FormRecuperacion recuperacion = new FormRecuperacion();
            recuperacion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
