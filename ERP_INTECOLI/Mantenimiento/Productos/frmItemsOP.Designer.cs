
namespace ERP_INTECOLI.Mantenimiento.Productos
{
    partial class frmItemsOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsOP));
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblTS = new DevExpress.XtraEditors.LabelControl();
            this.tsHabilitado = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(94, 9);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(137, 24);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "Crear Producto";
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
            this.cmdCancelar.Location = new System.Drawing.Point(180, 189);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 44);
            this.cmdCancelar.TabIndex = 58;
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
            this.cmdGuardar.Location = new System.Drawing.Point(52, 189);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(102, 44);
            this.cmdGuardar.TabIndex = 57;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblTS
            // 
            this.lblTS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTS.Appearance.Options.UseFont = true;
            this.lblTS.Location = new System.Drawing.Point(101, 144);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(60, 17);
            this.lblTS.TabIndex = 60;
            this.lblTS.Text = "Habilitado";
            this.lblTS.Visible = false;
            // 
            // tsHabilitado
            // 
            this.tsHabilitado.EditValue = true;
            this.tsHabilitado.Location = new System.Drawing.Point(180, 142);
            this.tsHabilitado.Name = "tsHabilitado";
            this.tsHabilitado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tsHabilitado.Properties.Appearance.Options.UseFont = true;
            this.tsHabilitado.Properties.OffText = "No";
            this.tsHabilitado.Properties.OnText = "Si";
            this.tsHabilitado.Size = new System.Drawing.Size(95, 22);
            this.tsHabilitado.TabIndex = 59;
            this.tsHabilitado.Visible = false;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemCode.Location = new System.Drawing.Point(63, 54);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(54, 17);
            this.lblItemCode.TabIndex = 66;
            this.lblItemCode.Text = "Codigo:";
            this.lblItemCode.Visible = false;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(124, 51);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.MaxLength = 100;
            this.txtItemCode.Size = new System.Drawing.Size(107, 24);
            this.txtItemCode.TabIndex = 65;
            this.txtItemCode.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.MaxLength = 100;
            this.txtDescripcion.Size = new System.Drawing.Size(133, 24);
            this.txtDescripcion.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Descripcion:";
            // 
            // frmItemsOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 252);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.tsHabilitado);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblOperacion);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmItemsOP.IconOptions.Image")));
            this.Name = "frmItemsOP";
            ((System.ComponentModel.ISupportInitialize)(this.tsHabilitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private DevExpress.XtraEditors.LabelControl lblTS;
        private DevExpress.XtraEditors.ToggleSwitch tsHabilitado;
        private System.Windows.Forms.Label lblItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label3;
    }
}