
namespace ERP_INTECOLI.Accesos.GrupoLosa
{
    partial class CrearGrupoLosa
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
            this.labelControlGrupo = new DevExpress.XtraEditors.LabelControl();
            this.textEditGrupo = new DevExpress.XtraEditors.TextEdit();
            this.checkEditHabilitado = new DevExpress.XtraEditors.CheckEdit();
            this.botonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.botonCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHabilitado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlGrupo
            // 
            this.labelControlGrupo.Location = new System.Drawing.Point(24, 41);
            this.labelControlGrupo.Name = "labelControlGrupo";
            this.labelControlGrupo.Size = new System.Drawing.Size(29, 13);
            this.labelControlGrupo.TabIndex = 0;
            this.labelControlGrupo.Text = "Grupo";
            // 
            // textEditGrupo
            // 
            this.textEditGrupo.Location = new System.Drawing.Point(24, 60);
            this.textEditGrupo.Name = "textEditGrupo";
            this.textEditGrupo.Size = new System.Drawing.Size(229, 20);
            this.textEditGrupo.TabIndex = 1;
            // 
            // checkEditHabilitado
            // 
            this.checkEditHabilitado.EditValue = true;
            this.checkEditHabilitado.Location = new System.Drawing.Point(24, 112);
            this.checkEditHabilitado.Name = "checkEditHabilitado";
            this.checkEditHabilitado.Properties.Caption = "Habilitado";
            this.checkEditHabilitado.Size = new System.Drawing.Size(75, 19);
            this.checkEditHabilitado.TabIndex = 2;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(24, 233);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 3;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Appearance.BackColor = System.Drawing.Color.Red;
            this.botonCancelar.Appearance.Options.UseBackColor = true;
            this.botonCancelar.Location = new System.Drawing.Point(106, 233);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 4;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // CrearGrupoLosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 268);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.checkEditHabilitado);
            this.Controls.Add(this.textEditGrupo);
            this.Controls.Add(this.labelControlGrupo);
            this.Name = "CrearGrupoLosa";
            this.Text = "Crear Grupo Losa";
            ((System.ComponentModel.ISupportInitialize)(this.textEditGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHabilitado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlGrupo;
        private DevExpress.XtraEditors.TextEdit textEditGrupo;
        private DevExpress.XtraEditors.CheckEdit checkEditHabilitado;
        private DevExpress.XtraEditors.SimpleButton botonGuardar;
        private DevExpress.XtraEditors.SimpleButton botonCancelar;
    }
}