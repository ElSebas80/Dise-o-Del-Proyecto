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
    }
}