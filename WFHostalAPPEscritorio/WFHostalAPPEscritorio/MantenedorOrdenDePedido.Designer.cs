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
            this.txtNOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOP = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNOP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Orden de Pedido";
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
            // dgvOP
            // 
            this.dgvOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOP.Location = new System.Drawing.Point(294, 12);
            this.dgvOP.Name = "dgvOP";
            this.dgvOP.Size = new System.Drawing.Size(397, 227);
            this.dgvOP.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(167, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Nº OP";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(50, 255);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(87, 23);
            this.btnTodas.TabIndex = 3;
            this.btnTodas.Text = "Mostrar Todas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
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
            // MantenedorOrdenDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 363);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvOP);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenedorOrdenDePedido";
            this.Text = "MantenedorOrdenDePedido";
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
    }
}