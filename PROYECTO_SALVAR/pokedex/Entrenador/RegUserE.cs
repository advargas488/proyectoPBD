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
    public partial class RegUserE : Form
    {
        Controlador.controladorUsuarios controladorUsuarios = new Controlador.controladorUsuarios();
        string userE;
        public RegUserE(string user)
        {
            InitializeComponent();
            userE = user;
            success.Hide();
            errorDatos.Hide();
            errorName.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menuEntrenador menuEntrenador = new menuEntrenador(userE);
            ActiveForm.Hide();
            menuEntrenador.Show();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if(user.Text != "" && password.Text != "")
            {
                if (controladorUsuarios.RegistroUsuario(user.Text, password.Text, "Entrenador"))
                {
                    success.Show();
                    errorDatos.Hide();
                    errorName.Hide();
                }
                else
                {
                    success.Hide();
                    errorDatos.Hide();
                    errorName.Show();
                }
            }
            else
            {
                success.Hide();
                errorDatos.Show();
                errorName.Hide();
            }
        }
    }
}
