//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Vendedores
    {
        public Vendedores()
        {
            this.Facturas = new HashSet<Facturas>();
        }
    
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Nullable<decimal> ComisionPorVenta { get; set; }
    
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
