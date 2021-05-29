using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class controladorEntrenadorPokemon
    {
        public IEnumerable<Modelos.EntrenadorPokemonViewModel> GetList(string userID)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.EntrenadorPokemonViewModel> lst = (from d in db.Entrenador_Pokemon where d.Entrenador.Nombre_Usuario.Equals(userID)
                                                                       select new Modelos.EntrenadorPokemonViewModel()
                                                                       {
                                                                           Estado = d.Estado,
                                                                           id = d.Identificador_P
                                                                           
                                                                       }).ToList();
                return lst;
                                                                       
            }
        }
    }
}
