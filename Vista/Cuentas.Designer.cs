
namespace Diseño.Vista
{
    partial class FrmCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentas));
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnDesh = new System.Windows.Forms.RadioButton();
            this.btnHabl = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrs = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnSal = new System.Windows.Forms.PictureBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.msgError = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEdiPf = new System.Windows.Forms.Button();
            this.btnActualizarP = new System.Windows.Forms.Button();
            this.btnCamb = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCanc
            // 
            this.btnCanc.BackColor = System.Drawing.Color.Transparent;
            this.btnCanc.FlatAppearance.BorderSize = 0;
            this.btnCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanc.ForeColor = System.Drawing.Color.White;
            this.btnCanc.Location = new System.Drawing.Point(458, 530);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 36;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = false;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(299, 530);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(146, 530);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox.Controls.Add(this.cmbTipo);
            this.groupBox.Controls.Add(this.btnDesh);
            this.groupBox.Controls.Add(this.btnHabl);
            this.groupBox.Controls.Add(this.pictureBox4);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(94, 572);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(534, 82);
            this.groupBox.TabIndex = 32;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tipo de Usuario";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbTipo.Location = new System.Drawing.Point(20, 25);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(156, 28);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnDesh
            // 
            this.btnDesh.AutoSize = true;
            this.btnDesh.Location = new System.Drawing.Point(399, 42);
            this.btnDesh.Name = "btnDesh";
            this.btnDesh.Size = new System.Drawing.Size(124, 24);
            this.btnDesh.TabIndex = 3;
            this.btnDesh.TabStop = true;
            this.btnDesh.Text = "Deshabilitado";
            this.btnDesh.UseVisualStyleBackColor = true;
            // 
            // btnHabl
            // 
            this.btnHabl.AutoSize = true;
            this.btnHabl.ForeColor = System.Drawing.Color.Black;
            this.btnHabl.Location = new System.Drawing.Point(399, 19);
            this.btnHabl.Name = "btnHabl";
            this.btnHabl.Size = new System.Drawing.Size(98, 24);
            this.btnHabl.TabIndex = 2;
            this.btnHabl.TabStop = true;
            this.btnHabl.Text = "Habilitado";
            this.btnHabl.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(315, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblContra.Location = new System.Drawing.Point(143, 398);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(87, 16);
            this.lblContra.TabIndex = 50;
            this.lblContra.Text = "Contraseña";
            this.lblContra.Visible = false;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(299, 398);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(260, 20);
            this.txtContra.TabIndex = 49;
            this.txtContra.Visible = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLog.Location = new System.Drawing.Point(143, 278);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(62, 16);
            this.lblLog.TabIndex = 31;
            this.lblLog.Text = "Usuario";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.BackColor = System.Drawing.Color.Transparent;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCed.Location = new System.Drawing.Point(143, 169);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(57, 16);
            this.lblCed.TabIndex = 30;
            this.lblCed.Text = "Cedula";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.Transparent;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDir.Location = new System.Drawing.Point(143, 222);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(74, 16);
            this.lblDir.TabIndex = 29;
            this.lblDir.Text = "Direccion";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNom.Location = new System.Drawing.Point(143, 114);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(133, 16);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nombre Completo";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(299, 278);
            this.txtLog.Name = "txtLog";
            this.txtLog.ShortcutsEnabled = false;
            this.txtLog.Size = new System.Drawing.Size(128, 20);
            this.txtLog.TabIndex = 26;
            this.txtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLog_KeyPress);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(299, 222);
            this.txtDir.Name = "txtDir";
            this.txtDir.ShortcutsEnabled = false;
            this.txtDir.Size = new System.Drawing.Size(260, 20);
            this.txtDir.TabIndex = 25;
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(299, 169);
            this.txtCed.Name = "txtCed";
            this.txtCed.ShortcutsEnabled = false;
            this.txtCed.Size = new System.Drawing.Size(128, 20);
            this.txtCed.TabIndex = 24;
            this.txtCed.TextChanged += new System.EventHandler(this.txtCed_TextChanged);
            this.txtCed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCed_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(299, 113);
            this.txtNom.Name = "txtNom";
            this.txtNom.ShortcutsEnabled = false;
            this.txtNom.Size = new System.Drawing.Size(276, 20);
            this.txtNom.TabIndex = 22;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblPrs
            // 
            this.lblPrs.BackColor = System.Drawing.Color.Goldenrod;
            this.lblPrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrs.ForeColor = System.Drawing.Color.Black;
            this.lblPrs.Location = new System.Drawing.Point(143, 48);
            this.lblPrs.Name = "lblPrs";
            this.lblPrs.Size = new System.Drawing.Size(379, 18);
            this.lblPrs.TabIndex = 37;
            this.lblPrs.Text = "Cuentas de Usuarios";
            this.lblPrs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCorreo.Location = new System.Drawing.Point(143, 336);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 16);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(299, 336);
            this.txtCor.Name = "txtCor";
            this.txtCor.ShortcutsEnabled = false;
            this.txtCor.Size = new System.Drawing.Size(260, 20);
            this.txtCor.TabIndex = 38;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            this.txtCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCor_KeyPress);
            this.txtCor.Leave += new System.EventHandler(this.txtCor_Leave);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(605, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 26);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 42;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(634, 20);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(23, 26);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 40;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToResizeColumns = false;
            this.dtgUsuarios.AllowUserToResizeRows = false;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(94, 543);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.Size = new System.Drawing.Size(534, 150);
            this.dtgUsuarios.TabIndex = 44;
            this.dtgUsuarios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellValueChanged);
            this.dtgUsuarios.DoubleClick += new System.EventHandler(this.dtgUsuarios_DoubleClick);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.BackColor = System.Drawing.Color.Transparent;
            this.msgError.ForeColor = System.Drawing.Color.Red;
            this.msgError.Location = new System.Drawing.Point(296, 359);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(29, 13);
            this.msgError.TabIndex = 45;
            this.msgError.Text = "Error";
            this.msgError.Visible = false;
            this.msgError.Click += new System.EventHandler(this.msgError_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(43, 514);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 23);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(44, 543);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(99, 23);
            this.btnCrear.TabIndex = 47;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEdiPf
            // 
            this.btnEdiPf.BackColor = System.Drawing.Color.Transparent;
            this.btnEdiPf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdiPf.FlatAppearance.BorderSize = 0;
            this.btnEdiPf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdiPf.ForeColor = System.Drawing.Color.White;
            this.btnEdiPf.Location = new System.Drawing.Point(43, 485);
            this.btnEdiPf.Name = "btnEdiPf";
            this.btnEdiPf.Size = new System.Drawing.Size(75, 23);
            this.btnEdiPf.TabIndex = 48;
            this.btnEdiPf.Text = "Editar perfil";
            this.btnEdiPf.UseVisualStyleBackColor = false;
            this.btnEdiPf.Click += new System.EventHandler(this.btnEdiPf_Click);
            // 
            // btnActualizarP
            // 
            this.btnActualizarP.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarP.FlatAppearance.BorderSize = 0;
            this.btnActualizarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarP.ForeColor = System.Drawing.Color.White;
            this.btnActualizarP.Location = new System.Drawing.Point(149, 530);
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarP.TabIndex = 51;
            this.btnActualizarP.Text = "Actualizar";
            this.btnActualizarP.UseVisualStyleBackColor = false;
            this.btnActualizarP.Visible = false;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click);
            // 
            // btnCamb
            // 
            this.btnCamb.BackColor = System.Drawing.Color.Transparent;
            this.btnCamb.FlatAppearance.BorderSize = 0;
            this.btnCamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamb.ForeColor = System.Drawing.Color.White;
            this.btnCamb.Location = new System.Drawing.Point(529, 461);
            this.btnCamb.Name = "btnCamb";
            this.btnCamb.Size = new System.Drawing.Size(112, 23);
            this.btnCamb.TabIndex = 52;
            this.btnCamb.Text = "Cambiar Contraseña";
            this.btnCamb.UseVisualStyleBackColor = false;
            this.btnCamb.Visible = false;
            this.btnCamb.Click += new System.EventHandler(this.btnCamb_Click);
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 661);
            this.Controls.Add(this.btnCamb);
            this.Controls.Add(this.btnActualizarP);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnEdiPf);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblPrs);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblCed);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dtgUsuarios);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton btnDesh;
        private System.Windows.Forms.RadioButton btnHabl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrs;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnSal;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label msgError;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEdiPf;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnActualizarP;
        private System.Windows.Forms.Button btnCamb;
    }
}