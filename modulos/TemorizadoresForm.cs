using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public class TemorizadoresForm : Form
    {
        public TemorizadoresForm()
        {
            this.Text = "Temporizadores y Alertas";
            this.Size = new System.Drawing.Size(600, 450);
            this.StartPosition = FormStartPosition.CenterParent;

            // TODO Equipo 1: construir la UI aquí
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            labelTiempo = new Label();
            label2 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            label3 = new Label();
            label4 = new Label();
            guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            guna2CircleProgressBar1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label1.Location = new System.Drawing.Point(63, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 43);
            label1.TabIndex = 1;
            label1.Text = "Temporizadores";
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.Controls.Add(label2);
            guna2CircleProgressBar1.Controls.Add(labelTiempo);
            guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = System.Drawing.Color.FromArgb(109, 158, 226);
            guna2CircleProgressBar1.Location = new System.Drawing.Point(113, 189);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new System.Drawing.Size(224, 224);
            guna2CircleProgressBar1.TabIndex = 2;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges11;
            guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            guna2Button1.FocusedColor = System.Drawing.Color.White;
            guna2Button1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = System.Drawing.Color.White;
            guna2Button1.Location = new System.Drawing.Point(390, 235);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button1.Size = new System.Drawing.Size(204, 66);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "⏸ Pausar";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.BackColor = System.Drawing.Color.Transparent;
            labelTiempo.Font = new System.Drawing.Font("Segoe UI", 33F);
            labelTiempo.Location = new System.Drawing.Point(34, 60);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new System.Drawing.Size(164, 74);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(65, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "ENFOQUE";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges13;
            guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            guna2Button2.FocusedColor = System.Drawing.Color.White;
            guna2Button2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = System.Drawing.Color.White;
            guna2Button2.Location = new System.Drawing.Point(390, 307);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button2.Size = new System.Drawing.Size(204, 66);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "🔄 Reiniciar";
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.BackColor = System.Drawing.Color.FromArgb(91, 104, 140);
            guna2ProgressBar1.CustomizableEdges = customizableEdges15;
            guna2ProgressBar1.Location = new System.Drawing.Point(50, 501);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2ProgressBar1.Size = new System.Drawing.Size(622, 18);
            guna2ProgressBar1.TabIndex = 5;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label3.Location = new System.Drawing.Point(50, 471);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(231, 27);
            label3.TabIndex = 6;
            label3.Text = "👁️ Regla 20 / 20 /20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            label4.Location = new System.Drawing.Point(50, 549);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(250, 27);
            label4.TabIndex = 8;
            label4.Text = "👣 Reto de movimiento";
            // 
            // guna2ProgressBar2
            // 
            guna2ProgressBar2.BackColor = System.Drawing.Color.FromArgb(91, 104, 140);
            guna2ProgressBar2.CustomizableEdges = customizableEdges17;
            guna2ProgressBar2.Location = new System.Drawing.Point(50, 579);
            guna2ProgressBar2.Name = "guna2ProgressBar2";
            guna2ProgressBar2.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2ProgressBar2.Size = new System.Drawing.Size(622, 18);
            guna2ProgressBar2.TabIndex = 7;
            guna2ProgressBar2.Text = "guna2ProgressBar2";
            guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label5.Location = new System.Drawing.Point(435, 478);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(237, 20);
            label5.TabIndex = 9;
            label5.Text = "Próxima micropausa en 00:00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label6.Location = new System.Drawing.Point(494, 556);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(178, 20);
            label6.TabIndex = 10;
            label6.Text = "Próximo reto en 00:00";
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            label7.Location = new System.Drawing.Point(75, 123);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(376, 48);
            label7.TabIndex = 11;
            label7.Text = "🔔 Recibiras una notificación suave cada 2 minutos antes de cada cambio de fase.";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(109, 158, 226);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(725, 29);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // TemorizadoresForm
            // 
            BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            ClientSize = new System.Drawing.Size(725, 669);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(guna2ProgressBar2);
            Controls.Add(label3);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "TemorizadoresForm";
            guna2CircleProgressBar1.ResumeLayout(false);
            guna2CircleProgressBar1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Label labelTiempo;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private Label label5;
        private Label label6;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
