namespace WFHostalAPPEscritorio
{
    partial class MantenedorProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxProd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxFamilia = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSctockCri = new System.Windows.Forms.TextBox();
            this.txPrecioEst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresoProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_familia = new System.Windows.Forms.TextBox();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTipo = new System.Windows.Forms.Button();
            this.tx_tipo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.tx_marca = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBoxProd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(428, 22);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(465, 326);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBoxProd
            // 
            this.groupBoxProd.Controls.Add(this.btnIngresoProd);
            this.groupBoxProd.Controls.Add(this.txPrecioEst);
            this.groupBoxProd.Controls.Add(this.label5);
            this.groupBoxProd.Controls.Add(this.txtSctockCri);
            this.groupBoxProd.Controls.Add(this.label4);
            this.groupBoxProd.Controls.Add(this.cbxMarca);
            this.groupBoxProd.Controls.Add(this.cbxFamilia);
            this.groupBoxProd.Controls.Add(this.cbxTipo);
            this.groupBoxProd.Controls.Add(this.label3);
            this.groupBoxProd.Controls.Add(this.label2);
            this.groupBoxProd.Controls.Add(this.label1);
            this.groupBoxProd.Location = new System.Drawing.Point(12, 22);
            this.groupBoxProd.Name = "groupBoxProd";
            this.groupBoxProd.Size = new System.Drawing.Size(243, 261);
            this.groupBoxProd.TabIndex = 1;
            this.groupBoxProd.TabStop = false;
            this.groupBoxProd.Text = "Datos Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Familia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(98, 65);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 3;
            // 
            // cbxFamilia
            // 
            this.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia.FormattingEnabled = true;
            this.cbxFamilia.Location = new System.Drawing.Point(98, 25);
            this.cbxFamilia.Name = "cbxFamilia";
            this.cbxFamilia.Size = new System.Drawing.Size(121, 21);
            this.cbxFamilia.TabIndex = 4;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(98, 105);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock Critico";
            // 
            // txtSctockCri
            // 
            this.txtSctockCri.Location = new System.Drawing.Point(98, 145);
            this.txtSctockCri.Name = "txtSctockCri";
            this.txtSctockCri.Size = new System.Drawing.Size(121, 20);
            this.txtSctockCri.TabIndex = 7;
            this.txtSctockCri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // txPrecioEst
            // 
            this.txPrecioEst.Location = new System.Drawing.Point(98, 184);
            this.txPrecioEst.Name = "txPrecioEst";
            this.txPrecioEst.Size = new System.Drawing.Size(121, 20);
            this.txPrecioEst.TabIndex = 9;
            this.txPrecioEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Estimado";
            // 
            // btnIngresoProd
            // 
            this.btnIngresoProd.Location = new System.Drawing.Point(98, 226);
            this.btnIngresoProd.Name = "btnIngresoProd";
            this.btnIngresoProd.Size = new System.Drawing.Size(121, 23);
            this.btnIngresoProd.TabIndex = 2;
            this.btnIngresoProd.Text = "Ingresar Producto";
            this.btnIngresoProd.UseVisualStyleBackColor = true;
            this.btnIngresoProd.Click += new System.EventHandler(this.btnIngresoProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFamilia);
            this.groupBox1.Controls.Add(this.tx_familia);
            this.groupBox1.Location = new System.Drawing.Point(261, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Familia";
            // 
            // tx_familia
            // 
            this.tx_familia.Location = new System.Drawing.Point(22, 25);
            this.tx_familia.Name = "tx_familia";
            this.tx_familia.Size = new System.Drawing.Size(121, 20);
            this.tx_familia.TabIndex = 10;
            // 
            // btnFamilia
            // 
            this.btnFamilia.Location = new System.Drawing.Point(22, 52);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(121, 23);
            this.btnFamilia.TabIndex = 11;
            this.btnFamilia.Text = "Ingresar Familia";
            this.btnFamilia.UseVisualStyleBackColor = true;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTipo);
            this.groupBox2.Controls.Add(this.tx_tipo);
            this.groupBox2.Location = new System.Drawing.Point(261, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de Tipo";
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(22, 52);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(121, 23);
            this.btnTipo.TabIndex = 11;
            this.btnTipo.Text = "Ingresar Tipo";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // tx_tipo
            // 
            this.tx_tipo.Location = new System.Drawing.Point(22, 25);
            this.tx_tipo.Name = "tx_tipo";
            this.tx_tipo.Size = new System.Drawing.Size(121, 20);
            this.tx_tipo.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMarca);
            this.groupBox3.Controls.Add(this.tx_marca);
            this.groupBox3.Location = new System.Drawing.Point(261, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 89);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de Marca";
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(22, 52);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(121, 23);
            this.btnMarca.TabIndex = 11;
            this.btnMarca.Text = "Ingresar de Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // tx_marca
            // 
            this.tx_marca.Location = new System.Drawing.Point(22, 25);
            this.tx_marca.Name = "tx_marca";
            this.tx_marca.Size = new System.Drawing.Size(121, 20);
            this.tx_marca.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(13, 353);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 6;
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 378);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProd);
            this.Controls.Add(this.dgvProductos);
            this.Name = "MantenedorProducto";
            this.Text = "Mantenedor Producto";
            this.Load += new System.EventHandler(this.MantenedorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBoxProd.ResumeLayout(false);
            this.groupBoxProd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBoxProd;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxFamilia;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPrecioEst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSctockCri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresoProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.TextBox tx_familia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.TextBox tx_tipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox tx_marca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbMsg;
    }
}