
namespace ERP_INTECOLI.Accesos.GrupoLosa
{
    partial class EditarGrupoLosa
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
            this.botonCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.botonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditHabilitado = new DevExpress.XtraEditors.CheckEdit();
            this.textEditGrupo = new DevExpress.XtraEditors.TextEdit();
            this.labelControlGrupo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHabilitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrupo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Appearance.BackColor = System.Drawing.Color.Red;
            this.botonCancelar.Appearance.Options.UseBackColor = true;
            this.botonCancelar.Location = new System.Drawing.Point(107, 233);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(24, 233);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // checkEditHabilitado
            // 
            this.checkEditHabilitado.Location = new System.Drawing.Point(25, 108);
            this.checkEditHabilitado.Name = "checkEditHabilitado";
            this.checkEditHabilitado.Properties.Caption = "Habilitado";
            this.checkEditHabilitado.Size = new System.Drawing.Size(75, 19);
            this.checkEditHabilitado.TabIndex = 7;
            // 
            // textEditGrupo
            // 
            this.textEditGrupo.Location = new System.Drawing.Point(25, 59);
            this.textEditGrupo.Name = "textEditGrupo";
            this.textEditGrupo.Size = new System.Drawing.Size(229, 20);
            this.textEditGrupo.TabIndex = 6;
            // 
            // labelControlGrupo
            // 
            this.labelControlGrupo.Location = new System.Drawing.Point(25, 40);
            this.labelControlGrupo.Name = "labelControlGrupo";
            this.labelControlGrupo.Size = new System.Drawing.Size(29, 13);
            this.labelControlGrupo.TabIndex = 5;
            this.labelControlGrupo.Text = "Grupo";
            // 
            // EditarGrupoLosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.checkEditHabilitado);
            this.Controls.Add(this.textEditGrupo);
            this.Controls.Add(this.labelControlGrupo);
            this.Name = "EditarGrupoLosa";
            this.Text = "Editar Grupo Losa";
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHabilitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrupo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton botonCancelar;
        private DevExpress.XtraEditors.SimpleButton botonGuardar;
        private DevExpress.XtraEditors.CheckEdit checkEditHabilitado;
        private DevExpress.XtraEditors.TextEdit textEditGrupo;
        private DevExpress.XtraEditors.LabelControl labelControlGrupo;
    }
}