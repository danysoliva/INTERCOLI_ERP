
namespace ERP_INTECOLI.Administracion.Estudiantes
{
    partial class frmRecuentoGeneros
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHombres = new System.Windows.Forms.Label();
            this.lblMujeres = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMujer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMujer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Recuento de Estudiantes por Genero";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(35, 412);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(624, 73);
            this.lblTotal.TabIndex = 54;
            this.lblTotal.Text = "00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHombres
            // 
            this.lblHombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHombres.Location = new System.Drawing.Point(441, 285);
            this.lblHombres.Name = "lblHombres";
            this.lblHombres.Size = new System.Drawing.Size(166, 73);
            this.lblHombres.TabIndex = 53;
            this.lblHombres.Text = "00";
            this.lblHombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMujeres
            // 
            this.lblMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMujeres.Location = new System.Drawing.Point(101, 285);
            this.lblMujeres.Name = "lblMujeres";
            this.lblMujeres.Size = new System.Drawing.Size(166, 73);
            this.lblMujeres.TabIndex = 52;
            this.lblMujeres.Text = "00";
            this.lblMujeres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.SpringGreen;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(300, 516);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(92, 40);
            this.cmdCancelar.TabIndex = 55;
            this.cmdCancelar.Text = "Aceptar";
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ERP_INTECOLI.Properties.Resources.jefe_x128;
            this.pictureBox1.Location = new System.Drawing.Point(441, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pbMujer
            // 
            this.pbMujer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMujer.Image = global::ERP_INTECOLI.Properties.Resources.mujeres_x128;
            this.pbMujer.Location = new System.Drawing.Point(101, 105);
            this.pbMujer.Name = "pbMujer";
            this.pbMujer.Size = new System.Drawing.Size(166, 157);
            this.pbMujer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMujer.TabIndex = 48;
            this.pbMujer.TabStop = false;
            // 
            // frmRecuentoGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 590);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHombres);
            this.Controls.Add(this.lblMujeres);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMujer);
            this.Controls.Add(this.label4);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmRecuentoGeneros";
            this.Load += new System.EventHandler(this.frmRecuentoGeneros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMujer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbMujer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHombres;
        private System.Windows.Forms.Label lblMujeres;
        private System.Windows.Forms.Button cmdCancelar;
    }
}