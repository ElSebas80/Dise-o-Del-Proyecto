
namespace Diseño.Vista
{
    partial class FrmCbiarPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConAlt = new System.Windows.Forms.TextBox();
            this.txtConNueCon = new System.Windows.Forms.TextBox();
            this.txtConConfCont = new System.Windows.Forms.TextBox();
            this.btnCanc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCamb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msmError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConAlt
            // 
            this.txtConAlt.Location = new System.Drawing.Point(192, 78);
            this.txtConAlt.Name = "txtConAlt";
            this.txtConAlt.Size = new System.Drawing.Size(163, 20);
            this.txtConAlt.TabIndex = 0;
            // 
            // txtConNueCon
            // 
            this.txtConNueCon.Location = new System.Drawing.Point(192, 114);
            this.txtConNueCon.Name = "txtConNueCon";
            this.txtConNueCon.Size = new System.Drawing.Size(163, 20);
            this.txtConNueCon.TabIndex = 1;
            // 
            // txtConConfCont
            // 
            this.txtConConfCont.Location = new System.Drawing.Point(192, 149);
            this.txtConConfCont.Name = "txtConConfCont";
            this.txtConConfCont.Size = new System.Drawing.Size(163, 20);
            this.txtConConfCont.TabIndex = 2;
            // 
            // btnCanc
            // 
            this.btnCanc.BackColor = System.Drawing.Color.Transparent;
            this.btnCanc.FlatAppearance.BorderSize = 0;
            this.btnCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCanc.Location = new System.Drawing.Point(280, 244);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 3;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = false;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(55, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña actual";
            // 
            // btnCamb
            // 
            this.btnCamb.BackColor = System.Drawing.Color.Transparent;
            this.btnCamb.FlatAppearance.BorderSize = 0;
            this.btnCamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCamb.Location = new System.Drawing.Point(192, 244);
            this.btnCamb.Name = "btnCamb";
            this.btnCamb.Size = new System.Drawing.Size(75, 23);
            this.btnCamb.TabIndex = 5;
            this.btnCamb.Text = "Cambiar";
            this.btnCamb.UseVisualStyleBackColor = false;
            this.btnCamb.Click += new System.EventHandler(this.btnCamb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(55, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirme contraseña";
            // 
            // msmError
            // 
            this.msmError.AutoSize = true;
            this.msmError.BackColor = System.Drawing.Color.Transparent;
            this.msmError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.msmError.Location = new System.Drawing.Point(189, 172);
            this.msmError.Name = "msmError";
            this.msmError.Size = new System.Drawing.Size(29, 13);
            this.msmError.TabIndex = 8;
            this.msmError.Text = "Error";
            this.msmError.Visible = false;
            // 
            // FrmCbiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diseño.Properties.Resources.FONDO_PROYECTO_s_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 325);
            this.Controls.Add(this.msmError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCamb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.txtConConfCont);
            this.Controls.Add(this.txtConNueCon);
            this.Controls.Add(this.txtConAlt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCbiarPass";
            this.Text = "FrmCbiarPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConAlt;
        private System.Windows.Forms.TextBox txtConNueCon;
        private System.Windows.Forms.TextBox txtConConfCont;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCamb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msmError;
    }
}