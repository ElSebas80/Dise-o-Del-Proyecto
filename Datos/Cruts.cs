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
        public void GuardarUser(int id, string User, string Cont,string Nom,int cc,string Correo)
        {
            using (emailEntities bd = new emailEntities())
            {
                bd.Sp_GuardarUser(id, User, Cont, Nom, cc, Correo);
            }

        }
    }
}
