﻿namespace WFHostalAPPEscritorio
{
    partial class CheckHuesped
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
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.txOrdenCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.txDatosHue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCheck
            // 
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheck.Location = new System.Drawing.Point(362, 79);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.Size = new System.Drawing.Size(533, 319);
            this.dgvCheck.TabIndex = 0;
            this.dgvCheck.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheck_CellDoubleClick);
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Location = new System.Drawing.Point(508, 30);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarOC.TabIndex = 1;
            this.btnBuscarOC.Text = "Buscar OC";
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
            // 
            // txOrdenCom
            // 
            this.txOrdenCom.Location = new System.Drawing.Point(402, 32);
            this.txOrdenCom.Name = "txOrdenCom";
            this.txOrdenCom.Size = new System.Drawing.Size(100, 20);
            this.txOrdenCom.TabIndex = 3;
            this.txOrdenCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OC:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(119, 375);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txDatosHue);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(34, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 326);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Huesped";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Salida";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingreso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(13, 405);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 8;
            // 
            // txDatosHue
            // 
            this.txDatosHue.Location = new System.Drawing.Point(3, 16);
            this.txDatosHue.Multiline = true;
            this.txDatosHue.Name = "txDatosHue";
            this.txDatosHue.ReadOnly = true;
            this.txDatosHue.Size = new System.Drawing.Size(283, 270);
            this.txDatosHue.TabIndex = 2;
            this.txDatosHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txDatosHue.Visible = false;
            // 
            // CheckHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 429);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOrdenCom);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.dgvCheck);
            this.Name = "CheckHuesped";
            this.Text = "CheckHuesped";
            this.Load += new System.EventHandler(this.CheckHuesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.TextBox txOrdenCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.TextBox txDatosHue;
    }
}