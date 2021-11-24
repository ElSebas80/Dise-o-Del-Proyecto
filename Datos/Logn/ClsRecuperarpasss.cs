using Diseño.BaseD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño.Datos.Logn
{
    public class ClsRecuperarpasss
    {
        public CuentasUsuario mail(string gm)
        {
            using (parkEntities db = new parkEntities())
            {
                var registro = db.CuentasUsuario.Where(x => x.email == gm
                    ).FirstOrDefault();
                return registro;
            }
        }
        public string Recuperarpasss(string User, string Correo)
        {
            using (parkEntities db = new parkEntities())
            {
                var Find = db.CuentasUsuario.Where(x => x.LoginN == User).Where(x => x.email == Correo).FirstOrDefault();

                if (Find != null)
                {
                    int CodiUser = int.Parse(Find.id.ToString());
                    string Nombre = Find.Nombre.ToString();


                    var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var Charsarr = new char[6];
                    var random = new Random();

                    for (int i = 0; i < Charsarr.Length; i++)
                    {
                        Charsarr[i] = characters[random.Next(characters.Length)];
                    }

                    var resultString = new String(Charsarr);

                    ClsEditarUser ClsEditUs = new ClsEditarUser();
                    ClsEditUs.EditarUser(CodiUser, resultString.ToString());

                    var Emailservice = new SistemSuports("sssssssssew888@gmail.com", "3017118619.");
                    Emailservice.Enviarmensaje(Asunto: "Solicitud de nueva contraseña",
                        Cuerpo: "Hola como estas este correo a sido enviado del sistema de informacion Sw Parking Gold, el nombre de su perfil es " + Nombre + " no sabemos el motivo de su perdida de clave pero debido al proceso solicitado se te asigno una nueva clave esta corresponde a: " + resultString,
                        Destino: Correo);
                    return "Cambio correcto";
                }
                else
                {
                    return "Unos de los campos no a sido digitado correctamente";
                }
            }
        }
        public string Enviarpasss(string user)
        {
            using (parkEntities db = new parkEntities())
            {
                var Find = db.CuentasUsuario.Where(x => x.LoginN == user).FirstOrDefault();

                if (Find != null)
                {
                    int CodiUser = int.Parse(Find.id.ToString());
                    string correo = Find.email.ToString();


                    var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var Charsarr = new char[6];
                    var random = new Random();

                    for (int i = 0; i < Charsarr.Length; i++)
                    {
                        Charsarr[i] = characters[random.Next(characters.Length)];
                    }

                    var resultString = new String(Charsarr);

                    ClsEditarUser ClsEditUs = new ClsEditarUser();
                    ClsEditUs.EditarUser(CodiUser, resultString.ToString());

                    var Emailservice = new SistemSuports("sssssssssew888@gmail.com", "3017118619.");
                    Emailservice.Enviarmensaje(Asunto: "Asignacion de contraseña",
                        Cuerpo: "Hola " + "Nuevo usuario" + " Por algun motivo usted es el nuevo empleado u administrador, pero su clave asignada es: " + resultString,
                        Destino: correo);
                    return "Cambio correcto";
                }
                else
                {
                    return "Algo anda mal";
                }
            }
        }
    }
}
