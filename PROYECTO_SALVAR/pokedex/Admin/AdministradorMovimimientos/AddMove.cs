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
    public partial class AddMove : Form
    {
        Controlador.controladorMovimientos controladorMovimientos = new Controlador.controladorMovimientos();
        private bool TieneChar(string str)
        {
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < str.Length; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (Char.IsLetter(str, i))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public AddMove()
        {
            InitializeComponent();
            error.Hide();
            success.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if(codigo.Text != "" && nombre.Text != "")
            {
                if(idpokemon.Text == "")
                {
                    idpokemon.Text = "0";
                }
                if(TieneChar(idpokemon.Text))
                {
                    error.Show();
                }
                else if(controladorMovimientos.AddMovement(codigo.Text,nombre.Text,descripcion.Text, tipo.Text, Int32.Parse(idpokemon.Text))){
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
                    error.Show();
                    success.Hide();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }
    }
}
