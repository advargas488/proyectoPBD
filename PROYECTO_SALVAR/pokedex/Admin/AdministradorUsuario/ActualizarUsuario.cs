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
    public partial class ActualizarUsuario : Form
    {
        Controlador.controladorUsuarios controladorUsuarios = new Controlador.controladorUsuarios();
        public ActualizarUsuario(string user)
        {
            InitializeComponent();
            usuario.Text = user;
            usuario.ReadOnly = true;
            success.Hide();
            rol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            controladorUsuarios.UpdateUsuario(usuario.Text, password.Text, rol.Text);
            success.Show();            
        }
    }
}
