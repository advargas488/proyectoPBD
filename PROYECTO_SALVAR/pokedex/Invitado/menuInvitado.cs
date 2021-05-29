using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.Invitado
{
    public partial class menuInvitado : Form
    {
        public menuInvitado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaPokemon consultaPokemon = new consultaPokemon();
            ActiveForm.Hide();
            consultaPokemon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultaMovimiento consultaMovimiento = new consultaMovimiento();
            ActiveForm.Hide();
            consultaMovimiento.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultaEntrenador consultaEntrenador = new consultaEntrenador();
            ActiveForm.Hide();
            consultaEntrenador.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicioSesion inicioSesion = new inicioSesion();
            ActiveForm.Hide();
            inicioSesion.Show();
        }
    }
}
