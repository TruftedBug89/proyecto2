//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class grups_has_docents
    {
        public int grups_id { get; set; }
        public int usuaris_id { get; set; }
        public int curs_id { get; set; }
    
        public virtual cursos cursos { get; set; }
        public virtual grups grups { get; set; }
        public virtual usuaris usuaris { get; set; }
    }
}
