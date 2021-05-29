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
    public partial class MovAdmin : Form
    {
        Controlador.controladorMovimientos controladorMovimientos = new Controlador.controladorMovimientos();
        public MovAdmin()
        {
            InitializeComponent();
            errorName.Hide();
            
        }

        private void MovAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorMovimientos.GetMovements();
            DataGridViewButtonColumn update = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(update);
            update.Text = "Editar";
            update.Name = "Acciones";
            update.UseColumnTextForButtonValue = true;
        }

        private void addMoveBtn_Click(object sender, EventArgs e)
        {
            AddMove addMove = new AddMove();
           
            addMove.Show();
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorMovimientos.GetMovements();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            menuAdmin menuAdmin = new menuAdmin();
            ActiveForm.Hide();
            menuAdmin.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(Xid.Text!= "")
            {
                if (controladorMovimientos.DeleteMove(Xid.Text))
                {
                    dataGridView1.DataSource = controladorMovimientos.GetMovements();
                    errorName.Hide();
                }
                else
                {
                    errorName.Show();
                }
            }
        }

        private void update(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                string codigo = Convert.ToString(dataGridView1.CurrentRow.Cells["Código_M"].Value);
                Form1 Actualizar = new Form1(codigo);

               Actualizar.Show();
            }
        }
    }
}
