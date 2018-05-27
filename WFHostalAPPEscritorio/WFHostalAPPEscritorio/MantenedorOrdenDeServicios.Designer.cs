namespace WFHostalAPPEscritorio
{
    partial class MantenedorOrdenDeServicios
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
            this.dgvODC = new System.Windows.Forms.DataGridView();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvODC
            // 
            this.dgvODC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODC.Location = new System.Drawing.Point(238, 12);
            this.dgvODC.Name = "dgvODC";
            this.dgvODC.Size = new System.Drawing.Size(443, 319);
            this.dgvODC.TabIndex = 0;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(13, 366);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(11, 13);
            this.lbMsg.TabIndex = 1;
            this.lbMsg.Text = "*";
            // 
            // MantenedorOrdenDeServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 391);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.dgvODC);
            this.Name = "MantenedorOrdenDeServicios";
            this.Text = "MantenedorOrdenDeServicios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvODC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvODC;
        private System.Windows.Forms.Label lbMsg;
    }
}