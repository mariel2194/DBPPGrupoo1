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
    
    public partial class Productos
    {
        public Productos()
        {
            this.Detalle = new HashSet<Detalle>();
        }
    
        public int ProductoId { get; set; }
        public string CodigoUPC { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> CategoriaID { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}
