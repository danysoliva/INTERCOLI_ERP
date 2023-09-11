
namespace ERP_INTECOLI.Administracion.Caja
{
    partial class frmTipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPago));
            this.cmdTransferencia = new DevExpress.XtraEditors.SimpleButton();
            this.cmdTarjeta = new DevExpress.XtraEditors.SimpleButton();
            this.cmdEfectivo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmdTransferencia
            // 
            this.cmdTransferencia.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdTransferencia.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdTransferencia.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdTransferencia.Appearance.Options.UseBackColor = true;
            this.cmdTransferencia.Appearance.Options.UseBorderColor = true;
            this.cmdTransferencia.Appearance.Options.UseFont = true;
            this.cmdTransferencia.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdTransferencia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdTransferencia.ImageOptions.Image")));
            this.cmdTransferencia.Location = new System.Drawing.Point(117, 142);
            this.cmdTransferencia.Name = "cmdTransferencia";
            this.cmdTransferencia.Size = new System.Drawing.Size(207, 122);
            this.cmdTransferencia.TabIndex = 5;
            this.cmdTransferencia.Text = "Transferencia \r\nBancaria";
            this.cmdTransferencia.Click += new System.EventHandler(this.cmdTransferencia_Click);
            // 
            // cmdTarjeta
            // 
            this.cmdTarjeta.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdTarjeta.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdTarjeta.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmdTarjeta.Appearance.Options.UseBackColor = true;
            this.cmdTarjeta.Appearance.Options.UseBorderColor = true;
            this.cmdTarjeta.Appearance.Options.UseFont = true;
            this.cmdTarjeta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdTarjeta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdTarjeta.ImageOptions.Image")));
            this.cmdTarjeta.Location = new System.Drawing.Point(226, 14);
            this.cmdTarjeta.Name = "cmdTarjeta";
            this.cmdTarjeta.Size = new System.Drawing.Size(193, 122);
            this.cmdTarjeta.TabIndex = 4;
            this.cmdTarjeta.Text = "Tarjeta";
            this.cmdTarjeta.Click += new System.EventHandler(this.cmdTarjeta_Click);
            // 
            // cmdEfectivo
            // 
            this.cmdEfectivo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdEfectivo.Appearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdEfectivo.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEfectivo.Appearance.Options.UseBackColor = true;
            this.cmdEfectivo.Appearance.Options.UseBorderColor = true;
            this.cmdEfectivo.Appearance.Options.UseFont = true;
            this.cmdEfectivo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdEfectivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEfectivo.ImageOptions.Image")));
            this.cmdEfectivo.Location = new System.Drawing.Point(18, 14);
            this.cmdEfectivo.Name = "cmdEfectivo";
            this.cmdEfectivo.Size = new System.Drawing.Size(193, 122);
            this.cmdEfectivo.TabIndex = 3;
            this.cmdEfectivo.Text = "Efectivo";
            this.cmdEfectivo.Click += new System.EventHandler(this.cmdEfectivo_Click);
            // 
            // frmTipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 278);
            this.Controls.Add(this.cmdTransferencia);
            this.Controls.Add(this.cmdTarjeta);
            this.Controls.Add(this.cmdEfectivo);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoPago";
            this.Text = "Seleccione la Forma de Pago";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdTransferencia;
        private DevExpress.XtraEditors.SimpleButton cmdTarjeta;
        private DevExpress.XtraEditors.SimpleButton cmdEfectivo;
    }
}