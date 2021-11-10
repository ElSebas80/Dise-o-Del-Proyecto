using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diseño.BaseD;

namespace Diseño.Datos
{
    public class Cruts
    {
        public void GuardarUser(string nombre, string apel, int cc, string direc, string correo, string longin, string contra)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_CuentasUsuario(nombre, apel, cc, direc, correo, longin, contra);
            }

        }
        public void GuardarInfo(string nombre, string nit, int tele, string direc, string correo, string horar)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_configuracion(nombre, nit, tele, direc, correo, horar);
            }

        }
    }
}