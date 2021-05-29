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
    public partial class ViewPokemonByID : Form
    {
        Controlador.controladorPokemon controladorPokemon = new Controlador.controladorPokemon();
        int idp;
        public ViewPokemonByID(int id)
        {
            InitializeComponent();
            idp = id;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }

        private void ViewPokemonByID_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorPokemon.GetPokemonById(idp);
        }
    }
}
