namespace WFHostalAPPEscritorio
{
    partial class MantenedorEmpleados
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
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.lblDv = new System.Windows.Forms.Label();
            this.btnIngresarEmp = new System.Windows.Forms.Button();
            this.txtApellidoEmp = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtRutEmp = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblRutEmp = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.Controls.Add(this.btnLimpiar);
            this.gbEmpleado.Controls.Add(this.txtDv);
            this.gbEmpleado.Controls.Add(this.lblDv);
            this.gbEmpleado.Controls.Add(this.btnIngresarEmp);
            this.gbEmpleado.Controls.Add(this.txtApellidoEmp);
            this.gbEmpleado.Controls.Add(this.txtNombreEmp);
            this.gbEmpleado.Controls.Add(this.txtRutEmp);
            this.gbEmpleado.Controls.Add(this.lblNombre);
            this.gbEmpleado.Controls.Add(this.lblApellido);
            this.gbEmpleado.Controls.Add(this.lblRutEmp);
            this.gbEmpleado.Location = new System.Drawing.Point(12, 21);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(455, 298);
            this.gbEmpleado.TabIndex = 0;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Datos Empleado";
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(213, 32);
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(29, 20);
            this.txtDv.TabIndex = 7;
            // 
            // lblDv
            // 
            this.lblDv.AutoSize = true;
            this.lblDv.Location = new System.Drawing.Point(197, 34);
            this.lblDv.Name = "lblDv";
            this.lblDv.Size = new System.Drawing.Size(10, 13);
            this.lblDv.TabIndex = 6;
            this.lblDv.Text = "-";
            // 
            // btnIngresarEmp
            // 
            this.btnIngresarEmp.Location = new System.Drawing.Point(352, 31);
            this.btnIngresarEmp.Name = "btnIngresarEmp";
            this.btnIngresarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarEmp.TabIndex = 1;
            this.btnIngresarEmp.Text = "Ingresar";
            this.btnIngresarEmp.UseVisualStyleBackColor = true;
            this.btnIngresarEmp.Click += new System.EventHandler(this.btnIngresarEmp_Click);
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.Location = new System.Drawing.Point(91, 102);
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            this.txtApellidoEmp.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEmp.TabIndex = 5;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(91, 64);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 4;
            // 
            // txtRutEmp
            // 
            this.txtRutEmp.Location = new System.Drawing.Point(91, 31);
            this.txtRutEmp.Name = "txtRutEmp";
            this.txtRutEmp.Size = new System.Drawing.Size(100, 20);
            this.txtRutEmp.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblRutEmp
            // 
            this.lblRutEmp.AutoSize = true;
            this.lblRutEmp.Location = new System.Drawing.Point(29, 39);
            this.lblRutEmp.Name = "lblRutEmp";
            this.lblRutEmp.Size = new System.Drawing.Size(24, 13);
            this.lblRutEmp.TabIndex = 0;
            this.lblRutEmp.Text = "Rut";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(352, 72);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MantenedorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 348);
            this.Controls.Add(this.gbEmpleado);
            this.Name = "MantenedorEmpleados";
            this.Text = "MantenedorEmpleados";
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtRutEmp;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblRutEmp;
        private System.Windows.Forms.Button btnIngresarEmp;
        private System.Windows.Forms.Label lblDv;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Button btnLimpiar;
    }
}