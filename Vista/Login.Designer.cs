
namespace Diseño.Vista
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.OlPass = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnSal = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.lblmsgErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(327, 269);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(188, 21);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Nombre Usuario";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(327, 305);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(188, 21);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Password";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.BorderSize = 2;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(346, 392);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(134, 27);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // OlPass
            // 
            this.OlPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OlPass.AutoSize = true;
            this.OlPass.BackColor = System.Drawing.Color.Transparent;
            this.OlPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OlPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlPass.ForeColor = System.Drawing.Color.Transparent;
            this.OlPass.Location = new System.Drawing.Point(339, 438);
            this.OlPass.Name = "OlPass";
            this.OlPass.Size = new System.Drawing.Size(154, 16);
            this.OlPass.TabIndex = 4;
            this.OlPass.Text = "Olvido su contraseña";
            this.OlPass.Click += new System.EventHandler(this.OlPass_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(704, 16);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 26);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 39;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(733, 16);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 26);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 38;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSal
            // 
            this.btnSal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(762, 16);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(23, 26);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 37;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.BackColor = System.Drawing.Color.Transparent;
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(733, 16);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(23, 26);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRes.TabIndex = 40;
            this.btnRes.TabStop = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblmsgErro
            // 
            this.lblmsgErro.AutoSize = true;
            this.lblmsgErro.BackColor = System.Drawing.Color.Transparent;
            this.lblmsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgErro.ForeColor = System.Drawing.Color.Red;
            this.lblmsgErro.Location = new System.Drawing.Point(323, 338);
            this.lblmsgErro.Name = "lblmsgErro";
            this.lblmsgErro.Size = new System.Drawing.Size(49, 20);
            this.lblmsgErro.TabIndex = 20;
            this.lblmsgErro.Text = "Error";
            this.lblmsgErro.Visible = false;
            this.lblmsgErro.Click += new System.EventHandler(this.msgErro_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.lblmsgErro);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.OlPass);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label OlPass;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnSal;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.Label lblmsgErro;
    }
}