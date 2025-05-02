namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class frmDespacharProductos
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
            this.dgvDespacharProductos = new System.Windows.Forms.DataGridView();
            this.btnDespachar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespacharProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDespacharProductos
            // 
            this.dgvDespacharProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespacharProductos.Location = new System.Drawing.Point(25, 26);
            this.dgvDespacharProductos.Name = "dgvDespacharProductos";
            this.dgvDespacharProductos.Size = new System.Drawing.Size(763, 246);
            this.dgvDespacharProductos.TabIndex = 0;
            // 
            // btnDespachar
            // 
            this.btnDespachar.Location = new System.Drawing.Point(25, 290);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(113, 34);
            this.btnDespachar.TabIndex = 1;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            // 
            // frmDespacharProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 433);
            this.Controls.Add(this.btnDespachar);
            this.Controls.Add(this.dgvDespacharProductos);
            this.Name = "frmDespacharProductos";
            this.Text = "frmDespacharProductos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDespacharProductos_FormClosing);
            this.Load += new System.EventHandler(this.frmDespacharProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespacharProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDespacharProductos;
        private System.Windows.Forms.Button btnDespachar;
    }
}