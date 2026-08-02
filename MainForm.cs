using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using PausasActivas.Modulos;

namespace PausasActivas
{
    public partial class MainForm : Form
    {
        private static readonly string rutaEstadisticas = Path.Combine(Application.StartupPath, "Data", "estadisticas.json");

        public MainForm()
        {
            InitializeComponent();
            string logoPath = Path.Combine(Application.StartupPath, "images", "uce_logo.png");
            if (File.Exists(logoPath))
                picLogo.Image = Image.FromFile(logoPath);

            CargarEstadisticas();
            this.Activated += (s, e) => CargarEstadisticas();
        }

        // ── Equipo 1 ──────────────────────────────────────────
        private void btnTemporizadores_Click(object sender, EventArgs e)
        {
            RegistrarUso("Temporizadores");
            var modulo = new TemorizadoresForm();
            modulo.Show();
        }

        // ── Equipo 2 ──────────────────────────────────────────
        private void btnOsteo_Click(object sender, EventArgs e)
        {
            RegistrarUso("Osteomuscular");
            var modulo = new OsteoForm();
            modulo.Show();
        }

        // ── Equipo 3 ──────────────────────────────────────────
        private void btnSaludMental_Click(object sender, EventArgs e)
        {
            RegistrarUso("SaludMental");
            var modulo = new SaludMentalForm();
            modulo.Show();
        }

        // ── Equipo 4 ──────────────────────────────────────────
        private void btnSedentarismo_Click(object sender, EventArgs e)
        {
            RegistrarUso("Sedentarismo");
            var modulo = new SedentarismoForm();
            modulo.Show();
        }

        // ── Botón Pin (Always on top) ──────────────────────────
        private void btnPin_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnPin.FillColor = this.TopMost ? Color.FromArgb(16, 3, 99) : Color.Transparent;
            btnPin.ForeColor = this.TopMost ? Color.White : Color.FromArgb(16, 3, 99);
        }

        // ── Estadísticas ──────────────────────────────────────
        private class EstadisticasUso
        {
            public int TotalSesiones { get; set; }
            public int UsosTemp { get; set; }
            public int UsosOsteo { get; set; }
            public int UsosMental { get; set; }
            public int UsosSed { get; set; }
            public string FechaInicio { get; set; } = "";
            public string UltimoUso { get; set; } = "";
        }

        private void RegistrarUso(string modulo)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaEstadisticas));
                EstadisticasUso stats;
                if (File.Exists(rutaEstadisticas))
                {
                    string json = File.ReadAllText(rutaEstadisticas);
                    stats = JsonSerializer.Deserialize<EstadisticasUso>(json) ?? new EstadisticasUso();
                }
                else
                {
                    stats = new EstadisticasUso { FechaInicio = DateTime.Now.ToString("dd/MM/yyyy") };
                }

                stats.TotalSesiones++;
                stats.UltimoUso = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                if (string.IsNullOrEmpty(stats.FechaInicio))
                    stats.FechaInicio = DateTime.Now.ToString("dd/MM/yyyy");

                switch (modulo)
                {
                    case "Temporizadores": stats.UsosTemp++; break;
                    case "Osteomuscular": stats.UsosOsteo++; break;
                    case "SaludMental": stats.UsosMental++; break;
                    case "Sedentarismo": stats.UsosSed++; break;
                }

                string output = JsonSerializer.Serialize(stats, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaEstadisticas, output);
                CargarEstadisticas();
            }
            catch { }
        }

        private void CargarEstadisticas()
        {
            try
            {
                // Stats panel defaults
                lblStatTotal.Text = "0 sesiones";
                lblStatFavorito.Text = "—";
                lblStatUltimo.Text = "—";

                // Module card stats defaults
                lblTempStat.Text = "0 usos";
                lblOsteoStat.Text = "0 usos";
                lblMentalStat.Text = "0 usos";
                lblSedStat.Text = "0 usos";

                if (File.Exists(rutaEstadisticas))
                {
                    string json = File.ReadAllText(rutaEstadisticas);
                    var stats = JsonSerializer.Deserialize<EstadisticasUso>(json);
                    if (stats != null)
                    {
                        lblStatTotal.Text = $"{stats.TotalSesiones} sesiones";
                        lblStatUltimo.Text = string.IsNullOrEmpty(stats.UltimoUso) ? "—" : stats.UltimoUso;

                        // Find favorite module
                        int max = Math.Max(Math.Max(stats.UsosTemp, stats.UsosOsteo),
                                           Math.Max(stats.UsosMental, stats.UsosSed));
                        if (max > 0)
                        {
                            if (max == stats.UsosTemp) lblStatFavorito.Text = "⏱️ Temporizadores";
                            else if (max == stats.UsosOsteo) lblStatFavorito.Text = "🦴 Osteomuscular";
                            else if (max == stats.UsosMental) lblStatFavorito.Text = "🧠 Salud Mental";
                            else lblStatFavorito.Text = "🏃 Anti-Sedentarismo";
                        }

                        lblTempStat.Text = $"{stats.UsosTemp} usos";
                        lblOsteoStat.Text = $"{stats.UsosOsteo} usos";
                        lblMentalStat.Text = $"{stats.UsosMental} usos";
                        lblSedStat.Text = $"{stats.UsosSed} usos";
                    }
                }

                // Load OsteoForm extra info
                string osteoPath = Path.Combine(Application.StartupPath, "Data", "osteo_data.json");
                if (File.Exists(osteoPath))
                {
                    string json = File.ReadAllText(osteoPath);
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;
                    if (root.TryGetProperty("CarpetaActual", out var carpeta) && carpeta.GetString() != null)
                    {
                        string nombre = carpeta.GetString() switch
                        {
                            "Cuello" => "Cuello",
                            "Espalda" => "Espalda",
                            "Muneca" => "Muñeca",
                            _ => carpeta.GetString()
                        };
                        int paso = root.TryGetProperty("Paso", out var p) ? p.GetInt32() : 0;
                        int total = root.TryGetProperty("PasoTotal", out var t) ? t.GetInt32() : 0;
                        lblOsteoStat.Text += $" · {nombre} {paso}/{total}";
                    }
                }

                // Load Sedentarismo extra info
                string sedPath = Path.Combine(Application.StartupPath, "Data", "sedentarismo_data.json");
                if (File.Exists(sedPath))
                {
                    string json = File.ReadAllText(sedPath);
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;
                    if (root.TryGetProperty("VasosConsumidos", out var vasos) &&
                        root.TryGetProperty("MetaVasos", out var meta))
                    {
                        lblSedStat.Text += $" · 💧{vasos.GetInt32()}/{meta.GetInt32()}";
                    }
                }
            }
            catch { }
        }
    }
}
