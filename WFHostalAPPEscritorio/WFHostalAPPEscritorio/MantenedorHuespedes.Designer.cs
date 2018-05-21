namespace WFHostalAPPEscritorio
{
    partial class MantenedorHuespedes
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
            this.btnTodas = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txRutEmp = new System.Windows.Forms.TextBox();
            this.lbRutEmp = new System.Windows.Forms.Label();
            this.txCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.txCorreo = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHuesped = new System.Windows.Forms.DataGridView();
            this.btIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(214, 304);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(83, 23);
            this.btnTodas.TabIndex = 22;
            this.btnTodas.Text = "MostrarTodos";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(14, 337);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(33, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(114, 304);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(114, 275);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(214, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar RUT";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txRutEmp);
            this.groupBox1.Controls.Add(this.lbRutEmp);
            this.groupBox1.Controls.Add(this.txCargo);
            this.groupBox1.Controls.Add(this.lbCargo);
            this.groupBox1.Controls.Add(this.txCorreo);
            this.groupBox1.Controls.Add(this.txTelefono);
            this.groupBox1.Controls.Add(this.txApellido);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.txRut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 238);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Huesped:";
            // 
            // txRutEmp
            // 
            this.txRutEmp.Location = new System.Drawing.Point(108, 212);
            this.txRutEmp.Name = "txRutEmp";
            this.txRutEmp.Size = new System.Drawing.Size(178, 20);
            this.txRutEmp.TabIndex = 15;
            this.txRutEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // lbRutEmp
            // 
            this.lbRutEmp.AutoSize = true;
            this.lbRutEmp.Location = new System.Drawing.Point(26, 216);
            this.lbRutEmp.Name = "lbRutEmp";
            this.lbRutEmp.Size = new System.Drawing.Size(77, 13);
            this.lbRutEmp.TabIndex = 14;
            this.lbRutEmp.Text = "RUT Empresa:";
            // 
            // txCargo
            // 
            this.txCargo.Location = new System.Drawing.Point(107, 183);
            this.txCargo.Name = "txCargo";
            this.txCargo.Size = new System.Drawing.Size(178, 20);
            this.txCargo.TabIndex = 13;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(28, 186);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(38, 13);
            this.lbCargo.TabIndex = 12;
            this.lbCargo.Text = "Cargo:";
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
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(107, 90);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(178, 20);
            this.txApellido.TabIndex = 9;
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
            this.txRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_KeyPress_Numeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // dgvHuesped
            // 
            this.dgvHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuesped.Location = new System.Drawing.Point(336, 24);
            this.dgvHuesped.MultiSelect = false;
            this.dgvHuesped.Name = "dgvHuesped";
            this.dgvHuesped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHuesped.Size = new System.Drawing.Size(537, 295);
            this.dgvHuesped.TabIndex = 15;
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(32, 275);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(76, 23);
            this.btIngresar.TabIndex = 23;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // MantenedorHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 366);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHuesped);
            this.Name = "MantenedorHuespedes";
            this.Text = "MantenedorHuespedes";
            this.Load += new System.EventHandler(this.MantenedorHuespedes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txCorreo;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHuesped;
        private System.Windows.Forms.TextBox txCargo;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.TextBox txRutEmp;
        private System.Windows.Forms.Label lbRutEmp;
        private System.Windows.Forms.Button btIngresar;
    }
}