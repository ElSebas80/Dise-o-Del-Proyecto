using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño.Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            FrmAdministrativo x = new FrmAdministrativo();
            x.Show();
            x.FormClosed += Logout;
            this.Hide();
            
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmIngresoMoto In = new FrmIngresoMoto();
            In.Show();
            In.FormClosed += Logout;
            this.Hide();
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnAutor_Click(object sender, EventArgs e)
        {
            FrmAutorizacion au = new FrmAutorizacion();
            au.FormClosed += Logout;
            au.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReporte Re = new FrmReporte();
            Re.FormClosed += Logout;
            Re.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnRes.Visible = false;
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
