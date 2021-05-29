using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.Entrenador
{
    public partial class EntrenadorPokemon : Form
    {
        Controlador.controladorEntrenadorPokemon controladorEntrenadorPokemon = new Controlador.controladorEntrenadorPokemon();
        string x;
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        public EntrenadorPokemon(string userE)
        {
            InitializeComponent();
            x = userE;
            userEntrenador.Text = x;
            userEntrenador.ReadOnly = true;
            error.Hide();
            errorPokemon.Hide();
        }
        private void agregar_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow d in dataGridView1.Rows)
            {
                Console.WriteLine(d.Cells["Estado"].Value.ToString());
                if(d.Cells["Estado"].Value.ToString() == "En equipo")
                {
                    i = i+1;
                }
            }
            if(estado.Text=="En equipo" && i >= 6)
            {
                error.Show();
            }else if(idp.Text == "")
            {
                errorPokemon.Show();
            }
            else
            {
                error.Hide();
                string query = "EXECUTE dbo.Insertar_Relacion_Entrenador_Pokemon @nombre, @idp , @estado ,0";
                conexion.Open();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", x);
                command.Parameters.AddWithValue("@idp", Int32.Parse(idp.Text));
                command.Parameters.AddWithValue("@estado", estado.Text);
                command.ExecuteNonQuery();

                conexion.Close();
                dataGridView1.DataSource = controladorEntrenadorPokemon.GetList(x);
            }

        }

        private void EntrenadorPokemon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEntrenadorPokemon.GetList(userEntrenador.Text);
            DataGridViewButtonColumn AddMove = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(AddMove);
            AddMove.Text = "Movimientos";
            AddMove.Name = "Movimientos";
            AddMove.UseColumnTextForButtonValue = true;

            dataGridView1.DataSource = controladorEntrenadorPokemon.GetList(x);
        }

        private void back_Click(object sender, EventArgs e)
        {
            menuEntrenador menuEntrenador = new menuEntrenador(x);
            ActiveForm.Hide();
            menuEntrenador.Show();
        }

        private void userEntrenador_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int valorId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            MovimientosPE movimientosPE = new MovimientosPE(valorId, x);
            movimientosPE.Show();
        }
    }
}
