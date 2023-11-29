
namespace ERP_INTECOLI.Mantenimiento.Proveedor
{
    partial class frmProveedorCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedorCRUD));
            this.lblTS = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.tsHabilitado = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtRTN = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTS
            // 
            this.lblTS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTS.Appearance.Options.UseFont = true;
            this.lblTS.Location = new System.Drawing.Point(189, 379);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(60, 17);
            this.lblTS.TabIndex = 65;
            this.lblTS.Text = "Habilitado";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(158, 262);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(267, 104);
            this.txtDireccion.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(18, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "RTN:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(173, 39);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(149, 24);
            this.lblOperacion.TabIndex = 57;
            this.lblOperacion.Text = "Crear Proveedor";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = global::ERP_INTECOLI.Properties.Resources.cerrar;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(309, 420);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(116, 44);
            this.cmdCancelar.TabIndex = 69;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = global::ERP_INTECOLI.Properties.Resources.save;
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(135, 420);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 44);
            this.cmdGuardar.TabIndex = 68;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // tsHabilitado
            // 
            this.tsHabilitado.EditValue = true;
            this.tsHabilitado.Location = new System.Drawing.Point(255, 377);
            this.tsHabilitado.Name = "tsHabilitado";
            this.tsHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsHabilitado.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitado.Properties.OffText = "No";
            this.tsHabilitado.Properties.OnText = "Si";
            this.tsHabilitado.Size = new System.Drawing.Size(101, 22);
            this.tsHabilitado.TabIndex = 64;
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(158, 145);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRTN.Properties.Appearance.Options.UseFont = true;
            this.txtRTN.Properties.MaxLength = 100;
            this.txtRTN.Size = new System.Drawing.Size(239, 24);
            this.txtRTN.TabIndex = 61;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 108);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(239, 24);
            this.txtDescripcion.TabIndex = 60;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(158, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.MaxLength = 100;
            this.txtCodigo.Size = new System.Drawing.Size(160, 24);
            this.txtCodigo.TabIndex = 70;
            this.txtCodigo.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(18, 72);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(54, 17);
            this.lblProveedor.TabIndex = 72;
            this.lblProveedor.Text = "Codigo:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(158, 184);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtContacto.Properties.Appearance.Options.UseFont = true;
            this.txtContacto.Properties.MaxLength = 50;
            this.txtContacto.Size = new System.Drawing.Size(239, 24);
            this.txtContacto.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(18, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Persona de Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 221);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.MaxLength = 30;
            this.txtTelefono.Size = new System.Drawing.Size(239, 24);
            this.txtTelefono.TabIndex = 75;
            // 
            // frmProveedorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.tsHabilitado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOperacion);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmProveedorCRUD.IconOptions.Image")));
            this.Name = "frmProveedorCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRTN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.LabelControl lblTS;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtRTN;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperacion;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private System.Windows.Forms.Label lblProveedor;
        private DevExpress.XtraEditors.TextEdit txtContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
    }
}