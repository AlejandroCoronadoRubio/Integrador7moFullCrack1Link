﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NordsonEntities : DbContext
    {
        public NordsonEntities()
            : base("name=NordsonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<almacen> almacen { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<orden> orden { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}
