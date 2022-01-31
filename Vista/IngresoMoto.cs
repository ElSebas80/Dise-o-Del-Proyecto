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
            }
            else if (rdQuincena.Checked == true)
            {
                MEnsuCLi = "Quincenal";
            }
            else if (rdMensualidad.Checked == true)
            {
                MEnsuCLi = "Mensual";
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {            
            EstD();
            ingresarVehiculo();
            MessageBox.Show("Vehiculo ingresado");
            db.ActualizarCanti(va, int.Parse(txtCuposD.Text));
            limp();
            }
            catch
            {
                MessageBox.Show("Revise nuevamente puede haber un campo vacio");
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblhoraCLi.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfechaCli.Text = DateTime.Now.ToShortDateString();
            buscaidTari();
            descon();
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
        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
            TipoVhculo();
            mensualid();
            if (MessageBox.Show("Seguro que quiere registrar este cliente?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                bd.RegistrarClientes(txtNombre.Text, int.Parse(txtCedula.Text), int.Parse(txtTelefono.Text), txtPlacaCli.Text.Trim(),
                 TpVhCli, MEnsuCLi, Decimal.Parse(txtPago1.Text), DateTime.Parse(lblfechaCli.Text), TimeSpan.Parse(lblhoraCLi.Text));
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

        parkEntities Pla = new parkEntities();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(numplacasal.Text, new Font("Arial", 100), Brushes.Blue, 10, 10);
            e.Graphics.DrawString(txtfeinsal.Text, new Font("Arial", 100), Brushes.Blue, 10, 130);
            e.Graphics.DrawString(txtheinsal.Text, new Font("Arial", 100), Brushes.Blue, 10, 250);
            e.Graphics.DrawString(txtfcsali.Text, new Font("Arial", 100), Brushes.Blue, 10, 370);
            e.Graphics.DrawString(txthrsali.Text, new Font("Arial", 100), Brushes.Blue, 10, 490);
            e.Graphics.DrawString(txtvalpago.Text, new Font("Arial", 100), Brushes.Blue, 10, 610);
            e.Graphics.DrawString(txtefect.Text, new Font("Arial", 100), Brushes.Blue, 10, 730);
            e.Graphics.DrawString(txtcambefect.Text, new Font("Arial", 100), Brushes.Blue, 10, 850);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        string Producto1;
        private void cmbMovim_SelectedValueChanged(object sender, EventArgs e)
        {
           // Producto1 = cmbMovim.SelectedValue.ToString();
        }
        Cruts db = new Cruts();
        private void MostrarPlaca()
        {
            //cmbMovim.DataSource = db.MostrarPlac();//buscar la plca mediante el primary key
            //cmbMovim.DisplayMember = "Placa";
            //cmbMovim.ValueMember = "NumTicket";
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

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if (txtPlaca.Text != "")
            {
                var x = db.ingresoVehiculosm(txtPlaca.Text);
                var s = db.ingresoClientesm(txtPlaca.Text);
                if (x.Count() >= 1 != s.Count() >= 1)
                {
                    if (s.Count() >= 1)
                    {
                        msmErP.ForeColor = Color.Green;
                        msmErP.Text = "este cliente cuenta con una mensualidad";
                        msmErP.Visible = true;
                    }
                    else if(x.Count() >= 1)
                    {
                        msmErP.ForeColor = Color.Red;
                        msmErP.Text = "Este vehiculo ya esta en el parqueadero";
                        msmErP.Visible = true;
                    }
                }
                else
                {
                    msmErP.ForeColor = Color.Green;
                    msmErP.Text = "nuevo cliente";
                    msmErP.Visible = true;
                }
            }
            else
            {
                msmErP.ForeColor = Color.Red;
                msmErP.Visible = false;
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
                    msmErPCli.Text = "Este vehiculo ya \nesta en el parqueadero";
                    msmErPCli.Visible = true;
                }
                else
                {
                    msmErPCli.ForeColor = Color.Green;
                    msmErPCli.Text = "nuevo cliente";
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

