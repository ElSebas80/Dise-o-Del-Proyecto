//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class RegistroCliente
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Cedula { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Placa { get; set; }
        public string tipoVhlo { get; set; }
        public string mensualidad { get; set; }
        public Nullable<decimal> ValorPagar { get; set; }
        public Nullable<System.DateTime> FechaIni { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
    }
}
