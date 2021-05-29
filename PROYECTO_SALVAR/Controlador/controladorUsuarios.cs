using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class controladorUsuarios
    {
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public String getUser(string name, string password) {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())//inicio de sesion
            {


                if (db.Usuarios.Find(name) != null && db.Usuarios.Find(name).Contraseña == GetSHA256(password))
                {//si encuentra al usuario y su contrasena esta bien retorna true
                    return db.Usuarios.Find(name).Rol;
                }
                else
                {
                    string f = GetSHA256(password);
                    return "error";
                }
            }
        }
        public void RegistroCliente(string name, string password, string rol, string nombre, string apellido1, string apellido2, int telefono,
                    string provincia, string canton, string distrito, string correo, int cedula, string otras,string ubicacion)
        {
            Modelos.EF.Usuario nu = new Modelos.EF.Usuario();//se crea un nuevo usuario con los datos adquiridos
            nu.Contraseña = GetSHA256(password);
            nu.Nombre_Usuario = name;
            nu.Rol = rol;

            Modelos.EF.Cliente nc = new Modelos.EF.Cliente();//se crea un nuevo cliente con los datos adquiridos
            nc.Apellido1 = apellido1;
            nc.Apellido2 = apellido2;
            nc.Cantón = canton;
            nc.Correo_Electrónico = correo;
            nc.Distrito = distrito;
            nc.Nombre_C = nombre;
            nc.Nombre_Usuario = name;
            nc.Núm_Cédula_C = cedula;
            nc.Núm_Teléfono = telefono;
            nc.Otras_señas = otras;
            nc.Provincia = provincia;
            nc.Ubicación = ubicacion;

            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())//se modifica la base de datos
            {
                db.Usuarios.Add(nu);
                db.SaveChanges();

                db.Clientes.Add(nc);
                db.SaveChanges();
            }
        }
        public bool RegistroEntrenador(string name, string password, string rol, string nombre, string apellido1, string apellido2, int telefono,
                    string provincia, string canton, string distrito, string correo, string identificador, string otras, string web, string lat, string lng,
                    string facebook, string instagram, string twitter)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())//se modifica la base de datos
            {
                Modelos.EF.Usuario nu = new Modelos.EF.Usuario();//se crea un nuevo usuario con los datos adquirido
                nu.Contraseña = GetSHA256(password);
                if(db.Usuarios.Find(name) == null)
                {
                    nu.Nombre_Usuario = name;
                }
                else
                {
                    return false;
                }
                
                nu.Rol = rol;
                db.Usuarios.Add(nu);
                db.SaveChanges();

                Modelos.EF.Entrenador nc = new Modelos.EF.Entrenador();//se crea un nuevo cliente con los datos adquiridos
                nc.Apellido1 = apellido1;
                nc.Apellido2 = apellido2;
                nc.Cantón = canton;
                nc.Correo_Electrónico = correo;
                nc.Distrito = distrito;
                nc.Nombre_E = nombre;
                nc.Nombre_Usuario = name;
                if(db.Entrenadors.Find(identificador) == null)
                {
                    nc.Identificador_E = identificador;
                }
                else
                {
                    return false;
                }
                nc.Núm_Teléfono = telefono;
                nc.Otras_señas = otras;
                nc.Provincia = provincia;
                nc.Ubicación = lat + " " + lng;
                nc.Sitio_Web = web;

                if (facebook != "")
                {
                    Modelos.EF.Redes_Sociales_E nrs = new Modelos.EF.Redes_Sociales_E();
                    nrs.Identificador_E = identificador;
                    nrs.Nombre_Usuario = name;
                    nrs.Red_Social = facebook;
                    nrs.Nombre_RS = "Facebook";
                    nc.Redes_Sociales_E.Add(nrs);
                    db.Redes_Sociales_E.Add(nrs);
                }
                if (instagram != "")
                {
                    Modelos.EF.Redes_Sociales_E nrs = new Modelos.EF.Redes_Sociales_E();
                    nrs.Identificador_E = identificador;
                    nrs.Nombre_Usuario = name;
                    nrs.Red_Social = instagram;
                    nrs.Nombre_RS = "Instagram";
                    nc.Redes_Sociales_E.Add(nrs);
                    db.Redes_Sociales_E.Add(nrs);
                }
                if (twitter != "")
                {
                    Modelos.EF.Redes_Sociales_E nrs = new Modelos.EF.Redes_Sociales_E();
                    nrs.Identificador_E = identificador;
                    nrs.Nombre_Usuario = name;
                    nrs.Red_Social = twitter;
                    nrs.Nombre_RS = "twitter";
                    nc.Redes_Sociales_E.Add(nrs);
                    db.Redes_Sociales_E.Add(nrs);
                }

                    db.Entrenadors.Add(nc);
                    db.SaveChanges();
            }
            return true;
        }

        public IEnumerable<Modelos.userViewModel> GetList()
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.userViewModel> lst = (from d in db.Usuarios
                                                          select new Modelos.userViewModel
                                                          {
                                                              Contraseña = d.Contraseña,
                                                              Nombre_Usuario = d.Nombre_Usuario,
                                                              Rol = d.Rol
                                                          }).ToList();
                return lst;
            }
        }

        public bool NuevoUsuario(string name, string password, string rol)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                Modelos.EF.Usuario nu = new Modelos.EF.Usuario();
                if (db.Usuarios.Find(name) == null)
                {
                    nu.Nombre_Usuario = name;
                    nu.Contraseña = GetSHA256(password);
                    nu.Rol = rol;
                    db.Usuarios.Add(nu);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void UpdateUsuario(string username, string password, string rol)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
               
                if (password != "")
                {
                    db.Usuarios.Find(username).Contraseña = GetSHA256(password);
                }
                if (rol != "")
                {
                    db.Usuarios.Find(username).Rol = rol;
                }
                
                db.SaveChanges();
            }
        }

        public bool EliminarUsuario(string username)
        {
            using (Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if(db.Usuarios.Find(username)== null)
                {
                    return false;
                }
                else
                {
                    db.Usuarios.Remove(db.Usuarios.Find(username));
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public bool RegistroUsuario(string nombre_u, string password, string rol)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Usuarios.Find(nombre_u) != null)
                {
                    return false;
                }
                else
                {
                    Modelos.EF.Usuario nu = new Modelos.EF.Usuario();
                    nu.Nombre_Usuario = nombre_u;
                    nu.Contraseña = GetSHA256(password);
                    nu.Rol = rol;
                    db.Usuarios.Add(nu);
                    db.SaveChanges();
                    return true;
                }
            }
        }
    }
}
