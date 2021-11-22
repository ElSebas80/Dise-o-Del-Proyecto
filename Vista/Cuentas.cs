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
using Diseño.Datos.Logn;
using Diseño.Datos.ValidacionCampos;

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
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Cruts s = new Cruts();
        string contra="123";
        int estd,tipoUser;
        
          
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
                txtLog.Text, contra, cmbTipo.Text, estd);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EstD();
                guar();
                Contr();
                Mostrartabla();
            }
            catch 
            {
                MessageBox.Show("Algo saliio mal");
            }
           
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
        private void Mostrartabla()
        {
            using (parkEntities1 mos = new parkEntities1())
            {
                dtgUsuarios.DataSource = mos.CuentasUsuario.ToList();
                dtgUsuarios.Columns[0].Visible = false;
                dtgUsuarios.Columns[6].Visible = false;
            }
        }
        private void btnCons_Click(object sender, EventArgs e)
        {
            Mostrartabla();
        }
        int idUser, bandera;
        private void dtgUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
            idUser=int.Parse(dtgUsuarios.CurrentRow.Cells[0].Value.ToString());
            txtNom.Text = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtCed.Text = dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDir.Text = dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtCor.Text = dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtLog.Text = dtgUsuarios.CurrentRow.Cells[5].Value.ToString();
            cmbTipo.Text = dtgUsuarios.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {

            }
        }

        private void txtCed_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtgUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.SoloLetras(e);
        }

        private void txtCed_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.SoloNumeros(e);
        }

        private void txtLog_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                msgError.Visible = true;
                msgError.Text = ("El campo correo esta vacio");
                msgError.ForeColor = Color.Red;
            }
            else if (valid.validarEmail(txtCor.Text))
            {
                msgError.Visible = true;
                msgError.Text = ("El campo correo si corresponde");
                msgError.ForeColor = Color.Green;
            }
            else
            {
                msgError.Visible = true;
                msgError.Text=("El campo no correspon a un correo electronico");
                msgError.ForeColor = Color.Red;
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            vistas();
            Mostrartabla();
        }
        private void cargarD()
        {
            if (txtNom.Text == "" || txtCed.Text == "" || txtDir.Text == "" || txtCor.Text == "" || txtLog.Text == "")
	        {
                lblPrs.Text = "Datos Personales";
                txtNom.Text = clsDatosUser.nombre;
                txtCed.Text = clsDatosUser.cedula;
                txtDir.Text = clsDatosUser.dirrecion;
                txtCor.Text = clsDatosUser.correo; 
                txtLog.Text = clsDatosUser.login;
            }

        }
        private void vistas()
        {
            if(clsDatosUser.roles != "Administrador")
            {
                btnCamb.Visible = true;
                btnActualizarP.Visible = true;
                btnActualizar.Visible = false;
                btnEditar.Visible = false;
                btnCrear.Visible = false;
                btnEdiPf.Visible = false;
                groupBox.Visible = false;
                btnGuardar.Visible = false;
                dtgUsuarios.Visible = false;
                lblContra.Visible = true;
                txtContra.Visible = true;
                LugarPerf(); 
                cargarD();
            }
            else
            {
                btnCamb.Visible = false;
                btnActualizarP.Visible = false;
                bandera = 2;
                lblPrs.Text = "Creacion de Usuarios";
                btnEditar.Visible = true;
                btnCrear.Visible = false;
                groupBox.Visible = true;
                dtgUsuarios.Visible = true;
                btnActualizar.Visible = false;
                lblContra.Visible = false;
                txtContra.Visible = false;
                LugarOrig();
            }
        }
        private void LugarOrig()
        {
            txtNom.Location = new Point(195, 93);
            lblNom.Location = new Point(56, 93);
            txtCed.Location = new Point(119, 129);
            lblCed.Location = new Point(56, 130);
            txtDir.Location = new Point(333, 133);
            lblDir.Location = new Point(253, 133);
            txtLog.Location = new Point(119, 177);
            lblLog.Location = new Point(56, 177);
            txtCor.Location = new Point(333, 180);
            lblCorreo.Location = new Point(253, 181);
            msgError.Location = new Point(331, 203);
            groupBox.Location = new Point(59, 222);
            dtgUsuarios.Location = new Point(59, 329);
        }
        private void LugarPerf()
        {
            txtNom.Location = new Point(299, 113);
            lblNom.Location = new Point(143, 114);
            txtCed.Location = new Point(299, 169);
            lblCed.Location = new Point(143, 169);
            txtDir.Location = new Point(299, 222);
            lblDir.Location = new Point(143, 222);
            txtLog.Location = new Point(299, 278);
            lblLog.Location = new Point(143, 278);
            txtCor.Location = new Point(299, 336);
            lblCorreo.Location = new Point(143, 336);
            msgError.Location = new Point(296, 359); 
            groupBox.Location = new Point(59, 222);
            dtgUsuarios.Location = new Point(59, 329);
            lblContra.Location = new Point(143, 398);
            txtContra.Location = new Point(299, 398);
        }
        private void Limpiar()
        {
            txtNom.Clear();
            txtCed.Clear();
            txtDir.Clear();
            txtLog.Clear();
            txtCor.Clear();
        }
        private void btnCanc_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bandera = 1;
            if (clsDatosUser.roles == "Administrador")
            {
                btnCamb.Visible = false;
                btnActualizarP.Visible = false;
                msgError.Visible = false;
                btnEdiPf.Visible = true;
                lblPrs.Text = "Cuentas de Usuarios";
                Limpiar();
                Mostrartabla();
                btnEditar.Visible = false;
                btnCrear.Visible = true;
                txtNom.Visible = true;
                txtNom.Enabled = false;
                txtCed.Visible = true;
                txtCed.Enabled = false;
                txtDir.Visible = true;
                txtDir.Enabled = false;
                txtLog.Visible = true;
                txtLog.Enabled = false;
                txtCor.Visible = true;
                txtCor.Enabled = false;
                lblContra.Visible = false;
                txtContra.Visible = false;
                groupBox.Visible = true;
                dtgUsuarios.Visible = true;
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                LugarOrig();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            btnCamb.Visible = false;
            msgError.Visible = false;
            bandera = 2;
            lblPrs.Text = "Creacion de Usuarios";
            Limpiar();
            btnEdiPf.Visible = true;
            btnEditar.Visible = true;
            btnCrear.Visible = false;
            txtNom.Visible = true;
            txtNom.Enabled = true;
            txtCed.Visible = true;
            txtCed.Enabled = true;
            txtDir.Visible = true;
            txtDir.Enabled = true;
            txtLog.Visible = true;
            txtLog.Enabled = true;
            txtCor.Visible = true;
            txtCor.Enabled = true;
            groupBox.Visible = true;
            lblContra.Visible = false;
            txtContra.Visible = false;
            dtgUsuarios.Visible = true;
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
            LugarOrig();
        }

        private void btnEdiPf_Click(object sender, EventArgs e)
        {
            btnCamb.Visible = true;
            btnActualizar.Visible = false;
            btnActualizarP.Visible = true;
            msgError.Visible = false;
            lblPrs.Text = "Datos Personales";
            btnEdiPf.Visible = false;
            btnEditar.Visible = true;
            btnCrear.Visible = true;
            txtNom.Visible = true;
            txtNom.Enabled = true;
            txtCed.Visible = true;
            txtCed.Enabled = true;
            txtDir.Visible = true;
            txtDir.Enabled = true;
            txtLog.Visible = true;
            txtLog.Enabled = true;
            txtCor.Visible = true;
            txtCor.Enabled = true;
            lblContra.Visible = true;
            txtContra.Visible = true;
            groupBox.Visible = false;
            dtgUsuarios.Visible = false;
            btnGuardar.Visible = false;
            btnActualizar.Visible = true;
            LugarPerf();
            cargarD();
        }

        private void msgError_Click(object sender, EventArgs e)
        {

        }

        private void editar()
        {
            s.EditarUser(idUser, cmbTipo.Text, estd);
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            cambiarDPersonales();

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnCamb_Click(object sender, EventArgs e)
        {
            btnCamb.Visible = true;
            FrmCbiarPass us = new FrmCbiarPass();
            us.Show();
            us.FormClosed += Logout;
            this.Hide();
        }

        private void cambiarDPersonales()
        {
            if (txtContra.Text.Trim() != clsDatosUser.contraseña)
            {
                MessageBox.Show("La contraseña no es la correcta");
            }
            else
            {
                s.EditarPerfil(clsDatosUser.id, txtNom.Text, int.Parse(txtCed.Text), txtDir.Text, txtCor.Text,
                txtLog.Text, txtContra.Text);
                MessageBox.Show("El perfil a sido editado");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            try
            {
                EstD();
                editar();
                Mostrartabla();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo esta mal");
            }
            
        }
    }
}
