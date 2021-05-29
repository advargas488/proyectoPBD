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
    public partial class UsuariosAdmin : Form
    {
        Controlador.controladorUsuarios controladorUsuarios = new Controlador.controladorUsuarios();
        public UsuariosAdmin()
        {
            InitializeComponent();
            
        }

        private void UsuariosAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorUsuarios.GetList();

            DataGridViewButtonColumn update = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(update);
            update.Text = "Editar";
            update.Name = "Acciones";
            update.UseColumnTextForButtonValue = true;
            
        }
        private void btn_update(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                string nombre = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre_Usuario"].Value);
                AdministradorUsuario.ActualizarUsuario actualizarUsuario = new AdministradorUsuario.ActualizarUsuario(nombre);
                actualizarUsuario.Show();
            }
            dataGridView1.DataSource = controladorUsuarios.GetList();
        }
        private void update_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuAdmin menuAdmin = new menuAdmin();
            ActiveForm.Hide();
            menuAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdministradorUsuario.RegistroUsuario registroUsuario = new AdministradorUsuario.RegistroUsuario();
            registroUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controladorUsuarios.EliminarUsuario(XUsername.Text))
            {
                dataGridView1.DataSource = controladorUsuarios.GetList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorUsuarios.GetList();
        }
    }
}
