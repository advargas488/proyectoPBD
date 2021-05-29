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
    public partial class Form1 : Form
    {
        Controlador.controladorMovimientos controladorMovimientos = new Controlador.controladorMovimientos();
        public Form1(string codigo)
        {
            InitializeComponent();
            success.Hide();
            error.Hide();
            codigoM.Text = codigo;
            codigoM.ReadOnly = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (codigoM.Text != "")
            {
                if(controladorMovimientos.UpdateMove(codigoM.Text, nombre.Text, descripcion.Text, tipo.Text))
                {
                    success.Show();
                }
                else
                {
                    success.Hide();
                    error.Show();
                }
            }
            else
            {
                error.Show();
                success.Hide();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
