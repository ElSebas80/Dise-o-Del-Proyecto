using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos.Logn
{
    class SistemSuports:Email
    {
            public SistemSuports(string Email, string Contra) // Recibe los parametros de donde se manda
        {
               // this.EnviaMail = "sssssssssew888@gmail.com";
                this.EnviaMail = Email;
                //this.contra = "3017118619.";
                this.contra = Contra;
                this.host = "smtp.gmail.com";// Host del gmail
                this.port = 587;
                this.ssl = true;
                IniciarsmClient();
            }
        
    }
}
