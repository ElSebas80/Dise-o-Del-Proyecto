using Diseño.BaseD;
using Diseño.Datos.Encriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos.Logn
{
    public class enviar
    {
        public CuentasUsuario Login(string user, string pass)
        {
            string ClaveEncrip = Encryp.GetSHA1(pass);
            using (parkEntities db = new parkEntities())
            {
                var registro = db.CuentasUsuario.Where(x => x.LoginN == user)
                        .Where(x => x.Contra == ClaveEncrip
                    ).FirstOrDefault();
                return registro;
            }
        }
        
    }
}
