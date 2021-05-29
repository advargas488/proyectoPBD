using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class controladorPokemon
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        public bool BuscarNombre(string name)
        {
            Modelos.EF.test1Entities db = new Modelos.EF.test1Entities();
            foreach(Modelos.EF.Pokemon pokemon in db.Pokemons)
            {
                if(pokemon.Nombre_P == name)
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
        public bool agregarPokemon(int id, string nombre, string tipo1, string tipo2, int total, int salud, int ataque, int defensa, int ataque_especial, int defensa_especial, int velocidad, int generacion, string legendario)
        {
            Modelos.EF.Pokemon np = new Modelos.EF.Pokemon();
            np.Ataque = ataque;
            np.Ataque_Especial = ataque_especial;
            np.Defensa = defensa;
            np.Defensa_Especial = defensa_especial;
            np.Generación = generacion;
            np.Identificador_P = id;
            np.Legendario = legendario;
            np.Nombre_P = nombre;
            np.Tipo1 = tipo1;
            np.Tipo2 = tipo2;
            np.Total = total;
            np.Velocidad = velocidad;
            np.Salud = salud;

            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Pokemons.Find(id) != null)
                {
                    return false;
                }
                else if (BuscarNombre(nombre))
                {
                    return false;
                }
                else
                {
                    db.Pokemons.Add(np);
                    db.SaveChanges();
                    return true;
                }
                
            }
        }
        public IEnumerable<Modelos.pokemonViewModel> GetList()
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.pokemonViewModel> lst = (from d in db.Pokemons
                                                             select new Modelos.pokemonViewModel
                                                             {
                                                                 Ataque = d.Ataque,
                                                                 Defensa = d.Defensa,
                                                                 Nombre_P = d.Nombre_P,
                                                                 Identificador_P = d.Identificador_P,
                                                                 Ataque_Especial = d.Ataque_Especial,
                                                                 Defensa_Especial = d.Defensa_Especial,
                                                                 Generación = d.Generación,
                                                                 Legendario = d.Legendario,
                                                                 Tipo1 = d.Tipo1,
                                                                 Tipo2 = d.Tipo2,
                                                                 Total = d.Total,
                                                                 Salud = d.Salud
                                                             }).ToList();
                return lst;
            }
            
        }
        public bool actualizar(int id, string nombre, string tipo1, string tipo2, int total, int salud, int ataque, int defensa
                              , int ataque_especial, int defensa_especial, int velocidad, int generacion, string legendario)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (ataque != 0)
                {
                    db.Pokemons.Find(id).Ataque = ataque;
                }
                if (nombre != "" && BuscarNombre(nombre)==false)
                {
                    db.Pokemons.Find(id).Nombre_P = nombre;
                }
                else
                {
                    return false;
                }
                if (tipo1 != "")
                {
                    db.Pokemons.Find(id).Tipo1 = tipo1;
                }
                if (tipo2 != "")
                {
                    db.Pokemons.Find(id).Tipo2 = tipo2;
                }
                if (total != 0)
                {
                    db.Pokemons.Find(id).Total = total;
                }
                if (salud != 0)
                {
                    db.Pokemons.Find(id).Salud = salud;
                }
                if (ataque != 0)
                {
                    db.Pokemons.Find(id).Ataque = ataque;
                }
                if (defensa != 0)
                {
                    db.Pokemons.Find(id).Defensa = defensa;
                }
                if (ataque_especial != 0)
                {
                    db.Pokemons.Find(id).Ataque_Especial = ataque_especial;
                }
                if (defensa_especial != 0)
                {
                    db.Pokemons.Find(id).Defensa_Especial = defensa_especial;
                }
                if (velocidad != 0)
                {
                    db.Pokemons.Find(id).Velocidad = velocidad;
                }
                if (generacion != 0)
                {
                    db.Pokemons.Find(id).Generación = generacion;
                }
                if (legendario != "")
                {
                    db.Pokemons.Find(id).Legendario = legendario;
                }
                db.SaveChanges();
                return true;
            }
        }

        public bool DeletePokemon(int id)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Pokemons.Find(id) != null)
                {
                    db.Pokemons.Remove(db.Pokemons.Find(id));
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public IEnumerable<Modelos.ShowPokemonUserViewModel> GetPokemonByUser(string user)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {

                string query = "SELECT Identificador_E FROM Entrenador WHERE Nombre_Usuario = @nombre";
                conexion.Open();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nombre", user);

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string idUser = reader["Identificador_E"].ToString();
                conexion.Close();

                Modelos.EF.test1Entities pokemon = new Modelos.EF.test1Entities();
                IEnumerable<Modelos.ShowPokemonUserViewModel> lst = (from d in db.Entrenador_Pokemon
                                                                     where d.Identificador_E == idUser 
                                                                     select new Modelos.ShowPokemonUserViewModel
                                                                     {
                                                                         Identificador_P = d.Identificador_P,
                                                                         Nombre_P = d.Pokemon.Nombre_P
                                                                     }).ToList();
                return lst;
            }
        }
        public IEnumerable<Modelos.pokemonViewModel> GetPokemonById(int id)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.pokemonViewModel> lst = (from d in db.Pokemons
                                                             where d.Identificador_P == id
                                                             select new Modelos.pokemonViewModel()
                                                             {
                                                                 Ataque = d.Ataque,
                                                                 Defensa = d.Defensa,
                                                                 Nombre_P = d.Nombre_P,
                                                                 Identificador_P = d.Identificador_P,
                                                                 Ataque_Especial = d.Ataque_Especial,
                                                                 Defensa_Especial = d.Defensa_Especial,
                                                                 Generación = d.Generación,
                                                                 Legendario = d.Legendario,
                                                                 Tipo1 = d.Tipo1,
                                                                 Tipo2 = d.Tipo2,
                                                                 Total = d.Total,
                                                                 Salud = d.Salud
                                                             }).ToList();
                return lst;
            }
        }

        public IEnumerable<Modelos.pokemonViewModel> GetPokemonByType(string tipo)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.pokemonViewModel> lst = (from d in db.Pokemons
                                                             where d.Tipo1 == tipo || d.Tipo2 == tipo
                                                             select new Modelos.pokemonViewModel()
                                                             {
                                                                 Ataque = d.Ataque,
                                                                 Defensa = d.Defensa,
                                                                 Nombre_P = d.Nombre_P,
                                                                 Identificador_P = d.Identificador_P,
                                                                 Ataque_Especial = d.Ataque_Especial,
                                                                 Defensa_Especial = d.Defensa_Especial,
                                                                 Generación = d.Generación,
                                                                 Legendario = d.Legendario,
                                                                 Tipo1 = d.Tipo1,
                                                                 Tipo2 = d.Tipo2,
                                                                 Total = d.Total,
                                                                 Salud = d.Salud
                                                             }).ToList();
                return lst;
            }
        }
    }
}
