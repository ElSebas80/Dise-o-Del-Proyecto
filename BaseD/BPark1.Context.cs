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
    
    public partial class parkEntities1 : DbContext
    {
        public parkEntities1()
            : base("name=parkEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<CuentasUsuario> CuentasUsuario { get; set; }
    
        public virtual int sp_configuracion(string nombreParqueadero, string nit, Nullable<int> telefono, string direccion, string correo, string horarioAtencion)
        {
            var nombreParqueaderoParameter = nombreParqueadero != null ?
                new ObjectParameter("NombreParqueadero", nombreParqueadero) :
                new ObjectParameter("NombreParqueadero", typeof(string));
    
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var horarioAtencionParameter = horarioAtencion != null ?
                new ObjectParameter("HorarioAtencion", horarioAtencion) :
                new ObjectParameter("HorarioAtencion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_configuracion", nombreParqueaderoParameter, nitParameter, telefonoParameter, direccionParameter, correoParameter, horarioAtencionParameter);
        }
    
        public virtual int sp_CuentasUsuario(string nombre, Nullable<int> cedula, string direccion, string email, string loginN, string contra, Nullable<int> tipo, Nullable<int> estd)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
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
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(int));
    
            var estdParameter = estd.HasValue ?
                new ObjectParameter("estd", estd) :
                new ObjectParameter("estd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CuentasUsuario", nombreParameter, cedulaParameter, direccionParameter, emailParameter, loginNParameter, contraParameter, tipoParameter, estdParameter);
        }
    
        public virtual int Sp_EditarContra(Nullable<int> id, string contra)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var contraParameter = contra != null ?
                new ObjectParameter("Contra", contra) :
                new ObjectParameter("Contra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_EditarContra", idParameter, contraParameter);
        }
    
        public virtual int deshUsuario(Nullable<int> id, Nullable<int> estado)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deshUsuario", idParameter, estadoParameter);
        }
    }
}
