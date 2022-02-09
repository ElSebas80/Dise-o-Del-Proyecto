
namespace Diseño.Vista
{
    partial class FrmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnSal = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Diseño.Properties.Resources.panel_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNota);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(21, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 610);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(32, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "NORA SAAVEDRA RUEDA \r\nPROPIETARIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.YellowGreen;
            this.txtNota.Enabled = false;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(10, 541);
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(187, 41);
            this.txtNota.TabIndex = 3;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(58, 391);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 126);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 4;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(210)))), ((int)(((byte)(152)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(277, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(567, 65);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "\r\nREPORTE";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(810, 19);
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
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(839, 19);
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
            this.btnSal.Image = ((System.Drawing.Image)(resources.GetObject("btnSal.Image")));
            this.btnSal.Location = new System.Drawing.Point(868, 19);
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
            this.btnRes.Location = new System.Drawing.Point(839, 19);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(23, 26);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRes.TabIndex = 40;
            this.btnRes.TabStop = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diseño.Properties.Resources.FONDO_PROYECTO_s_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 661);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FrmIngresoMoto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmIngresoMoto_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmReporte_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnSal;
        private System.Windows.Forms.PictureBox btnRes;
    }
}