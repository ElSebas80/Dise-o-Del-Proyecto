using Diseño.BaseD;
using Diseño.Datos;
using Diseño.Datos.Logn;
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
    public partial class FrmCbiarPass : Form
    {
        public FrmCbiarPass()
        {
            InitializeComponent();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Salir()
        {
            FormCollection s = Application.OpenForms;
            foreach (Form Nom in s)
            {
                if (Nom.Name != "FrmLogin")
                {
                    Nom.Hide();
                }
            }
            FrmLogin login = new FrmLogin();
            login.Show();
        }
        private void btnConf_Click(object sender, EventArgs e)
        {
            msmError.Visible = true;
            using (parkEntities db = new parkEntities())
            {
                ClsEditarUser cp = new ClsEditarUser();
                // var Find = db.CuentasUsuario.Where(x => x.id == clsDatosUser.id).FirstOrDefault();
                // int CodiUser = int.Parse(Find.id.ToString());
                if (txtConAlt.Text.Trim() != clsDatosUser.contraseña)
                {
                    msmError.Visible = true;
                    msmError.Text = ("Esta no es la contraseña actual");
                }
                else if (txtConNueCon.Text == txtConConfCont.Text)
                {
                    cp.EditarUser(clsDatosUser.id, txtConNueCon.Text);
                    msmError.Visible = true;
                    msmError.Text = ("la contraseña se a cambiado correctamente");
                    Salir();
                }
                else
                {
                    msmError.Visible = true;
                    msmError.Text = ("Los dos campos no coinciden");
                    txtConNueCon.Clear();
                    txtConConfCont.Clear();
                }
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere cancelar el proceso de cambiar la contraseña?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void FrmCbiarPass_Load(object sender, EventArgs e)
        {

        }
    }
}
