﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class frase_aluEntities : DbContext
    {
        public frase_aluEntities()
            : base("name=frase_aluEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<cursos> cursos { get; set; }
        public virtual DbSet<grups> grups { get; set; }
        public virtual DbSet<grups_has_alumnes> grups_has_alumnes { get; set; }
        public virtual DbSet<grups_has_docents> grups_has_docents { get; set; }
        public virtual DbSet<grups_has_llistes_skills> grups_has_llistes_skills { get; set; }
        public virtual DbSet<kpis> kpis { get; set; }
        public virtual DbSet<llistes_skills> llistes_skills { get; set; }
        public virtual DbSet<valoracions> valoracions { get; set; }
        public virtual DbSet<skills> skills { get; set; }
        public virtual DbSet<rols> rols { get; set; }
        public virtual DbSet<usuaris> usuaris { get; set; }
    }
}
