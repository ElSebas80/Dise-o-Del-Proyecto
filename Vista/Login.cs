using Diseño.BaseD;
using Diseño.Datos;
using Diseño.Datos.Logn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.Datos;

namespace Diseño.Vista
{
    public partial class FrmLogin : Form
    {
        private static string password;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Pasword";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Nombre Usuario";
            lblmsgErro.Visible = false;
            this.Show();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Nombre Usuario")
            {
                if (txtPass.Text != "Pasword")
                {
                    enviar user = new enviar();
                    //  bool verificado = user.LoginUser(txtUser.Text, txtPass.Text);
                    // var validLogin = user.LoginUser(txtUser.Text.Trim(), txtPass.Text.Trim());
                    //var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    var verificado = user.Login(txtUser.Text, txtPass.Text.Trim());

                    if (verificado != null)
                    {
                        clsDatosUser.id = verificado.id;
                        clsDatosUser.nombre = verificado.Nombre.ToString();
                        clsDatosUser.cedula = verificado.Cedula.ToString();
                        clsDatosUser.dirrecion = verificado.Direccion.ToString();
                        clsDatosUser.correo = verificado.email.ToString();
                        clsDatosUser.login = verificado.LoginN.ToString();
                        clsDatosUser.contraseña = txtPass.Text.Trim();
                        clsDatosUser.roles = verificado.idTp.ToString();
                        clsDatosUser.estado = verificado.idEs.ToString();
                        if (clsDatosUser.estado != "1")
                        {
                            MessageBox.Show("Este usuario no tiene acceso al sistema");
                        }
                        else
                        {
                            FrmPrincipal us = new FrmPrincipal();
                            us.Show();
                            us.FormClosed += Logout;
                            this.Hide();
                        }
                        //FrmIngresoMoto us = new FrmIngresoMoto();
                    }
                    else
                    {
                        msgErro("Usuario o contraseña incorrecto. \npor favor intente otra vez.");
                        txtPass.Text = "Pasword";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }

                }
                else msgErro("Por favor digite su Password");
            }
            else msgErro("Digite su Usuario por favor");
        }
        private void msgErro(string msg)
        {
            lblmsgErro.Text = "" + msg;
            lblmsgErro.Visible = true;

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

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OlPass_Click(object sender, EventArgs e)
        {
            Contra x = new Contra();
            x.Show();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Nombre Usuario")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Nombre Usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Pasword")
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Pasword";
            }
        }

        private void msgErro_Click(object sender, EventArgs e)
        {

        }
    }
}