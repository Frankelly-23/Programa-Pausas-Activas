using System.Text.Json;
using Timer = System.Windows.Forms.Timer;

using System.Windows.Forms;
//using Button = System.Windows.Forms.Button;

namespace PausasActivas.Modulos
{

    public partial class SedentarismoForm : Form
    {

        private static readonly string RutaImagen =
    Path.Combine(AppContext.BaseDirectory, "modulos", "Sedentarismo", "imagen");

        private static readonly string RutaImagenGotaDeAgua =Path.Combine(RutaImagen, "gota-de-agua.png");
        private static readonly string RutaImagenAlerta = Path.Combine(RutaImagen, "alerta.png");
        private int vasosConsumidos = 0;
        private int metaVasos = 8;
        private const int ML_POR_VASO = 250;

        // Timer para el movimiento
        private Timer timerMovimiento;
        private int segundosRestantes = 1800; // 30 minutos
        private const int INTERVALO_MOVIMIENTO = 1800;
        private const int MAXIMO_MINUTOS = 60; // Máximo permitido
        private const int SEGUNDOS_POR_MINUTO = 60;
        private bool alertaActiva = false;
        private bool actualizandoDesdeCodigo = false;

        // Ruta del archivo JSON
        private string rutaArchivo = Path.Combine(Application.StartupPath, "Data", "sedentarismo_data.json");

        public SedentarismoForm()
        {
            InitializeComponent();
            InicializarHidratacion();
            InicializarMovimiento();

            this.Text = "Anti-Sedentarismo";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // Cargar datos guardados
            bool datosCargados = CargarDatos();
            ActualizarUI();
            ActualizarMovimiento();

            if (!datosCargados)
            {
                // Iniciar el contador automáticamente
                IniciarContadorMovimiento();
            }
        }

        private void InicializarHidratacion()
        {
            // Configurar la barra de progreso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = metaVasos;
            progressBar1.Value = 0;

            ActualizarUI();
        }

        private void InicializarMovimiento()
        {
            timerMovimiento = new Timer();
            timerMovimiento.Interval = 1000;
            timerMovimiento.Tick += TimerMovimiento_Tick;

            // Configurar el trackbar
            trackBarMovimiento.Minimum = 0;
            trackBarMovimiento.Maximum = MAXIMO_MINUTOS;
            actualizandoDesdeCodigo = true;
            trackBarMovimiento.Value = 30;
            actualizandoDesdeCodigo = false;
            // Configurar el switch
            switchMovimiento.Checked = true;

            ActualizarMovimiento();
        }

        private void IniciarContadorMovimiento()
        {
            // Reiniciar el contador
            segundosRestantes = INTERVALO_MOVIMIENTO;
            alertaActiva = false;

            // Iniciar el timer
            timerMovimiento.Start();

            // Actualizar la interfaz
            ActualizarMovimiento();

            // Cambiar el texto del botón
            btnIniciarMovimiento.Text = "En curso...";
            btnIniciarMovimiento.FillColor = Color.FromArgb(109, 158, 226);
        }

