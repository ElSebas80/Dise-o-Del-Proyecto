using Diseño.BaseD;
using Diseño.Datos.Encriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos.Logn
{
    class ClsEditarUser
    {
        public void EditarUser(int Cod, string Clave)
        {
            //string ClaveEncrip = Encryp.GetSHA1(Clave);
            using (parkEntities bd = new parkEntities())
            {
                bd.Sp_EditarContra(Cod, Clave);
            }
        }
        public IList<CuentasUsuario> MostrarClientes()
        {
            using (parkEntities db = new parkEntities())
            {
                return db.CuentasUsuario.ToList();
            }
        }
    }
}
