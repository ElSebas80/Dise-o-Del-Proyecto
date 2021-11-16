using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diseño.BaseD;
using Diseño.Datos.Encriptacion;

namespace Diseño.Datos
{
    public class Cruts
    {
        public void GuardarUser(string nombre, int cc, string direc, string correo, string longin, string contra, string tipo, int estado)
        {
            
            using (parkEntities1 bd = new parkEntities1())
            {
                bd.sp_CuentasUsuario(nombre, cc, direc, correo, longin, contra, tipo, estado);
            }

        }
        public void GuardarInfo(string nombre, string nit, int tele, string direc, string correo, string horar)
        {
            using (parkEntities1 bd = new parkEntities1())
            {
                bd.sp_configuracion(nombre, nit, tele, direc, correo, horar);
            }
        }
        public void GuardarInfoTarifas(DateTime fecha, Decimal hormt, Decimal semmt, Decimal quinmt,Decimal mensrmt,Decimal horbc, Decimal sembc, Decimal quinbc, Decimal mensbc,int cupos)
        {
            using (parkEntities1 bd = new parkEntities1())
            {
                bd.sp_tarifas(fecha, hormt, semmt, quinmt, mensrmt, horbc,sembc,quinbc,mensbc,cupos);
            }
        }
        public void RegistrarVehvls(string tipoVh, string placa, string numcs, int cuposD, DateTime fecha, TimeSpan hora)
        {
            using (parkEntities1 bd = new parkEntities1())
            {
                bd.sp_ingresoVehiculo(tipoVh, placa, numcs, cuposD, fecha, hora);
            }
        }
    }
}