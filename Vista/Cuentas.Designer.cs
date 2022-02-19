
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
<<<<<<< Updated upstream
            this.msgCedula = new System.Windows.Forms.Label();
            this.msgUsuario = new System.Windows.Forms.Label();
=======
>>>>>>> Stashed changes
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCanc
            // 
<<<<<<< Updated upstream
            this.btnCanc.Location = new System.Drawing.Point(473, 576);
=======
            this.btnCanc.Location = new System.Drawing.Point(458, 530);
>>>>>>> Stashed changes
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 36;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click_1);
            // 
            // btnGuardar
            // 
<<<<<<< Updated upstream
            this.btnGuardar.Location = new System.Drawing.Point(332, 576);
=======
            this.btnGuardar.Location = new System.Drawing.Point(351, 530);
>>>>>>> Stashed changes
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_2);
            // 
            // btnActualizar
            // 
<<<<<<< Updated upstream
            this.btnActualizar.Location = new System.Drawing.Point(185, 576);
=======
            this.btnActualizar.Location = new System.Drawing.Point(261, 530);
>>>>>>> Stashed changes
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_2);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox.Controls.Add(this.cmbTipo);
            this.groupBox.Controls.Add(this.btnDesh);
            this.groupBox.Controls.Add(this.btnHabl);
            this.groupBox.Controls.Add(this.pictureBox4);
<<<<<<< Updated upstream
            this.groupBox.Location = new System.Drawing.Point(56, 343);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(514, 72);
=======
            this.groupBox.Location = new System.Drawing.Point(146, 343);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(482, 100);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.cmbTipo.Location = new System.Drawing.Point(21, 27);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
=======
            this.cmbTipo.Location = new System.Drawing.Point(24, 19);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(126, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // btnDesh
            // 
            this.btnDesh.AutoSize = true;
<<<<<<< Updated upstream
            this.btnDesh.Location = new System.Drawing.Point(357, 35);
=======
            this.btnDesh.Location = new System.Drawing.Point(368, 42);
>>>>>>> Stashed changes
            this.btnDesh.Name = "btnDesh";
            this.btnDesh.Size = new System.Drawing.Size(89, 17);
            this.btnDesh.TabIndex = 3;
            this.btnDesh.TabStop = true;
            this.btnDesh.Text = "Deshabilitado";
            this.btnDesh.UseVisualStyleBackColor = true;
            // 
            // btnHabl
            // 
<<<<<<< Updated upstream
            this.btnHabl.AutoSize = true;
            this.btnHabl.Location = new System.Drawing.Point(357, 12);
            this.btnHabl.Name = "btnHabl";
            this.btnHabl.Size = new System.Drawing.Size(72, 17);
            this.btnHabl.TabIndex = 2;
            this.btnHabl.TabStop = true;
            this.btnHabl.Text = "Habilitado";
            this.btnHabl.UseVisualStyleBackColor = true;
=======
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(368, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Habilitado";
            this.radioButton1.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
<<<<<<< Updated upstream
            this.pictureBox4.Location = new System.Drawing.Point(288, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 60);
=======
            this.pictureBox4.Location = new System.Drawing.Point(314, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 53);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.lblLog.Location = new System.Drawing.Point(53, 190);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(62, 16);
=======
            this.lblLog.Location = new System.Drawing.Point(143, 239);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(46, 16);
>>>>>>> Stashed changes
            this.lblLog.TabIndex = 31;
            this.lblLog.Text = "Usuario";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.BackColor = System.Drawing.Color.Transparent;
            this.lblCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCed.ForeColor = System.Drawing.Color.Cornsilk;
<<<<<<< Updated upstream
            this.lblCed.Location = new System.Drawing.Point(58, 131);
=======
            this.lblCed.Location = new System.Drawing.Point(143, 167);
>>>>>>> Stashed changes
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(57, 16);
            this.lblCed.TabIndex = 30;
            this.lblCed.Text = "Cédula";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.Transparent;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.Cornsilk;
<<<<<<< Updated upstream
            this.lblDir.Location = new System.Drawing.Point(280, 131);
=======
            this.lblDir.Location = new System.Drawing.Point(143, 203);
>>>>>>> Stashed changes
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(74, 16);
            this.lblDir.TabIndex = 29;
            this.lblDir.Text = "Dirección";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Cornsilk;
<<<<<<< Updated upstream
            this.lblNom.Location = new System.Drawing.Point(58, 81);
=======
            this.lblNom.Location = new System.Drawing.Point(143, 91);
>>>>>>> Stashed changes
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(63, 16);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nombre";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< Updated upstream
            this.txtLog.Location = new System.Drawing.Point(119, 192);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(125, 29);
=======
            this.txtLog.Location = new System.Drawing.Point(254, 235);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtLog.TabIndex = 26;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtDir
            // 
            this.txtDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< Updated upstream
            this.txtDir.Location = new System.Drawing.Point(360, 131);
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(201, 24);
=======
            this.txtDir.Location = new System.Drawing.Point(254, 199);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtDir.TabIndex = 25;
            // 
            // txtCed
            // 
            this.txtCed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< Updated upstream
            this.txtCed.Location = new System.Drawing.Point(119, 129);
            this.txtCed.Multiline = true;
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(125, 26);
=======
            this.txtCed.Location = new System.Drawing.Point(254, 163);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtCed.TabIndex = 24;
            this.txtCed.TextChanged += new System.EventHandler(this.txtCed_TextChanged_1);
            this.txtCed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCed_KeyPress_1);
            // 
            // txtNom
            // 
<<<<<<< Updated upstream
            this.txtNom.Location = new System.Drawing.Point(127, 77);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(280, 29);
=======
            this.txtNom.Location = new System.Drawing.Point(254, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtNom.TabIndex = 22;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblPrs
            // 
            this.lblPrs.AutoSize = true;
            this.lblPrs.BackColor = System.Drawing.Color.Transparent;
            this.lblPrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrs.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPrs.Location = new System.Drawing.Point(270, 38);
            this.lblPrs.Name = "lblPrs";
            this.lblPrs.Size = new System.Drawing.Size(152, 16);
            this.lblPrs.TabIndex = 37;
            this.lblPrs.Text = "Cuentas de Usuarios";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Cornsilk;
<<<<<<< Updated upstream
            this.lblCorreo.Location = new System.Drawing.Point(270, 205);
=======
            this.lblCorreo.Location = new System.Drawing.Point(143, 275);
>>>>>>> Stashed changes
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 16);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< Updated upstream
            this.txtCor.Location = new System.Drawing.Point(385, 198);
            this.txtCor.Multiline = true;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(176, 29);
=======
            this.txtCor.Location = new System.Drawing.Point(254, 271);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtCor.TabIndex = 38;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged_1);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(604, 19);
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
            this.btnSal.Location = new System.Drawing.Point(634, 19);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(23, 26);
            this.btnSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSal.TabIndex = 40;
            this.btnSal.TabStop = false;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // btnActualizarP
            // 
