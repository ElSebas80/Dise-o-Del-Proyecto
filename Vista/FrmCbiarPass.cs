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
        
        private void btnCamb_Click(object sender, EventArgs e)
        {
            msmError.Visible = true;
            using (parkEntities1 db = new parkEntities1())
            {
                ClsEditarUser cp = new ClsEditarUser();
               // var Find = db.CuentasUsuario.Where(x => x.id == clsDatosUser.id).FirstOrDefault();
               // int CodiUser = int.Parse(Find.id.ToString());
                if (txtConAlt.Text.Trim() != clsDatosUser.contraseña)
                {
                    msmError.Text = ("Esta no es la contraseña actual");
                }
                else if(txtConNueCon.Text == txtConConfCont.Text)
                {
                    cp.EditarUser(clsDatosUser.id, txtConNueCon.Text);
                    msmError.Text = ("la contraseña se a cambiado correctamente");
                    this.Close();
                    FrmLogin us = new FrmLogin();
                    us.Show();
                }
                else
                {
                    msmError.Text = ("La contraseña no es la misma");
                }
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere cancelar el proceso de cambiar la contraseña?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
