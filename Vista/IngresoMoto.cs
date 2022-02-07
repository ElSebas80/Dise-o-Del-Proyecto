using Diseño.BaseD;
using Diseño.Datos;
using Diseño.Datos.Logn;
using Diseño.Datos.ValidacionCampos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Vista
{
    public partial class FrmIngresoMoto : Form
    {
        public FrmIngresoMoto()
        {
            InitializeComponent();
        }

        private void FrmIngresoMoto_Load(object sender, EventArgs e)
        {
            //MostrarPlaca();
            dtg();
            buscaid();
        }
        private void dtg()
        {
            dtgMovim.DataSource = bd.MostrarPlac().ToList();
        }
        private void FrmIngresoMoto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAU_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtAU_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmIngresoMoto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
        }
        Cruts bd = new Cruts();
        string tVhlO;
        private void EstD()
        {
            if (rdtMoto.Checked == true)
                tVhlO = "Moto";
            else if (rdtBici.Checked == true)
                tVhlO = "Bicicleta";
        }
        private void ingresarVehiculo()
        {
            bd.RegistrarVehvls(tVhlO, txtPlaca.Text, txtNCascos.Text, int.Parse(txtCuposD.Text), DateTime.Parse(lblFecha.Text), TimeSpan.Parse(lblHora.Text)
                );
        }
        Cruts s = new Cruts();
        int id = 1;
        private void buscaidTari()
        {
            var x = s.MosDtTari(id);
            if (rdSemana.Checked == true && rdMotoCli.Checked == true)
            {
                txtPago1.Text = x.SemanaEstacioMoto.ToString();
            }
            else if (rdQuincena.Checked == true && rdMotoCli.Checked == true)
            {
                txtPago1.Text = x.QuincenaEstacioMoto.ToString();
            }
            else if (rdMensualidad.Checked == true && rdMotoCli.Checked == true)
            {
                txtPago1.Text = x.MensualidadEstacioMoto.ToString();
            }
            else if (rdSemana.Checked == true && rdBiciCli.Checked == true)
            {
                txtPago1.Text = x.SemanaEstacioBici.ToString();
            }
            else if (rdQuincena.Checked == true && rdBiciCli.Checked == true)
            {
                txtPago1.Text = x.QuincenaEstacioBici.ToString();
            }
            else if (rdMensualidad.Checked == true && rdBiciCli.Checked == true)
            {
                txtPago1.Text = x.MensualidadEstacioBici.ToString();
            }
        }
        private void mensualid()
        {
            if (rdSemana.Checked == true)
            {
                MEnsuCLi = "Semanal";
                DateTime FeFin = DateTime.Today.AddDays(7);
                lblFeFin.Text = FeFin.ToShortDateString().ToString();
                lblFeFin.Visible = true;
            }
            else if (rdQuincena.Checked == true)
            {
                MEnsuCLi = "Quincenal";
                DateTime FeFin = DateTime.Today.AddDays(14);
                lblFeFin.Text = FeFin.ToShortDateString().ToString();
                lblFeFin.Visible = true;
            }
            else if (rdMensualidad.Checked == true)
            {
                MEnsuCLi = "Mensual";
                DateTime FeFin = DateTime.Today.AddMonths(1);
                lblFeFin.Text = FeFin.ToShortDateString().ToString();
                lblFeFin.Visible = true;
            }
        }
        string nom, nit, tel, dir,corr;
        int idc = 1, numTk;
        private void buscaid()
        {
            var x = s.MosDtConfi(idc);
            if (x != null)
            {
                nom = x.NombreParqueadero.ToString();
                nit = x.Nit.ToString();
                tel = x.Telefono.ToString();
                dir = x.Direccion.ToString();
                corr = x.Correo.ToString();
                //txtTel.Text = x.Telefono.ToString();
                //txtDir.Text = x.Direccion.ToString();
                //txtCorreo.Text = x.Correo.ToString();
                //txtHorATenc.Text = x.HorarioAtencion.ToString();
                //BtnGuarInfo.Visible = false;
                //btnModInfo.Visible = true;
                //btnCanInfo.Visible = true;
            }   
           
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
                foreach (var fato in db.MostrarPlac())
                {
                numTk = fato.NumTicket;
                    //= db.MostrarPlac();//buscar la plca mediante el primary key

                }
            //if (btnIngresar == )
            //{
            // Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("Parqueadero ", new Font("Arial", 30), Brushes.Black, 65, 10);//(x,y)x se mueve en horizontal. y en vertical
            e.Graphics.DrawString( nom, new Font("Arial", 30), Brushes.Black, 55, 50);
            e.Graphics.DrawString("No. Ticket: " , new Font("Arial", 30), Brushes.Black, 550, 10);
            e.Graphics.DrawString(""+ numTk, new Font("Arial", 30), Brushes.Black, 610, 50);
            e.Graphics.DrawString("Nit: " + nit, new Font("Arial", 30), Brushes.Black, 285, 95);
            e.Graphics.DrawString("Regimen Simplificado", new Font("Arial", 30), Brushes.Black, 200, 130);
            e.Graphics.DrawString("Dirección: " + dir, new Font("Arial", 30), Brushes.Black, 190, 165);
            e.Graphics.DrawString("WhatsApp: " + tel, new Font("Arial", 30), Brushes.Black, 205, 200);
            e.Graphics.DrawString("Numero de la placa: " + txtPlaca.Text, new Font("Arial", 40), Brushes.Black, 0, 235);
            e.Graphics.DrawString("Tipo de vehículo: " + tVhlO, new Font("Arial", 30), Brushes.Black,0, 290);
            e.Graphics.DrawString("Numero de cascos: " + txtNCascos.Text, new Font("Arial", 30), Brushes.Black,0, 325);
            e.Graphics.DrawString("Fecha de ingreso: " + lblFecha.Text, new Font("Arial", 30), Brushes.Black, 0, 360);
            e.Graphics.DrawString("Hora de ingreso: " + lblHora.Text, new Font("Arial", 30), Brushes.Black, 0, 395);
            e.Graphics.DrawString("Software: Sw Parking Gold", new Font("Arial", 30), Brushes.DarkGoldenrod, 160, 435);
            e.Graphics.DrawString("REGLAMENTO", new Font("Arial", 30), Brushes.Red, 240, 470);
            e.Graphics.DrawString("El Vehículo se entregará al portador del recibo. \n" +
                "No aceptamos órdenes telefónicas, Retirado el \nautomotor " +
                "no se aceptan reclamos de ningún tipo.", new Font("Arial", 25), Brushes.Black, 10, 505);
            e.Graphics.DrawString("CONSERVE SU RECIBO", new Font("Arial", 30), Brushes.Red, 130, 620);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imp();
        }
        private void imp()
        {
            //printDialog1.ShowDialog();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printPreviewControl2.Document = printDocument1;

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtPlaca.Text != "" && txtNCascos.Text != "")
            {            
            EstD();
            ingresarVehiculo();
            MessageBox.Show("Vehiculo ingresado");
            db.ActualizarCanti(va, int.Parse(txtCuposD.Text));
            imp();
            //limp();
            dtg();
                btnIngresar.Visible = false;
                btncancIn.Visible = false;
                btnImpIn.Visible = true;
                printPreviewControl2.Visible = true;
            }
            else
            {
                MessageBox.Show("Revise nuevamente puede haber un campo vacio");
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhoraCLi.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfechaCli.Text = DateTime.Now.ToShortDateString();
            txthrsali.Text = DateTime.Now.ToString("hh:mm:ss");
            txtfcsali.Text = DateTime.Now.ToShortDateString();
            buscaidTari();
            descon();
            //mensu();
            mensualid();
        }
        //modulo de clientes
        string TpVhCli, MEnsuCLi, pago;
        private void TipoVhculo()
        {
            if (rdMotoCli.Checked == true)
                TpVhCli = "Moto";
            else if (rdBiciCli.Checked == true)
                TpVhCli = "Bicicleta";
        }
        private void mensu()
        {
            DateTime FeFin = DateTime.Today.AddMonths(1);
            lblFeFin.Text= FeFin.ToShortDateString().ToString();
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
            TipoVhculo();
            mensualid();
            if (MessageBox.Show("Seguro que quiere registrar este cliente?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                bd.RegistrarClientes(txtNombre.Text, int.Parse(txtCedula.Text), int.Parse(txtTelefono.Text), txtPlacaCli.Text.Trim(),
                 TpVhCli, MEnsuCLi, Decimal.Parse(txtPago1.Text), DateTime.Parse(lblfechaCli.Text), DateTime.Parse(lblFeFin.Text), TimeSpan.Parse(lblhoraCLi.Text));
            limp();
            }
            catch
            {
                MessageBox.Show ("Revise nuevamente puede haber un campo vacio");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        parkEntities myReader = new parkEntities();
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime fentrada = Convert.ToDateTime(txtfeinsal);
            DateTime fsalida = dateTimePicker1.Value;



                //es esta variable tenemos los dias que se quedo en el parqueadero
                //Horas
                DateTime entrada = fentrada;
                DateTime salida = fsalida;
                TimeSpan span = salida.Subtract(entrada);



            txthrsali.Text = Convert.ToString(span);
                //MessageBox.Show(Convert.ToString(span), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int prueba = Convert.ToInt32(span.TotalMinutes);
                //dias = span.Days;

                // Aqui definimos cuantos cobramos dependiendo del vehiculo

                if (tVhlO == "Motocicleta".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                    txtvalpago.Text = "2000";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 7);
                        if (total < 5000)
                        {
                        txtvalpago.Text = "5000";
                        }
                        else
                        {
                        txtvalpago.Text = Convert.ToString(prueba * 7);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                    txtvalpago.Text = "4000";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                    txtvalpago.Text = "3500";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                    txtvalpago.Text = "3000";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                    txtvalpago.Text = "2500";
                    }


                }
                if (tVhlO == "Bicicleta".Trim())
                {
                    if (Convert.ToDouble(prueba) < 60)
                    {
                    txtvalpago.Text = "4000";
                    }
                    else
                    if (Convert.ToDouble(prueba) > 540)
                    {
                        int total = (Convert.ToInt32(prueba) * 11);
                        if (total < 8000)
                        {
                        txtvalpago.Text = "8000";
                        }
                        else
                        {
                        txtvalpago.Text = Convert.ToString(prueba * 11);
                        }
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 360)
                    {

                    txtvalpago.Text = "6000";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 300)
                    {

                    txtvalpago.Text = "5500";
                    }
                    else
                  if (Convert.ToDouble(prueba) >= 240)
                    {

                    txtvalpago.Text = "5000";
                    }
                    else

                  if (Convert.ToDouble(prueba) >= 60)
                    {

                    txtvalpago.Text = "4500";
                    }


                }
            
                printPreviewControl1.Document = printDocument1;

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        string bFech;
        private void cmbMovim_SelectedValueChanged(object sender, EventArgs e)
        {
           // Producto1 = cmbMovim.SelectedValue.ToString();
        }
        Cruts db = new Cruts();
        private void MostrarFecha()
        {
            foreach(var fato in db.ingresoClientesm(txtPlaca.Text))
            {
                DateTime.Parse(bFech = fato.FechaFin.ToString()).ToShortDateString();//mostrar la fecha con esactitau con conversion a solo ("dd/MM/yyyy")
                //= db.MostrarPlac();//buscar la plca mediante el primary key

            }
            //cmbMovim.DisplayMember = "Placa";
            msmErP.Text = "NumTicket";
        }
        int va = 1;
        private void descon()
        {
            var x = s.MosDtTari(id);
            if (x != null)
            {
                txtCuposD.Text = x.CuposDIsponibles.ToString();
                //txtCuposD.Text = objo1.Resta(double.Parse(txtCuposD.Text), va).ToString();
            }
        }
            private void limp()
        {

            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtPlacaCli.Clear();
            txtPago1.Clear();
            rdSemana.Checked = false;
            rdQuincena.Checked = false;
            rdMensualidad.Checked = false;
            rdMotoCli.Checked = false;
            rdBiciCli.Checked = false;
            txtPlaca.Clear();
            txtNCascos.Clear();
            rdtMoto.Checked = false;
            rdtBici.Checked = false;
            msmErP.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limp();
        }

        private void btncancIn_Click(object sender, EventArgs e)
        {
            limp();
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere volver a la pantalla de inicio?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void txtBuscarPla_TextChanged(object sender, EventArgs e)
        {

        }
        string ValUnd;
        string CodProd;
        string fech;
        private void EncontarCant()
        {
            fech = db.REtornarFecha(int.Parse(CodProd));
        }
        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if (txtPlaca.Text != "")
            {
                MostrarFecha();
                 var ServicioParqueo = db.ingresoVehiculosm(txtPlaca.Text).Count();
                var Mensualidades = db.ingresoClientesm(txtPlaca.Text).Count();
                if (ServicioParqueo >= 1 || Mensualidades >= 1)
                {
                    if (ServicioParqueo >= 1 && Mensualidades >= 1)
                    {
                        msmErP.ForeColor = Color.Red;
                        msmErP.Text = "Este cliente ya se encunetra \nen el parqueadero";
                        msmErP.Visible = true;
                        btnIngresar.Visible = false;
                    }
                    else if (Mensualidades >= 1)
                    {
                        msmErP.ForeColor = Color.Green;
                        msmErP.Text = "Este cliente cuenta con una \nmensualidad " +
                            "que temina el dia \n" + bFech;
                        msmErP.Visible = true;
                fecPlacaCopi = DateTime.Parse(dtgMovim.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();

                    }
                    else if(ServicioParqueo >= 1)
                    {
                        msmErP.ForeColor = Color.Red;
                        msmErP.Text = "Este vehiculo ya esta en el \nparqueadero";
                        msmErP.Visible = true;
                        btnIngresar.Visible = false;
                    }
                }
                else
                {
                    msmErP.ForeColor = Color.Green;
                    msmErP.Text = "Nuevo cliente";
                    msmErP.Visible = true;
                    btnIngresar.Visible = true;
                }
            }
            else
            {
                msmErP.ForeColor = Color.Red;
                msmErP.Visible = false;
                btnIngresar.Visible = false;
            }
        }

        private void txtPlacaCli_TextChanged(object sender, EventArgs e)
        {
            if (txtPlacaCli.Text != "")
            {
                var x = db.ingresoClientesm(txtPlacaCli.Text);
                if (x.Count() >= 1)
                {
                    msmErPCli.ForeColor = Color.Red;
                    msmErPCli.Text = "El cliente ya se encuentra registrado";
                    msmErPCli.Visible = true;
                    //DateTime FeFin =  DateTime.Today.AddMonths(1);
                    //MessageBox.Show(FeFin.ToShortDateString().ToString());
                }
                else
                {
                    msmErPCli.ForeColor = Color.Green;
                    msmErPCli.Text = "Nuevo cliente";
                    msmErPCli.Visible = true;
                }
            }
            else
            {
                msmErPCli.ForeColor = Color.Red;
                msmErPCli.Visible = false;
            }
        }

        private void txtPago1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.SoloNumeros(e);
        }

        private void txtCuposD_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.SoloNumeros(e);
        }
        int bandera, idUser;

        private void btnGenTick_CheckedChanged(object sender, EventArgs e){        }

        private void btnImpIn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            limp();
            btnIngresar.Visible = true;
            btncancIn.Visible = true;
            btnImpIn.Visible = false;
            printPreviewControl2.Visible = false;

        }

        //        nt segundosTotales;

        //        int dias = segundosTotales / (60 * 60 * 24);
        //        int segundosRestantes = segundosTotales % (60 * 60 * 24);

        //        int horas = segundosRestantes / (60 * 60);
        //        segundosRestantes segundosRestantes % (60 * 60);

        //int minutos = segundosRestantes / 60;
        //        int segundos = segundosRestantes % 60;
        //        int numHoras = 0;
        //        double precioTotal = 0;
        //        numHoras = 7;
        //        prcioTotal = calcularPrecio(numHoras);
        //public static double calcularPrecio(int horas)
        //{
        //    double precio, precioReto;
        //    int restoHoras;
        //    int dias;
        //    if (horas <= 24)
        //    {
        //        if (horas <= 3)
        //        {
        //            precio = horas * 15;
        //        }
        //        else
        //        {
        //            precio = (3 * 20) + ((horas - 3) * 15);
        //            if (precio >= 250)
        //            {
        //                precio = 250;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        dias = horas / 24;
        //        restoHoras = horas % 24;
        //        precioResto = restoHoras * 15;
        //        if (precioResto >= 250)
        //        {
        //            precioResto = 250;
        //        }
        //        precio = dias * 250 + precioResto;
        //    }
        //    return precio;
        //}
        DateTime ahora = DateTime.Now;
        DateTime final;


        int fin;
        string[] fecha = new string[3];

        private void button1_Click(object sender, EventArgs e)
        {

        }

            string plc, fechin, hor;
        private void numplacasal_TextChanged(object sender, EventArgs e)
        {
            var llenartex = db.ingresoVehiculosm(numplacasal.Text).Count();
            foreach (var fato in db.MostrarPlac())
            {
                plc= fato.Placa;
                DateTime.Parse(fechin = fato.Fecha.ToString()).ToShortDateString();
                TimeSpan.Parse(hor = fato.hora.ToString());
                //= db.MostrarPlac();//buscar la plca mediante el primary key
            }
            if (llenartex >= 1)
            {
                txtfeinsal.Text = fechin;
                txtheinsal.Text = hor;
            }
            else
            {
                txtfeinsal.Text = "";
                txtheinsal.Text = "";
            }
        }

        private void diferenciastime()
        {
            foreach (var fato in db.MostrarPlac())
            {
                fin = int.Parse(fato.hora.ToString());
                //= db.MostrarPlac();//buscar la plca mediante el primary key

            }
            DateTime hoy = DateTime.Now;
            string temp = txthrsali.Text;
            fecha = temp.Split(':');
            int año = int.Parse(fecha[0]);
            final = new DateTime(ahora.Year, ahora.Month, ahora.Day, año, int.Parse(fecha[1]), int.Parse(fecha[2]));
            TimeSpan Diferen = new TimeSpan();
            Diferen = TimeSpan.FromHours(fin - int.Parse(txtheinsal.Text.ToString()));
            txtefect.Text = Diferen.Hours + Diferen.Minutes + (Diferen.Seconds + 1).ToString();
        }
        private void ImprimirCopi(object sender, PrintPageEventArgs e)
        {
            foreach (var fato in db.MostrarPlac())
            {
                numTk = fato.NumTicket;
                //= db.MostrarPlac();//buscar la plca mediante el primary key

            }
            //if (btnIngresar == )
            //{
            // Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("Parqueadero ", new Font("Arial", 30), Brushes.Black, 65, 10);//(x,y)x se mueve en horizontal. y en vertical
            e.Graphics.DrawString(nom, new Font("Arial", 30), Brushes.Black, 55, 50);
            e.Graphics.DrawString("No. Ticket: ", new Font("Arial", 30), Brushes.Black, 550, 10);
            e.Graphics.DrawString("" + numTk, new Font("Arial", 30), Brushes.Black, 610, 50);
            e.Graphics.DrawString("Nit: " + nit, new Font("Arial", 30), Brushes.Black, 285, 95);
            e.Graphics.DrawString("Regimen Simplificado", new Font("Arial", 30), Brushes.Black, 200, 130);
            e.Graphics.DrawString("Dirección: " + dir, new Font("Arial", 30), Brushes.Black, 190, 165);
            e.Graphics.DrawString("WhatsApp: " + tel, new Font("Arial", 30), Brushes.Black, 205, 200);
            e.Graphics.DrawString("Numero de la placa: " + PlacaCopi, new Font("Arial", 40), Brushes.Black, 0, 235);
            e.Graphics.DrawString("Tipo de vehículo: " + tipoVeh, new Font("Arial", 30), Brushes.Black, 0, 290);
            e.Graphics.DrawString("Numero de cascos: " + CascosCopi, new Font("Arial", 30), Brushes.Black, 0, 325);
            e.Graphics.DrawString("Fecha de ingreso: " + fecPlacaCopi, new Font("Arial", 30), Brushes.Black, 0, 360);
            e.Graphics.DrawString("Hora de ingreso: " + HoraPlacaCopi, new Font("Arial", 30), Brushes.Black, 0, 395);
            e.Graphics.DrawString("Software: Sw Parking Gold", new Font("Arial", 30), Brushes.DarkGoldenrod, 160, 435);
            e.Graphics.DrawString("REGLAMENTO", new Font("Arial", 30), Brushes.Red, 240, 470);
            e.Graphics.DrawString("El Vehículo se entregará al portador del recibo. \n" +
                "No aceptamos órdenes telefónicas, Retirado el \nautomotor " +
                "no se aceptan reclamos de ningún tipo.", new Font("Arial", 25), Brushes.Black, 10, 505);
            e.Graphics.DrawString("ACTUAR CON MAS \nRESPONSABILIDAD", new Font("Arial", 30), Brushes.Red, 170, 620);
        }
        private void impCopi()
        {
            //printDialog1.ShowDialog();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += ImprimirCopi;
            printPreviewControl3.Document = printDocument1;

        }
        string tipoVeh,PlacaCopi, fecPlacaCopi,HoraPlacaCopi, CascosCopi;
     
        private void btnGenTic_Click(object sender, EventArgs e)
        {
            try
            {
                idUser = int.Parse(dtgMovim.CurrentRow.Cells[0].Value.ToString());
                tipoVeh = dtgMovim.CurrentRow.Cells[1].Value.ToString();
                PlacaCopi = dtgMovim.CurrentRow.Cells[2].Value.ToString();
                CascosCopi = dtgMovim.CurrentRow.Cells[3].Value.ToString();
                fecPlacaCopi = DateTime.Parse(dtgMovim.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();
                HoraPlacaCopi = dtgMovim.CurrentRow.Cells[6].Value.ToString();
                impCopi();
                printPreviewControl3.Visible = true;
                //  //txtCor.Text = dtgMovim.CurrentRow.Cells[5].Value.ToString();
                //  //txtLog.Text = dtgMovim.CurrentRow.Cells[5].Value.ToString();
                //  //cmbTipo.Text = dtgMovim.CurrentRow.Cells[6].Value.ToString();
                //  tabContPrimc.SelectTab(3);
                ////  diferenciastime();
                btnGenTic.Visible = false;
                brnImpCopi.Visible = true;

            }
            catch
            { 
                MessageBox.Show("seleccione una placa");
            }
        }
        private void brnImpCopi_Click(object sender, EventArgs e)
        {
                printDocument1.Print();
            btnGenTic.Visible = true;
            brnImpCopi.Visible = false;
            printPreviewControl3.Visible = false;
        }
        private void Mostrartabla()
        {
            dtgMovim.DataSource = db.ingresoVehiculosm(txtBuscarPla.Text.ToString());//buscar la paca por escrito
            dtgMovim.Columns[0].Visible = false;
            dtgMovim.Columns[1].HeaderText = "Vehiculo";
            dtgMovim.Columns[3].HeaderText = "Cascos";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrartabla();
        }
        }
    } 

