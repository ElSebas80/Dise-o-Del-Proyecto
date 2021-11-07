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
        public void GuardarUser(string nombre, string apel,int cc, string direc,string longin, string contra, string correo)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_CuentasUsuario(nombre, apel, cc, direc, correo, longin, contra);
            }

        }
    }
}
