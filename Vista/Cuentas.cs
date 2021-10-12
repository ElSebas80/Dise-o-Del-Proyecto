using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.Datos;
using Diseño.Datos.Logn;

namespace Diseño.Vista
{
    public partial class FrmCuentas : Form
    {
        public FrmCuentas()
        {
            InitializeComponent();
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
        Cruts s = new Cruts();
        string contra="123";
        private void guar()
        {
            s.GuardarUser(int.Parse(txtId.Text), txtLog.Text,
                contra, txtNom.Text, int.Parse(txtCed.Text), txtCor.Text);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guar();
            Contr();
        }
        private void Contr()
        {
            ClsRecuperarpasss em = new ClsRecuperarpasss();
            ClsRecuperarpasss cahs = new ClsRecuperarpasss();
            var verificado = em.mail(txtCor.Text.Trim());
            if (verificado != null)
            {
                cahs.Enviarpasss(txtCor.Text);
                MessageBox.Show("Nuevo usuario creado correctamente La contraseña asignada fue enviada al " +
                "correo de entrada en " + txtCor.Text);
            }
            else
            {
                MessageBox.Show("Correo incorrecto o no exixtente");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {        }
    }
}
