namespace WFHostalAPPEscritorio
{
    partial class FormularioEmpleado
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
            this.LbBienvenida = new System.Windows.Forms.Label();
            this.picBLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.generarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloHostalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkINCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorOrdenDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenedorComedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenedorFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarOrdenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorOrdenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenedorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbBienvenida
            // 
            this.LbBienvenida.AutoSize = true;
            this.LbBienvenida.Location = new System.Drawing.Point(57, 142);
            this.LbBienvenida.Name = "LbBienvenida";
            this.LbBienvenida.Size = new System.Drawing.Size(35, 13);
            this.LbBienvenida.TabIndex = 14;
            this.LbBienvenida.Text = "label1";
            // 
            // picBLogo
            // 
            this.picBLogo.Image = global::WFHostalAPPEscritorio.Properties.Resources.logo_hostal;
            this.picBLogo.Location = new System.Drawing.Point(60, 46);
            this.picBLogo.Name = "picBLogo";
            this.picBLogo.Size = new System.Drawing.Size(121, 93);
            this.picBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBLogo.TabIndex = 15;
            this.picBLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.moduloFacturaciónToolStripMenuItem,
            this.moduloHostalToolStripMenuItem,
            this.moduloProveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // moduloFacturaciónToolStripMenuItem
            // 
            this.moduloFacturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpresaToolStripMenuItem,
            this.mantenedorEmpresaToolStripMenuItem,
            this.toolStripSeparator1,
            this.generarFacturasToolStripMenuItem});
            this.moduloFacturaciónToolStripMenuItem.Name = "moduloFacturaciónToolStripMenuItem";
            this.moduloFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.moduloFacturaciónToolStripMenuItem.Text = "Módulo Facturación";
            // 
            // registrarEmpresaToolStripMenuItem
            // 
            this.registrarEmpresaToolStripMenuItem.Name = "registrarEmpresaToolStripMenuItem";
            this.registrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.registrarEmpresaToolStripMenuItem.Text = "Registrar Empresa";
            // 
            // mantenedorEmpresaToolStripMenuItem
            // 
            this.mantenedorEmpresaToolStripMenuItem.Name = "mantenedorEmpresaToolStripMenuItem";
            this.mantenedorEmpresaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mantenedorEmpresaToolStripMenuItem.Text = "Mantenedor Empresa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // generarFacturasToolStripMenuItem
            // 
            this.generarFacturasToolStripMenuItem.Name = "generarFacturasToolStripMenuItem";
            this.generarFacturasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.generarFacturasToolStripMenuItem.Text = "Generar Facturas";
            // 
            // moduloHostalToolStripMenuItem
            // 
            this.moduloHostalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkINCheckOutToolStripMenuItem,
            this.mantenedorOrdenDeServiciosToolStripMenuItem,
            this.toolStripSeparator2,
            this.mantenedorComedorToolStripMenuItem,
            this.toolStripSeparator3,
            this.mantenedorFacturasToolStripMenuItem,
            this.mantenedorUsuariosToolStripMenuItem});
            this.moduloHostalToolStripMenuItem.Name = "moduloHostalToolStripMenuItem";
            this.moduloHostalToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.moduloHostalToolStripMenuItem.Text = "Módulo Hostal";
            // 
            // checkINCheckOutToolStripMenuItem
            // 
            this.checkINCheckOutToolStripMenuItem.Name = "checkINCheckOutToolStripMenuItem";
            this.checkINCheckOutToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.checkINCheckOutToolStripMenuItem.Text = "CheckIN/CheckOut";
            // 
            // mantenedorOrdenDeServiciosToolStripMenuItem
            // 
            this.mantenedorOrdenDeServiciosToolStripMenuItem.Name = "mantenedorOrdenDeServiciosToolStripMenuItem";
            this.mantenedorOrdenDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.mantenedorOrdenDeServiciosToolStripMenuItem.Text = "Mantenedor Orden de Servicios";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // mantenedorComedorToolStripMenuItem
            // 
            this.mantenedorComedorToolStripMenuItem.Name = "mantenedorComedorToolStripMenuItem";
            this.mantenedorComedorToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.mantenedorComedorToolStripMenuItem.Text = "Mantenedor Huéspedes";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // mantenedorFacturasToolStripMenuItem
            // 
            this.mantenedorFacturasToolStripMenuItem.Name = "mantenedorFacturasToolStripMenuItem";
            this.mantenedorFacturasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.mantenedorFacturasToolStripMenuItem.Text = "Mantenedor Facturas";
            // 
            // mantenedorUsuariosToolStripMenuItem
            // 
            this.mantenedorUsuariosToolStripMenuItem.Name = "mantenedorUsuariosToolStripMenuItem";
            this.mantenedorUsuariosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.mantenedorUsuariosToolStripMenuItem.Text = "Mantenedor Usuarios";
            // 
            // moduloProveedoresToolStripMenuItem
            // 
            this.moduloProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarOrdenDePedidoToolStripMenuItem,
            this.recepciónDePedidoToolStripMenuItem,
            this.mantenedorOrdenDePedidoToolStripMenuItem,
            this.toolStripSeparator4,
            this.mantenedorProductoToolStripMenuItem,
            this.mantenedorProveedoresToolStripMenuItem,
            this.registrarProveedorToolStripMenuItem});
            this.moduloProveedoresToolStripMenuItem.Name = "moduloProveedoresToolStripMenuItem";
            this.moduloProveedoresToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.moduloProveedoresToolStripMenuItem.Text = "Módulo Proveedores";
            // 
            // ingresarOrdenDePedidoToolStripMenuItem
            // 
            this.ingresarOrdenDePedidoToolStripMenuItem.Name = "ingresarOrdenDePedidoToolStripMenuItem";
            this.ingresarOrdenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ingresarOrdenDePedidoToolStripMenuItem.Text = "Ingresar Orden de Pedido";
            // 
            // recepciónDePedidoToolStripMenuItem
            // 
            this.recepciónDePedidoToolStripMenuItem.Name = "recepciónDePedidoToolStripMenuItem";
            this.recepciónDePedidoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.recepciónDePedidoToolStripMenuItem.Text = "Recepción de Pedido";
            // 
            // mantenedorOrdenDePedidoToolStripMenuItem
            // 
            this.mantenedorOrdenDePedidoToolStripMenuItem.Name = "mantenedorOrdenDePedidoToolStripMenuItem";
            this.mantenedorOrdenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.mantenedorOrdenDePedidoToolStripMenuItem.Text = "Mantenedor Orden de Pedido";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(212, 6);
            // 
            // mantenedorProductoToolStripMenuItem
            // 
            this.mantenedorProductoToolStripMenuItem.Name = "mantenedorProductoToolStripMenuItem";
            this.mantenedorProductoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.mantenedorProductoToolStripMenuItem.Text = "Mantenedor Producto";
            // 
            // mantenedorProveedoresToolStripMenuItem
            // 
            this.mantenedorProveedoresToolStripMenuItem.Name = "mantenedorProveedoresToolStripMenuItem";
            this.mantenedorProveedoresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.mantenedorProveedoresToolStripMenuItem.Text = "Mantenedor Proveedores";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.registrarProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBLogo);
            this.Controls.Add(this.LbBienvenida);
            this.Name = "FormularioEmpleado";
            this.Text = "FormularioEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbBienvenida;
        private System.Windows.Forms.PictureBox picBLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloFacturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem generarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloHostalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkINCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorOrdenDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mantenedorComedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mantenedorFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarOrdenDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepciónDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorOrdenDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
    }
}