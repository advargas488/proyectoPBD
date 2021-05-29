using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace pokedex.Invitado
{
    public partial class consultaEntrenador : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        double LatInicial = 9.9262422798561;
        double LongInicial = -84.0921020507813;
        Controlador.controladorEntrenadores controladorEntrenadores = new Controlador.controladorEntrenadores();
        public consultaEntrenador()
        {
            InitializeComponent();
        }

        private void consultaEntrenador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEntrenadores.GetList();
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.CanDragMap = true;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 9;
            gMapControl.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud {1}", LatInicial, LongInicial);

            gMapControl.Overlays.Add(markerOverlay);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuInvitado menuInvitado = new menuInvitado();
            ActiveForm.Hide();
            menuInvitado.Show();
        }

        private void gMapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;

            int late = Convert.ToInt32(gMapControl.FromLocalToLatLng(e.X, e.Y).Lat);
            int lnge = Convert.ToInt32(gMapControl.FromLocalToLatLng(e.X, e.Y).Lng);
            longitud.Text = lnge.ToString();
            latitud.Text = late.ToString();
            marker.Position = new PointLatLng(lat, lng);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string ubicacion = "";
            if(latitud.Text!="" && longitud.Text != "")
            {
                ubicacion = latitud.Text + " " + longitud.Text;
            }
            if(name.Text != "" && ubicacion != "")
            {
                dataGridView1.DataSource = controladorEntrenadores.GetTrainerByFliters(name.Text, ubicacion);
            }else if(name.Text != "" && ubicacion == "")
            {
                dataGridView1.DataSource = controladorEntrenadores.GetTrainersByName(name.Text);
            }else if(name.Text == "" && ubicacion != "")
            {
                dataGridView1.DataSource = controladorEntrenadores.GetTrainersByLoc(ubicacion);
            }
            else
            {
                dataGridView1.DataSource = controladorEntrenadores.GetList();
            }
            
        }
        private DataTable dtEntrenador()
        {
            DataTable dt = new DataTable();
            string ubicacion = "";
            SqlCommand command;
            if (latitud.Text != "" && longitud.Text != "")
            {
                ubicacion = latitud.Text + " " + longitud.Text;
            }
            string query;
            if (name.Text != "" && ubicacion != "")
            {
                query = "SELECT * FROM Entrenador WHERE Nombre_E = @nombre AND Ubicación = @ubicacion";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", name.Text);
                command.Parameters.AddWithValue("@ubicacion", ubicacion);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                da.Dispose();
            }
            else if (name.Text != "" && ubicacion == "")
            {
                query = "SELECT * FROM Entrenador WHERE Nombre_E = @nombre";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", name.Text);       
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                da.Dispose();
            }
            else if (name.Text == "" && ubicacion != "")
            {
                query = "SELECT * FROM Entrenador WHERE Ubicación = @ubicacion";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@ubicacion", ubicacion);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                da.Dispose();
            }
            conexion.Open();
            
            return dt;
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Dell\Downloads\Consulta_Entrenador.pdf", FileMode.Create));
            dt = dtEntrenador();
            if (dt.Rows.Count > 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


                PdfPTable table = new PdfPTable(dt.Columns.Count);
                document.Add(new Paragraph(20, "Reporte Entrenador", fontTitle));
                document.Add(new Chunk("\n"));

                float[] widths = new float[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                    widths[i] = 4f;

                table.SetWidths(widths);
                table.WidthPercentage = 90;

                PdfPCell cell = new PdfPCell(new Phrase("columns"));
                cell.Colspan = dt.Columns.Count;

                foreach (DataColumn c in dt.Columns)
                {
                    table.AddCell(new Phrase(c.ColumnName, font9));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int h = 0; h < dt.Columns.Count; h++)
                        {
                            table.AddCell(new Phrase(r[h].ToString(), font9));
                        }
                    }
                }
                document.Add(table);
            }
            document.Close();
        }
    }
}
