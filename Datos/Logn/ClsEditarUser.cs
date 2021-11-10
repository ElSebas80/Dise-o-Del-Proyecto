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
            using (parkEntities1 bd = new parkEntities1())
            {
                bd.Sp_EditarContra(Cod, Clave);
            }
        }
        public IList<CuentasUsuario> MostrarClientes()
        {
            using (parkEntities1 db = new parkEntities1())
            {
                return db.CuentasUsuario.ToList();
            }
        }
    }
}
