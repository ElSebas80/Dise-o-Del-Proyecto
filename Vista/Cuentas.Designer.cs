
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
            this.btnDesh = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.btnActualizarP = new System.Windows.Forms.Button();
            this.btnCamb = new System.Windows.Forms.Button();
            this.btnEdiPf = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.msgError = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(611, 652);
            this.btnCanc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(100, 28);
            this.btnCanc.TabIndex = 36;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(468, 652);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_2);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(348, 652);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_2);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox.Controls.Add(this.cmbTipo);
            this.groupBox.Controls.Add(this.btnDesh);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Controls.Add(this.pictureBox4);
            this.groupBox.Location = new System.Drawing.Point(195, 422);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(642, 123);
            this.groupBox.TabIndex = 32;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tipo de Usuario";
            // 
            // btnDesh
            // 
            this.btnDesh.AutoSize = true;
            this.btnDesh.Location = new System.Drawing.Point(491, 52);
            this.btnDesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesh.Name = "btnDesh";
            this.btnDesh.Size = new System.Drawing.Size(115, 21);
            this.btnDesh.TabIndex = 3;
            this.btnDesh.TabStop = true;
            this.btnDesh.Text = "Deshabilitado";
            this.btnDesh.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(491, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Habilitado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(419, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLog.Location = new System.Drawing.Point(191, 294);
            this.lblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(55, 20);
            this.lblLog.TabIndex = 31;
            this.lblLog.Text = "Login";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.BackColor = System.Drawing.Color.Transparent;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCed.Location = new System.Drawing.Point(191, 206);
            this.lblCed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(67, 20);
            this.lblCed.TabIndex = 30;
            this.lblCed.Text = "Cedula";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.Transparent;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDir.Location = new System.Drawing.Point(191, 250);
            this.lblDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(90, 20);
            this.lblDir.TabIndex = 29;
            this.lblDir.Text = "Dirección";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblNom.Location = new System.Drawing.Point(191, 112);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(74, 20);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nombre";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(339, 289);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(299, 22);
            this.txtLog.TabIndex = 26;
            // 
            // txtDir
            // 
            this.txtDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDir.Location = new System.Drawing.Point(339, 245);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(299, 22);
            this.txtDir.TabIndex = 25;
            // 
            // txtCed
            // 
            this.txtCed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCed.Location = new System.Drawing.Point(339, 201);
            this.txtCed.Margin = new System.Windows.Forms.Padding(4);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(299, 22);
            this.txtCed.TabIndex = 24;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(339, 99);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(299, 22);
            this.txtNom.TabIndex = 22;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblPrs
            // 
            this.lblPrs.AutoSize = true;
            this.lblPrs.BackColor = System.Drawing.Color.Transparent;
            this.lblPrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrs.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPrs.Location = new System.Drawing.Point(360, 47);
            this.lblPrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrs.Name = "lblPrs";
            this.lblPrs.Size = new System.Drawing.Size(185, 20);
            this.lblPrs.TabIndex = 37;
            this.lblPrs.Text = "Cuentas de Usuarios";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCorreo.Location = new System.Drawing.Point(191, 338);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 20);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.Location = new System.Drawing.Point(339, 334);
            this.txtCor.Margin = new System.Windows.Forms.Padding(4);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(299, 22);
            this.txtCor.TabIndex = 38;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(806, 23);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 32);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 42;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(845, 23);
            this.btnSal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(31, 32);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 40;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnActualizarP
            // 
            this.btnActualizarP.Location = new System.Drawing.Point(227, 652);
            this.btnActualizarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(100, 28);
            this.btnActualizarP.TabIndex = 43;
            this.btnActualizarP.Text = "Actualizar";
            this.btnActualizarP.UseVisualStyleBackColor = true;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click_1);
            // 
            // btnCamb
            // 
            this.btnCamb.Location = new System.Drawing.Point(721, 607);
            this.btnCamb.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamb.Name = "btnCamb";
            this.btnCamb.Size = new System.Drawing.Size(155, 28);
            this.btnCamb.TabIndex = 44;
            this.btnCamb.Text = "Cambiar Contraseña";
            this.btnCamb.UseVisualStyleBackColor = true;
            this.btnCamb.Click += new System.EventHandler(this.btnCamb_Click_1);
            // 
            // btnEdiPf
            // 
            this.btnEdiPf.Location = new System.Drawing.Point(81, 616);
            this.btnEdiPf.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdiPf.Name = "btnEdiPf";
            this.btnEdiPf.Size = new System.Drawing.Size(124, 28);
            this.btnEdiPf.TabIndex = 45;
            this.btnEdiPf.Text = "Editar Perfil";
            this.btnEdiPf.UseVisualStyleBackColor = true;
            this.btnEdiPf.Click += new System.EventHandler(this.btnEdiPf_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(81, 652);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 28);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(81, 688);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(124, 28);
            this.btnCrear.TabIndex = 47;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // txtContra
            // 
            this.txtContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContra.Location = new System.Drawing.Point(339, 383);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(299, 22);
            this.txtContra.TabIndex = 48;
            this.txtContra.Visible = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblContra.Location = new System.Drawing.Point(199, 385);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(105, 20);
            this.lblContra.TabIndex = 49;
            this.lblContra.Text = "Contraseña";
            this.lblContra.Visible = false;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(185, 583);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.Size = new System.Drawing.Size(652, 122);
            this.dtgUsuarios.TabIndex = 50;
            this.dtgUsuarios.DoubleClick += new System.EventHandler(this.dtgUsuarios_DoubleClick);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.BackColor = System.Drawing.Color.Transparent;
            this.msgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgError.ForeColor = System.Drawing.Color.Cornsilk;
            this.msgError.Location = new System.Drawing.Point(516, 359);
            this.msgError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(52, 20);
            this.msgError.TabIndex = 51;
            this.msgError.Text = "Error";
            this.msgError.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbTipo.Location = new System.Drawing.Point(32, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(166, 24);
            this.cmbTipo.TabIndex = 4;
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 814);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEdiPf);
            this.Controls.Add(this.btnCamb);
            this.Controls.Add(this.btnActualizarP);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblPrs);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblCed);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.txtNom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load_1);
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
        private System.Windows.Forms.RadioButton radioButton1;
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
        private System.Windows.Forms.Button btnActualizarP;
        private System.Windows.Forms.Button btnCamb;
        private System.Windows.Forms.Button btnEdiPf;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Label msgError;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}