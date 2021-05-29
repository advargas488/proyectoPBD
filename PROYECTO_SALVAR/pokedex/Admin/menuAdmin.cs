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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void pokeAdd_Click(object sender, EventArgs e)
        {
            addPokemon addPokemon = new addPokemon();
            ActiveForm.Hide();
            addPokemon.Show();
        }

        private void pokeVerBtn_Click(object sender, EventArgs e)
        {
            pokeForm verPokemon = new pokeForm();
            ActiveForm.Hide();
            verPokemon.Show();
        }

        private void movBtn_Click(object sender, EventArgs e)
        {
            MovAdmin addMove = new MovAdmin();
            ActiveForm.Hide();
            addMove.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrenadores entrenadores = new Entrenadores();
            ActiveForm.Close();
            entrenadores.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuariosAdmin usuariosAdmin = new UsuariosAdmin();
            ActiveForm.Close();
            usuariosAdmin.Show();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            inicioSesion inicioSesion = new inicioSesion();
            
            ActiveForm.Close();
            inicioSesion.Show();

        }
    }
}
