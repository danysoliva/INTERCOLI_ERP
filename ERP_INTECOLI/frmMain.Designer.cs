using DevExpress.XtraEditors;

namespace JAGUAR_APP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblVersion = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SaltarLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cmdButtonSaltarLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMicros = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaltarLoginPRD = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAbrirTeclado = new DevExpress.XtraEditors.SimpleButton();
            this.cmdIngresarAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdCerrar.ImageOptions.SvgImage")));
            this.cmdCerrar.Location = new System.Drawing.Point(433, 281);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(265, 73);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Appearance.Options.UseBackColor = true;
            this.cmdLogin.Appearance.Options.UseBorderColor = true;
            this.cmdLogin.Appearance.Options.UseFont = true;
            this.cmdLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdLogin.ImageOptions.SvgImage")));
            this.cmdLogin.Location = new System.Drawing.Point(163, 281);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(265, 73);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Ingresar";
            this.cmdLogin.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtClave
            // 
            this.txtClave.EditValue = "";
            this.txtClave.Location = new System.Drawing.Point(252, 203);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtClave.Properties.Appearance.Options.UseFont = true;
            //this.txtClave.Properties.ContextImageOptions.Image = global::JAGUAR_APP.Properties.Resources.key;
            this.txtClave.Properties.UseSystemPasswordChar = true;
            this.txtClave.Size = new System.Drawing.Size(296, 36);
            this.txtClave.TabIndex = 1;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(252, 132);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            //this.txtUsuario.Properties.ContextImageOptions.Image = global::JAGUAR_APP.Properties.Resources.user;
            this.txtUsuario.Size = new System.Drawing.Size(296, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(159, 135);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Usuario";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(163, 207);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 29);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Clave";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(188, 76);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(496, 33);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Bienvenido";
            this.labelControl3.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(159, 617);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 17);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Ninguna";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Orange;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(433, 361);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(265, 73);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Alimentación";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // SaltarLogin
            // 
            this.SaltarLogin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SaltarLogin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SaltarLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaltarLogin.Appearance.Options.UseBackColor = true;
            this.SaltarLogin.Appearance.Options.UseBorderColor = true;
            this.SaltarLogin.Appearance.Options.UseFont = true;
            this.SaltarLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.SaltarLogin.Location = new System.Drawing.Point(159, 521);
            this.SaltarLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaltarLogin.Name = "SaltarLogin";
            this.SaltarLogin.Size = new System.Drawing.Size(265, 87);
            this.SaltarLogin.TabIndex = 15;
            this.SaltarLogin.Text = "Ingresar Log";
            this.SaltarLogin.Visible = false;
            this.SaltarLogin.Click += new System.EventHandler(this.SaltarLogin_Click);
            // 
            // cmdButtonSaltarLogin
            // 
            this.cmdButtonSaltarLogin.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdButtonSaltarLogin.Appearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.cmdButtonSaltarLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButtonSaltarLogin.Appearance.Options.UseBackColor = true;
            this.cmdButtonSaltarLogin.Appearance.Options.UseBorderColor = true;
            this.cmdButtonSaltarLogin.Appearance.Options.UseFont = true;
            this.cmdButtonSaltarLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdButtonSaltarLogin.Location = new System.Drawing.Point(163, 361);
            this.cmdButtonSaltarLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdButtonSaltarLogin.Name = "cmdButtonSaltarLogin";
            this.cmdButtonSaltarLogin.Size = new System.Drawing.Size(265, 73);
            this.cmdButtonSaltarLogin.TabIndex = 11;
            this.cmdButtonSaltarLogin.Text = "Montacarga";
            this.cmdButtonSaltarLogin.Visible = false;
            this.cmdButtonSaltarLogin.Click += new System.EventHandler(this.cmdButtonSaltarLogin_Click);
            // 
            // cmdMicros
            // 
            this.cmdMicros.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmdMicros.Appearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.cmdMicros.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMicros.Appearance.Options.UseBackColor = true;
            this.cmdMicros.Appearance.Options.UseBorderColor = true;
            this.cmdMicros.Appearance.Options.UseFont = true;
            this.cmdMicros.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdMicros.Location = new System.Drawing.Point(433, 441);
            this.cmdMicros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdMicros.Name = "cmdMicros";
            this.cmdMicros.Size = new System.Drawing.Size(265, 73);
            this.cmdMicros.TabIndex = 16;
            this.cmdMicros.Text = "Micro Ingredientes";
            this.cmdMicros.Visible = false;
            this.cmdMicros.Click += new System.EventHandler(this.cmdMicros_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(433, 521);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(265, 87);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Ingresar Calidad";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::JAGUAR_APP.Properties.Resources.Users_Group_icon64px;
            this.pictureBox1.Location = new System.Drawing.Point(567, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SaltarLoginPRD
            // 
            this.SaltarLoginPRD.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SaltarLoginPRD.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.SaltarLoginPRD.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaltarLoginPRD.Appearance.Options.UseBackColor = true;
            this.SaltarLoginPRD.Appearance.Options.UseBorderColor = true;
            this.SaltarLoginPRD.Appearance.Options.UseFont = true;
            this.SaltarLoginPRD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.SaltarLoginPRD.Location = new System.Drawing.Point(432, 615);
            this.SaltarLoginPRD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaltarLoginPRD.Name = "SaltarLoginPRD";
            this.SaltarLoginPRD.Size = new System.Drawing.Size(265, 87);
            this.SaltarLoginPRD.TabIndex = 18;
            this.SaltarLoginPRD.Text = "Ingresar PRD";
            this.SaltarLoginPRD.Visible = false;
            this.SaltarLoginPRD.Click += new System.EventHandler(this.SaltarLoginPRD_Click);
            // 
            // cmdAbrirTeclado
            // 
            this.cmdAbrirTeclado.Appearance.BackColor = System.Drawing.Color.White;
            this.cmdAbrirTeclado.Appearance.Options.UseBackColor = true;
            this.cmdAbrirTeclado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAbrirTeclado.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.cmdAbrirTeclado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cmdAbrirTeclado.ImageOptions.SvgImage")));
            this.cmdAbrirTeclado.Location = new System.Drawing.Point(707, 197);
            this.cmdAbrirTeclado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAbrirTeclado.Name = "cmdAbrirTeclado";
            this.cmdAbrirTeclado.Size = new System.Drawing.Size(72, 43);
            this.cmdAbrirTeclado.TabIndex = 19;
            this.cmdAbrirTeclado.Click += new System.EventHandler(this.cmdAbrirTeclado_Click);
            // 
            // cmdIngresarAdmin
            // 
            this.cmdIngresarAdmin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdIngresarAdmin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdIngresarAdmin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresarAdmin.Appearance.Options.UseBackColor = true;
            this.cmdIngresarAdmin.Appearance.Options.UseBorderColor = true;
            this.cmdIngresarAdmin.Appearance.Options.UseFont = true;
            this.cmdIngresarAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdIngresarAdmin.Location = new System.Drawing.Point(160, 441);
            this.cmdIngresarAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdIngresarAdmin.Name = "cmdIngresarAdmin";
            this.cmdIngresarAdmin.Size = new System.Drawing.Size(265, 73);
            this.cmdIngresarAdmin.TabIndex = 20;
            this.cmdIngresarAdmin.Text = "Ingresar Admin";
            this.cmdIngresarAdmin.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::JAGUAR_APP.Properties.Resources.Ovejita;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(851, 711);
            this.ControlBox = false;
            this.Controls.Add(this.cmdIngresarAdmin);
            this.Controls.Add(this.cmdAbrirTeclado);
            this.Controls.Add(this.SaltarLoginPRD);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cmdMicros);
            this.Controls.Add(this.SaltarLogin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmdButtonSaltarLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdLogin;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lblVersion;
        private SimpleButton simpleButton1;
        private SimpleButton SaltarLogin;
        private SimpleButton cmdButtonSaltarLogin;
        private SimpleButton cmdMicros;
        private SimpleButton simpleButton2;
        private SimpleButton SaltarLoginPRD;
        private SimpleButton cmdAbrirTeclado;
        private SimpleButton cmdIngresarAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

