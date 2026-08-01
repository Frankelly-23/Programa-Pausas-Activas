namespace PausasActivas.Modulos
{
    public class SaludMentalForm : System.Windows.Forms.Form
    {
        public SaludMentalForm()
        {
            this.Text = "Salud Mental";
            this.Size = new System.Drawing.Size(600, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.Load += (s, e) =>
            {
                this.Hide();
                var form1 = new Form1();
                form1.FormClosed += (s2, e2) => this.Close();
                form1.Show();
            };
        }
    }
}
