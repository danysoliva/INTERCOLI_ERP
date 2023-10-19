
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class xfrmDialogAutorizacionConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDialogAutorizacionConfirmation));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            this.txtJustificacion = new DevExpress.XtraEditors.MemoEdit();
            this.cdmConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.cdmCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            //this.pictureEdit1.EditValue = global::JAGUAR_APP.Properties.Resources.information_64X64;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 2);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 52);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ingrese una Justificación de esta Solicitud";
            // 
            // dsFacturasGestion
            // 
            this.dsFacturasGestion.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(12, 59);
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Properties.MaxLength = 200;
            this.txtJustificacion.Size = new System.Drawing.Size(329, 120);
            this.txtJustificacion.TabIndex = 2;
            // 
            // cdmConfirmar
            // 
            this.cdmConfirmar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.cdmConfirmar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmConfirmar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cdmConfirmar.Appearance.Options.UseBackColor = true;
            this.cdmConfirmar.Appearance.Options.UseFont = true;
            this.cdmConfirmar.Appearance.Options.UseForeColor = true;
            this.cdmConfirmar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            //this.cdmConfirmar.ImageOptions.Image = global::JAGUAR_APP.Properties.Resources.check_mark_24X24;
            this.cdmConfirmar.Location = new System.Drawing.Point(345, 60);
            this.cdmConfirmar.Name = "cdmConfirmar";
            this.cdmConfirmar.Size = new System.Drawing.Size(110, 47);
            this.cdmConfirmar.TabIndex = 3;
            this.cdmConfirmar.Text = "Confirmar";
            this.cdmConfirmar.Click += new System.EventHandler(this.cdmConfirmar_Click);
            // 
            // cdmCancelar
            // 
            this.cdmCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmCancelar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cdmCancelar.Appearance.Options.UseFont = true;
            this.cdmCancelar.Appearance.Options.UseForeColor = true;
            this.cdmCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.cdmCancelar.Location = new System.Drawing.Point(345, 113);
            this.cdmCancelar.Name = "cdmCancelar";
            this.cdmCancelar.Size = new System.Drawing.Size(110, 47);
            this.cdmCancelar.TabIndex = 4;
            this.cdmCancelar.Text = "Cancelar";
            this.cdmCancelar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xfrmDialogAutorizacionConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 192);
            this.Controls.Add(this.cdmCancelar);
            this.Controls.Add(this.cdmConfirmar);
            this.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmDialogAutorizacionConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraEditors.MemoEdit txtJustificacion;
        private DevExpress.XtraEditors.SimpleButton cdmConfirmar;
        private DevExpress.XtraEditors.SimpleButton cdmCancelar;
    }
}