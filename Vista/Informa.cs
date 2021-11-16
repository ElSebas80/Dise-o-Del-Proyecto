using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.BaseD;
using Diseño.Datos;

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

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
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
        Cruts s = new Cruts();
        private void info()
        {
            s.GuardarInfo(txtNom.Text, txtNit.Text,
                int.Parse(txtTel.Text), txtDir.Text, txtCorreo.Text, txtHorATenc.Text);
            MessageBox.Show("Dato ingresado");
        }
        parkEntities1 bd = new parkEntities1();
        private void btnGuar_Click(object sender, EventArgs e)
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
        private void infoTarifas()
        {
            s.GuardarInfoTarifas(DateTime.Parse(lblFecha.Text), decimal.Parse(txtHrM.Text), decimal.Parse(txtSmM.Text), decimal.Parse(txtQnM.Text),
                decimal.Parse(txtMsM.Text), decimal.Parse(txtHrB.Text), decimal.Parse(txtSmB.Text), decimal.Parse(txtQnB.Text), decimal.Parse(txtMsB.Text), int.Parse(txtCupos.Text));
        }
        private void btnGuarda_Click(object sender, EventArgs e)
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
