//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Núm_Cédula_C { get; set; }
        public string Nombre_C { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Núm_Teléfono { get; set; }
        public string Provincia { get; set; }
        public string Cantón { get; set; }
        public string Distrito { get; set; }
        public string Otras_señas { get; set; }
        public string Correo_Electrónico { get; set; }
        public string Ubicación { get; set; }
        public string Nombre_Usuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
