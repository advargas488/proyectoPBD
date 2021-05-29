using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex.Entrenador
{
    public partial class CreadorBitacoras : Form
    {
        string x;
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        public CreadorBitacoras(string user)
        {
            InitializeComponent();
            x = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string theDate = date.Value.ToString("dd-MM-yyyy");
            DateTime dt = DateTime.ParseExact(theDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string query = "EXECUTE Add_bitacora @nombre,@fecha,@desc,0";
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", x);
            command.Parameters.AddWithValue("@fecha", dt);
            command.Parameters.AddWithValue("@desc", textBox1.Text);
            command.ExecuteNonQuery();

            conexion.Close();
            
        }
    }
}
