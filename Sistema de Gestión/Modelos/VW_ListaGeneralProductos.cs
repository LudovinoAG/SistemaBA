//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class VW_ListaGeneralProductos
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> ITBIS { get; set; }
    }
}
