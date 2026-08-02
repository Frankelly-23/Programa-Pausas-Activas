using System;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace PausasActivas.Modulos

{
    public class OsteoForm : System.Windows.Forms.Form
    {
        private Guna.UI2.WinForms.Guna2Button BotonAnterior;

        private Guna.UI2.WinForms.Guna2Button botonCuello;

        private Guna.UI2.WinForms.Guna2Button BotonEspalda;

        private Guna.UI2.WinForms.Guna2Button BotonMuñeca;

        private Guna.UI2.WinForms.Guna2Button BotonPausa;

        private Guna.UI2.WinForms.Guna2Button BotonSiguiente;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label LabelPaso;

        private System.Windows.Forms.Label LabelEstiramiento;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar TemporizadorBar;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Panel panelHeader;
        private System.ComponentModel.IContainer components;

        public OsteoForm()
        {
            InitializeComponent();
            this.Text = "Prevención Osteomuscular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolver = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ceVolverShadow = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges cePin2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panelHeader = new Panel();
            btnPin = new Guna.UI2.WinForms.Guna2Button();
            botonCuello = new Guna.UI2.WinForms.Guna2Button();
            BotonMuñeca = new Guna.UI2.WinForms.Guna2Button();
            BotonEspalda = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            LabelEstiramiento = new Label();
            LabelPaso = new Label();
            BotonSiguiente = new Guna.UI2.WinForms.Guna2Button();
            BotonPausa = new Guna.UI2.WinForms.Guna2Button();
            BotonAnterior = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new System.Windows.Forms.Timer(components);
            TemporizadorBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            btnVolver = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(171, 217, 244);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 80;
            panelHeader.Name = "panelHeader";
            panelHeader.Controls.Add(btnPin);
            panelHeader.Controls.Add(label1);
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
            btnPin.Location = new Point(860, 18);
            btnPin.Name = "btnPin";
            btnPin.ShadowDecoration.CustomizableEdges = cePin2;
            btnPin.Size = new Size(50, 42);
            btnPin.TabIndex = 99;
            btnPin.Text = "📌";
            btnPin.Click += btnPin_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 3, 99);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(618, 71);
            label1.TabIndex = 0;
            label1.Text = "Prevencion Osteomuscular";
            //
            // botonCuello
            //
            botonCuello.Animated = true;
            botonCuello.BackColor = Color.Transparent;
            botonCuello.BorderRadius = 12;
            botonCuello.CustomizableEdges = customizableEdges15;
            botonCuello.DisabledState.BorderColor = Color.DarkGray;
            botonCuello.DisabledState.CustomBorderColor = Color.DarkGray;
            botonCuello.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            botonCuello.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            botonCuello.FillColor = Color.FromArgb(109, 158, 226);
            botonCuello.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonCuello.ForeColor = Color.Black;
            botonCuello.Location = new Point(89, 117);
            botonCuello.Name = "botonCuello";
            botonCuello.ShadowDecoration.CustomizableEdges = customizableEdges16;
            botonCuello.Size = new Size(221, 79);
            botonCuello.TabIndex = 2;
            botonCuello.Text = "Cuello";
            botonCuello.Click += botonCuello_Click;
            //
            // BotonMuñeca
            //
            BotonMuñeca.Animated = true;
            BotonMuñeca.BackColor = Color.Transparent;
            BotonMuñeca.BorderRadius = 12;
            BotonMuñeca.CustomizableEdges = customizableEdges17;
            BotonMuñeca.DisabledState.BorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonMuñeca.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonMuñeca.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonMuñeca.FillColor = Color.FromArgb(109, 158, 226);
            BotonMuñeca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonMuñeca.ForeColor = Color.Black;
            BotonMuñeca.Location = new Point(352, 117);
            BotonMuñeca.Name = "BotonMuñeca";
            BotonMuñeca.ShadowDecoration.CustomizableEdges = customizableEdges18;
            BotonMuñeca.Size = new Size(221, 79);
            BotonMuñeca.TabIndex = 3;
            BotonMuñeca.Text = "Muñecas";
            BotonMuñeca.Click += BotonMuñeca_Click;
            //
            // BotonEspalda
            //
            BotonEspalda.Animated = true;
            BotonEspalda.BackColor = Color.Transparent;
            BotonEspalda.BorderRadius = 12;
            BotonEspalda.CustomizableEdges = customizableEdges19;
            BotonEspalda.DisabledState.BorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonEspalda.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonEspalda.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonEspalda.FillColor = Color.FromArgb(109, 158, 226);
            BotonEspalda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEspalda.ForeColor = Color.Black;
            BotonEspalda.Location = new Point(627, 117);
            BotonEspalda.Name = "BotonEspalda";
            BotonEspalda.ShadowDecoration.CustomizableEdges = customizableEdges20;
            BotonEspalda.Size = new Size(221, 79);
            BotonEspalda.TabIndex = 4;
            BotonEspalda.Text = "Espalda";
            BotonEspalda.Click += BotonEspalda_Click;
            //
            // pictureBox1
            //
            pictureBox1.BackColor = Color.FromArgb(230, 240, 250);
            pictureBox1.Location = new Point(50, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(6);
            pictureBox1.Size = new Size(798, 162);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            //
            // LabelEstiramiento
            //
            LabelEstiramiento.AutoSize = true;
            LabelEstiramiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEstiramiento.ForeColor = Color.FromArgb(16, 3, 99);
            LabelEstiramiento.Location = new Point(41, 413);
            LabelEstiramiento.Name = "LabelEstiramiento";
            LabelEstiramiento.Size = new Size(398, 45);
            LabelEstiramiento.TabIndex = 7;
            LabelEstiramiento.Text = "Seleccione un estiramiento";
            //
            // LabelPaso
            //
            LabelPaso.AutoSize = true;
            LabelPaso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPaso.ForeColor = Color.FromArgb(16, 3, 99);
            LabelPaso.Location = new Point(50, 552);
            LabelPaso.Name = "LabelPaso";
            LabelPaso.Size = new Size(146, 36);
            LabelPaso.TabIndex = 9;
            LabelPaso.Text = "Paso _ de _";
            //
            // BotonSiguiente
            //
            BotonSiguiente.Animated = true;
            BotonSiguiente.BackColor = Color.Transparent;
            BotonSiguiente.BorderRadius = 12;
            BotonSiguiente.CustomizableEdges = customizableEdges21;
            BotonSiguiente.DisabledState.BorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonSiguiente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonSiguiente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonSiguiente.Enabled = false;
            BotonSiguiente.FillColor = Color.FromArgb(109, 158, 226);
            BotonSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BotonSiguiente.ForeColor = Color.Black;
            BotonSiguiente.Location = new Point(579, 620);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges22;
            BotonSiguiente.Size = new Size(159, 65);
            BotonSiguiente.TabIndex = 12;
            BotonSiguiente.Text = "Siguiente >";
            BotonSiguiente.Click += BotonSiguiente_Click;
            //
            // BotonPausa
            //
            BotonPausa.Animated = true;
            BotonPausa.BackColor = Color.Transparent;
            BotonPausa.BorderRadius = 12;
            BotonPausa.CustomizableEdges = customizableEdges23;
            BotonPausa.DisabledState.BorderColor = Color.DarkGray;
            BotonPausa.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonPausa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonPausa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonPausa.Enabled = false;
            BotonPausa.FillColor = Color.FromArgb(109, 158, 226);
            BotonPausa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BotonPausa.ForeColor = Color.Black;
            BotonPausa.Location = new Point(427, 620);
            BotonPausa.Name = "BotonPausa";
            BotonPausa.ShadowDecoration.CustomizableEdges = customizableEdges24;
            BotonPausa.Size = new Size(146, 65);
            BotonPausa.TabIndex = 11;
            BotonPausa.Text = "II Pausar";
            BotonPausa.Click += BotonPausa_Click;
            //
            // BotonAnterior
            //
            BotonAnterior.Animated = true;
            BotonAnterior.BackColor = Color.Transparent;
            BotonAnterior.BorderRadius = 12;
            BotonAnterior.CustomizableEdges = customizableEdges25;
            BotonAnterior.DisabledState.BorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.CustomBorderColor = Color.DarkGray;
            BotonAnterior.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BotonAnterior.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BotonAnterior.Enabled = false;
            BotonAnterior.FillColor = Color.FromArgb(109, 158, 226);
            BotonAnterior.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BotonAnterior.ForeColor = Color.Black;
            BotonAnterior.Location = new Point(271, 620);
            BotonAnterior.Name = "BotonAnterior";
            BotonAnterior.ShadowDecoration.CustomizableEdges = customizableEdges26;
            BotonAnterior.Size = new Size(150, 65);
            BotonAnterior.TabIndex = 10;
            BotonAnterior.Text = "< Anterior";
            BotonAnterior.Click += BotonAnterior_Click;
            //
            // timer1
            //
            timer1.Tick += timer1_Tick;
            //
            // TemporizadorBar
            //
            TemporizadorBar.BorderRadius = 20;
            TemporizadorBar.CustomizableEdges = customizableEdges27;
            TemporizadorBar.FillColor = Color.FromArgb(190, 198, 211);
            TemporizadorBar.Location = new Point(50, 479);
            TemporizadorBar.Name = "TemporizadorBar";
            TemporizadorBar.ProgressColor = Color.FromArgb(109, 157, 226);
            TemporizadorBar.ProgressColor2 = Color.FromArgb(15, 3, 98);
            TemporizadorBar.ShadowDecoration.CustomizableEdges = customizableEdges28;
            TemporizadorBar.Size = new Size(473, 70);
            TemporizadorBar.Style = ProgressBarStyle.Continuous;
            TemporizadorBar.TabIndex = 13;
            TemporizadorBar.Text = "guna2ProgressBar1";
            TemporizadorBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            btnVolver.Location = new Point(15, 650);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ceVolverShadow;
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            //
            // OsteoForm
            //
            BackColor = Color.FromArgb(243, 248, 253);
            ClientSize = new Size(934, 697);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Controls.Add(btnVolver);
            Controls.Add(TemporizadorBar);
            Controls.Add(BotonSiguiente);
            Controls.Add(BotonPausa);
            Controls.Add(BotonAnterior);
            Controls.Add(LabelPaso);
            Controls.Add(LabelEstiramiento);
            Controls.Add(pictureBox1);
            Controls.Add(BotonEspalda);
            Controls.Add(BotonMuñeca);
            Controls.Add(botonCuello);
            Controls.Add(panelHeader);
            Name = "OsteoForm";
            Text = "Osteo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private int paso;
        private int paso_total;

        // Carpeta del estiramiento actualmente seleccionado (p.ej. "Cuello", "Cuello")
        private string carpetaActual;

        private string prefijoArchivoActual;
        private bool completado;

        // Ruta base donde viven las carpetas de imágenes, relativa al ejecutable
        private static readonly string RutaBaseImagenes =
            Path.Combine(AppContext.BaseDirectory, "modulos", "ImagenesOsteo");

        private static readonly string RutaImagenCompletado =
            Path.Combine(RutaBaseImagenes, "Completado.png");

        private void CargarImagenPaso()
        {
            if (string.IsNullOrEmpty(carpetaActual))
                return;

            System.Media.SystemSounds.Asterisk.Play();
            string rutaImagen = Path.Combine(RutaBaseImagenes, carpetaActual, $"{prefijoArchivoActual}{paso}.jpg");
            MostrarImagenDesdeArchivo(rutaImagen);
        }

        private void MostrarImagenDesdeArchivo(string rutaImagen)
        {
            // Se libera la imagen anterior para no dejar el archivo bloqueado
            var imagenAnterior = pictureBox1.Image;
            pictureBox1.Image = null;
            imagenAnterior?.Dispose();

            if (File.Exists(rutaImagen))
            {
                using (var stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void MostrarCompletado()
        {
            timer1.Stop();
            completado = true;

            LabelEstiramiento.Text = "¡Estiramiento completado!";
            LabelPaso.Text = $"Paso {paso_total} de {paso_total}";
            TemporizadorBar.Value = TemporizadorBar.Maximum;

            MostrarImagenDesdeArchivo(RutaImagenCompletado);

            BotonSiguiente.Enabled = false;
            BotonPausa.Enabled = false;
            BotonPausa.Text = "II Pausar";
            BotonAnterior.Enabled = true; // permite revisar pasos anteriores

            BotonPausa_Click(null, null); // Devuelve la barra de progreso a 0 y le quita la pausa si se le da al boton anterior
                                          // (bug arreglado :b) 
        }

        private void IniciarEstiramiento(string nombreMostrado, string carpeta, string prefijoArchivo, int totalPasos)
        {
            carpetaActual = carpeta;
            prefijoArchivoActual = prefijoArchivo;

            paso = 1;
            paso_total = totalPasos;
            completado = false;

            BotonAnterior.Enabled = true;
            BotonSiguiente.Enabled = true;
            BotonPausa.Enabled = true;
            BotonPausa.Text = "II Pausar";

            LabelEstiramiento.Text = nombreMostrado;
            TemporizadorBar.Minimum = 0;
            TemporizadorBar.Maximum = 70; // 7 segundos
            TemporizadorBar.Value = 0;

            CargarImagenPaso();

            timer1.Interval = 100;
            timer1.Start();

            LabelPaso.Text = $"Paso {paso} de {paso_total}";
        }

        private void botonCuello_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(botonCuello);
            IniciarEstiramiento("Estiramiento de Cuello", "Cuello", "Cuello", totalPasos: 5);
        }

        private void BotonMuñeca_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(BotonMuñeca);
            IniciarEstiramiento("Estiramiento de muñecas", "Muneca", "Muneca", totalPasos: 3);
        }

        private void BotonEspalda_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(BotonEspalda);
            IniciarEstiramiento("Estiramiento de Espalda", "Espalda", "Espalda", totalPasos: 5);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (TemporizadorBar.Value < TemporizadorBar.Maximum)
            {
                TemporizadorBar.Value++;
            }
            else
            {
                paso++;

                if (paso > paso_total)
                {
                    paso = paso_total;
                    MostrarCompletado();
                    return;
                }

                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                TemporizadorBar.Value = 0;
                CargarImagenPaso();
            }
        }

        private void BotonPausa_Click(object sender, System.EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                BotonPausa.Text = "▶ Reanudar";
            }
            else
            {
                timer1.Start();
                BotonPausa.Text = "II Pausar";
            }
        }

        private void BotonSiguiente_Click(object sender, System.EventArgs e)
        {
            if (completado)
                return;

            if (paso < paso_total)
            {
                paso++;
                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                //reiniciar el temporizador
                TemporizadorBar.Value = 0;
                CargarImagenPaso();
            }
            else
            {
                MostrarCompletado();
            }
        }

        private void BotonAnterior_Click(object sender, System.EventArgs e)
        {
            if (completado)
            {
                // Salir de la pantalla de completado y volver a mostrar el último paso real
                completado = false;
                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                TemporizadorBar.Value = 0;
                CargarImagenPaso();

                BotonSiguiente.Enabled = true;
                BotonPausa.Enabled = true;
                LabelEstiramiento.Text = ObtenerNombreEstiramientoActual();
                return;
            }

            if (paso > 1)
            {
                paso--;
                LabelPaso.Text = $"Paso {paso} de {paso_total}";
                //reiniciar el temporizador
                TemporizadorBar.Value = 0;
                CargarImagenPaso();
            }
        }

        private string ObtenerNombreEstiramientoActual()
        {
            switch (carpetaActual)
            {
                case "Cuello": return "Estiramiento de Cuello";
                case "Espalda": return "Estiramiento de Espalda";
                case "Muneca": return "Estiramiento de muñecas";
                default: return LabelEstiramiento.Text;
            }
        }

        private void ActivarBoton(Guna.UI2.WinForms.Guna2Button botonActivo)
        {
            // Color normal para todos
            botonCuello.FillColor = Color.FromArgb(109, 158, 226);
            BotonMuñeca.FillColor = Color.FromArgb(109, 158, 226);
            BotonEspalda.FillColor = Color.FromArgb(109, 158, 226);
            botonCuello.ForeColor = Color.Black;
            BotonMuñeca.ForeColor = Color.Black;
            BotonEspalda.ForeColor = Color.Black;

            // Color del botón seleccionado
            botonActivo.FillColor = Color.FromArgb(16, 3, 99);
            botonActivo.ForeColor = Color.White;
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void btnPin_Click(object sender, System.EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? Color.FromArgb(16, 3, 99) : Color.Transparent;
            btnPin.ForeColor = this.TopMost ? Color.White : Color.FromArgb(16, 3, 99);
        }
        private Guna.UI2.WinForms.Guna2Button btnPin;
    }
}