//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiProyect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class valoracions
    {
        public int kpis_id { get; set; }
        public int usuari_valorat_id { get; set; }
        public int usuari_pp_id { get; set; }
        public System.DateTime data { get; set; }
        public int nota { get; set; }
        public int llistes_skills_id { get; set; }
        public int skills_id { get; set; }
    
        public virtual kpis kpis { get; set; }
        public virtual usuaris usuaris { get; set; }
        public virtual usuaris usuaris1 { get; set; }
    }
}
