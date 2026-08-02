using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public partial class SedentarismoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Método de ejemplo para cargar imágenes (ajusta la ruta según tu proyecto)
        private Image CargarImagen(string ruta)
        {
            try
            {
                return Image.FromFile(ruta);
            }
            catch
            {
                // Si no encuentra la imagen, devuelve un icono por defecto o null
                return null;
            }
        }

        private void InitializeComponent()
        {
            // ============================================================
            //  PANEL PRINCIPAL: FONDO Y TAMAÑO
            // ============================================================
            this.BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.MinimumSize = new System.Drawing.Size(800, 680);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hidratación";
            this.Resize += new System.EventHandler(this.SedentarismoForm_Resize);

            // ============================================================
            //  PANEL HIDRATACIÓN (Título + icono)
            // ============================================================
            this.panel1 = new Panel();
            this.pictureBox1 = new PictureBox();
            this.label1 = new Label();
            this.panel1.BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Size = new System.Drawing.Size(320, 60);
            this.panel1.TabIndex = 0;

            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = CargarImagen("ruta_gota_agua.png"); // Reemplaza con tu imagen
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Text = "Hidratación";
            this.label1.TabIndex = 1;

            // ============================================================
            //  CONTADOR DE VASOS (esquina superior derecha)
            // ============================================================
            this.label2 = new Label();
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.label2.Location = new System.Drawing.Point(640, 35);
            this.label2.Size = new System.Drawing.Size(137, 35);
            this.label2.Text = "0 / 8 vasos";
            this.label2.TabIndex = 1;

            // ============================================================
            //  FLOWLAYOUT PARA VASOS (iconos de vasos)
            // ============================================================
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 100);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 66);
            this.flowLayoutPanel1.Padding = new Padding(5);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;

            // ============================================================
            //  BARRA DE PROGRESO
            // ============================================================
            this.progressBar1 = new Guna2ProgressBar();
            this.progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderRadius = 12;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(109, 158, 226);
            this.progressBar1.Location = new System.Drawing.Point(20, 190);
            this.progressBar1.Size = new System.Drawing.Size(760, 28);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            // ============================================================
            //  BOTONES: AGREGAR VASO Y REINICIAR
            // ============================================================
            this.btnAgregarVaso = new Guna2Button();
            this.btnAgregarVaso.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarVaso.BorderRadius = 24;
            this.btnAgregarVaso.BorderThickness = 0;
            this.btnAgregarVaso.Cursor = Cursors.Hand;
            this.btnAgregarVaso.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.btnAgregarVaso.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.btnAgregarVaso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVaso.Location = new System.Drawing.Point(20, 240);
            this.btnAgregarVaso.Size = new System.Drawing.Size(220, 48);
            this.btnAgregarVaso.Text = "+ Agregar vaso";
            this.btnAgregarVaso.TabIndex = 6;
            this.btnAgregarVaso.Click += BtnAgregarVaso_Click;

            this.btnReiniciar = new Guna2Button();
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.BorderRadius = 24;
            this.btnReiniciar.BorderThickness = 0;
            this.btnReiniciar.Cursor = Cursors.Hand;
            this.btnReiniciar.FillColor = System.Drawing.Color.FromArgb(191, 198, 211);
            this.btnReiniciar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(255, 240);
            this.btnReiniciar.Size = new System.Drawing.Size(220, 48);
            this.btnReiniciar.Text = "⟳ Reiniciar día";
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Click += BtnReiniciar_Click;

            // ============================================================
            //  CONTROL DE META (botones - / +, caja de texto)
            // ============================================================
            this.btnMetaMenos = new Guna2Button();
            this.btnMetaMenos.BackColor = System.Drawing.Color.Transparent;
            this.btnMetaMenos.BorderRadius = 24;
            this.btnMetaMenos.BorderThickness = 0;
            this.btnMetaMenos.Cursor = Cursors.Hand;
            this.btnMetaMenos.FillColor = System.Drawing.Color.Transparent;
            this.btnMetaMenos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnMetaMenos.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.btnMetaMenos.Location = new System.Drawing.Point(20, 310);
            this.btnMetaMenos.Size = new System.Drawing.Size(48, 48);
            this.btnMetaMenos.Text = "-";
            this.btnMetaMenos.TabIndex = 1;
            this.btnMetaMenos.Click += BtnMetaMenos_Click;

            this.txtMeta = new Guna2TextBox();
            this.txtMeta.BackColor = System.Drawing.Color.Transparent;
            this.txtMeta.BorderRadius = 16;
            this.txtMeta.BorderThickness = 0;
            this.txtMeta.Cursor = Cursors.IBeam;
            this.txtMeta.DefaultText = "8";
            this.txtMeta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.txtMeta.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.txtMeta.Location = new System.Drawing.Point(88, 310);
            this.txtMeta.Size = new System.Drawing.Size(90, 47);
            this.txtMeta.TextAlign = HorizontalAlignment.Center;
            this.txtMeta.TabIndex = 3;
            this.txtMeta.Click += TxtMeta_TextChanged;

            this.btnMetaMas = new Guna2Button();
            this.btnMetaMas.BackColor = System.Drawing.Color.Transparent;
            this.btnMetaMas.BorderRadius = 24;
            this.btnMetaMas.BorderThickness = 0;
            this.btnMetaMas.Cursor = Cursors.Hand;
            this.btnMetaMas.FillColor = System.Drawing.Color.Transparent;
            this.btnMetaMas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnMetaMas.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.btnMetaMas.Location = new System.Drawing.Point(198, 310);
            this.btnMetaMas.Size = new System.Drawing.Size(48, 48);
            this.btnMetaMas.Text = "+";
            this.btnMetaMas.TabIndex = 1;
            this.btnMetaMas.Click += BtnMetaMas_Click;

            // ============================================================
            //  ETIQUETAS DE INFORMACIÓN: % META Y ML
            // ============================================================
            this.label3 = new Label();
            this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            this.label3.Location = new System.Drawing.Point(640, 240);
            this.label3.Text = "0% de la meta";
            this.label3.TabIndex = 9;

            this.label4 = new Label();
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            this.label4.Location = new System.Drawing.Point(270, 322);
            this.label4.Text = "≈ 0 ml";
            this.label4.TabIndex = 10;

            // ============================================================
            //  PANEL ALERTA DE MOVIMIENTO
            // ============================================================
            this.panel2 = new Panel();
            this.pictureBox2 = new PictureBox();
            this.label5 = new Label();
            this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(243, 248, 253);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(20, 390);
            this.panel2.Size = new System.Drawing.Size(760, 60);
            this.panel2.TabIndex = 2;

            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = CargarImagen("ruta_alerta.png"); // Reemplaza con tu imagen
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;

            this.label5.AutoSize = true;
            this.label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.label5.Location = new System.Drawing.Point(60, 10);
            this.label5.Text = "Alerta De Movimiento";
            this.label5.TabIndex = 1;

            // ============================================================
            //  PANEL CONTROLES DE MOVIMIENTO
            // ============================================================
            this.panel3 = new Panel();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.trackBarMovimiento = new Guna2TrackBar();
            this.switchMovimiento = new Guna2ToggleSwitch();
            this.btnIniciarMovimiento = new Guna2Button();
            this.btnPosponerMovimiento = new Guna2Button();

            this.panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.trackBarMovimiento);
            this.panel3.Controls.Add(this.switchMovimiento);
            this.panel3.Controls.Add(this.btnIniciarMovimiento);
            this.panel3.Controls.Add(this.btnPosponerMovimiento);
            this.panel3.Location = new System.Drawing.Point(20, 470);
            this.panel3.Size = new System.Drawing.Size(760, 170);
            this.panel3.TabIndex = 11;

            // Título "Tiempo de inactividad"
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Text = "Tiempo de inactividad";

            // Etiqueta "30 minutos" (izquierda)
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Text = "30 minutos";

            // Etiqueta "60 minutos" (derecha)
            this.label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(91, 104, 140);
            this.label8.Location = new System.Drawing.Point(620, 48);
            this.label8.Text = "60 minutos";

            // Trackbar
            this.trackBarMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.trackBarMovimiento.FillColor = System.Drawing.Color.FromArgb(191, 198, 211);
            this.trackBarMovimiento.Location = new System.Drawing.Point(18, 75);
            this.trackBarMovimiento.Maximum = 60;
            this.trackBarMovimiento.Minimum = 5;
            this.trackBarMovimiento.Size = new System.Drawing.Size(710, 23);
            this.trackBarMovimiento.TabIndex = 0;
            this.trackBarMovimiento.ThumbColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.trackBarMovimiento.Value = 30;
            this.trackBarMovimiento.ValueChanged += new System.EventHandler(this.TrackBarMovimiento_ValueChanged);

            // Toggle switch
            this.switchMovimiento.Checked = true;
            this.switchMovimiento.CheckedState.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.switchMovimiento.Location = new System.Drawing.Point(18, 115);
            this.switchMovimiento.Size = new System.Drawing.Size(35, 20);
            this.switchMovimiento.TabIndex = 0;
            this.switchMovimiento.UncheckedState.FillColor = System.Drawing.Color.FromArgb(191, 198, 211);
            this.switchMovimiento.CheckedChanged += new System.EventHandler(this.SwitchMovimiento_CheckedChanged);

            // Botón Iniciar
            this.btnIniciarMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnIniciarMovimiento.Animated = true;
            this.btnIniciarMovimiento.BorderRadius = 18;
            this.btnIniciarMovimiento.BorderThickness = 0;
            this.btnIniciarMovimiento.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);
            this.btnIniciarMovimiento.Font = new Font("Segoe UI", 9F);
            this.btnIniciarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnIniciarMovimiento.Location = new System.Drawing.Point(430, 108);
            this.btnIniciarMovimiento.Size = new System.Drawing.Size(140, 40);
            this.btnIniciarMovimiento.Text = "Iniciar";
            this.btnIniciarMovimiento.Click += new System.EventHandler(this.BtnIniciarMovimiento_Click);

            // Botón Posponer
            this.btnPosponerMovimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnPosponerMovimiento.Animated = true;
            this.btnPosponerMovimiento.BorderRadius = 18;
            this.btnPosponerMovimiento.BorderThickness = 0;
            this.btnPosponerMovimiento.FillColor = System.Drawing.Color.FromArgb(109, 158, 226);
            this.btnPosponerMovimiento.Font = new Font("Segoe UI", 9F);
            this.btnPosponerMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnPosponerMovimiento.Location = new System.Drawing.Point(585, 108);
            this.btnPosponerMovimiento.Size = new System.Drawing.Size(140, 40);
            this.btnPosponerMovimiento.Text = "Posponer";
            this.btnPosponerMovimiento.Click += new System.EventHandler(this.BtnPosponerMovimiento_Click);

            // ============================================================
            //  AGREGAR CONTROLES AL FORMULARIO
            // ============================================================
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarVaso);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnMetaMenos);
            this.Controls.Add(this.txtMeta);
            this.Controls.Add(this.btnMetaMas);
            this.Controls.Add(this.label4);
        }

        // Declaración de los controles (como campos de clase)
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna2ProgressBar progressBar1;
        private Guna2Button btnAgregarVaso;
        private Guna2Button btnReiniciar;
        private Guna2Button btnMetaMenos;
        private Guna2Button btnMetaMas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna2TextBox txtMeta;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Guna2TrackBar trackBarMovimiento;
        private Guna2ToggleSwitch switchMovimiento;
        private Guna2Button btnIniciarMovimiento;
        private Guna2Button btnPosponerMovimiento;

    }
}