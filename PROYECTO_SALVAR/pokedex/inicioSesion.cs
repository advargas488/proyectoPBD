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
    public partial class inicioSesion : Form
    {
        Controlador.controladorUsuarios controladorInicio = new Controlador.controladorUsuarios();
        public inicioSesion()
        {
            InitializeComponent();
            error.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && password.Text != "")
            {
                if(controladorInicio.getUser(name.Text, password.Text)=="Administrador")
                {
                    menuAdmin menu = new menuAdmin();
                    ActiveForm.Hide();
                    menu.Show();
                }
                else if(controladorInicio.getUser(name.Text, password.Text) == "Entrenador")
                {
                    Entrenador.menuEntrenador menuEntrenador = new Entrenador.menuEntrenador(name.Text);
                    ActiveForm.Hide();
                    menuEntrenador.Show();
                }else if (controladorInicio.getUser(name.Text, password.Text) == "Invitado")
                {
                    Invitado.menuInvitado menuInvitado = new Invitado.menuInvitado();
                    ActiveForm.Hide();
                    menuInvitado.Show();
                }
                else
                {
                    error.Show();
                }
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            registroCliente registroCliente = new registroCliente();
            ActiveForm.Hide();
            registroCliente.Show();
        }
    }
}
