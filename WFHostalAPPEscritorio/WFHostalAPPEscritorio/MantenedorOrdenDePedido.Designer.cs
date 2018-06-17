namespace WFHostalAPPEscritorio
{
    partial class MantenedorOrdenDePedido
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
            this.btnAceptadas = new System.Windows.Forms.Button();
            this.btnRechazadas = new System.Windows.Forms.Button();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.txtNOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvOP = new System.Windows.Forms.DataGridView();
            this.lbMsg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptadas);
            this.groupBox1.Controls.Add(this.btnRechazadas);
            this.groupBox1.Controls.Add(this.btnPendientes);
            this.groupBox1.Controls.Add(this.txtNOP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTodas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Orden de Pedido";
            // 
            // btnAceptadas
            // 
            this.btnAceptadas.Location = new System.Drawing.Point(157, 164);
            this.btnAceptadas.Name = "btnAceptadas";
            this.btnAceptadas.Size = new System.Drawing.Size(150, 23);
            this.btnAceptadas.TabIndex = 6;
            this.btnAceptadas.Text = "Mostrar Aceptadas";
            this.btnAceptadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptadas.UseVisualStyleBackColor = true;
            this.btnAceptadas.Click += new System.EventHandler(this.btnAceptadas_Click);
            // 
            // btnRechazadas
            // 
            this.btnRechazadas.Location = new System.Drawing.Point(157, 220);
            this.btnRechazadas.Name = "btnRechazadas";
            this.btnRechazadas.Size = new System.Drawing.Size(150, 23);
            this.btnRechazadas.TabIndex = 5;
            this.btnRechazadas.Text = "Mostrar Rechazadas";
            this.btnRechazadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRechazadas.UseVisualStyleBackColor = true;
            this.btnRechazadas.Click += new System.EventHandler(this.btnRechazadas_Click);
            // 
            // btnPendientes
            // 
            this.btnPendientes.Location = new System.Drawing.Point(157, 192);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(150, 23);
            this.btnPendientes.TabIndex = 4;
            this.btnPendientes.Text = "Mostrar Pendientes";
            this.btnPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // txtNOP
            // 
            this.txtNOP.Location = new System.Drawing.Point(114, 29);
            this.txtNOP.Name = "txtNOP";
            this.txtNOP.Size = new System.Drawing.Size(100, 20);
            this.txtNOP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Orden Pedido:";
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(157, 136);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(150, 23);
            this.btnTodas.TabIndex = 3;
            this.btnTodas.Text = "Mostrar Todas";
            this.btnTodas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(127, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Nº OP";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvOP
            // 
            this.dgvOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOP.Location = new System.Drawing.Point(331, 12);
            this.dgvOP.Name = "dgvOP";
            this.dgvOP.Size = new System.Drawing.Size(668, 339);
            this.dgvOP.TabIndex = 1;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(22, 321);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(11, 13);
            this.lbMsg.TabIndex = 4;
            this.lbMsg.Text = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Salir";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 295);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MantenedorOrdenDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 363);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.dgvOP);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenedorOrdenDePedido";
            this.Text = "MantenedorOrdenDePedido";
            this.Load += new System.EventHandler(this.MantenedorOrdenDePedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAceptadas;
        private System.Windows.Forms.Button btnRechazadas;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnLimpiar;
    }
}