using Diseño.BaseD;
using Diseño.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Vista
{
    public partial class FrmInforma : Form
    {
        public FrmInforma()
        {
            InitializeComponent();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRes_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInforma_Load(object sender, EventArgs e)
        {
           llenar();
            llenarTari();
        }
        private void llenar()
        {
            parkEntities f = new parkEntities()
;            if (f.confi != null)
            {
            buscaid();
            }
            else
            {
                BtnGuarInfo.Visible = true;
                btnModInfo.Visible = false;
            }
        }
        private void llenarTari()
        {
            parkEntities f = new parkEntities();
            if (f.tari != null)
            {
                buscaidTari();
            }
            else
            {
                btnGuarTari.Visible = true;
                btnModiTari.Visible = false;
            }
        }
        private void info()
        {
            s.GuardarInfo(txtNom.Text, txtNit.Text,
                int.Parse(txtTel.Text), txtDir.Text, txtCorreo.Text, txtHorATenc.Text);
            MessageBox.Show("Dato ingresado");
        }
        int id =1;
        private void buscaid()
        {
            var x = s.MosDtConfi(id);
            if (x != null)
            {
                txtNom.Text = x.NombreParqueadero.ToString();
                txtNit.Text = x.Nit.ToString();
                txtTel.Text = x.Telefono.ToString();
                txtDir.Text = x.Direccion.ToString();
                txtCorreo.Text = x.Correo.ToString();
                txtHorATenc.Text = x.HorarioAtencion.ToString();
                BtnGuarInfo.Visible = false;
                btnModInfo.Visible = true;
                btnCanInfo.Visible = true;
            }

        }
        private void buscaidTari()
        {
            var x = s.MosDtTari(id);
            if (x != null)
            {
                txtHrM.Text = x.HoraEstacioMoto.ToString();
                txtSmM.Text = x.SemanaEstacioMoto.ToString();
                txtQnM.Text = x.QuincenaEstacioMoto.ToString();
                txtMsM.Text = x.MensualidadEstacioMoto.ToString();
                txtHrB.Text = x.HoraEstacioBici.ToString();
                txtSmB.Text = x.SemanaEstacioBici.ToString();
                txtQnB.Text = x.QuincenaEstacioBici.ToString();
                txtMsB.Text = x.MensualidadEstacioBici.ToString();
                txtCupos.Text = x.CuposDIsponibles.ToString();
                btnGuarTari.Visible = false;
                btnModiTari.Visible = true;
                btnCanTari.Visible = true;
            }

        }
        private void btnModInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuarInfo_Click(object sender, EventArgs e)
        {

            try
            {
                info();
                MessageBox.Show("Dato ingresado");
            }
            catch
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void btnCanInfo_Click(object sender, EventArgs e)
        {
            buscaid();
        }
        private void btnCanTari_Click(object sender, EventArgs e)
        {
            buscaidTari();
        }
        Cruts s = new Cruts();
        private void infoTarifas()
        {
            s.GuardarInfoTarifas(DateTime.Parse(lblFecha.Text), decimal.Parse(txtHrM.Text), decimal.Parse(txtSmM.Text), decimal.Parse(txtQnM.Text),
                decimal.Parse(txtMsM.Text), decimal.Parse(txtHrB.Text), decimal.Parse(txtSmB.Text), decimal.Parse(txtQnB.Text), decimal.Parse(txtMsB.Text), int.Parse(txtCupos.Text));
        }
        private void btnModiTari_Click(object sender, EventArgs e)
        {

        }

        private void btnGuarTari_Click(object sender, EventArgs e)
        {
            try
            {
                infoTarifas();
                MessageBox.Show("Dato ingresado");
            }
            catch
            {
                MessageBox.Show("Algo salio mal");
            }
        }

    }
}
