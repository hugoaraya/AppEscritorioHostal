namespace WFHostalAPPEscritorio
{
    partial class MantenedorProveedores
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
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txRut = new System.Windows.Forms.TextBox();
            this.txDv = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDireccion = new System.Windows.Forms.TextBox();
            this.txRubro = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(335, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(537, 295);
            this.dgvProveedor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txRubro);
            this.groupBox1.Controls.Add(this.txDireccion);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.txDv);
            this.groupBox1.Controls.Add(this.txRut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rubro:";
            // 
            // txRut
            // 
            this.txRut.Location = new System.Drawing.Point(70, 24);
            this.txRut.Name = "txRut";
            this.txRut.Size = new System.Drawing.Size(145, 20);
            this.txRut.TabIndex = 5;
            // 
            // txDv
            // 
            this.txDv.Location = new System.Drawing.Point(238, 23);
            this.txDv.Name = "txDv";
            this.txDv.Size = new System.Drawing.Size(37, 20);
            this.txDv.TabIndex = 6;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(70, 60);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(145, 20);
            this.txNombre.TabIndex = 7;
            // 
            // txDireccion
            // 
            this.txDireccion.Location = new System.Drawing.Point(70, 95);
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.Size = new System.Drawing.Size(145, 20);
            this.txDireccion.TabIndex = 8;
            // 
            // txRubro
            // 
            this.txRubro.Location = new System.Drawing.Point(70, 130);
            this.txRubro.Name = "txRubro";
            this.txRubro.Size = new System.Drawing.Size(145, 20);
            this.txRubro.TabIndex = 9;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(196, 256);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(92, 23);
            this.btnTodos.TabIndex = 2;
            this.btnTodos.Text = "Mostrar Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(213, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar RUT";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(112, 214);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(112, 256);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(13, 295);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 7;
            // 
            // MantenedorProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 331);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProveedor);
            this.Name = "MantenedorProveedores";
            this.Text = "MantenedorProveedores";
            this.Load += new System.EventHandler(this.MantenedorProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txRubro;
        private System.Windows.Forms.TextBox txDireccion;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDv;
        private System.Windows.Forms.TextBox txRut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMsg;
    }
}