﻿
namespace CapaVistaMVentasCC
{
    partial class MDIProyectoEF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIProyectoEF));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantienimientoTipoComisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cerarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cerarSesiónToolStripMenuItem
            // 
            this.cerarSesiónToolStripMenuItem.Name = "cerarSesiónToolStripMenuItem";
            this.cerarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerarSesiónToolStripMenuItem.Text = "Cerar Sesión ";
            this.cerarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerarSesiónToolStripMenuItem_Click);
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.bodegasToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.lineaToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoInventarioToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // tipoInventarioToolStripMenuItem
            // 
            this.tipoInventarioToolStripMenuItem.Name = "tipoInventarioToolStripMenuItem";
            this.tipoInventarioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tipoInventarioToolStripMenuItem.Text = "Tipo Inventario";
            this.tipoInventarioToolStripMenuItem.Click += new System.EventHandler(this.tipoInventarioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantienimientoTipoComisiónToolStripMenuItem});
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // mantienimientoTipoComisiónToolStripMenuItem
            // 
            this.mantienimientoTipoComisiónToolStripMenuItem.Name = "mantienimientoTipoComisiónToolStripMenuItem";
            this.mantienimientoTipoComisiónToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.mantienimientoTipoComisiónToolStripMenuItem.Text = "Mantienimiento Tipo Comisión";
            this.mantienimientoTipoComisiónToolStripMenuItem.Click += new System.EventHandler(this.mantienimientoTipoComisiónToolStripMenuItem_Click);
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoBodegaToolStripMenuItem,
            this.tipoBodegaToolStripMenuItem});
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            // 
            // mantenimientoBodegaToolStripMenuItem
            // 
            this.mantenimientoBodegaToolStripMenuItem.Name = "mantenimientoBodegaToolStripMenuItem";
            this.mantenimientoBodegaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mantenimientoBodegaToolStripMenuItem.Text = "Mantenimiento Bodega";
            this.mantenimientoBodegaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoBodegaToolStripMenuItem_Click);
            // 
            // tipoBodegaToolStripMenuItem
            // 
            this.tipoBodegaToolStripMenuItem.Name = "tipoBodegaToolStripMenuItem";
            this.tipoBodegaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tipoBodegaToolStripMenuItem.Text = "Tipo Bodega";
            this.tipoBodegaToolStripMenuItem.Click += new System.EventHandler(this.tipoBodegaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineaToolStripMenuItem.Text = "Linea";
            this.lineaToolStripMenuItem.Click += new System.EventHandler(this.lineaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comisionesToolStripMenuItem1});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // comisionesToolStripMenuItem1
            // 
            this.comisionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarComisionesToolStripMenuItem});
            this.comisionesToolStripMenuItem1.Name = "comisionesToolStripMenuItem1";
            this.comisionesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.comisionesToolStripMenuItem1.Text = "Comisiones";
            // 
            // gestionarComisionesToolStripMenuItem
            // 
            this.gestionarComisionesToolStripMenuItem.Name = "gestionarComisionesToolStripMenuItem";
            this.gestionarComisionesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarComisionesToolStripMenuItem.Text = "Gestionar Comisiones";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(688, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Visible = false;
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoProductoToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // matenimientoProductoToolStripMenuItem
            // 
            this.matenimientoProductoToolStripMenuItem.Name = "matenimientoProductoToolStripMenuItem";
            this.matenimientoProductoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.matenimientoProductoToolStripMenuItem.Text = "Matenimiento Producto";
            this.matenimientoProductoToolStripMenuItem.Click += new System.EventHandler(this.matenimientoProductoToolStripMenuItem_Click);
            // 
            // MDIProyectoEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIProyectoEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3001 MDI Ventas y Cuentas por Cobrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIVentas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerarSesiónToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarComisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantienimientoTipoComisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matenimientoProductoToolStripMenuItem;
    }
}