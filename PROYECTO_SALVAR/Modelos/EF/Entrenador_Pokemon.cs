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
    
    public partial class Entrenador_Pokemon
    {
        public int Id { get; set; }
        public string Identificador_E { get; set; }
        public int Identificador_P { get; set; }
        public string Estado { get; set; }
    
        public virtual Entrenador Entrenador { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
