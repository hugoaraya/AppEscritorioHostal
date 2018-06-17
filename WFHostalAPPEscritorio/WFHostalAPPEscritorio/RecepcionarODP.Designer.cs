namespace WFHostalAPPEscritorio
{
    partial class RecepcionarODP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnCerrada = new System.Windows.Forms.Button();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.dgvODP = new System.Windows.Forms.DataGridView();
            this.btnBuscarODP = new System.Windows.Forms.Button();
            this.txODP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.lblGrilla = new System.Windows.Forms.Label();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIDRecep = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDescripc = new System.Windows.Forms.Label();
            this.lbIDProd = new System.Windows.Forms.Label();
            this.lbCodigoBarra = new System.Windows.Forms.Label();
            this.dtiVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIdODP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODP)).BeginInit();
            this.gbProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIdODP);
            this.groupBox1.Controls.Add(this.lbProveedor);
            this.groupBox1.Controls.Add(this.lbEstado);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.btnCerrada);
            this.groupBox1.Controls.Add(this.btnPendiente);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de ODP";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(20, 20);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(129, 13);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Estado Orden de Pedido :";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(21, 39);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(59, 13);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Proveedor:";
            // 
            // btnCerrada
            // 
            this.btnCerrada.Location = new System.Drawing.Point(93, 295);
            this.btnCerrada.Name = "btnCerrada";
            this.btnCerrada.Size = new System.Drawing.Size(75, 23);
            this.btnCerrada.TabIndex = 4;
            this.btnCerrada.Text = "Cerrada";
            this.btnCerrada.UseVisualStyleBackColor = true;
            // 
            // btnPendiente
            // 
            this.btnPendiente.Location = new System.Drawing.Point(185, 295);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(104, 23);
            this.btnPendiente.TabIndex = 1;
            this.btnPendiente.Text = "Pendiente";
            this.btnPendiente.UseVisualStyleBackColor = true;
            // 
            // dgvODP
            // 
            this.dgvODP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODP.Location = new System.Drawing.Point(328, 49);
            this.dgvODP.Name = "dgvODP";
            this.dgvODP.Size = new System.Drawing.Size(567, 341);
            this.dgvODP.TabIndex = 1;
            this.dgvODP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvODP_CellDoubleClick);
            // 
            // btnBuscarODP
            // 
            this.btnBuscarODP.Location = new System.Drawing.Point(240, 12);
            this.btnBuscarODP.Name = "btnBuscarODP";
            this.btnBuscarODP.Size = new System.Drawing.Size(80, 23);
            this.btnBuscarODP.TabIndex = 2;
            this.btnBuscarODP.Text = "Buscar ODP";
            this.btnBuscarODP.UseVisualStyleBackColor = true;
            this.btnBuscarODP.Click += new System.EventHandler(this.btnBuscarODP_Click);
            // 
            // txODP
            // 
            this.txODP.Location = new System.Drawing.Point(134, 13);
            this.txODP.Name = "txODP";
            this.txODP.Size = new System.Drawing.Size(100, 20);
            this.txODP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Nro de Orden";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(103, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(13, 404);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(11, 13);
            this.lbMsg.TabIndex = 7;
            this.lbMsg.Text = "*";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(156, 20);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 13);
            this.lbEstado.TabIndex = 7;
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(89, 39);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(0, 13);
            this.lbProveedor.TabIndex = 8;
            // 
            // lblGrilla
            // 
            this.lblGrilla.AutoSize = true;
            this.lblGrilla.Location = new System.Drawing.Point(328, 30);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(14, 13);
            this.lblGrilla.TabIndex = 8;
            this.lblGrilla.Text = "V";
            // 
            // gbProd
            // 
            this.gbProd.Controls.Add(this.label6);
            this.gbProd.Controls.Add(this.dtiVencimiento);
            this.gbProd.Controls.Add(this.lbCantidad);
            this.gbProd.Controls.Add(this.lbDescripc);
            this.gbProd.Controls.Add(this.lbIDProd);
            this.gbProd.Controls.Add(this.lbCodigoBarra);
            this.gbProd.Controls.Add(this.lbIDRecep);
            this.gbProd.Controls.Add(this.label5);
            this.gbProd.Controls.Add(this.label4);
            this.gbProd.Controls.Add(this.label3);
            this.gbProd.Controls.Add(this.label2);
            this.gbProd.Location = new System.Drawing.Point(12, 130);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(308, 145);
            this.gbProd.TabIndex = 9;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Datos Producto";
            this.gbProd.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad Solicitada";
            // 
            // lbIDRecep
            // 
            this.lbIDRecep.AutoSize = true;
            this.lbIDRecep.Location = new System.Drawing.Point(13, 116);
            this.lbIDRecep.Name = "lbIDRecep";
            this.lbIDRecep.Size = new System.Drawing.Size(0, 13);
            this.lbIDRecep.TabIndex = 4;
            this.lbIDRecep.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(176, 281);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(144, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar Recepción";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(120, 88);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(0, 13);
            this.lbCantidad.TabIndex = 8;
            // 
            // lbDescripc
            // 
            this.lbDescripc.AutoSize = true;
            this.lbDescripc.Location = new System.Drawing.Point(119, 64);
            this.lbDescripc.Name = "lbDescripc";
            this.lbDescripc.Size = new System.Drawing.Size(0, 13);
            this.lbDescripc.TabIndex = 7;
            // 
            // lbIDProd
            // 
            this.lbIDProd.AutoSize = true;
            this.lbIDProd.Location = new System.Drawing.Point(119, 25);
            this.lbIDProd.Name = "lbIDProd";
            this.lbIDProd.Size = new System.Drawing.Size(0, 13);
            this.lbIDProd.TabIndex = 6;
            // 
            // lbCodigoBarra
            // 
            this.lbCodigoBarra.AutoSize = true;
            this.lbCodigoBarra.Location = new System.Drawing.Point(119, 44);
            this.lbCodigoBarra.Name = "lbCodigoBarra";
            this.lbCodigoBarra.Size = new System.Drawing.Size(0, 13);
            this.lbCodigoBarra.TabIndex = 5;
            // 
            // dtiVencimiento
            // 
            this.dtiVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtiVencimiento.Location = new System.Drawing.Point(159, 109);
            this.dtiVencimiento.Name = "dtiVencimiento";
            this.dtiVencimiento.Size = new System.Drawing.Size(92, 20);
            this.dtiVencimiento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrese Fecha Vencimiento";
            // 
            // lbIdODP
            // 
            this.lbIdODP.AutoSize = true;
            this.lbIdODP.Location = new System.Drawing.Point(5, 19);
            this.lbIdODP.Name = "lbIdODP";
            this.lbIdODP.Size = new System.Drawing.Size(0, 13);
            this.lbIdODP.TabIndex = 9;
            this.lbIdODP.Visible = false;
            // 
            // RecepcionarODP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 429);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbProd);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txODP);
            this.Controls.Add(this.btnBuscarODP);
            this.Controls.Add(this.dgvODP);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecepcionarODP";
            this.Text = "Recepcionar Orden De Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODP)).EndInit();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrada;
        private System.Windows.Forms.Button btnPendiente;
        private System.Windows.Forms.DataGridView dgvODP;
        private System.Windows.Forms.Button btnBuscarODP;
        private System.Windows.Forms.TextBox txODP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lblGrilla;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIDRecep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDescripc;
        private System.Windows.Forms.Label lbIDProd;
        private System.Windows.Forms.Label lbCodigoBarra;
        private System.Windows.Forms.DateTimePicker dtiVencimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIdODP;
    }
}