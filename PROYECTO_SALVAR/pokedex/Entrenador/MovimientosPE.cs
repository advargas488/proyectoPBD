using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.Entrenador
{
    public partial class MovimientosPE : Form
    {
        Controlador.controladorMovimientos controladorMovimientos = new Controlador.controladorMovimientos();
        int id_P;
        string id_E;
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        public MovimientosPE(int idp, string ide)
        {
            InitializeComponent();
            id_E = ide;
            id_P = idp;
            errorNP.Hide();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string query = "EXECUTE dbo.Movimientos_Pokemon_Entrenador @nombre,@idp,@idm,0";
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", id_E);
            command.Parameters.AddWithValue("@idp",id_P);
            command.Parameters.AddWithValue("@idm", idM.Text);
            command.ExecuteNonQuery();

            conexion.Close();
            dataGridView1.DataSource = controladorMovimientos.GetMoveById(id_P);

            if(dataGridView1.Rows.Count == 4)
            {
                errorNP.Show();
            }

        }

        private void MovimientosPE_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorMovimientos.GetMoveById(id_P);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Hide();
            
        }
    }
}
