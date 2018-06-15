namespace WFHostalAPPEscritorio
{
    partial class RegistrarEmpresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txDireccion = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txRut = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.txResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUT completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txCorreo);
            this.groupBox1.Controls.Add(this.txTelefono);
            this.groupBox1.Controls.Add(this.txDireccion);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.txRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos de Empresa:";
            // 
            // txCorreo
            // 
            this.txCorreo.Location = new System.Drawing.Point(107, 154);
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.Size = new System.Drawing.Size(178, 20);
            this.txCorreo.TabIndex = 11;
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(107, 122);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(178, 20);
            this.txTelefono.TabIndex = 10;
            this.txTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // txDireccion
            // 
            this.txDireccion.Location = new System.Drawing.Point(107, 90);
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.Size = new System.Drawing.Size(178, 20);
            this.txDireccion.TabIndex = 9;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(107, 58);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(178, 20);
            this.txNombre.TabIndex = 8;
            // 
            // txRut
            // 
            this.txRut.Location = new System.Drawing.Point(107, 26);
            this.txRut.Name = "txRut";
            this.txRut.Size = new System.Drawing.Size(178, 20);
            this.txRut.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(235, 238);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(22, 295);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(11, 13);
            this.lbMsg.TabIndex = 14;
            this.lbMsg.Text = "*";
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(357, 34);
            this.txResult.Multiline = true;
            this.txResult.Name = "txResult";
            this.txResult.ReadOnly = true;
            this.txResult.Size = new System.Drawing.Size(234, 256);
            this.txResult.TabIndex = 16;
            this.txResult.Visible = false;
            // 
            // RegistrarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarEmpresa";
            this.Text = "Registrar Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txDireccion;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txRut;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.TextBox txResult;
    }
}