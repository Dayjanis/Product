namespace fromproveedorprodcuto1
{
    partial class MDIProducto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIProducto));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenimientoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RespaldoBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCatalogo,
            this.gestionMenu,
            this.mantenimientoMenu,
            this.AyudaMenu,
            this.salirMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileCatalogo
            // 
            this.fileCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.toolStripSeparator3,
            this.productoToolStripMenuItem});
            this.fileCatalogo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileCatalogo.Name = "fileCatalogo";
            this.fileCatalogo.Size = new System.Drawing.Size(67, 20);
            this.fileCatalogo.Text = "&Catalogo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedorToolStripMenuItem.Image")));
            this.proveedorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.proveedorToolStripMenuItem.Text = "&Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productoToolStripMenuItem.Image")));
            this.productoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.productoToolStripMenuItem.Text = "&Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // gestionMenu
            // 
            this.gestionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.toolStripSeparator6});
            this.gestionMenu.Name = "gestionMenu";
            this.gestionMenu.Size = new System.Drawing.Size(59, 20);
            this.gestionMenu.Text = "&Gestion";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compraToolStripMenuItem.Image")));
            this.compraToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.compraToolStripMenuItem.Text = "&Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaToolStripMenuItem.Image")));
            this.ventaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ventaToolStripMenuItem.Text = "&Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(155, 6);
            // 
            // mantenimientoMenu
            // 
            this.mantenimientoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioBarToolStripMenuItem,
            this.RespaldoBarToolStripMenuItem});
            this.mantenimientoMenu.Name = "mantenimientoMenu";
            this.mantenimientoMenu.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoMenu.Text = "&Mantenimiento";
            // 
            // usuarioBarToolStripMenuItem
            // 
            this.usuarioBarToolStripMenuItem.Checked = true;
            this.usuarioBarToolStripMenuItem.CheckOnClick = true;
            this.usuarioBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usuarioBarToolStripMenuItem.Name = "usuarioBarToolStripMenuItem";
            this.usuarioBarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuarioBarToolStripMenuItem.Text = "&Usuario";
            this.usuarioBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // RespaldoBarToolStripMenuItem
            // 
            this.RespaldoBarToolStripMenuItem.Checked = true;
            this.RespaldoBarToolStripMenuItem.CheckOnClick = true;
            this.RespaldoBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RespaldoBarToolStripMenuItem.Name = "RespaldoBarToolStripMenuItem";
            this.RespaldoBarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.RespaldoBarToolStripMenuItem.Text = "&Respaldo";
            this.RespaldoBarToolStripMenuItem.Click += new System.EventHandler(this.RespaldoBarToolStripMenuItem_Click);
            // 
            // AyudaMenu
            // 
            this.AyudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaToolStripMenuItem});
            this.AyudaMenu.Name = "AyudaMenu";
            this.AyudaMenu.Size = new System.Drawing.Size(53, 20);
            this.AyudaMenu.Text = "&Ayuda";
            // 
            // AcercaToolStripMenuItem
            // 
            this.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem";
            this.AcercaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.AcercaToolStripMenuItem.Text = "&Acerca";
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(41, 20);
            this.salirMenu.Text = "Salir";
            this.salirMenu.Click += new System.EventHandler(this.salirMenu_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "Nuevo";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Abrir";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDIProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIProducto";
            this.Text = "MDIProducto";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileCatalogo;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMenu;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RespaldoBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaMenu;
        private System.Windows.Forms.ToolStripMenuItem AcercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
    }
}



