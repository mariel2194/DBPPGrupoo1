﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBPPGrupoo1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FacturacionProdGrupoo1Entities1 : DbContext
    {
        public FacturacionProdGrupoo1Entities1()
            : base("name=FacturacionProdGrupoo1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
    }
}
