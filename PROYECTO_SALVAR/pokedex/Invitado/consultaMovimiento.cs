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
    public partial class consultaMovimiento : Form
    {
        Controlador.controladorMovimientos controladorMovimientos = new Controlador.controladorMovimientos();
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");

        public consultaMovimiento()
        {
            InitializeComponent();
            
        }

        private void consultaMovimiento_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorMovimientos.GetMovements();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuInvitado menuInvitado = new menuInvitado();
            ActiveForm.Hide();
            menuInvitado.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (tipoM.Text != "")
            {
                dataGridView1.DataSource = controladorMovimientos.GetMovByType(tipoM.Text);
                
            }
            
        }
        private DataTable dtMove()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Movimiento WHERE Tipo = @tipo";
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@tipo", tipoM.Text);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Dell\Downloads\Consulta_Movimiento.pdf", FileMode.Create));
            dt = dtMove();
            if (dt.Rows.Count > 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


                PdfPTable table = new PdfPTable(dt.Columns.Count);
                document.Add(new Paragraph(20, "Reporte Movimientos", fontTitle));
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