        private void TimerMovimiento_Tick(object sender, EventArgs e)
        {
            // Si el switch está desactivado, pausar el timer
            if (!switchMovimiento.Checked)
            {
                timerMovimiento.Stop();
                btnIniciarMovimiento.Text = "Reanudar";
                btnIniciarMovimiento.FillColor = Color.FromArgb(255, 193, 7);
                ActualizarMovimiento();
                return;
            }

            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                ActualizarMovimiento();
            }
            else
            {
                timerMovimiento.Stop();
                alertaActiva = true;
                ActualizarMovimiento();

                MessageBox.Show(
                    "Es momento de levantarte y caminar unos minutos.",
                    "Alerta de Movimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void ActualizarMovimiento()
        {
            // Actualizar los labels de tiempo
            TimeSpan tiempo = TimeSpan.FromSeconds(segundosRestantes);
            label7.Text = $"{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";

            // El trackbar muestra el valor en minutos
            int minutosRestantes = (int)Math.Ceiling(segundosRestantes / 60.0);
            actualizandoDesdeCodigo = true;
            trackBarMovimiento.Value = Math.Max(0, Math.Min(MAXIMO_MINUTOS, minutosRestantes));
            actualizandoDesdeCodigo = false;

            // Si el switch está desactivado, mostrar estado desactivado
            if (!switchMovimiento.Checked)
            {
                label6.Text = "Tiempo de inactividad (Desactivado)";
                label6.ForeColor = Color.FromArgb(191, 198, 211);
                btnIniciarMovimiento.Enabled = false;
                btnPosponerMovimiento.Enabled = false;
                return;
            }

            // Actualizar el estado de los botones según la alerta
            if (alertaActiva)
            {
                btnIniciarMovimiento.Text = "Reiniciar";
                btnIniciarMovimiento.FillColor = Color.FromArgb(191, 198, 211);

                // Cambiar color del label de estado
                label6.Text = "⏰ ¡Tiempo de moverse!";
                label6.ForeColor = Color.Firebrick;

                // Deshabilitar posponer cuando hay alerta
                btnPosponerMovimiento.Enabled = false;

                // Desactivar el switch automáticamente cuando hay alerta
                actualizandoDesdeCodigo = true;
                switchMovimiento.Checked = false;
                switchMovimiento.CheckedState.FillColor = Color.FromArgb(191, 198, 211);
                actualizandoDesdeCodigo = false;
            }
            else
            {
                if (timerMovimiento.Enabled)
                {
                    btnIniciarMovimiento.Text = "En curso...";
                    btnIniciarMovimiento.FillColor = Color.FromArgb(109, 158, 226);
                }
                else
                {
                    btnIniciarMovimiento.Text = segundosRestantes > 0 ? "Reanudar" : "Iniciar";
                    btnIniciarMovimiento.FillColor = segundosRestantes > 0 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(16, 3, 99);
                }

                label6.Text = "Tiempo de inactividad";
                label6.ForeColor = Color.FromArgb(16, 3, 99);

                // Habilitar o deshabilitar el botón posponer según el tiempo
                int minutosActuales = (int)Math.Ceiling(segundosRestantes / 60.0);
                btnPosponerMovimiento.Enabled = minutosActuales < MAXIMO_MINUTOS;

                // Cambiar el texto del botón posponer si está en el límite
                if (minutosActuales >= MAXIMO_MINUTOS)
                {
                    btnPosponerMovimiento.Text = "Límite alcanzado";
                    btnPosponerMovimiento.FillColor = Color.FromArgb(191, 198, 211);
                }
                else
                {
                    btnPosponerMovimiento.Text = "Posponer (+5 min)";
                    btnPosponerMovimiento.FillColor = Color.FromArgb(109, 158, 226);
                }

                // Asegurar que el switch refleje el estado correcto
                actualizandoDesdeCodigo = true;
                switchMovimiento.Checked = true;
                switchMovimiento.CheckedState.FillColor = Color.FromArgb(16, 3, 99);
                actualizandoDesdeCodigo = false;
            }
        }
        private void BtnAgregarVaso_Click(object sender, EventArgs e)
        {
            if (vasosConsumidos >= metaVasos)
            {
                MessageBox.Show(
                    $"Ya alcanzaste tu meta diaria de {metaVasos} vasos.",
                    "Meta cumplida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            vasosConsumidos++;
            ActualizarUI();
            GuardarDatos(); // Guardar después de cambiar

            if (vasosConsumidos == metaVasos)
            {
                MessageBox.Show(
                    "¡Felicidades! Meta completada 🎉",
                    "Hidratación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Reiniciar hidratación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                vasosConsumidos = 0;
                ActualizarUI();
                GuardarDatos(); // Guardar después de cambiar
            }
        }

        private void BtnMetaMenos_Click(object sender, EventArgs e)
        {
            if (metaVasos > 1)
            {
                metaVasos--;
                if (vasosConsumidos > metaVasos)
                    vasosConsumidos = metaVasos;
                ActualizarUI();
                GuardarDatos(); // Guardar después de cambiar
            }
        }

        private void BtnMetaMas_Click(object sender, EventArgs e)
        {
            metaVasos++;
            ActualizarUI();
            GuardarDatos(); // Guardar después de cambiar
        }

        private void ActualizarUI()
        {
            // Texto superior
            label2.Text = $"{vasosConsumidos} / {metaVasos} vasos";

            // Porcentaje
            int porcentaje = metaVasos > 0
                ? (int)((vasosConsumidos * 100.0) / metaVasos)
                : 0;
            label3.Text = $"{porcentaje}% de la meta";

            // Barra de progreso
            progressBar1.Maximum = metaVasos;
            progressBar1.Value = Math.Min(vasosConsumidos, metaVasos);

            // Meta
            txtMeta.Text = metaVasos.ToString();

            // Mililitros
            label4.Text = $"≈ {metaVasos * ML_POR_VASO} ml";

            // Botón
            btnAgregarVaso.Enabled = vasosConsumidos < metaVasos;
            btnAgregarVaso.Text = vasosConsumidos >= metaVasos
                ? "✓ Meta cumplida"
                : "+ Agregar vaso";

            // Iconos
            ActualizarIconosVasos();
        }

        private void ActualizarIconosVasos()
        {
            if (flowLayoutPanel1 == null)
                return;

            // Agregar los que faltan
            while (flowLayoutPanel1.Controls.Count < metaVasos)
            {
                Button btn = new Button
                {
                    Width = 40,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI Emoji", 18),
                    Margin = new Padding(4),
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += BtnGota_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

            // Quitar los sobrantes
            while (flowLayoutPanel1.Controls.Count > metaVasos)
            {
                int lastIndex = flowLayoutPanel1.Controls.Count - 1;
                Control c = flowLayoutPanel1.Controls[lastIndex];
                flowLayoutPanel1.Controls.RemoveAt(lastIndex);
                c.Dispose();
            }

            // Actualizar iconos
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                Button btn = (Button)flowLayoutPanel1.Controls[i];
                btn.Text = "💧";
                btn.ForeColor = i < vasosConsumidos
                    ? Color.FromArgb(109, 158, 226)
                    : Color.FromArgb(191, 198, 211);
                btn.Tag = i;
            }
        }

        private void BtnGota_Click(object sender, EventArgs e)
        {
            if (vasosConsumidos >= metaVasos)
                return;

            vasosConsumidos++;
            ActualizarUI();
            GuardarDatos(); // Guardar después de cambiar
        }

        private void BtnIniciarMovimiento_Click(object sender, EventArgs e)
        {
            if (alertaActiva)
            {
                // Reiniciar después de una alerta
                IniciarContadorMovimiento();
            }
            else if (timerMovimiento.Enabled)
            {
                // Si está en curso, pausar
                timerMovimiento.Stop();
                btnIniciarMovimiento.Text = "Reanudar";
                btnIniciarMovimiento.FillColor = Color.FromArgb(255, 193, 7);
                ActualizarMovimiento();
            }
            else
            {
                // Reanudar o iniciar
                if (segundosRestantes <= 0)
                {
                    IniciarContadorMovimiento();
                }
                else
                {
                    timerMovimiento.Start();
                    btnIniciarMovimiento.Text = "En curso...";
                    btnIniciarMovimiento.FillColor = Color.FromArgb(109, 158, 226);
                    ActualizarMovimiento();
                }
            }
            GuardarDatos(); // Guardar después de cambiar
        }

        private void BtnPosponerMovimiento_Click(object sender, EventArgs e)
        {
            // Verificar si ya se alcanzó el límite máximo
            int minutosActuales = (int)Math.Ceiling(segundosRestantes / 60.0);

            if (minutosActuales >= MAXIMO_MINUTOS)
            {
                MessageBox.Show(
                    $"Ya has alcanzado el límite máximo de {MAXIMO_MINUTOS} minutos de inactividad.\n" +
                    "Por favor, realiza una pausa activa ahora.",
                    "Límite alcanzado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Verificar si al agregar 5 minutos se superaría el límite
            if (minutosActuales + 5 > MAXIMO_MINUTOS)
            {
                // Solo agregar hasta el límite
                int segundosMaximos = MAXIMO_MINUTOS * SEGUNDOS_POR_MINUTO;
                if (segundosRestantes < segundosMaximos)
                {
                    segundosRestantes = segundosMaximos;
                }

                MessageBox.Show(
                    $"Solo se puede posponer hasta {MAXIMO_MINUTOS} minutos.\n" +
                    "Se ha establecido el tiempo al límite máximo.",
                    "Límite alcanzado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                // Agregar 5 minutos normalmente
                segundosRestantes += 300;
            }

            alertaActiva = false;

            if (!timerMovimiento.Enabled)
            {
                timerMovimiento.Start();
            }

            btnIniciarMovimiento.Text = "En curso...";
            btnIniciarMovimiento.FillColor = Color.FromArgb(109, 158, 226);
            ActualizarMovimiento();
            GuardarDatos(); // Guardar después de cambiar
        }

        private void TrackBarMovimiento_ValueChanged(object sender, EventArgs e)
        {
            // Evitar bucles si la actualización viene del código
            if (actualizandoDesdeCodigo)
                return;

            // Obtener el valor en minutos del trackbar
            int minutosSeleccionados = trackBarMovimiento.Value;

            // Convertir a segundos
            int segundosSeleccionados = minutosSeleccionados * SEGUNDOS_POR_MINUTO;

            // Actualizar el tiempo restante
            segundosRestantes = segundosSeleccionados;

            // Actualizar el label de tiempo
            TimeSpan tiempo = TimeSpan.FromSeconds(segundosRestantes);
            label7.Text = $"{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";

            // Si el timer está detenido y no hay alerta, actualizar la interfaz
            if (!timerMovimiento.Enabled && !alertaActiva)
            {
                ActualizarMovimiento();
            }
            else if (timerMovimiento.Enabled && !alertaActiva)
            {
                // Si el timer está en curso, actualizar el tiempo
                ActualizarMovimiento();
            }

            // Verificar si se alcanzó el límite máximo
            if (minutosSeleccionados >= MAXIMO_MINUTOS)
            {
                btnPosponerMovimiento.Enabled = false;
                btnPosponerMovimiento.Text = "Límite alcanzado";
                btnPosponerMovimiento.FillColor = Color.FromArgb(191, 198, 211);
            }
            else
            {
                btnPosponerMovimiento.Enabled = true;
                btnPosponerMovimiento.Text = "Posponer (+5 min)";
                btnPosponerMovimiento.FillColor = Color.FromArgb(109, 158, 226);
            }
        }

        private void SedentarismoForm_Resize(object sender, EventArgs e)
        {
            // Obtener el ancho actual del formulario
            int anchoFormulario = this.ClientSize.Width;

            // Calcular márgenes
            int margen = 20;
            int anchoDisponible = anchoFormulario - (margen * 2);

            // Ajustar progressBar1
            if (progressBar1 != null)
            {
                progressBar1.Width = anchoDisponible;
                progressBar1.Location = new Point(margen, progressBar1.Location.Y);
            }

            // Ajustar flowLayoutPanel1
            if (flowLayoutPanel1 != null)
            {
                flowLayoutPanel1.Width = anchoDisponible;
                flowLayoutPanel1.Location = new Point(margen, flowLayoutPanel1.Location.Y);
            }

            // Ajustar panel2
            if (panel2 != null)
            {
                panel2.Width = anchoDisponible;
                panel2.Location = new Point(margen, panel2.Location.Y);
            }

            // Ajustar panel3
            if (panel3 != null)
            {
                panel3.Width = anchoDisponible;
                panel3.Location = new Point(margen, panel3.Location.Y);
            }

            // Ajustar label2 (derecha, a la izquierda del botón Pin)
            if (label2 != null)
            {
                label2.Location = new Point(anchoDisponible - label2.Width - margen - 65, label2.Location.Y);
            }

            // Ajustar label3 (derecha)
            if (label3 != null)
            {
                label3.Location = new Point(anchoDisponible - label3.Width - margen, label3.Location.Y);
            }

            // Ajustar trackBarMovimiento dentro de panel3
            if (trackBarMovimiento != null && panel3 != null)
            {
                int margenInterno = 18;
                trackBarMovimiento.Width = panel3.Width - (margenInterno * 2);
            }

            // Ajustar btnIniciarMovimiento dentro de panel3
            if (btnIniciarMovimiento != null && panel3 != null)
            {
                btnIniciarMovimiento.Location = new Point(
                    panel3.Width - btnIniciarMovimiento.Width - btnPosponerMovimiento.Width - 20,
                    btnIniciarMovimiento.Location.Y
                );
            }

            // Ajustar btnPosponerMovimiento dentro de panel3
            if (btnPosponerMovimiento != null && panel3 != null)
            {
                btnPosponerMovimiento.Location = new Point(
                    panel3.Width - btnPosponerMovimiento.Width - 10,
                    btnPosponerMovimiento.Location.Y
                );
            }

            // Ajustar label8 dentro de panel3 (derecha)
            if (label8 != null && panel3 != null)
            {
                label8.Location = new Point(
                    panel3.Width - label8.Width - 15,
                    label8.Location.Y
                );
            }
        }

        // ============================================================
        // EVENTO: TEXTO DE META CAMBIADO
        // ============================================================
        private void TxtMeta_TextChanged(object sender, EventArgs e)
        {
            // Validar que el texto ingresado sea un número válido
            if (int.TryParse(txtMeta.Text, out int nuevaMeta))
            {
                // Limitar la meta entre 1 y 20
                if (nuevaMeta < 1)
                {
                    nuevaMeta = 1;
                    txtMeta.Text = "1";
                }
                else if (nuevaMeta > 20)
                {
                    nuevaMeta = 20;
                    txtMeta.Text = "20";
                }

                // Actualizar la meta
                metaVasos = nuevaMeta;

                // Si los vasos consumidos superan la nueva meta, ajustarlos
                if (vasosConsumidos > metaVasos)
                {
                    vasosConsumidos = metaVasos;
                    // Remover iconos de vasos sobrantes
                    while (flowLayoutPanel1.Controls.Count > vasosConsumidos)
                    {
                        flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    }
                }

                ActualizarUI();
            }
            else
            {
                // Si no es un número válido, restaurar el valor anterior
                if (!string.IsNullOrEmpty(txtMeta.Text))
                {
                    txtMeta.Text = metaVasos.ToString();
                }
            }
        }

        // ============================================================
        // EVENTO: TOGGLE SWITCH DE MOVIMIENTO CAMBIADO
        // ============================================================
        private void SwitchMovimiento_CheckedChanged(object sender, EventArgs e)
        {
            // Evitar bucles si la actualización viene del código
            if (actualizandoDesdeCodigo)
                return;

            // Cambiar el estado de la alerta según el switch
            alertaActiva = !switchMovimiento.Checked;

            if (switchMovimiento.Checked)
            {
                // ACTIVADO - Habilitar alertas y temporizador
                label6.ForeColor = System.Drawing.Color.FromArgb(16, 3, 99);
                label6.Text = "Tiempo de inactividad";

                // Cambiar color del switch
                switchMovimiento.CheckedState.FillColor = System.Drawing.Color.FromArgb(16, 3, 99);

                // Si hay una alerta activa, reiniciar el contador
                if (alertaActiva)
                {
                    IniciarContadorMovimiento();
                    alertaActiva = false;
                }
                else
                {
                    // Si el timer está detenido, reanudarlo
                    if (!timerMovimiento.Enabled && segundosRestantes > 0)
                    {
                        timerMovimiento.Start();
                        btnIniciarMovimiento.Text = "En curso...";
                        btnIniciarMovimiento.FillColor = Color.FromArgb(109, 158, 226);
                    }
                }

                // Habilitar botones
                trackBarMovimiento.Enabled = true;

                btnIniciarMovimiento.Enabled = true;
                btnPosponerMovimiento.Enabled = segundosRestantes < (MAXIMO_MINUTOS * SEGUNDOS_POR_MINUTO);

                // Actualizar la interfaz
                ActualizarMovimiento();
            }
            else
            {
                // DESACTIVADO - Deshabilitar alertas y pausar temporizador
                label6.ForeColor = System.Drawing.Color.FromArgb(191, 198, 211);
                label6.Text = "Tiempo de inactividad (Desactivado)";

                // Cambiar color del switch
                switchMovimiento.UncheckedState.FillColor = System.Drawing.Color.FromArgb(191, 198, 211);

                // Pausar el timer si está activo
                if (timerMovimiento.Enabled)
                {
                    timerMovimiento.Stop();
                    btnIniciarMovimiento.Text = "Reanudar";
                    btnIniciarMovimiento.FillColor = Color.FromArgb(255, 193, 7);
                }

                // Deshabilitar botones (excepto para reactivar)
                trackBarMovimiento.Enabled = false;
                btnIniciarMovimiento.Enabled = false;
                btnPosponerMovimiento.Enabled = false;

                // Actualizar la interfaz
                ActualizarMovimiento();
            }

            // Guardar el estado
            GuardarDatos();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            GuardarDatos(); // Guardar antes de cerrar
        }

        // Clase para serializar los datos
        private class DatosSedentarismo
        {
            public int VasosConsumidos { get; set; }
            public int MetaVasos { get; set; }
            public int SegundosRestantes { get; set; }
            public bool AlertaActiva { get; set; }
            public bool TimerActivo { get; set; }
            public DateTime FechaGuardado { get; set; }
        }

        private void GuardarDatos()
        {
            try
            {
                var datos = new DatosSedentarismo
                {
                    VasosConsumidos = vasosConsumidos,
                    MetaVasos = metaVasos,
                    SegundosRestantes = segundosRestantes,
                    AlertaActiva = alertaActiva,
                    TimerActivo = timerMovimiento.Enabled,
                    FechaGuardado = DateTime.Now
                };

                string jsonString = JsonSerializer.Serialize(datos, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));
                File.WriteAllText(rutaArchivo, jsonString);
            }
            catch (Exception ex)
            {
                // En producción, considerar logging
                Console.WriteLine($"Error al guardar: {ex.Message}");
            }
        }

        private bool CargarDatos()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string jsonString = File.ReadAllText(rutaArchivo);
                    var datos = JsonSerializer.Deserialize<DatosSedentarismo>(jsonString);

                    if (datos != null)
                    {
                        // Verificar si los datos son de hoy
                        if (datos.FechaGuardado.Date == DateTime.Now.Date)
                        {
                            vasosConsumidos = datos.VasosConsumidos;
                            metaVasos = datos.MetaVasos;
                            segundosRestantes = datos.SegundosRestantes;
                            alertaActiva = datos.AlertaActiva;

                            // Si el timer estaba activo al guardar, calcular el tiempo transcurrido
                            if (datos.TimerActivo && !alertaActiva)
                            {
                                TimeSpan tiempoTranscurrido = DateTime.Now - datos.FechaGuardado;
                                int segundosTranscurridos = (int)tiempoTranscurrido.TotalSeconds;

                                segundosRestantes = Math.Max(0, datos.SegundosRestantes - segundosTranscurridos);

                                if (segundosRestantes <= 0)
                                {
                                    alertaActiva = true;
                                    segundosRestantes = 0;
                                }
                            }
                            return true;
                        }
                        else
                        {
                            // Si no es de hoy, reiniciar datos
                            ReiniciarDatosDiarios();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar: {ex.Message}");
                ReiniciarDatosDiarios();
            }
            return false;
        }

        private void ReiniciarDatosDiarios()
        {
            vasosConsumidos = 0;
            metaVasos = 8;
            segundosRestantes = INTERVALO_MOVIMIENTO;
            alertaActiva = false;
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? Color.FromArgb(16, 3, 99) : Color.Transparent;
            btnPin.ForeColor = this.TopMost ? Color.White : Color.FromArgb(16, 3, 99);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
