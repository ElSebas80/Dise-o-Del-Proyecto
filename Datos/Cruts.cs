using Diseño.BaseD;
using Diseño.Datos.Encriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos
{
    public class Cruts
    {
        public void GuardarUser(string nombre, int cc, string direc, string correo, string longin, string contra, string tipo, int estado)
        {

            using (parkEntities bd = new parkEntities())
            {
                bd.sp_CuentasUsuario(nombre, cc, direc, correo, longin, contra, tipo, estado);
            }

        }
        public void EditarUser(int id, string tipo, int estado)
        {

            using (parkEntities bd = new parkEntities())
            {
                bd.sp_EdiCuentasUsuario(id, tipo, estado);
            }

        }
        public void EditarPerfil(int id, string nombre, int cc, string direc, string correo, string longin, string contra)
        {
            string pass = Encryp.GetSHA1(contra);
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_EdiPerfil(id, nombre, cc, direc, correo, longin, pass);
            }

        }
        //public string RetornarContra (int Cod)
        //{
        //    using (parkEntities1 db = new parkEntities1())
        //    {
        //        var Preciou = (from prod in db.Configuration
        //                       where prod. == Cod
        //                       select prod).FirstOrDefault();
        //        return Preciou.Contra.ToString();
        //    }
        //}
        public void GuardarInfo(string nombre, string nit, int tele, string direc, string correo, string horar)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_configuracion(nombre, nit, tele, direc, correo, horar);
            }
        }
        public void GuardarInfoTarifas(DateTime fecha, Decimal hormt, Decimal semmt, Decimal quinmt, Decimal mensrmt, Decimal horbc, Decimal sembc, Decimal quinbc, Decimal mensbc, int cupos)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_tarifas(fecha, hormt, semmt, quinmt, mensrmt, horbc, sembc, quinbc, mensbc, cupos);
            }
        }
        public void RegistrarVehvls(string tipoVh, string placa, string numcs, int cuposD, DateTime fecha, TimeSpan hora)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_ingresoVehiculo(tipoVh, placa, numcs, cuposD, fecha, hora);
            }
        }
    }
}
