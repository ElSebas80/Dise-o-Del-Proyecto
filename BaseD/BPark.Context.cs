﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diseño.BaseD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class parkEntities : DbContext
    {
        public parkEntities()
            : base("name=parkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CuentasUsuario> CuentasUsuario { get; set; }
        public virtual DbSet<ingresoVehiculo> ingresoVehiculo { get; set; }
        public virtual DbSet<MovimintoEst> MovimintoEst { get; set; }
    
        public virtual int sp_CuentasUsuario(string nombre, string apellido, Nullable<int> cedula, string direccion, string email, string loginN, string contra)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var loginNParameter = loginN != null ?
                new ObjectParameter("LoginN", loginN) :
                new ObjectParameter("LoginN", typeof(string));
    
            var contraParameter = contra != null ?
                new ObjectParameter("Contra", contra) :
                new ObjectParameter("Contra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CuentasUsuario", nombreParameter, apellidoParameter, cedulaParameter, direccionParameter, emailParameter, loginNParameter, contraParameter);
        }
    }
}