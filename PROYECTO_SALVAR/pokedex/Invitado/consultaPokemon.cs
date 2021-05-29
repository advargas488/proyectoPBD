using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Windows;
using System.IO;

namespace pokedex.Invitado
{
    public partial class consultaPokemon : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        Controlador.controladorPokemon controladorPokemon = new Controlador.controladorPokemon();
        public consultaPokemon()
        {
            InitializeComponent();
        }

        private void consultaPokemon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorPokemon.GetList();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = controladorPokemon.GetPokemonByType(textBox1.Text);
            }
        }

        private DataTable dtPokemon()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Pokemon WHERE Tipo1 = @tipo OR Tipo2 = @tipo";
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@tipo", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        public void pdfBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Dell\Downloads\Consulta_Pokemon.pdf", FileMode.Create));
            dt = dtPokemon();
            if (dt.Rows.Count > 0)
            {
                document.Open();
                Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
                Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


                PdfPTable table = new PdfPTable(dt.Columns.Count);
                document.Add(new Paragraph(20, "Reporte Pokemon", fontTitle));
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

        private void back_Click(object sender, EventArgs e)
        {
            menuInvitado menuInvitado = new menuInvitado();
            ActiveForm.Hide();
            menuInvitado.Show();
        }
    }
}