<<<<<<< Updated upstream
            this.btnActualizarP.Location = new System.Drawing.Point(184, 576);
=======
            this.btnActualizarP.Location = new System.Drawing.Point(170, 530);
>>>>>>> Stashed changes
            this.btnActualizarP.Name = "btnActualizarP";
            this.btnActualizarP.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarP.TabIndex = 43;
            this.btnActualizarP.Text = "Actualizar";
            this.btnActualizarP.UseVisualStyleBackColor = true;
            this.btnActualizarP.Visible = false;
            this.btnActualizarP.Click += new System.EventHandler(this.btnActualizarP_Click_1);
            // 
            // btnCamb
            // 
<<<<<<< Updated upstream
            this.btnCamb.Location = new System.Drawing.Point(473, 444);
=======
            this.btnCamb.Location = new System.Drawing.Point(541, 493);
>>>>>>> Stashed changes
            this.btnCamb.Name = "btnCamb";
            this.btnCamb.Size = new System.Drawing.Size(116, 23);
            this.btnCamb.TabIndex = 44;
            this.btnCamb.Text = "Cambiar Contraseña";
            this.btnCamb.UseVisualStyleBackColor = true;
            this.btnCamb.Click += new System.EventHandler(this.btnCamb_Click_1);
            // 
            // btnEdiPf
            // 
<<<<<<< Updated upstream
            this.btnEdiPf.Location = new System.Drawing.Point(46, 443);
            this.btnEdiPf.Name = "btnEdiPf";
            this.btnEdiPf.Size = new System.Drawing.Size(93, 28);
