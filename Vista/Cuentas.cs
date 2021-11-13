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
    //public partial class dusuario
    //{
    //    public string nombre { get; set; }
    //    public string nombre { get; set; }
    //    public string nombre { get; set; }
    //    public string nombre { get; set; }
    //    public string nombre { get; set; }
    //    public string nombre { get; set; }
    //}
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
        int estd,tipoUser;
        private void tip()
        {
            if (txtTipo.Text == "Administrador")
                tipoUser = 1;
            else if (txtTipo.Text == "Empleado")
                tipoUser = 2;
        }
          
        private void EstD()
        {
            if (btnHabl.Checked == true)
                estd = 1;
            else if (btnDesh.Checked == true)
                estd = 2;
        }
        private void guar()
        {
            s.GuardarUser(txtNom.Text,int.Parse(txtCed.Text),txtDir.Text, txtCor.Text,
                txtLog.Text, contra, txtTipo.Text, estd);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tip();
            EstD();
            guar();
            Contr();
        }
        private void Contr()
        {
            ClsRecuperarpasss em = new ClsRecuperarpasss();
            ClsRecuperarpasss cahs = new ClsRecuperarpasss();
                cahs.Enviarpasss(txtLog.Text);
                MessageBox.Show("Nuevo usuario creado correctamente La contraseña asignada fue enviada al " +
                "correo correspondiente a " + txtCor.Text);
            //var verificado = em.mail(txtCor.Text.Trim());+
            //if (verificado != null)
            //{
            //}
            //else
            //{
            //    MessageBox.Show("Correo incorrecto o no exixtente");
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {        }
    }
}
