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
        public EnvEmail Login(string user, string pass)
        {
           // string ClaveEncrip = Encryp.GetSHA1(pass);
            using (emailEntities db = new emailEntities())
            {
                var registro = db.EnvEmail.Where(x => x.LoginName == user)
                        .Where(x => x.Contra == pass
                    ).FirstOrDefault();
                return registro;
            }
        }
        
    }
}
