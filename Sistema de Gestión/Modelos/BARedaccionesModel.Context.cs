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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BARedaccionesEntities : DbContext
    {
        public BARedaccionesEntities()
            : base("name=BARedaccionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_VerDetalleRedaccion_Result> SP_VerDetalleRedaccion(Nullable<int> iDPedidos)
        {
            var iDPedidosParameter = iDPedidos.HasValue ?
                new ObjectParameter("IDPedidos", iDPedidos) :
                new ObjectParameter("IDPedidos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerDetalleRedaccion_Result>("SP_VerDetalleRedaccion", iDPedidosParameter);
        }
    
        public virtual ObjectResult<SP_VerConducesPedidos_Result> SP_VerConducesPedidos(Nullable<int> iDPedido)
        {
            var iDPedidoParameter = iDPedido.HasValue ?
                new ObjectParameter("IDPedido", iDPedido) :
                new ObjectParameter("IDPedido", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerConducesPedidos_Result>("SP_VerConducesPedidos", iDPedidoParameter);
        }
    
        public virtual ObjectResult<SP_VerRedaccionClienteID_Result> SP_VerRedaccionClienteID(Nullable<int> iDCliente)
        {
            var iDClienteParameter = iDCliente.HasValue ?
                new ObjectParameter("IDCliente", iDCliente) :
                new ObjectParameter("IDCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerRedaccionClienteID_Result>("SP_VerRedaccionClienteID", iDClienteParameter);
        }
    
        public virtual int SP_InsertarRedaccion(string placa, Nullable<int> conduce, string producto, Nullable<int> servicios, Nullable<decimal> capacidad_m3, string medida, Nullable<decimal> m3_total, Nullable<decimal> precio, Nullable<decimal> total_pedido, Nullable<int> id_cliente)
        {
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            var conduceParameter = conduce.HasValue ?
                new ObjectParameter("conduce", conduce) :
                new ObjectParameter("conduce", typeof(int));
    
            var productoParameter = producto != null ?
                new ObjectParameter("producto", producto) :
                new ObjectParameter("producto", typeof(string));
    
            var serviciosParameter = servicios.HasValue ?
                new ObjectParameter("servicios", servicios) :
                new ObjectParameter("servicios", typeof(int));
    
            var capacidad_m3Parameter = capacidad_m3.HasValue ?
                new ObjectParameter("capacidad_m3", capacidad_m3) :
                new ObjectParameter("capacidad_m3", typeof(decimal));
    
            var medidaParameter = medida != null ?
                new ObjectParameter("medida", medida) :
                new ObjectParameter("medida", typeof(string));
    
            var m3_totalParameter = m3_total.HasValue ?
                new ObjectParameter("m3_total", m3_total) :
                new ObjectParameter("m3_total", typeof(decimal));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var total_pedidoParameter = total_pedido.HasValue ?
                new ObjectParameter("total_pedido", total_pedido) :
                new ObjectParameter("total_pedido", typeof(decimal));
    
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarRedaccion", placaParameter, conduceParameter, productoParameter, serviciosParameter, capacidad_m3Parameter, medidaParameter, m3_totalParameter, precioParameter, total_pedidoParameter, id_clienteParameter);
        }
    }
}
