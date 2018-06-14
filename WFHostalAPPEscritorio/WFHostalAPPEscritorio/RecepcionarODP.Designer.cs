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
            this.txDatosODP = new System.Windows.Forms.TextBox();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnCerrada = new System.Windows.Forms.Button();
            this.dgvODP = new System.Windows.Forms.DataGridView();
            this.btnBuscarODP = new System.Windows.Forms.Button();
            this.txODP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrada);
            this.groupBox1.Controls.Add(this.btnPendiente);
            this.groupBox1.Controls.Add(this.txDatosODP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de ODP";
            // 
            // txDatosODP
            // 
            this.txDatosODP.Location = new System.Drawing.Point(6, 19);
            this.txDatosODP.Multiline = true;
            this.txDatosODP.Name = "txDatosODP";
            this.txDatosODP.ReadOnly = true;
            this.txDatosODP.Size = new System.Drawing.Size(283, 270);
            this.txDatosODP.TabIndex = 3;
            this.txDatosODP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txDatosODP.Visible = false;
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
            // btnCerrada
            // 
            this.btnCerrada.Location = new System.Drawing.Point(93, 295);
            this.btnCerrada.Name = "btnCerrada";
            this.btnCerrada.Size = new System.Drawing.Size(75, 23);
            this.btnCerrada.TabIndex = 4;
            this.btnCerrada.Text = "Cerrada";
            this.btnCerrada.UseVisualStyleBackColor = true;
            // 
            // dgvODP
            // 
            this.dgvODP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODP.Location = new System.Drawing.Point(328, 61);
            this.dgvODP.Name = "dgvODP";
            this.dgvODP.Size = new System.Drawing.Size(567, 341);
            this.dgvODP.TabIndex = 1;
            this.dgvODP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvODP_CellDoubleClick);
            // 
            // btnBuscarODP
            // 
            this.btnBuscarODP.Location = new System.Drawing.Point(512, 23);
            this.btnBuscarODP.Name = "btnBuscarODP";
            this.btnBuscarODP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarODP.TabIndex = 2;
            this.btnBuscarODP.Text = "Buscar ODP";
            this.btnBuscarODP.UseVisualStyleBackColor = true;
            this.btnBuscarODP.Click += new System.EventHandler(this.btnBuscarODP_Click);
            // 
            // txODP
            // 
            this.txODP.Location = new System.Drawing.Point(373, 26);
            this.txODP.Name = "txODP";
            this.txODP.Size = new System.Drawing.Size(117, 20);
            this.txODP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ODP:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(18, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(104, 358);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
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
            // RecepcionarODP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 429);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrada;
        private System.Windows.Forms.Button btnPendiente;
        private System.Windows.Forms.TextBox txDatosODP;
        private System.Windows.Forms.DataGridView dgvODP;
        private System.Windows.Forms.Button btnBuscarODP;
        private System.Windows.Forms.TextBox txODP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbMsg;
    }
}