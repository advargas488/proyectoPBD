using System;
using System.Windows.Forms;

namespace pokedex
{
    public partial class addPokemon : Form
    {
        Controlador.controladorPokemon controladorAddPokemon = new Controlador.controladorPokemon();
        public addPokemon()
        {
            InitializeComponent();
            labelErrorLegen.Hide();
            error.Hide();
            errorId.Hide();
        }

        private void agregarPokemon_Click(object sender, EventArgs e)
        {
            if (indentificador.Text != "" && name.Text != "" && total.Text != "" &&
                salud.Text != "" && ataque.Text != "" && defensa.Text != "" && espAtaque.Text != "" && espDefensa.Text != "" &&
                velocidad.Text != "" && generacion.Text != "" && legendario.Text != "")//revisa que se ingresen los datos necesarios
            {
                error.Hide();
                if (legendario.Text == "No" || legendario.Text == "Si")
                {
                    labelErrorLegen.Hide();
                    if (controladorAddPokemon.agregarPokemon(Int32.Parse(indentificador.Text), name.Text, type1.Text, type2.Text, Int32.Parse(total.Text),
                    Int32.Parse(salud.Text), Int32.Parse(ataque.Text), Int32.Parse(defensa.Text), Int32.Parse(espAtaque.Text), Int32.Parse(espDefensa.Text),
                    Int32.Parse(velocidad.Text), Int32.Parse(generacion.Text), legendario.Text))//se llama al controlador para que gestione los datos
                    {
                        errorId.Hide();
                        name.ResetText();
                        indentificador.ResetText();
                        type1.ResetText();
                        type2.ResetText();
                        total.ResetText();
                        salud.ResetText();
                        ataque.ResetText();
                        defensa.ResetText();
                        espAtaque.ResetText();
                        espDefensa.ResetText();
                        velocidad.ResetText();
                        generacion.ResetText();
                        legendario.ResetText();
                    }
                    else
                    {
                        errorId.Show();
                    }
                }
                else
                {
                    labelErrorLegen.Show();
                }
            }
            else
            {
                error.Show();
            }
        }

        private void addPokemon_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }
    }
}
