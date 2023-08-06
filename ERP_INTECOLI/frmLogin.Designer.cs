
namespace ERP_INTECOLI
{
    partial class frmLogin
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.txtPass = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtUsuario = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSkip = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsRecordatorios1 = new ERP_INTECOLI.dsRecordatorios();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecordatorios1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.cbxCompany);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Location = new System.Drawing.Point(12, 34);
            this.panel2.MaximumSize = new System.Drawing.Size(364, 102);
            this.panel2.MinimumSize = new System.Drawing.Size(364, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 102);
            this.panel2.TabIndex = 2;
            // 
            // cbxCompany
            // 
            this.cbxCompany.DataSource = this.dsRecordatorios1;
            this.cbxCompany.DisplayMember = "sucursales.name";
            this.cbxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(137, 70);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(204, 26);
            this.cbxCompany.TabIndex = 2;
            this.cbxCompany.ValueMember = "sucursales.codigo";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPass.Location = new System.Drawing.Point(137, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.NullText = "Contraseña";
            appearance1.FontData.ItalicAsString = "True";
            appearance1.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.NullTextAppearance = appearance1;
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(204, 26);
            this.txtPass.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUsuario.Location = new System.Drawing.Point(137, 7);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NullText = "Usuario";
            appearance2.FontData.ItalicAsString = "True";
            appearance2.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.NullTextAppearance = appearance2;
            this.txtUsuario.Size = new System.Drawing.Size(204, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenido.Location = new System.Drawing.Point(0, -1);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(381, 38);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdSkip);
            this.panel1.Controls.Add(this.cmdAceptar);
            this.panel1.Controls.Add(this.cmdCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 45);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version 2.0";
            // 
            // cmdSkip
            // 
            this.cmdSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSkip.BackColor = System.Drawing.Color.Aqua;
            this.cmdSkip.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdSkip.FlatAppearance.BorderSize = 2;
            this.cmdSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSkip.Location = new System.Drawing.Point(97, 4);
            this.cmdSkip.Name = "cmdSkip";
            this.cmdSkip.Size = new System.Drawing.Size(89, 37);
            this.cmdSkip.TabIndex = 2;
            this.cmdSkip.Text = "Skip";
            this.cmdSkip.UseVisualStyleBackColor = true;
            this.cmdSkip.Click += new System.EventHandler(this.cmdSkip_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAceptar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdAceptar.FlatAppearance.BorderSize = 2;
            this.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(192, 4);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(89, 37);
            this.cmdAceptar.TabIndex = 0;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(287, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(89, 37);
            this.cmdCancelar.TabIndex = 1;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dsRecordatorios1
            // 
            this.dsRecordatorios1.DataSetName = "dsRecordatorios";
            this.dsRecordatorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 185);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Inicio de Sesion";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecordatorios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPass;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUsuario;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSkip;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private dsRecordatorios dsRecordatorios1;
    }
}