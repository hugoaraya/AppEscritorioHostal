﻿namespace WFHostalAPPEscritorio
{
    partial class IngresoOrdenPedido
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
            this.btnProvee = new System.Windows.Forms.Button();
            this.txRubroProvee = new System.Windows.Forms.Label();
            this.txNombreProvee = new System.Windows.Forms.Label();
            this.txRutProvee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProvee = new System.Windows.Forms.DataGridView();
            this.txGrilla = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvProdSelec = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSelec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProvee);
            this.groupBox1.Controls.Add(this.txRubroProvee);
            this.groupBox1.Controls.Add(this.txNombreProvee);
            this.groupBox1.Controls.Add(this.txRutProvee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionne Proveedor";
            // 
            // btnProvee
            // 
            this.btnProvee.Location = new System.Drawing.Point(363, 82);
            this.btnProvee.Name = "btnProvee";
            this.btnProvee.Size = new System.Drawing.Size(72, 23);
            this.btnProvee.TabIndex = 7;
            this.btnProvee.Text = "Siguiente >";
            this.btnProvee.UseVisualStyleBackColor = true;
            this.btnProvee.Click += new System.EventHandler(this.btnProvee_Click);
            // 
            // txRubroProvee
            // 
            this.txRubroProvee.AutoSize = true;
            this.txRubroProvee.Location = new System.Drawing.Point(142, 77);
            this.txRubroProvee.Name = "txRubroProvee";
            this.txRubroProvee.Size = new System.Drawing.Size(19, 13);
            this.txRubroProvee.TabIndex = 6;
            this.txRubroProvee.Text = "-->";
            // 
            // txNombreProvee
            // 
            this.txNombreProvee.AutoSize = true;
            this.txNombreProvee.Location = new System.Drawing.Point(142, 54);
            this.txNombreProvee.Name = "txNombreProvee";
            this.txNombreProvee.Size = new System.Drawing.Size(19, 13);
            this.txNombreProvee.TabIndex = 5;
            this.txNombreProvee.Text = "-->";
            // 
            // txRutProvee
            // 
            this.txRutProvee.AutoSize = true;
            this.txRutProvee.Location = new System.Drawing.Point(142, 32);
            this.txRutProvee.Name = "txRutProvee";
            this.txRutProvee.Size = new System.Drawing.Size(19, 13);
            this.txRutProvee.TabIndex = 4;
            this.txRutProvee.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rubro Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUT Proveedor :";
            // 
            // dgvProvee
            // 
            this.dgvProvee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvee.Location = new System.Drawing.Point(487, 31);
            this.dgvProvee.Name = "dgvProvee";
            this.dgvProvee.Size = new System.Drawing.Size(477, 417);
            this.dgvProvee.TabIndex = 1;
            this.dgvProvee.Visible = false;
            this.dgvProvee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvee_CellDoubleClick);
            // 
            // txGrilla
            // 
            this.txGrilla.AutoSize = true;
            this.txGrilla.Location = new System.Drawing.Point(487, 12);
            this.txGrilla.Name = "txGrilla";
            this.txGrilla.Size = new System.Drawing.Size(14, 13);
            this.txGrilla.TabIndex = 2;
            this.txGrilla.Text = "V";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(471, 31);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(477, 417);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.Visible = false;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // dgvProdSelec
            // 
            this.dgvProdSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdSelec.Location = new System.Drawing.Point(12, 194);
            this.dgvProdSelec.Name = "dgvProdSelec";
            this.dgvProdSelec.Size = new System.Drawing.Size(345, 193);
            this.dgvProdSelec.TabIndex = 5;
            this.dgvProdSelec.Visible = false;
            this.dgvProdSelec.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProdSelec_DataError);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agregue Productos";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(9, 438);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(11, 13);
            this.lbMsg.TabIndex = 6;
            this.lbMsg.Text = "*";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(398, 199);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(19, 13);
            this.lblpro.TabIndex = 7;
            this.lblpro.Text = "<--";
            this.lblpro.Visible = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(18, 12);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 13);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario Activo:";
            // 
            // IngresoOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 460);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.dgvProdSelec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txGrilla);
            this.Controls.Add(this.dgvProvee);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresoOrdenPedido";
            this.Text = "IngresoOrdenPedido";
            this.Load += new System.EventHandler(this.IngresoOrdenPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSelec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProvee;
        private System.Windows.Forms.Label txRubroProvee;
        private System.Windows.Forms.Label txNombreProvee;
        private System.Windows.Forms.Label txRutProvee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txGrilla;
        private System.Windows.Forms.Button btnProvee;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvProdSelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.Label lbUsuario;
    }
}