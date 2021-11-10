﻿using Diseño.BaseD;
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
        public string Recuperarpasss(string User)
        {
            using (parkEntities db = new parkEntities())
            {
                var Find = db.CuentasUsuario.Where(x => x.email == User).FirstOrDefault();

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
                    Emailservice.Enviarmensaje(Asunto: "Solicitud para la contraseña :c",
                        Cuerpo: "Hola " + Nombre + " Por algun motivo se te olvido tu clave :c, pero su clave nueva es: " + resultString,
                        Destino: User);
                    return "Cambio correcto";
                }
                else
                {
                    return "Algo anda mal";
                }
            }
        }
        public string Enviarpasss(string User)
        {
            using (parkEntities db = new parkEntities())
            {
                var Find = db.CuentasUsuario.Where(x => x.email == User).FirstOrDefault();

                if (Find != null)
                {
                    int CodiUser = int.Parse(Find.id.ToString());
                    //string Nombre = Find.FirstName.ToString();


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
                    Emailservice.Enviarmensaje(Asunto: "Solicitud para la contraseña :c",
                        Cuerpo: "Hola " + "Nuevo usuario" + " Por algun motivo usted es el nuevo empleado, pero su clave nueva es: " + resultString,
                        Destino: User);
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
