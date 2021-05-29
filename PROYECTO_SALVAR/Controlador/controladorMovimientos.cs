using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class controladorMovimientos
    {
        public IEnumerable<Modelos.movementViewModel> GetMovements()
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.movementViewModel> lst = (from d in db.Movimientoes
                                                              select new Modelos.movementViewModel
                                                              {
                                                                  Código_M = d.Código_M,
                                                                  Nombre_M = d.Nombre_M,
                                                                  Descripción = d.Descripción,
                                                                  Tipo = d.Tipo
                                                              }).ToList();
                return lst;
            }
        }

        public bool AddMovement(string codigo, string nombre, string desc, string tipo, int idP)
        {
            Modelos.EF.Movimiento nm = new Modelos.EF.Movimiento();
            Modelos.EF.Movimiento_Pokemon nmp = new Modelos.EF.Movimiento_Pokemon();
            nm.Código_M = codigo;
            nm.Nombre_M = nombre;
            nm.Descripción = desc;
            nm.Tipo = tipo;
            nmp.Código_M = codigo;
            nmp.Identificador_P = idP;
            nm.Movimiento_Pokemon.Add(nmp);
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if (db.Movimientoes.Find(codigo) != null)
                {
                    return false;
                }
                else
                {
                    db.Movimientoes.Add(nm);
                    db.SaveChanges();
                    return true;
                }
                
            }
        }
        public bool UpdateMove(string codigo, string nombre, string desc, string tipo)
        {
            Modelos.EF.test1Entities db = new Modelos.EF.test1Entities();
            if (db.Movimientoes.Find(codigo) != null)
            {
                if(nombre != "")
                {
                    db.Movimientoes.Find(codigo).Nombre_M = nombre;
                }
                if(desc != "")
                {
                    db.Movimientoes.Find(codigo).Descripción = desc;
                }
                if(tipo != "")
                {
                    db.Movimientoes.Find(codigo).Tipo = tipo;
                }
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteMove(string id)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                if(db.Movimientoes.Find(id)!= null)
                {
                    db.Movimientoes.Remove(db.Movimientoes.Find(id));
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerable<Modelos.EPMUserViewModel> GetMoveById(int idP)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.EPMUserViewModel> lst = (from d in db.Entrenador_Pokemon_Movimiento
                                                              where d.Identificador_P == idP
                                                              select new Modelos.EPMUserViewModel()
                                                              {
                                                                  Código_M = d.Código_M,
                                                                  Identificador_E = d.Identificador_E,
                                                                  Identificador_P = d.Identificador_P
                                                                  
                                                              }).ToList();
                return lst;
            }
        }

        public IEnumerable<Modelos.movementViewModel> GetMovByType(string type)
        {
            using(Modelos.EF.test1Entities db = new Modelos.EF.test1Entities())
            {
                IEnumerable<Modelos.movementViewModel> lst = (from d in db.Movimientoes
                                                              where d.Tipo == type
                                                              select new Modelos.movementViewModel
                                                              {
                                                                  Código_M = d.Código_M,
                                                                  Nombre_M = d.Nombre_M,
                                                                  Descripción = d.Descripción,
                                                                  Tipo = d.Tipo
                                                              }).ToList();
                if (lst.Count() == 0)
                {
                    return GetMovements();
                }
                else
                {
                    return lst;
                }
                
            }
        }
    }
}
