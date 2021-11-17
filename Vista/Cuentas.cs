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

        private void dtgUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtNom.Text = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtCed.Text = dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDir.Text = dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtCor.Text = dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtLog.Text = dtgUsuarios.CurrentRow.Cells[5].Value.ToString();
            cmbTipo.Text = dtgUsuarios.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtCed_TextChanged(object sender, EventArgs e)
        {

        }
        string Rcontra, CodProd;
        Cruts ct = new Cruts();
        private void EncontrarCont()
        {
            Rcontra = ct.RetornarContra(int.Parse(CodProd));
        }

        private void dtgUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editar()
        {
            s.EditarUser(txtNom.Text, int.Parse(txtCed.Text), txtDir.Text, txtCor.Text,
                txtLog.Text, Rcontra, cmbTipo.Text, estd);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EncontrarCont();
                editar();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo saliio mal");
            }        
        }
    }
}
