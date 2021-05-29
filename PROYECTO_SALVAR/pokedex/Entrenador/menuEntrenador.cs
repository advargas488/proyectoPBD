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
    public partial class menuEntrenador : Form
    {
        Controlador.controladorEntrenadores controladorEntrenadores = new Controlador.controladorEntrenadores();
        string x;
        public menuEntrenador(string userE)
        {
            InitializeComponent();
            x = userE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrenador.EntrenadorPokemon entrenadorPokemon = new EntrenadorPokemon(x);
            ActiveForm.Hide();
            entrenadorPokemon.Show();
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            Bitacoras bitacoras = new Bitacoras(x);
            ActiveForm.Hide();
            bitacoras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPokemonEntrenador verPokemonsEntreandor = new VerPokemonEntrenador(x);
            ActiveForm.Hide();
            verPokemonsEntreandor.Show();
        }

        private void RegUser_Click(object sender, EventArgs e)
        {
            RegUserE regUser = new RegUserE(x);
            ActiveForm.Hide();
            regUser.Show();
        }

        private void end_Click(object sender, EventArgs e)
        {
            inicioSesion inicioSesion = new inicioSesion();
            ActiveForm.Hide();
            inicioSesion.Show();
        }
    }
}
