﻿
using DevExpress.XtraTab;

namespace ERP_INTECOLI
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.xtraTabControlMenu = new DevExpress.XtraTab.XtraTabControl();
            this.TabAdministracion = new DevExpress.XtraTab.XtraTabPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarEstudiantes = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarInstructor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navMatricula = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPermisosUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.navUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblServerName = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMenu)).BeginInit();
            this.xtraTabControlMenu.SuspendLayout();
            this.TabAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlMenu
            // 
            this.xtraTabControlMenu.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControlMenu.Appearance.Options.UseBackColor = true;
            this.xtraTabControlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlMenu.Name = "xtraTabControlMenu";
            this.xtraTabControlMenu.SelectedTabPage = this.TabAdministracion;
            this.xtraTabControlMenu.Size = new System.Drawing.Size(209, 759);
            this.xtraTabControlMenu.TabIndex = 0;
            this.xtraTabControlMenu.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAdministracion});
            this.xtraTabControlMenu.Visible = false;
            // 
            // TabAdministracion
            // 
            this.TabAdministracion.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.TabAdministracion.Appearance.PageClient.Options.UseBackColor = true;
            this.TabAdministracion.Controls.Add(this.navBarControl1);
            this.TabAdministracion.Name = "TabAdministracion";
            this.TabAdministracion.Size = new System.Drawing.Size(207, 734);
            this.TabAdministracion.Text = "Menu Principal";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navBarControl1.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarSeparatorItem1,
            this.navBarEstudiantes,
            this.navBarItem4,
            this.navBarInstructor,
            this.navBarSeparatorItem2,
            this.navMatricula,
            this.navBarSeparatorItem3,
            this.navPermisosUsuarios,
            this.navUsuarios});
            this.navBarControl1.Location = new System.Drawing.Point(3, 3);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl1.Size = new System.Drawing.Size(204, 728);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Acciones";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEstudiantes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarInstructor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navMatricula),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // navBarEstudiantes
            // 
            this.navBarEstudiantes.Caption = "Estudiantes";
            this.navBarEstudiantes.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.Estudiantex32;
            this.navBarEstudiantes.Name = "navBarEstudiantes";
            this.navBarEstudiantes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEstudiantes_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Niveles Academicos";
            this.navBarItem4.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.Niveles_x32;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarInstructor
            // 
            this.navBarInstructor.Caption = "Instructores";
            this.navBarInstructor.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.maestro_x32;
            this.navBarInstructor.Name = "navBarInstructor";
            this.navBarInstructor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarInstructor_LinkClicked);
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // navMatricula
            // 
            this.navMatricula.Caption = "Matricula";
            this.navMatricula.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.matriculax32;
            this.navMatricula.Name = "navMatricula";
            this.navMatricula.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMatricula_LinkClicked);
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Usuarios";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPermisosUsuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUsuarios)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navPermisosUsuarios
            // 
            this.navPermisosUsuarios.Caption = "Gestion de Permisos";
            this.navPermisosUsuarios.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.control_de_accessox32;
            this.navPermisosUsuarios.Name = "navPermisosUsuarios";
            this.navPermisosUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navPermisosUsuarios_LinkClicked);
            // 
            // navUsuarios
            // 
            this.navUsuarios.Caption = "Usuarios y Permisos";
            this.navUsuarios.ImageOptions.SmallImage = global::ERP_INTECOLI.Properties.Resources.userx32;
            this.navUsuarios.Name = "navUsuarios";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.lblServerName});
            this.statusStrip1.Location = new System.Drawing.Point(209, 737);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 759);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.xtraTabControlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Text = "ERP - Success English Academy System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMenu)).EndInit();
            this.xtraTabControlMenu.ResumeLayout(false);
            this.TabAdministracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraTabControl xtraTabControlMenu;
        private XtraTabPage TabAdministracion;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarEstudiantes;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarInstructor;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem navMatricula;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblServerName;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navPermisosUsuarios;
        private DevExpress.XtraNavBar.NavBarItem navUsuarios;
    }
}