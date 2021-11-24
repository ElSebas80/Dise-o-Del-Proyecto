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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Vista
{
    public partial class Contra : Form
    {
        public static string password;

        public Contra()
        {
            InitializeComponent();
        }

        ClsEditarUser db = new ClsEditarUser();

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClsRecuperarpasss em = new ClsRecuperarpasss();
            ClsRecuperarpasss cahs = new ClsRecuperarpasss();
            var verificado = em.mail(txtmail.Text.Trim());
            if (verificado != null)
            {
                cahs.Recuperarpasss(txtUser.Text, txtmail.Text);
                MessageBox.Show("Revisa tu bandeja de entrada en " + txtmail.Text + " " +
                    " El Cambio a sido exitoso");
                this.Close();
            }
            else if (txtUser.Text == "" || txtmail.Text == "")
            {
                msgError.Visible = true;
                msgError.Text = "Alguna de las cajas de texto esta vacia";
            }
            else
            {
                msgError.Visible = true;
                msgError.Text = "Correo incorrecto o no exixtente";
            }

        }

        private void Contra_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
 
