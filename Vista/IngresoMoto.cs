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
            comb();
        }
        private void dtg()
        {
            dtgMovim.DataSource = bd.MostrarPlac();

            dtgMovim.Columns[0].Visible = false;
            //   dtgMovim.DataSource = bd.mostardtg();
            dtgMovim.Columns[4].Visible = false;
            dtgMovim.Columns[1].HeaderText = "Vehiculo";
            dtgMovim.Columns[3].HeaderText = "Cascos";
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
            e.Graphics.DrawString("Número de la placa: " + txtPlaca.Text, new Font("Arial", 40), Brushes.Black, 0, 235);
            e.Graphics.DrawString("Tipo de vehículo: " + tVhlO, new Font("Arial", 30), Brushes.Black,0, 290);
            e.Graphics.DrawString("Número de cascos: " + txtNCascos.Text, new Font("Arial", 30), Brushes.Black,0, 325);
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
                comb();
                impriingre();
                printPreviewControl2.Visible = true;
                rdtMoto.Checked = true;
            }
            else
            {
                MessageBox.Show("Revise nuevamente puede haber un campo vacio");
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhoraCLi.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfechaCli.Text = DateTime.Now.ToShortDateString();
            txthrsali.Text = DateTime.Now.ToString("HH:mm:ss");
            txtfcsali.Text = DateTime.Now.ToShortDateString()/* +" "+ DateTime.Now.ToString("hh:mm:ss")*/;
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
        int idt = 1;
        double hm,dm,sm,qm,mm,hb,dib,sb,qb,mb;
        double hg,hsg;
        private void calcuHora()
        {
            var x = s.MosDtTari(idt);
            if (x != null)
            {
                hm = double.Parse(x.HoraEstacioMoto.ToString());
                dm = double.Parse(x.DiaEstacioMoto.ToString()); 
                sm = double.Parse(x.SemanaEstacioMoto.ToString());
                qm = double.Parse(x.QuincenaEstacioMoto.ToString());
                mm = double.Parse(x.MensualidadEstacioMoto.ToString());
                hb = double.Parse(x.HoraEstacioBici.ToString());
                dib = double.Parse(x.DiaEstacioBici.ToString());
                sb = double.Parse(x.SemanaEstacioBici.ToString());
                qb = double.Parse(x.QuincenaEstacioBici.ToString());
                mb = double.Parse(x.MensualidadEstacioBici.ToString());

            }
            if (txtheinsal.Text != "" && txthrsali.Text != "")
            {
                TimeSpan Hentrada = TimeSpan.Parse(txtheinsal.Text);
                TimeSpan Hsalida = TimeSpan.Parse(txthrsali.Text);
                DateTime fentrada = DateTime.Parse(txtfeinsal.Text);
                DateTime fsalida = DateTime.Parse(txtfcsali.Text);
       
        
                TimeSpan span = Hsalida.Subtract(Hentrada);
                TimeSpan spand = fsalida.Subtract(fentrada);
                int prueba = Convert.ToInt32(span.TotalHours);
                int pruebad = Convert.ToInt32(spand.TotalHours);
                // MessageBox.Show(RESF.ToString("dd ")+"\n"+ RESH.ToString());
                var valiMensualidad = db.ingresoClientesm(txtplacasali.Text).Count();
                foreach (var fato in db.ingresoClientesm(txtplacasali.Text))
                {
                    Fechms = DateTime.Parse(fato.FechaFin.ToString()).ToShortDateString();//mostrar la fecha con esactitau con conversion a solo ("dd/MM/yyyy")
                                                                                         //= db.MostrarPlac();//buscar la plca mediante el primary key
                }
                if (valiMensualidad >= 1 && DateTime.Parse(Fechms) > fsalida)
                {
                    txtvalpago.Text = "0";
                    txtefect.Text = "0";
                }
                else if (Convert.ToDouble(prueba) < 24 && Convert.ToDouble(pruebad) <= 48)
                {
                    hg = hm * prueba +(hm*pruebad);
                    txtvalpago.Text = Convert.ToString(hg);
                } //else if (Convert.ToDouble(prueba) <= 1440)
                //{
                //    int hrs = prueba / 60;
                //    hg = (hm * hrs);
                //    txtvalpago.Text = Convert.ToString(hg);
                //}
            }
            
        }
       
           
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtefect.Text != "")
            {
            comb();
            impAdios();
            SalidaVehiculos();
            printPreviewControl1.Visible = true;
            //calcuHora();
            button6.Visible = false;
            btnimpriAdios.Visible = true;
            db.ActualizarCantim(va, int.Parse(txtCuposD.Text));
            db.EliminarDtProductos(txtplacasali.Text);
            dtg();
            }
            else { MessageBox.Show("Llenar la caja de texto vacia por favor"); }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        string bFech, Fechms;
        private void cmbMovim_SelectedValueChanged(object sender, EventArgs e)
        {
           // Producto1 = cmbMovim.SelectedValue.ToString();
        }
        Cruts db = new Cruts();
        private void MostrarFecha()
        {
            foreach(var fato in db.ingresoClientesm(txtPlaca.Text))
            {
                bFech = DateTime.Parse(fato.FechaFin.ToString()).ToShortDateString();//mostrar la fecha con esactitau con conversion a solo ("dd/MM/yyyy")
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
            rdMotoCli.Checked = true;
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
            rdtMoto.Checked = true;
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
                        btnIngresar.Visible = true;
             //   fecPlacaCopi = DateTime.Parse(dtgMovim.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();

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
                    btnRegis.Visible = false;
                    //DateTime FeFin =  DateTime.Today.AddMonths(1);
                    //MessageBox.Show(FeFin.ToShortDateString().ToString());
                }
                else
                {
                    msmErPCli.ForeColor = Color.Green;
                    msmErPCli.Text = "Nuevo cliente";
                    msmErPCli.Visible = true;
                    btnRegis.Visible = true;
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
        double pg;
        private void txtefect_TextChanged(object sender, EventArgs e)
        {
            if (txtvalpago.Text != "" && txtefect.Text != "")
            {
                pg = double.Parse(txtvalpago.Text);
                txtcambefect.Text = (double.Parse(txtefect.Text) - pg).ToString();
            }
            else
            {
                txtefect.Text = "";
            }
        }
            
        private void ImprimirAdios(object sender, PrintPageEventArgs e)
        {
            //if (btnIngresar == )
            //{
            // Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            e.Graphics.DrawString("Parqueadero ", new Font("Arial", 30), Brushes.Black, 65, 10);//(x,y)x se mueve en horizontal. y en vertical
            e.Graphics.DrawString(nom, new Font("Arial", 30), Brushes.Black, 55, 50);
            e.Graphics.DrawString("No. Ticket: ", new Font("Arial", 30), Brushes.Black, 550, 10);
            e.Graphics.DrawString("" + numTksal, new Font("Arial", 30), Brushes.Black, 610, 50);
            e.Graphics.DrawString("Nit: " + nit, new Font("Arial", 30), Brushes.Black, 285, 95);
            e.Graphics.DrawString("Regimen Simplificado", new Font("Arial", 30), Brushes.Black, 200, 130);
            e.Graphics.DrawString("Dirección: " + dir, new Font("Arial", 30), Brushes.Black, 190, 165);
            e.Graphics.DrawString("WhatsApp: " + tel, new Font("Arial", 30), Brushes.Black, 205, 200);
            e.Graphics.DrawString("Número de la placa: " + Placasal, new Font("Arial", 40), Brushes.Black, 0, 235);
            e.Graphics.DrawString("Tipo de vehículo: " + tipoVehsal, new Font("Arial", 30), Brushes.Black, 0, 290);
            e.Graphics.DrawString("Número de cascos: " + Cascossal, new Font("Arial", 30), Brushes.Black, 0, 325);
            e.Graphics.DrawString("Fecha de ingreso: " + txtfeinsal.Text, new Font("Arial", 30), Brushes.Black, 0, 360);
            e.Graphics.DrawString("Hora de ingreso: " + txtheinsal.Text, new Font("Arial", 30), Brushes.Black, 0, 395);
            e.Graphics.DrawString("Fecha de salida: " + txtfcsali.Text, new Font("Arial", 30), Brushes.Black, 0, 430);
            e.Graphics.DrawString("Hora de salida: " + txthrsali.Text, new Font("Arial", 30), Brushes.Black, 0, 465);
            e.Graphics.DrawString("Valor a pagar: " + txtvalpago.Text, new Font("Arial", 30), Brushes.Black, 0, 500);
            e.Graphics.DrawString("Efectivo recibido: " + txtefect.Text, new Font("Arial", 30), Brushes.Black, 0, 535);
            e.Graphics.DrawString("Cambio: " + txtcambefect.Text, new Font("Arial", 30), Brushes.Black, 0, 570);
            e.Graphics.DrawString("Software: Sw Parking Gold", new Font("Arial", 30), Brushes.DarkGoldenrod, 150, 605);
            e.Graphics.DrawString("Gracias vuelva pronto", new Font("Arial", 30), Brushes.Red, 180, 640);

        }
        private void SalidaVehiculos()
        {
            db.GuardSali(tipoVehsal, Placasal, Cascossal, DateTime.Parse(txtfeinsal.Text), 
                TimeSpan.Parse(txtheinsal.Text), DateTime.Parse(txtfcsali.Text), TimeSpan.Parse(txthrsali.Text),  
                decimal.Parse(txtvalpago.Text), decimal.Parse(txtefect.Text), decimal.Parse(txtcambefect.Text));
        }
        private void impAdios()
        {
            //printDialog1.ShowDialog();
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += ImprimirAdios;
            printPreviewControl1.Document = printDocument1;

        }
        private void btnimpriAdios_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            button6.Visible = true;
            btnimpriAdios.Visible = false;
            printPreviewControl1.Visible = false;
            comb();
            txtvalpago.Clear();
            txtefect.Clear();
            txtcambefect.Clear();
            txtheinsal.Clear();
            txtfeinsal.Clear();
            txtplacasali.Clear();
        }

        private void txtefect_Leave(object sender, EventArgs e)
        {

        }

        private void txtefect_Enter(object sender, EventArgs e)
        {
        }

        private void txtheinsal_TextChanged(object sender, EventArgs e)
        {
            calcuHora();
        }

        private void txtefect_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.SoloNumeros(e);
        }

        private void tabContPrimc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenTick_CheckedChanged(object sender, EventArgs e){        }
        private void impriingre()
        {
            printDocument1.Print();
            btnIngresar.Visible = true;
            btncancIn.Visible = true;
            printPreviewControl2.Visible = false;
            limp();

        }
            

        private void txtBuscarPla_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtvalpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgMovim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclientesd_Click(object sender, EventArgs e)
        {
            dtg();
        }

        private void btnclientescon_Click(object sender, EventArgs e)
        {
            dtgMovim.DataSource = bd.mostardtg();
            //dtgMovim.Columns[0].Visible = false;
            //dtgMovim.Columns[4].Visible = false;
            //dtgMovim.Columns[6].Visible = false;
            //dtgMovim.Columns[6].Visible = false;
            //dtgMovim.Columns[9].Visible = false;
            // dtgMovim.Columns[1].HeaderText = "Vehiculo"; 


        }

        private void btnrecargar_Click(object sender, EventArgs e)
        {
            dtg();
        }

        private void txtplacasali_TextChanged(object sender, EventArgs e)
        {

            foreach (var fato in db.ingresoVehiculosm(txtplacasali.Text))
            {
                fechin = DateTime.Parse(fato.Fecha.ToString()).ToShortDateString();//mostrar la fecha con esactitau con conversion a solo ("dd/MM/yyyy")
                TimeSpan.Parse(hor = fato.hora.ToString());
            }
            if (txtplacasali.Text != "")
            {
                txtfeinsal.Text = fechin/* +" "+ hor*/;
                txtheinsal.Text = hor;
            }
            else
            {
                txtfeinsal.Text = "";
                txtheinsal.Text = "";
                txtvalpago.Text = "";
            }
        }
        private void btnImpIn_Click(object sender, EventArgs e)
        {
        }
         string[] fecha = new string[3];
         int fin, numTksal;
         string plc, fechin, hor;
         string Placasal, Cascossal, tipoVehsal;
        private void comb()
        {

            foreach (var fato in db.ingresoVehiculosm(txtplacasali.Text))
            {
                //cmbplaca.DataSource = db.MostrarPlac();//buscar la plca mediante el primary key
                //cmbplaca.DisplayMember = "Placa";
                //cmbplaca.ValueMember = "NumTicket"; 
                numTksal = fato.NumTicket;
                Placasal = fato.Placa;
                Cascossal = fato.NumCascos;
                tipoVehsal = fato.tipoVhlo;
                //DateTime.Parse(fechin = fato.Fecha.ToString()).ToShortDateString();
                //TimeSpan.Parse(hor = fato.hora.ToString());
                //fechin = fato.Fecha;
                //hor = fato.hora;
            }
        }
        private void cmbplaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbMovim.DisplayMember = "Placa";
           // msmErP.Text = "NumTicket";
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
            e.Graphics.DrawString("Número de la placa: " + PlacaCopi, new Font("Arial", 40), Brushes.Black, 0, 235);
            e.Graphics.DrawString("Tipo de vehículo: " + tipoVeh, new Font("Arial", 30), Brushes.Black, 0, 290);
            e.Graphics.DrawString("Número de cascos: " + CascosCopi, new Font("Arial", 30), Brushes.Black, 0, 325);
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
                imprimicopi();
                dtg();
                //txtCor.Text = dtgMovim.CurrentRow.Cells[5].Value.ToString();
                //txtLog.Text = dtgMovim.CurrentRow.Cells[5].Value.ToString();
                //cmbTipo.Text = dtgMovim.CurrentRow.Cells[6].Value.ToString();
                //tabContPrimc.SelectTab(3);
                //diferenciastime();
            }
            catch
            { 
                MessageBox.Show("seleccione una placa");
            }
        }
        private void imprimicopi()
        {
            printDocument1.Print();
            btnGenTic.Visible = true;
            printPreviewControl3.Visible = false;
        }
        private void brnImpCopi_Click(object sender, EventArgs e)
        {
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
            if (txtBuscarPla.Text != "")
            {
            Mostrartabla();
            txtBuscarPla.Text = "";
            }
            else
            {
                dtg();
            }
        }
    }
} 