=======
            this.btnEdiPf.Location = new System.Drawing.Point(61, 500);
            this.btnEdiPf.Name = "btnEdiPf";
            this.btnEdiPf.Size = new System.Drawing.Size(93, 23);
>>>>>>> Stashed changes
            this.btnEdiPf.TabIndex = 45;
            this.btnEdiPf.Text = "Editar Perfil";
            this.btnEdiPf.UseVisualStyleBackColor = true;
            this.btnEdiPf.Click += new System.EventHandler(this.btnEdiPf_Click_1);
            // 
            // btnEditar
            // 
<<<<<<< Updated upstream
            this.btnEditar.Location = new System.Drawing.Point(46, 487);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 28);
=======
            this.btnEditar.Location = new System.Drawing.Point(61, 530);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 23);
>>>>>>> Stashed changes
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCrear
            // 
<<<<<<< Updated upstream
            this.btnCrear.Location = new System.Drawing.Point(46, 532);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 28);
=======
            this.btnCrear.Location = new System.Drawing.Point(61, 559);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 23);
>>>>>>> Stashed changes
            this.btnCrear.TabIndex = 47;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // txtContra
            // 
            this.txtContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< Updated upstream
            this.txtContra.Location = new System.Drawing.Point(209, 286);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(225, 29);
=======
            this.txtContra.Location = new System.Drawing.Point(254, 311);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(225, 20);
>>>>>>> Stashed changes
            this.txtContra.TabIndex = 48;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.Visible = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Cornsilk;
<<<<<<< Updated upstream
            this.lblContra.Location = new System.Drawing.Point(116, 287);
=======
            this.lblContra.Location = new System.Drawing.Point(149, 313);
>>>>>>> Stashed changes
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(87, 16);
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
<<<<<<< Updated upstream
            this.dtgUsuarios.Location = new System.Drawing.Point(155, 432);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dtgUsuarios.Location = new System.Drawing.Point(139, 474);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
<<<<<<< Updated upstream
            this.dtgUsuarios.Size = new System.Drawing.Size(440, 104);
=======
            this.dtgUsuarios.Size = new System.Drawing.Size(489, 99);
>>>>>>> Stashed changes
            this.dtgUsuarios.TabIndex = 50;
            this.dtgUsuarios.DoubleClick += new System.EventHandler(this.dtgUsuarios_DoubleClick);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.BackColor = System.Drawing.Color.Transparent;
            this.msgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.msgError.ForeColor = System.Drawing.Color.Red;
            this.msgError.Location = new System.Drawing.Point(382, 241);
=======
            this.msgError.ForeColor = System.Drawing.Color.Cornsilk;
            this.msgError.Location = new System.Drawing.Point(270, 292);
>>>>>>> Stashed changes
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(42, 16);
            this.msgError.TabIndex = 51;
            this.msgError.Text = "Error";
            this.msgError.Visible = false;
            // 
<<<<<<< Updated upstream
            // msgCedula
            // 
            this.msgCedula.AutoSize = true;
            this.msgCedula.BackColor = System.Drawing.Color.Transparent;
            this.msgCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgCedula.ForeColor = System.Drawing.Color.Red;
            this.msgCedula.Location = new System.Drawing.Point(117, 158);
            this.msgCedula.Name = "msgCedula";
            this.msgCedula.Size = new System.Drawing.Size(26, 16);
            this.msgCedula.TabIndex = 52;
            this.msgCedula.Text = "Cc";
            this.msgCedula.Visible = false;
            // 
            // msgUsuario
            // 
            this.msgUsuario.AutoSize = true;
            this.msgUsuario.BackColor = System.Drawing.Color.Transparent;
            this.msgUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgUsuario.ForeColor = System.Drawing.Color.Red;
            this.msgUsuario.Location = new System.Drawing.Point(117, 230);
            this.msgUsuario.Name = "msgUsuario";
            this.msgUsuario.Size = new System.Drawing.Size(50, 16);
            this.msgUsuario.TabIndex = 53;
            this.msgUsuario.Text = "Existe";
            this.msgUsuario.Visible = false;
            // 
=======
>>>>>>> Stashed changes
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 640);
<<<<<<< Updated upstream
            this.Controls.Add(this.msgUsuario);
            this.Controls.Add(this.msgCedula);
=======
>>>>>>> Stashed changes
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
        private System.Windows.Forms.Label msgCedula;
        private System.Windows.Forms.Label msgUsuario;
    }
}