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
    public partial class Bitacoras : Form
    {
        Controlador.controladorEntrenadores controladorEntrenadores = new Controlador.controladorEntrenadores();
        string x;
        public Bitacoras(string user)
        {
            InitializeComponent();
            x = user;
        }

        private void crear_Click(object sender, EventArgs e)
        {
            CreadorBitacoras creadorBitacoras = new CreadorBitacoras(x);
            creadorBitacoras.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuEntrenador menuEntrenador = new menuEntrenador(x);
            ActiveForm.Hide();
            menuEntrenador.Show();
        }

        private void Bitacoras_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEntrenadores.GetTrainerBitacoras(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEntrenadores.GetTrainerBitacoras(x);
        }
    }
}
