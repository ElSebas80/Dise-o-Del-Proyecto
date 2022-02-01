using Diseño.BaseD;
using Diseño.Datos.Encriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Diseño.Datos
{
    public class Cruts
    {
        public void GuardarUser(string nombre, int cc, string direc, string correo, string longin, string contra, string tipo, int estado)
        {

            using (parkEntities bd = new parkEntities())
            {
                bd.sp_CuentasUsuario(nombre, cc, direc, correo, longin, contra, tipo, estado);
            }

        }
        public void EditarUser(int id, string tipo, int estado)
        {

            using (parkEntities bd = new parkEntities())
            {
                bd.sp_EdiCuentasUsuario(id, tipo, estado);
            }

        }
        public List<CuentasUsuario> MostrarCc(int Cc)
        {
            using (parkEntities db = new parkEntities())
            {
                var reg = db.CuentasUsuario.Where(x => x.Cedula == Cc).ToList();
                
                    return reg;
                
            }
        }
        public List<CuentasUsuario> MostrarUser(string Long)
        {
            using (parkEntities db = new parkEntities())
            {
                var reg = db.CuentasUsuario.Where(x => x.LoginN == Long).ToList();

                return reg;

            }
        }
        public void EditarPerfil(int id, string nombre, int cc, string direc, string correo, string longin, string contra)
        {
            string pass = Encryp.GetSHA1(contra);
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_EdiPerfil(id, nombre, cc, direc, correo, longin, pass);
            }

        }
        public IList RetornarEst()
        {
            using (parkEntities db = new parkEntities())
            {
                var Preciou = (from prod in db.CuentasUsuario
                               join Est in db.Estado on prod.idEs equals Est.id
                              select new {prod.id,prod.Nombre,prod.Cedula,prod.Direccion,prod.email,prod.LoginN,prod.idTp,Estado = Est.nombre}).ToList();
                return Preciou;
            }
        }
        public void GuardarInfo(string nombre, string nit, int tele, string direc, string correo, string horar)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_configuracion(nombre, nit, tele, direc, correo, horar);
            }
        }
        public void AlterarInfo(string nombre, string nit, int tele, string direc, string correo, string horar)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_Alterconfi(nombre, nit, tele, direc, correo, horar);
            }
        }
        public confi MosDtConfi(int id)
        {
            using (parkEntities bd = new parkEntities())
            {
                confi reg = bd.confi.Where(x => x.Id == id).FirstOrDefault();
                return reg;
            }
        }
        public tari MosDtTari(int id)
        {
            using (parkEntities bd = new parkEntities())
            {
                tari reg = bd.tari.Where(x => x.Id == id).FirstOrDefault();
                return reg;
            }
        }
        public void GuardarInfoTarifas(DateTime fecha, Decimal hormt, Decimal semmt, Decimal quinmt, Decimal mensrmt, Decimal horbc, Decimal sembc, Decimal quinbc, Decimal mensbc, int cupos)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_tarifas(fecha, hormt, semmt, quinmt, mensrmt, horbc, sembc, quinbc, mensbc, cupos);
            }
        }
        public void AlterarInfoTarifas(DateTime fecha, Decimal hormt, Decimal semmt, Decimal quinmt, Decimal mensrmt, Decimal horbc, Decimal sembc, Decimal quinbc, Decimal mensbc, int cupos)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_Altertarifas(fecha, hormt, semmt, quinmt, mensrmt, horbc, sembc, quinbc, mensbc, cupos);
            }
        }
        public void RegistrarVehvls(string tipoVh, string placa, string numcs, int cuposD, DateTime fecha, TimeSpan hora)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_ingresoVehiculo(tipoVh, placa, numcs, cuposD, fecha, hora);
            }
        }
        public void RegistrarClientes(string nombre, int Cedula, int telefon, string placa, string tipoVhlo,string mensualidad, Decimal valor, DateTime fechaini, DateTime fechafin, TimeSpan hora)
        {
            using (parkEntities bd = new parkEntities())
            {
                bd.sp_RegistroCliente(nombre, Cedula, telefon, placa, tipoVhlo, mensualidad, valor, fechaini, fechafin, hora);
            }
        }
        public IList<ingresoVehiculo> MostrarPlac()
        {
            using (parkEntities db = new parkEntities())
            {
                return db.ingresoVehiculo.ToList();
            }
        }
        public IList<ingresoVehiculo> ingresoVehiculosm(string ID)
        {
            using (parkEntities db = new parkEntities())
            {
                return db.ingresoVehiculo.Where(x => x.Placa == ID).ToList();
            }
        }
        public IList<RegistroCliente> ingresoClientesm(string ID)
        {
            using (parkEntities db = new parkEntities())
            {
                return db.RegistroCliente.Where(x => x.Placa == ID).ToList();
            }
        }
        public void ActualizarCanti(int CodProd, int Cant)
        {
            using (parkEntities db = new parkEntities())
            {
                db.Sp_DesconCant(CodProd, Cant);
            }
        }
    }
}
