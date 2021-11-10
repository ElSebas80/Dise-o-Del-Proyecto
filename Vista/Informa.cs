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
                int.Parse(txtTel.Text), txtDir.Text, txtCorreo.Text, txtHor.Text);
        }
        parkEntities1 bd = new parkEntities1();
        private void btnGuar_Click(object sender, EventArgs e)
        {

        }
    }
}
