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
    public partial class Entrenadores : Form
    {
        Controlador.controladorEntrenadores controlador = new Controlador.controladorEntrenadores(); 
        public Entrenadores()
        {
            InitializeComponent();
            errorDelete.Hide();
            successDelete.Hide();
        }

        private void Entrenadores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlador.GetList();

            DataGridViewButtonColumn update = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(update);
            update.Text = "Editar";
            update.Name = "Acciones";
            update.UseColumnTextForButtonValue = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registroEntrenador registroEntrenador = new registroEntrenador();
            registroEntrenador.Show();
        }

        

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuAdmin menuAdmin = new menuAdmin();
            ActiveForm.Close();
            menuAdmin.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlador.GetList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(Xid.Text != "")
            {
                if (controlador.DeleteEntrenador(Xid.Text))
                {
                    successDelete.Show();
                    errorDelete.Hide();
                    dataGridView1.DataSource = controlador.GetList();
                }
                else
                {
                    successDelete.Hide();
                    errorDelete.Show();
                }
            }
        }

        private void updateEntrenador(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                string id = Convert.ToString(dataGridView1.CurrentRow.Cells["Identificador_E"].Value);
                ActualizarEntrenador actualizarEntrenador = new ActualizarEntrenador(id);
                actualizarEntrenador.Show();
            }
        }
    }
}
