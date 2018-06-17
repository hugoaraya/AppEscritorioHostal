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
            this.moduloHostalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkINCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenedorComedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarOrdenDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenedorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbBienvenida
            // 
            this.LbBienvenida.AutoSize = true;
            this.LbBienvenida.Location = new System.Drawing.Point(57, 142);
            this.LbBienvenida.Name = "LbBienvenida";
            this.LbBienvenida.Size = new System.Drawing.Size(11, 13);
            this.LbBienvenida.TabIndex = 14;
            this.LbBienvenida.Text = "*";
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
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
            this.mantenedorEmpresaToolStripMenuItem});
            this.moduloFacturaciónToolStripMenuItem.Name = "moduloFacturaciónToolStripMenuItem";
            this.moduloFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.moduloFacturaciónToolStripMenuItem.Text = "Módulo Facturación";
            // 
            // registrarEmpresaToolStripMenuItem
            // 
            this.registrarEmpresaToolStripMenuItem.Name = "registrarEmpresaToolStripMenuItem";
            this.registrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registrarEmpresaToolStripMenuItem.Text = "Registrar Empresa";
            this.registrarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpresaToolStripMenuItem_Click);
            // 
            // mantenedorEmpresaToolStripMenuItem
            // 
            this.mantenedorEmpresaToolStripMenuItem.Name = "mantenedorEmpresaToolStripMenuItem";
            this.mantenedorEmpresaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mantenedorEmpresaToolStripMenuItem.Text = "Mantenedor Empresa";
            this.mantenedorEmpresaToolStripMenuItem.Click += new System.EventHandler(this.mantenedorEmpresaToolStripMenuItem_Click);
            // 
            // moduloHostalToolStripMenuItem
            // 
            this.moduloHostalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkINCheckOutToolStripMenuItem,
            this.toolStripSeparator3,
            this.mantenedorComedorToolStripMenuItem});
            this.moduloHostalToolStripMenuItem.Name = "moduloHostalToolStripMenuItem";
            this.moduloHostalToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.moduloHostalToolStripMenuItem.Text = "Módulo Hostal";
            // 
            // checkINCheckOutToolStripMenuItem
            // 
            this.checkINCheckOutToolStripMenuItem.Name = "checkINCheckOutToolStripMenuItem";
            this.checkINCheckOutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.checkINCheckOutToolStripMenuItem.Text = "CheckIN/CheckOut";
            this.checkINCheckOutToolStripMenuItem.Click += new System.EventHandler(this.checkINCheckOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // mantenedorComedorToolStripMenuItem
            // 
            this.mantenedorComedorToolStripMenuItem.Name = "mantenedorComedorToolStripMenuItem";
            this.mantenedorComedorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mantenedorComedorToolStripMenuItem.Text = "Mantenedor Huéspedes";
            this.mantenedorComedorToolStripMenuItem.Click += new System.EventHandler(this.mantenedorComedorToolStripMenuItem_Click);
            // 
            // moduloProveedoresToolStripMenuItem
            // 
            this.moduloProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarOrdenDePedidoToolStripMenuItem,
            this.recepciónDePedidoToolStripMenuItem,
            this.toolStripSeparator4,
            this.mantenedorProductoToolStripMenuItem,
            this.toolStripSeparator2,
            this.registrarProveedorToolStripMenuItem,
            this.mantenedorProveedoresToolStripMenuItem});
            this.moduloProveedoresToolStripMenuItem.Name = "moduloProveedoresToolStripMenuItem";
            this.moduloProveedoresToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.moduloProveedoresToolStripMenuItem.Text = "Módulo Proveedores";
            // 
            // ingresarOrdenDePedidoToolStripMenuItem
            // 
            this.ingresarOrdenDePedidoToolStripMenuItem.Name = "ingresarOrdenDePedidoToolStripMenuItem";
            this.ingresarOrdenDePedidoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ingresarOrdenDePedidoToolStripMenuItem.Text = "Ingresar Orden de Pedido";
            this.ingresarOrdenDePedidoToolStripMenuItem.Click += new System.EventHandler(this.ingresarOrdenDePedidoToolStripMenuItem_Click);
            // 
            // recepciónDePedidoToolStripMenuItem
            // 
            this.recepciónDePedidoToolStripMenuItem.Name = "recepciónDePedidoToolStripMenuItem";
            this.recepciónDePedidoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.recepciónDePedidoToolStripMenuItem.Text = "Recepción de Pedido";
            this.recepciónDePedidoToolStripMenuItem.Click += new System.EventHandler(this.recepciónDePedidoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // mantenedorProductoToolStripMenuItem
            // 
            this.mantenedorProductoToolStripMenuItem.Name = "mantenedorProductoToolStripMenuItem";
            this.mantenedorProductoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mantenedorProductoToolStripMenuItem.Text = "Mantenedor Producto";
            this.mantenedorProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenedorProductoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.registrarProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            this.registrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // mantenedorProveedoresToolStripMenuItem
            // 
            this.mantenedorProveedoresToolStripMenuItem.Name = "mantenedorProveedoresToolStripMenuItem";
            this.mantenedorProveedoresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mantenedorProveedoresToolStripMenuItem.Text = "Mantenedor Proveedores";
            this.mantenedorProveedoresToolStripMenuItem.Click += new System.EventHandler(this.mantenedorProveedoresToolStripMenuItem_Click);
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
            this.Text = "Formulario Empleado";
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
        private System.Windows.Forms.ToolStripMenuItem moduloHostalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkINCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mantenedorComedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarOrdenDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepciónDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProveedoresToolStripMenuItem;
    }
}