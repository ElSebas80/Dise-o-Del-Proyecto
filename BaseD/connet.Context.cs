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
    
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<CuentasUsuario> CuentasUsuario { get; set; }
        public virtual DbSet<ingresoVehiculo> ingresoVehiculo { get; set; }
        public virtual DbSet<confi> confi { get; set; }
        public virtual DbSet<tari> tari { get; set; }
        public virtual DbSet<RegistroCliente> RegistroCliente { get; set; }
    
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
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
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
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_CuentasUsuario(string nombre, Nullable<int> cedula, string direccion, string email, string loginN, string contra, string tipo, Nullable<int> estd)
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
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            var estdParameter = estd.HasValue ?
                new ObjectParameter("estd", estd) :
                new ObjectParameter("estd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CuentasUsuario", nombreParameter, cedulaParameter, direccionParameter, emailParameter, loginNParameter, contraParameter, tipoParameter, estdParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EdiCuentasUsuario(Nullable<int> id, string tipo, Nullable<int> estd)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            var estdParameter = estd.HasValue ?
                new ObjectParameter("estd", estd) :
                new ObjectParameter("estd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EdiCuentasUsuario", idParameter, tipoParameter, estdParameter);
        }
    
        public virtual int sp_EdiPerfil(Nullable<int> id, string nombre, Nullable<int> cedula, string direccion, string email, string loginN, string contra)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EdiPerfil", idParameter, nombreParameter, cedulaParameter, direccionParameter, emailParameter, loginNParameter, contraParameter);
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
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_ingresoVehiculo(string tipoVhlo, string placa, string numCascos, Nullable<int> cuposDis, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora)
        {
            var tipoVhloParameter = tipoVhlo != null ?
                new ObjectParameter("tipoVhlo", tipoVhlo) :
                new ObjectParameter("tipoVhlo", typeof(string));
    
            var placaParameter = placa != null ?
                new ObjectParameter("Placa", placa) :
                new ObjectParameter("Placa", typeof(string));
    
            var numCascosParameter = numCascos != null ?
                new ObjectParameter("NumCascos", numCascos) :
                new ObjectParameter("NumCascos", typeof(string));
    
            var cuposDisParameter = cuposDis.HasValue ?
                new ObjectParameter("CuposDis", cuposDis) :
                new ObjectParameter("CuposDis", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("hora", hora) :
                new ObjectParameter("hora", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ingresoVehiculo", tipoVhloParameter, placaParameter, numCascosParameter, cuposDisParameter, fechaParameter, horaParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_tarifas(Nullable<System.DateTime> fecha, Nullable<decimal> horaEstacioMoto, Nullable<decimal> semanaEstacioMoto, Nullable<decimal> quincenaEstacioMoto, Nullable<decimal> mensualidadEstacioMoto, Nullable<decimal> horaEstacioBici, Nullable<decimal> semanaEstacioBici, Nullable<decimal> quincenaEstacioBici, Nullable<decimal> mensualidadEstacioBici, Nullable<int> cuposDIsponibles)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var horaEstacioMotoParameter = horaEstacioMoto.HasValue ?
                new ObjectParameter("HoraEstacioMoto", horaEstacioMoto) :
                new ObjectParameter("HoraEstacioMoto", typeof(decimal));
    
            var semanaEstacioMotoParameter = semanaEstacioMoto.HasValue ?
                new ObjectParameter("SemanaEstacioMoto", semanaEstacioMoto) :
                new ObjectParameter("SemanaEstacioMoto", typeof(decimal));
    
            var quincenaEstacioMotoParameter = quincenaEstacioMoto.HasValue ?
                new ObjectParameter("QuincenaEstacioMoto", quincenaEstacioMoto) :
                new ObjectParameter("QuincenaEstacioMoto", typeof(decimal));
    
            var mensualidadEstacioMotoParameter = mensualidadEstacioMoto.HasValue ?
                new ObjectParameter("MensualidadEstacioMoto", mensualidadEstacioMoto) :
                new ObjectParameter("MensualidadEstacioMoto", typeof(decimal));
    
            var horaEstacioBiciParameter = horaEstacioBici.HasValue ?
                new ObjectParameter("HoraEstacioBici", horaEstacioBici) :
                new ObjectParameter("HoraEstacioBici", typeof(decimal));
    
            var semanaEstacioBiciParameter = semanaEstacioBici.HasValue ?
                new ObjectParameter("SemanaEstacioBici", semanaEstacioBici) :
                new ObjectParameter("SemanaEstacioBici", typeof(decimal));
    
            var quincenaEstacioBiciParameter = quincenaEstacioBici.HasValue ?
                new ObjectParameter("QuincenaEstacioBici", quincenaEstacioBici) :
                new ObjectParameter("QuincenaEstacioBici", typeof(decimal));
    
            var mensualidadEstacioBiciParameter = mensualidadEstacioBici.HasValue ?
                new ObjectParameter("MensualidadEstacioBici", mensualidadEstacioBici) :
                new ObjectParameter("MensualidadEstacioBici", typeof(decimal));
    
            var cuposDIsponiblesParameter = cuposDIsponibles.HasValue ?
                new ObjectParameter("CuposDIsponibles", cuposDIsponibles) :
                new ObjectParameter("CuposDIsponibles", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_tarifas", fechaParameter, horaEstacioMotoParameter, semanaEstacioMotoParameter, quincenaEstacioMotoParameter, mensualidadEstacioMotoParameter, horaEstacioBiciParameter, semanaEstacioBiciParameter, quincenaEstacioBiciParameter, mensualidadEstacioBiciParameter, cuposDIsponiblesParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_RegistroCliente(string nombre, Nullable<int> cedula, Nullable<int> telefono, string placa, string tipoVhlo, string mensualidad, Nullable<decimal> valorPagar, Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin, Nullable<System.TimeSpan> hora)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(int));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(int));
    
            var placaParameter = placa != null ?
                new ObjectParameter("Placa", placa) :
                new ObjectParameter("Placa", typeof(string));
    
            var tipoVhloParameter = tipoVhlo != null ?
                new ObjectParameter("tipoVhlo", tipoVhlo) :
                new ObjectParameter("tipoVhlo", typeof(string));
    
            var mensualidadParameter = mensualidad != null ?
                new ObjectParameter("mensualidad", mensualidad) :
                new ObjectParameter("mensualidad", typeof(string));
    
            var valorPagarParameter = valorPagar.HasValue ?
                new ObjectParameter("ValorPagar", valorPagar) :
                new ObjectParameter("ValorPagar", typeof(decimal));
    
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("FechaIni", fechaIni) :
                new ObjectParameter("FechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("hora", hora) :
                new ObjectParameter("hora", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_RegistroCliente", nombreParameter, cedulaParameter, telefonoParameter, placaParameter, tipoVhloParameter, mensualidadParameter, valorPagarParameter, fechaIniParameter, fechaFinParameter, horaParameter);
        }
    
        public virtual int sp_Alterconfi(string nombreParqueadero, string nit, Nullable<int> telefono, string direccion, string correo, string horarioAtencion)
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Alterconfi", nombreParqueaderoParameter, nitParameter, telefonoParameter, direccionParameter, correoParameter, horarioAtencionParameter);
        }
    
        public virtual int sp_Altertarifas(Nullable<System.DateTime> fecha, Nullable<decimal> horaEstacioMoto, Nullable<decimal> semanaEstacioMoto, Nullable<decimal> quincenaEstacioMoto, Nullable<decimal> mensualidadEstacioMoto, Nullable<decimal> horaEstacioBici, Nullable<decimal> semanaEstacioBici, Nullable<decimal> quincenaEstacioBici, Nullable<decimal> mensualidadEstacioBici, Nullable<int> cuposDIsponibles)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var horaEstacioMotoParameter = horaEstacioMoto.HasValue ?
                new ObjectParameter("HoraEstacioMoto", horaEstacioMoto) :
                new ObjectParameter("HoraEstacioMoto", typeof(decimal));
    
            var semanaEstacioMotoParameter = semanaEstacioMoto.HasValue ?
                new ObjectParameter("SemanaEstacioMoto", semanaEstacioMoto) :
                new ObjectParameter("SemanaEstacioMoto", typeof(decimal));
    
            var quincenaEstacioMotoParameter = quincenaEstacioMoto.HasValue ?
                new ObjectParameter("QuincenaEstacioMoto", quincenaEstacioMoto) :
                new ObjectParameter("QuincenaEstacioMoto", typeof(decimal));
    
            var mensualidadEstacioMotoParameter = mensualidadEstacioMoto.HasValue ?
                new ObjectParameter("MensualidadEstacioMoto", mensualidadEstacioMoto) :
                new ObjectParameter("MensualidadEstacioMoto", typeof(decimal));
    
            var horaEstacioBiciParameter = horaEstacioBici.HasValue ?
                new ObjectParameter("HoraEstacioBici", horaEstacioBici) :
                new ObjectParameter("HoraEstacioBici", typeof(decimal));
    
            var semanaEstacioBiciParameter = semanaEstacioBici.HasValue ?
                new ObjectParameter("SemanaEstacioBici", semanaEstacioBici) :
                new ObjectParameter("SemanaEstacioBici", typeof(decimal));
    
            var quincenaEstacioBiciParameter = quincenaEstacioBici.HasValue ?
                new ObjectParameter("QuincenaEstacioBici", quincenaEstacioBici) :
                new ObjectParameter("QuincenaEstacioBici", typeof(decimal));
    
            var mensualidadEstacioBiciParameter = mensualidadEstacioBici.HasValue ?
                new ObjectParameter("MensualidadEstacioBici", mensualidadEstacioBici) :
                new ObjectParameter("MensualidadEstacioBici", typeof(decimal));
    
            var cuposDIsponiblesParameter = cuposDIsponibles.HasValue ?
                new ObjectParameter("CuposDIsponibles", cuposDIsponibles) :
                new ObjectParameter("CuposDIsponibles", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Altertarifas", fechaParameter, horaEstacioMotoParameter, semanaEstacioMotoParameter, quincenaEstacioMotoParameter, mensualidadEstacioMotoParameter, horaEstacioBiciParameter, semanaEstacioBiciParameter, quincenaEstacioBiciParameter, mensualidadEstacioBiciParameter, cuposDIsponiblesParameter);
        }
    
        public virtual int Sp_DesconCant(Nullable<int> codc, Nullable<int> cupo)
        {
            var codcParameter = codc.HasValue ?
                new ObjectParameter("Codc", codc) :
                new ObjectParameter("Codc", typeof(int));
    
            var cupoParameter = cupo.HasValue ?
                new ObjectParameter("Cupo", cupo) :
                new ObjectParameter("Cupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_DesconCant", codcParameter, cupoParameter);
        }
    }
}
