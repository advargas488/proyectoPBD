using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class pokemonViewModel
    {   
        public int Identificador_P { get; set; }
        public string Nombre_P { get; set; }
        public string Tipo1 { get; set; }
        public string Tipo2 { get; set; }
        public int Total { get; set; }
        public int Salud { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Ataque_Especial { get; set; }
        public int Defensa_Especial { get; set; }
        public int Velocidad { get; set; }
        public int Generación { get; set; }
        public string Legendario { get; set; }
    }
}
