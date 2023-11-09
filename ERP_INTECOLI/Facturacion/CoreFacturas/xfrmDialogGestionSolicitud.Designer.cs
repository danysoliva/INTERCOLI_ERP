
namespace JAGUAR_APP.Facturacion.CoreFacturas
{
    partial class xfrmDialogGestionSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmDialogGestionSolicitud));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cdmAprobar = new DevExpress.XtraEditors.SimpleButton();
            this.cdmRechazar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dsFacturasGestion = new JAGUAR_APP.Facturacion.CoreFacturas.dsFacturasGestion();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(4, 8);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 52);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(80, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(360, 49);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Por favor seleccione una opcion para finalizar esta solicitud";
            // 
            // cdmAprobar
            // 
            this.cdmAprobar.Appearance.BackColor = System.Drawing.Color.White;
            this.cdmAprobar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmAprobar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cdmAprobar.Appearance.Options.UseBackColor = true;
            this.cdmAprobar.Appearance.Options.UseFont = true;
            this.cdmAprobar.Appearance.Options.UseForeColor = true;
            this.cdmAprobar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmAprobar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cdmAprobar.ImageOptions.SvgImage")));
            this.cdmAprobar.Location = new System.Drawing.Point(47, 83);
            this.cdmAprobar.Name = "cdmAprobar";
            this.cdmAprobar.Size = new System.Drawing.Size(110, 47);
            this.cdmAprobar.TabIndex = 3;
            this.cdmAprobar.Text = "Aprobar";
            this.cdmAprobar.Click += new System.EventHandler(this.cdmConfirmar_Click);
            // 
            // cdmRechazar
            // 
            this.cdmRechazar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.cdmRechazar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdmRechazar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cdmRechazar.Appearance.Options.UseBackColor = true;
            this.cdmRechazar.Appearance.Options.UseFont = true;
            this.cdmRechazar.Appearance.Options.UseForeColor = true;
            this.cdmRechazar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cdmRechazar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cdmRechazar.ImageOptions.SvgImage")));
            this.cdmRechazar.Location = new System.Drawing.Point(179, 83);
            this.cdmRechazar.Name = "cdmRechazar";
            this.cdmRechazar.Size = new System.Drawing.Size(110, 47);
            this.cdmRechazar.TabIndex = 4;
            this.cdmRechazar.Text = "Rechazar";
            this.cdmRechazar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(309, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 47);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Cerrar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // dsFacturasGestion
            // 
            this.dsFacturasGestion.DataSetName = "dsFacturasGestion";
            this.dsFacturasGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xfrmDialogGestionSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 142);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cdmRechazar);
            this.Controls.Add(this.cdmAprobar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfrmDialogGestionSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFacturasGestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dsFacturasGestion dsFacturasGestion;
        private DevExpress.XtraEditors.SimpleButton cdmAprobar;
        private DevExpress.XtraEditors.SimpleButton cdmRechazar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}