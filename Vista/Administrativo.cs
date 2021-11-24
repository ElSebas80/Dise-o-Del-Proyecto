using Diseño.Datos;
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
    public partial class FrmAdministrativo : Form
    {
        public FrmAdministrativo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmCuentas());
          
        }

        private void btnInforma_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInforma());
        }

        private void FrmAdministrativo_Load(object sender, EventArgs e)
        {
            vistas();
        }
        private void vistas()
        {
            if (clsDatosUser.roles != "Administrador")
            {
                btnInforma.Enabled = false;
            }
            else
            {
                btnInforma.Enabled = true;
            }
        }
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdministrativo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere volver a la pantalla de inicio?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close(); 
            


        }
    }
}
