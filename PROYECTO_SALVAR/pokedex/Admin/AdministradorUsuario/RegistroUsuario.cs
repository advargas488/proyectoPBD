using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.AdministradorUsuario
{
    public partial class RegistroUsuario : Form
    {
        Controlador.controladorUsuarios controladorUsuarios = new Controlador.controladorUsuarios();
        public RegistroUsuario()
        {
            InitializeComponent();
            errorUser.Hide();
            success.Hide();
            errorDatos.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(usuario.Text != "" && password.Text != "" && rol.Text != "")
            {
                if (controladorUsuarios.NuevoUsuario(usuario.Text, password.Text, rol.Text))
                {
                    foreach(Control c in Controls)
                    {
                        if(c is TextBox)
                        {
                            c.ResetText();
                        }
                    }
                    success.Show();
                    errorDatos.Hide();
                    errorUser.Hide();
                }
                else
                {
                    errorUser.Show();
                    success.Hide();
                    errorDatos.Hide();
                }
            }
            else
            {
                errorUser.Hide();
                success.Hide();
                errorDatos.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Hide();
           
        }
    }
}
