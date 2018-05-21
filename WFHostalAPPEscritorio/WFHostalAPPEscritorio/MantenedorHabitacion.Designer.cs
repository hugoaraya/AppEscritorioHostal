namespace WFHostalAPPEscritorio
{
    partial class MantenedorHabitacion
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
            this.lblTipoCama = new System.Windows.Forms.Label();
            this.lblAccesorio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtTipoCama = new System.Windows.Forms.TextBox();
            this.txtAccesorio = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtAccesorio);
            this.groupBox1.Controls.Add(this.txtTipoCama);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblAccesorio);
            this.groupBox1.Controls.Add(this.lblTipoCama);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos habitación";
            // 
            // lblTipoCama
            // 
            this.lblTipoCama.AutoSize = true;
            this.lblTipoCama.Location = new System.Drawing.Point(19, 43);
            this.lblTipoCama.Name = "lblTipoCama";
            this.lblTipoCama.Size = new System.Drawing.Size(57, 13);
            this.lblTipoCama.TabIndex = 0;
            this.lblTipoCama.Text = "Tipo cama";
            // 
            // lblAccesorio
            // 
            this.lblAccesorio.AutoSize = true;
            this.lblAccesorio.Location = new System.Drawing.Point(22, 87);
            this.lblAccesorio.Name = "lblAccesorio";
            this.lblAccesorio.Size = new System.Drawing.Size(65, 13);
            this.lblAccesorio.TabIndex = 1;
            this.lblAccesorio.Text = "Accesorio(s)";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(22, 131);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // txtTipoCama
            // 
            this.txtTipoCama.Location = new System.Drawing.Point(99, 36);
            this.txtTipoCama.Name = "txtTipoCama";
            this.txtTipoCama.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCama.TabIndex = 3;
            // 
            // txtAccesorio
            // 
            this.txtAccesorio.Location = new System.Drawing.Point(99, 79);
            this.txtAccesorio.Name = "txtAccesorio";
            this.txtAccesorio.Size = new System.Drawing.Size(100, 20);
            this.txtAccesorio.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(99, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(301, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // MantenedorHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenedorHabitacion";
            this.Text = "MantenedorHabitación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAccesorio;
        private System.Windows.Forms.TextBox txtTipoCama;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAccesorio;
        private System.Windows.Forms.Label lblTipoCama;
    }
}