
namespace Diseño.Vista
{
    partial class Contra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contra));
            this.txtmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSal = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msgError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(162, 150);
            this.txtmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(256, 22);
            this.txtmail.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            // 
            // btnSal
            // 
            this.btnSal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(523, 15);
            this.btnSal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(31, 32);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 38;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(162, 87);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(256, 22);
            this.txtUser.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.BackColor = System.Drawing.Color.Transparent;
            this.msgError.ForeColor = System.Drawing.Color.White;
            this.msgError.Location = new System.Drawing.Point(159, 176);
            this.msgError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(40, 17);
            this.msgError.TabIndex = 41;
            this.msgError.Text = "Error";
            // 
            // Contra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diseño.Properties.Resources.FONDO_PROYECTO_s_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 448);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contra";
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSal;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label msgError;
    }
}