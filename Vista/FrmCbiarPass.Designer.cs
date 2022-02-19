
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCbiarPass));
            this.btnSal = new System.Windows.Forms.PictureBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.txtConAlt = new System.Windows.Forms.TextBox();
            this.txtConNueCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msmError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConConfCont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(381, 9);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(23, 26);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 41;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.Location = new System.Drawing.Point(102, 244);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(82, 23);
            this.btnConf.TabIndex = 45;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Location = new System.Drawing.Point(225, 244);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(82, 23);
            this.btnCanc.TabIndex = 44;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // txtConAlt
            // 
            this.txtConAlt.Location = new System.Drawing.Point(201, 75);
            this.txtConAlt.Name = "txtConAlt";
            this.txtConAlt.Size = new System.Drawing.Size(144, 20);
            this.txtConAlt.TabIndex = 46;
            this.txtConAlt.UseSystemPasswordChar = true;
            // 
            // txtConNueCon
            // 
            this.txtConNueCon.Location = new System.Drawing.Point(201, 118);
            this.txtConNueCon.Name = "txtConNueCon";
            this.txtConNueCon.Size = new System.Drawing.Size(144, 20);
            this.txtConNueCon.TabIndex = 47;
            this.txtConNueCon.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(46, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nueva contraseña";
            // 
            // msmError
            // 
            this.msmError.AutoSize = true;
            this.msmError.BackColor = System.Drawing.Color.Transparent;
            this.msmError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msmError.ForeColor = System.Drawing.Color.Yellow;
            this.msmError.Location = new System.Drawing.Point(154, 201);
            this.msmError.Name = "msmError";
            this.msmError.Size = new System.Drawing.Size(39, 15);
            this.msmError.TabIndex = 50;
            this.msmError.Text = "Error";
            this.msmError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(46, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Confirmar  contraseña";
            // 
            // txtConConfCont
            // 
            this.txtConConfCont.Location = new System.Drawing.Point(201, 166);
            this.txtConConfCont.Name = "txtConConfCont";
            this.txtConConfCont.Size = new System.Drawing.Size(144, 20);
            this.txtConConfCont.TabIndex = 51;
            this.txtConConfCont.UseSystemPasswordChar = true;
            // 
            // FrmCbiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diseño.Properties.Resources.FONDO_PROYECTO_s_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConConfCont);
            this.Controls.Add(this.msmError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConNueCon);
            this.Controls.Add(this.txtConAlt);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnSal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCbiarPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCbiarPass";
            this.Load += new System.EventHandler(this.FrmCbiarPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSal;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.TextBox txtConAlt;
        private System.Windows.Forms.TextBox txtConNueCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label msmError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConConfCont;
    }
}