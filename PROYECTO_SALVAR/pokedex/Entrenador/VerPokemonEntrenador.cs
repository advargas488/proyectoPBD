using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.Entrenador
{
    public partial class VerPokemonEntrenador : Form
    {
        Controlador.controladorEntrenadorPokemon controladorEntrenadorPokemon = new Controlador.controladorEntrenadorPokemon();
        string user_ID;
        public VerPokemonEntrenador(string user)
        {
            InitializeComponent();
            user_ID = user;
        }

        private void VerPokemonEntrenador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEntrenadorPokemon.GetList(user_ID);
            DataGridViewButtonColumn ver = new DataGridViewButtonColumn();
            ver.Name = "Ver pokemon";
            ver.Text = "Ver pokemon";
            dataGridView1.Columns.Add(ver);
            ver.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idP = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            ViewPokemonByID viewPokemonByID = new ViewPokemonByID(idP);
            viewPokemonByID.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuEntrenador menuEntrenador = new menuEntrenador(user_ID);
            ActiveForm.Hide();
            menuEntrenador.Show();
        }
    }
}
