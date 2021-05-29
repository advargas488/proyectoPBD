using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Controlador
{
    public class controladorEntrenadores
    {
        
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-B1IPIRT\\SERVIDORSQL ; database=pokedexF ; integrated security = true");
        public IEnumerable<Modelos.trainerViewModel> GetList()
        {
            
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                Modelos.EF.test1Entities Ogdb = new Modelos.EF.test1Entities();
                
                IEnumerable<Modelos.trainerViewModel> lst = (from d in db.Entrenadors
                                                             select new Modelos.trainerViewModel()
                                                             {

                                                                 Identificador_E = d.Identificador_E,
                                                                 Nombre_E = d.Nombre_E,
                                                                 Apellido1 = d.Apellido1,
                                                                 Apellido2 = d.Apellido2,
                                                                 Núm_Teléfono = d.Núm_Teléfono,
                                                                 Provincia = d.Provincia,
                                                                 Cantón = d.Cantón,
                                                                 Distrito = d.Distrito,
                                                                 Otras_señas = d.Otras_señas,
                                                                 Correo_Electrónico = d.Correo_Electrónico,
                                                                 Ubicación = d.Ubicación,
                                                                 Sitio_Web = d.Sitio_Web,
                                                                 Nombre_Usuario = d.Nombre_Usuario,    
                                                             }).ToList();
                return lst;
            }
        }

        public bool ActualizarEntrenador(string nombre, string apellido1, string apellido2, int telefono,
                    string provincia, string canton, string distrito, string correo, string identificador, string otras, string web, string lat, string lng,
                    string facebook, string instagram, string twitter)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Entrenadors.Find(identificador) == null)
                {
                    return false;
                }
                if (nombre != "")
                {
                    db.Entrenadors.Find(identificador).Nombre_E = nombre;
                }
                if(apellido1 != "")
                {
                    db.Entrenadors.Find(identificador).Apellido1 = apellido1;
                }
                if (apellido2 != "")
                {
                    db.Entrenadors.Find(identificador).Apellido2 = apellido2;
                }
                if (telefono != 0)
                {
                    db.Entrenadors.Find(identificador).Núm_Teléfono = telefono;
                }
                if (provincia != "")
                {
                    db.Entrenadors.Find(identificador).Provincia = provincia;
                }
                if (canton != "")
                {
                    db.Entrenadors.Find(identificador).Cantón = canton;
                }
                if (distrito != "")
                {
                    db.Entrenadors.Find(identificador).Distrito = distrito;
                }
                if (correo != "")
                {
                    db.Entrenadors.Find(identificador).Correo_Electrónico = correo;
                }
                if (otras != "")
                {
                    db.Entrenadors.Find(identificador).Otras_señas = otras;
                }
                if (web != "")
                {
                    db.Entrenadors.Find(identificador).Sitio_Web = web;
                }
                if (lat != "" && lng != "")
                {
                    db.Entrenadors.Find(identificador).Ubicación = lat + " " + lng;
                }
                
                if (facebook != "")
                {
                    string query = "UPDATE Redes_Sociales_E SET Red_Social = @red WHERE[Identificador_E] = @id AND[Nombre_RS] = 'Facebook'";
                    conexion.Open();
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@red", facebook);
                    command.Parameters.AddWithValue("@id", identificador);
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
                if (instagram != "")
                {
                    string query = "UPDATE Redes_Sociales_E SET Red_Social = @red WHERE[Identificador_E] = @id AND[Nombre_RS] = 'Instagram'";
                    conexion.Open();
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@red", instagram);
                    command.Parameters.AddWithValue("@id", identificador);
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
                if (twitter != "")
                {
                    string query = "UPDATE Redes_Sociales_E SET Red_Social = @red WHERE[Identificador_E] = @id AND[Nombre_RS] = 'twitter'";
                    conexion.Open();
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@red", twitter);
                    command.Parameters.AddWithValue("@id", identificador);
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
                db.SaveChanges();
            }
            return true;
        }

        public bool DeleteEntrenador(string id)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Entrenadors.Find(id) != null)
                {
                    db.Usuarios.Remove(db.Usuarios.Find(db.Entrenadors.Find(id).Nombre_Usuario));
                    db.Entrenadors.Remove(db.Entrenadors.Find(id));
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public IEnumerable<Modelos.trainerViewModel> GetTrainerByFliters(string nombre, string ubicacion)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                
                    IEnumerable<Modelos.trainerViewModel> lst = (from d in db.Entrenadors
                                                                 where d.Nombre_E == nombre && d.Ubicación == ubicacion
                                                                 select new Modelos.trainerViewModel()
                                                                 {
                                                                     Identificador_E = d.Identificador_E,
                                                                     Nombre_E = d.Nombre_E,
                                                                     Apellido1 = d.Apellido1,
                                                                     Apellido2 = d.Apellido2,
                                                                     Núm_Teléfono = d.Núm_Teléfono,
                                                                     Provincia = d.Provincia,
                                                                     Cantón = d.Cantón,
                                                                     Distrito = d.Distrito,
                                                                     Otras_señas = d.Otras_señas,
                                                                     Correo_Electrónico = d.Correo_Electrónico,
                                                                     Ubicación = d.Ubicación,
                                                                     Sitio_Web = d.Sitio_Web,
                                                                     Nombre_Usuario = d.Nombre_Usuario,
                                                                 }).ToList();
                    return lst;
            }
                
                
        }

        public IEnumerable<Modelos.trainerViewModel> GetTrainersByName(string name)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.trainerViewModel> lst = (from d in db.Entrenadors
                                                                where d.Nombre_E == name
                                                                select new Modelos.trainerViewModel()
                                                                {
                                                                    Identificador_E = d.Identificador_E,
                                                                    Nombre_E = d.Nombre_E,
                                                                    Apellido1 = d.Apellido1,
                                                                    Apellido2 = d.Apellido2,
                                                                    Núm_Teléfono = d.Núm_Teléfono,
                                                                    Provincia = d.Provincia,
                                                                    Cantón = d.Cantón,
                                                                    Distrito = d.Distrito,
                                                                    Otras_señas = d.Otras_señas,
                                                                    Correo_Electrónico = d.Correo_Electrónico,
                                                                    Ubicación = d.Ubicación,
                                                                    Sitio_Web = d.Sitio_Web,
                                                                    Nombre_Usuario = d.Nombre_Usuario,
                                                                }).ToList();
                return lst;
            }
        }
        public IEnumerable<Modelos.trainerViewModel> GetTrainersByLoc(string ubicacion)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.trainerViewModel> lst = (from d in db.Entrenadors
                                                             where d.Ubicación == ubicacion
                                                             select new Modelos.trainerViewModel()
                                                             {
                                                                 Identificador_E = d.Identificador_E,
                                                                 Nombre_E = d.Nombre_E,
                                                                 Apellido1 = d.Apellido1,
                                                                 Apellido2 = d.Apellido2,
                                                                 Núm_Teléfono = d.Núm_Teléfono,
                                                                 Provincia = d.Provincia,
                                                                 Cantón = d.Cantón,
                                                                 Distrito = d.Distrito,
                                                                 Otras_señas = d.Otras_señas,
                                                                 Correo_Electrónico = d.Correo_Electrónico,
                                                                 Ubicación = d.Ubicación,
                                                                 Sitio_Web = d.Sitio_Web,
                                                                 Nombre_Usuario = d.Nombre_Usuario,
                                                             }).ToList();
                return lst;
            }
        }
        public IEnumerable<Modelos.bitacoraViewModel> GetTrainerBitacoras(string user)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.bitacoraViewModel> lst = (from d in db.Bitácora
                                                              where d.Entrenador.Nombre_Usuario == user
                                                              select new Modelos.bitacoraViewModel()
                                                              {
                                                                  Descripción = d.Descripción,
                                                                  Fecha = d.Fecha,
                                                                  Identificador_Entrenador = d.Identificador_E

                                                              }).ToList();
                return lst;
            }
        }
    }
}

