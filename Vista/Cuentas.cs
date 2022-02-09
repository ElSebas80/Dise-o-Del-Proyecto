using Diseño.BaseD;
using Diseño.Datos;
using Diseño.Datos.Logn;
using Diseño.Datos.ValidacionCampos;
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
        string contra = "123";
        int estd, tipoUser;


        private void EstD()
        {
            if (btnHabl.Checked == true)
                estd = 1;
            else if (btnDesh.Checked == true)
                estd = 2;
        }
        private void guar()
        {
            s.GuardarUser(txtNom.Text, int.Parse(txtCed.Text), txtDir.Text, txtCor.Text,
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
                if (txtNom.Text == "" || txtCed.Text == "" || txtDir.Text == "" || txtCor.Text == "" || txtLog.Text == "" || cmbTipo.Text == "" || btnHabl.Checked == false || btnDesh.Checked == false)
                {
                    MessageBox.Show("Los campos estan vacio");
                }
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
        Cruts db = new Cruts();
        private void MostrarEst()
        {
            try
            {
                if (banderacc != "")
                {
                    var x = db.MostrarCc(int.Parse(txtCed.Text));
                    if (x.Count() >= 1)
                    {
                        msgCedula.ForeColor = Color.Red;
                        msgCedula.Text = "Esta Cedula ya existe";
                    }
                    else
                    {
                        msgCedula.ForeColor = Color.Green;
                        msgCedula.Text = "La Cedula es unica";
                    }
                }
            }
            catch (Exception)
            {            }
        }
        private void Mostrartabla()
        {
            Cruts r = new Cruts();
          //  dtgUsuarios.DataSource = mos.CuentasUsuario.ToList();
            dtgUsuarios.DataSource = r.RetornarEst();
            dtgUsuarios.Columns[0].Visible = false;
            dtgUsuarios.Columns[4].HeaderText = "Email";
            dtgUsuarios.Columns[5].HeaderText = "Usuario";
            dtgUsuarios.Columns[6].HeaderText = "Tipo";
        }
        private void btnCons_Click(object sender, EventArgs e)
        {
            Mostrartabla();
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {

        }

        private void dtgUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                idUser = int.Parse(dtgUsuarios.CurrentRow.Cells[0].Value.ToString());
                txtNom.Text = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtCed.Text = dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtDir.Text = dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtCor.Text = dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
                txtLog.Text = dtgUsuarios.CurrentRow.Cells[5].Value.ToString();
                cmbTipo.Text = dtgUsuarios.CurrentRow.Cells[6].Value.ToString();
                if (dtgUsuarios.CurrentRow.Cells[7].Value.ToString() != "Habilitado")
                {
                    btnDesh.Checked = true;
                }
                else
                {
                    btnHabl.Checked = true;
                }
                msgCedula.Visible = false;
                msgUsuario.Visible = false;
                msgError.Visible = false;
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
            if (clsDatosUser.roles != "Administrador")
            {
                banderacc = ""; banderaUser = "";
                txtLog.Enabled = false;
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
                msgCedula.Visible = false;
                msgUsuario.Visible = false;
                LugarPerf();
                cargarD();
                ocultarmsm();
            }
            else
            {
                banderacc = "1"; banderaUser = "1";
                msgCedula.Visible = false;
                msgUsuario.Visible = false;
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
            msgCedula.Location = new Point(116, 152);
            txtDir.Location = new Point(333, 133);
            lblDir.Location = new Point(253, 133);
            txtLog.Location = new Point(119, 177);
            lblLog.Location = new Point(56, 177);
            msgUsuario.Location = new Point(117, 200);
            txtCor.Location = new Point(333, 180);
            lblCorreo.Location = new Point(253, 181);
            msgError.Location = new Point(331, 203);
            groupBox.Location = new Point(59, 222);
            dtgUsuarios.Location = new Point(110, 329);
        }
        private void LugarPerf()
        {
            txtNom.Location = new Point(299, 113);
            lblNom.Location = new Point(143, 114);
            txtCed.Location = new Point(299, 169);
            msgCedula.Location = new Point(299, 189);
            lblCed.Location = new Point(143, 169);
            txtDir.Location = new Point(299, 222);
            lblDir.Location = new Point(143, 222);
            txtLog.Location = new Point(299, 278);
            msgUsuario.Location = new Point(299, 290);
            lblLog.Location = new Point(143, 278);
            txtCor.Location = new Point(299, 336);
            msgError.Location = new Point(299, 354);
            lblCorreo.Location = new Point(143, 336);
            groupBox.Location = new Point(59, 222);
            dtgUsuarios.Location = new Point(110, 329);
            lblContra.Location = new Point(143, 398);
            txtContra.Location = new Point(299, 398); 
            btnCamb.Location = new Point(511, 487);
        }
        private void Limpiar()
        {
            txtNom.Clear();
            txtCed.Text = "";
            txtDir.Clear();
            txtLog.Clear();
            txtCor.Clear();
            cmbTipo.Text = "";
            btnHabl.Checked = false;
            btnDesh.Checked = false;

        }
        int bandera, idUser;
        private void editar()
        {
            s.EditarUser(idUser, cmbTipo.Text, estd);
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            
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
                MessageBox.Show("Su perfil a sido editado correctamente");
            }
        }
        string banderacc,banderaUser;
        private void btnEdiPf_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            banderacc = ""; banderaUser = "";
            LugarPerf();
            cargarD();
            txtLog.ReadOnly = true;
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
            msgCedula.Visible = false;
            msgUsuario.Visible = false;
        }
        private void ocultarmsm()
        {
            msgError.Visible = false;
            msgUsuario.Visible = false;
            msgCedula.Visible = false;
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            banderacc = "";
            banderaUser = "";
            bandera = 1;
            if (clsDatosUser.roles == "Administrador")
            {
                btnCamb.Visible = false;
                btnActualizarP.Visible = false;
                btnEdiPf.Visible = true;
                lblPrs.Text = "Cuentas de Usuarios";
                Limpiar();
                Mostrartabla();
                msgError.Visible = false;
                msgUsuario.Visible = false;
                msgCedula.Visible = false;
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

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            banderacc = "1";
            banderaUser = "1";
            txtLog.ReadOnly = false;
            txtLog.Enabled = true;
            btnActualizarP.Visible = false;
            btnCamb.Visible = false;
            msgError.Visible = false;
            bandera = 2;
            lblPrs.Text = "Creacion de Usuarios";
            msgCedula.Visible = false;
            msgUsuario.Visible = false;
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

        private void btnActualizarP_Click_1(object sender, EventArgs e)
        {
            cambiarDPersonales();
        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
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

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
            try
            {
                EstD();
                guar();
                Contr();
                Mostrartabla();
                Limpiar();
                ocultarmsm();
            }
            catch 
            {
                if(txtNom.Text == "" || txtCed.Text == "" || txtDir.Text == "" || txtCor.Text == "" || txtLog.Text == "" || cmbTipo.Text == "" || btnHabl.Checked == false || btnDesh.Checked == false)
                    MessageBox.Show("rebizar los campos puede faltar uno");
            }
        } 
        private void btnCanc_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCamb_Click_1(object sender, EventArgs e)
        {
            btnCamb.Visible = true;
            FrmCbiarPass us = new FrmCbiarPass();
            us.ShowDialog();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCed_TextChanged_1(object sender, EventArgs e)
        {
            msgCedula.Visible = true;
            MostrarEst();
        }
        private void MostrarUser()
        {
            try
            {
                if (banderacc != "")
                {
                    var x = db.MostrarUser(txtLog.Text);
                    if (x.Count() >= 1)
                    {
                        msgUsuario.ForeColor = Color.Red;
                        msgUsuario.Text = "Este Usuario ya existe";
                    }
                    else
                    {
                        msgUsuario.ForeColor = Color.Green;
                        msgUsuario.Text = "Este Usuario es unico";
                    }
                }
            }
            catch (Exception)
            { }
        }
        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            msgUsuario.Visible = true;
            MostrarUser();


        }

        private void txtCed_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            valid.SoloNumeros(e);
        }

        private void txtCor_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                msgError.Visible = true;
                msgError.Text = ("El campo correo esta vacio");
                msgError.ForeColor = Color.Red;
            }
            else if (valid.valiCorreo(txtCor.Text.Trim()))
            {
                msgError.Visible = true;
                msgError.Text = ("El campo correo si corresponde");
                msgError.ForeColor = Color.Green;
            }
            else
            {
                msgError.Visible = true;
                msgError.Text = ("El campo no correspon a un correo electronico");
                msgError.ForeColor = Color.Red;
            }
        }

        private void FrmCuentas_Load_1(object sender, EventArgs e)
        {
            vistas();
            Mostrartabla();
        }
    }
}
