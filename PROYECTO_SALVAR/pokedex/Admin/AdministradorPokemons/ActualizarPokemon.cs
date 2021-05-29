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
    public partial class ActualizarPokemon : Form
    {
        Controlador.controladorPokemon controlador = new Controlador.controladorPokemon();
        public ActualizarPokemon()
        {
            InitializeComponent();
            
            error.Hide();
            errorId.Hide();
            success.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            if(indentificador.Text ==""){
                error.Show();
                success.Hide();
            }
            else
            {
                if(controlador.actualizar(Int32.Parse(indentificador.Text), name.Text, type1.Text, type2.Text, Int32.Parse(total.Text), Int32.Parse(salud.Text),
                Int32.Parse(ataque.Text), Int32.Parse(defensa.Text), Int32.Parse(espAtaque.Text), Int32.Parse(espDefensa.Text), Int32.Parse(velocidad.Text),
                Int32.Parse(generacion.Text), legendario.Text))
                {
                    foreach(Control c in ActiveForm.Controls)
                    {
                        if(c is TextBox)
                        {
                            c.ResetText();
                        }
                    }
                }
                else
                {
                    errorId.Show();
                }
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }
    }
}
