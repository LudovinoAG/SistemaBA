﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_de_Gestión.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BAReportesEntities : DbContext
    {
        public BAReportesEntities()
            : base("name=BAReportesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VW_VerReportesFacturasPendientesCredito> VW_VerReportesFacturasPendientesCredito { get; set; }
        public virtual DbSet<VW_VerFacturas> VW_VerFacturas { get; set; }
    }
}
