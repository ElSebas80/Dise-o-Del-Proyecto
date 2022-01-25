using Diseño.BaseD;
using Diseño.Datos;
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
            if (MessageBox.Show("Seguro que quiere volver a la pantalla de inicio?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            

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
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                EstD();
                ingresarVehiculo();
                MessageBox.Show("Vehiculo ingresado");
            }
            catch
            {
                MessageBox.Show("Un campo vacio");
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblhoraCLi.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfechaCli.Text = DateTime.Now.ToShortDateString();

        }
        //modulo de clientes
        string TpVhCli,MEnsuCLi,pago;
        private void TipoVhculo()
        {
            if (rdMotoCli.Checked == true)
                TpVhCli = "Moto";
            else if (rdBiciCli.Checked == true)
                TpVhCli = "Bicicleta";
        }
        private void mensualid()
        {
            if (rdSemana.Checked == true)
            {
                MEnsuCLi = "Semanal";
                pago = "30000";
                txtPago.Text = pago;
            }
            else if (rdQuincena.Checked == true)
            {
                MEnsuCLi = "Quincenal";
                pago = "45000";
                txtPago.Text = pago;
            }
            else if (rdMensualidad.Checked == true)
            {
                MEnsuCLi = "Mensual";
                pago = "60000";
                txtPago.Text = pago;
            }
        }
        private void btnRegis_Click(object sender, EventArgs e)
        {
            TipoVhculo();
            mensualid();
            if (MessageBox.Show("Seguro que quiere registrar este cliente?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            bd.RegistrarClientes(txtNombre.Text, int.Parse(txtCedula.Text), int.Parse(txtTelefono.Text), txtPlacaCli.Text.Trim(),
             TpVhCli, MEnsuCLi, Decimal.Parse(txtPago.Text), DateTime.Parse(lblfechaCli.Text), TimeSpan.Parse(lblhoraCLi.Text));
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

            parkEntities Pla = new parkEntities();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //printDocument1 = new System.Drawing.Printing.PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += Imprimir;
            //printDocument1.Print(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (true)
            {
            }
            else
            {
                MessageBox.Show("Esta placa no esta registrada");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
