namespace WFHostalAPPEscritorio
{
    partial class Ingresar_Empleado
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellidoEmp = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtRutEmp = new System.Windows.Forms.TextBox();
            this.lblApellidoEmp = new System.Windows.Forms.Label();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblRutEmp = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txResult = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtApellidoEmp);
            this.groupBox1.Controls.Add(this.txtNombreEmp);
            this.groupBox1.Controls.Add(this.txtRutEmp);
            this.groupBox1.Controls.Add(this.lblApellidoEmp);
            this.groupBox1.Controls.Add(this.lblNombreEmp);
            this.groupBox1.Controls.Add(this.lblRutEmp);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos de Empleado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(101, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.Location = new System.Drawing.Point(87, 108);
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            this.txtApellidoEmp.Size = new System.Drawing.Size(142, 20);
            this.txtApellidoEmp.TabIndex = 5;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(87, 71);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(142, 20);
            this.txtNombreEmp.TabIndex = 4;
            // 
            // txtRutEmp
            // 
            this.txtRutEmp.Location = new System.Drawing.Point(87, 35);
            this.txtRutEmp.Name = "txtRutEmp";
            this.txtRutEmp.Size = new System.Drawing.Size(142, 20);
            this.txtRutEmp.TabIndex = 3;
            // 
            // lblApellidoEmp
            // 
            this.lblApellidoEmp.AutoSize = true;
            this.lblApellidoEmp.Location = new System.Drawing.Point(19, 116);
            this.lblApellidoEmp.Name = "lblApellidoEmp";
            this.lblApellidoEmp.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoEmp.TabIndex = 2;
            this.lblApellidoEmp.Text = "Apellido:";
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Location = new System.Drawing.Point(19, 79);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEmp.TabIndex = 1;
            this.lblNombreEmp.Text = "Nombre:";
            // 
            // lblRutEmp
            // 
            this.lblRutEmp.AutoSize = true;
            this.lblRutEmp.Location = new System.Drawing.Point(19, 42);
            this.lblRutEmp.Name = "lblRutEmp";
            this.lblRutEmp.Size = new System.Drawing.Size(33, 13);
            this.lblRutEmp.TabIndex = 0;
            this.lblRutEmp.Text = "RUT:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(254, 235);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(365, 31);
            this.txResult.Multiline = true;
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(234, 200);
            this.txResult.TabIndex = 17;
            this.txResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txResult.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(20, 279);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(11, 13);
            this.lblMsg.TabIndex = 19;
            this.lblMsg.Text = "*";
            // 
            // Ingresar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ingresar_Empleado";
            this.Text = "Registrar Empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApellidoEmp;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Label lblRutEmp;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtApellidoEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtRutEmp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMsg;
    }
}