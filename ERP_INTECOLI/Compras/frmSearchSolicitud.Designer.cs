
namespace ERP_INTECOLI.Compras
{
    partial class frmSearchSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchSolicitud));
            this.grdSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.dsCompras1 = new ERP_INTECOLI.Compras.dsCompras();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado_solicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_contabilizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSolicitudes
            // 
            this.grdSolicitudes.DataMember = "solicitudes";
            this.grdSolicitudes.DataSource = this.dsCompras1;
            this.grdSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.grdSolicitudes.MainView = this.gridView1;
            this.grdSolicitudes.Name = "grdSolicitudes";
            this.grdSolicitudes.Size = new System.Drawing.Size(882, 454);
            this.grdSolicitudes.TabIndex = 0;
            this.grdSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsCompras1
            // 
            this.dsCompras1.DataSetName = "dsCompras";
            this.dsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_solicitud,
            this.colid_user,
            this.colusuario,
            this.colid_estado_solicitud,
            this.colestado,
            this.colfecha_registro,
            this.colfecha_contabilizacion,
            this.colcomentario});
            this.gridView1.GridControl = this.grdSolicitudes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colid_solicitud
            // 
            this.colid_solicitud.Caption = "Num. Doc";
            this.colid_solicitud.FieldName = "id_solicitud";
            this.colid_solicitud.Name = "colid_solicitud";
            this.colid_solicitud.OptionsColumn.AllowEdit = false;
            this.colid_solicitud.Visible = true;
            this.colid_solicitud.VisibleIndex = 0;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.OptionsColumn.AllowEdit = false;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario Creador";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowEdit = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 1;
            // 
            // colid_estado_solicitud
            // 
            this.colid_estado_solicitud.FieldName = "id_estado_solicitud";
            this.colid_estado_solicitud.Name = "colid_estado_solicitud";
            this.colid_estado_solicitud.OptionsColumn.AllowEdit = false;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado Solicitud";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.OptionsColumn.AllowEdit = false;
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.OptionsColumn.AllowEdit = false;
            // 
            // colfecha_contabilizacion
            // 
            this.colfecha_contabilizacion.Caption = "Fecha";
            this.colfecha_contabilizacion.FieldName = "fecha_contabilizacion";
            this.colfecha_contabilizacion.Name = "colfecha_contabilizacion";
            this.colfecha_contabilizacion.OptionsColumn.AllowEdit = false;
            this.colfecha_contabilizacion.Visible = true;
            this.colfecha_contabilizacion.VisibleIndex = 3;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.OptionsColumn.AllowEdit = false;
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 4;
            // 
            // frmSearchSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 454);
            this.Controls.Add(this.grdSolicitudes);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmSearchSolicitud.IconOptions.LargeImage")));
            this.Name = "frmSearchSolicitud";
            this.Text = "Seleccionar Solicitud";
            ((System.ComponentModel.ISupportInitialize)(this.grdSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsCompras dsCompras1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado_solicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_contabilizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
    }
}