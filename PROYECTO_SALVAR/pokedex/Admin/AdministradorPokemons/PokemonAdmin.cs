using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class pokeForm : Form
    {
        Controlador.controladorPokemon controladorAddPokemon = new Controlador.controladorPokemon();
        public pokeForm()
        {
            InitializeComponent();
            errorName.Hide();
        }

        private void Pokemon_Load(object sender, EventArgs e)
        {
            pokeData.DataSource = controladorAddPokemon.GetList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addPokemon addPokemon = new addPokemon();
            addPokemon.Show();
        }

        private void actualizarInfo_Click(object sender, EventArgs e)
        {
            pokeData.DataSource = controladorAddPokemon.GetList();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            menuAdmin menu = new menuAdmin();
            ActiveForm.Hide();
            menu.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ActualizarPokemon actualizarPokemon = new ActualizarPokemon();
            actualizarPokemon.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(XId.Text != "")
            {
                if (controladorAddPokemon.DeletePokemon(Int32.Parse(XId.Text)))
                {
                    errorName.Hide();
                    pokeData.DataSource = controladorAddPokemon.GetList();
                }
                else
                {
                    errorName.Show();
                }
            }
        }
    }
}
