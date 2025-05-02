namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class frmGenerarFactura
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
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.dgvGenerarFactura = new System.Windows.Forms.DataGridView();
            this.DespacharVino = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(27, 252);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(139, 33);
            this.btnGenerarFactura.TabIndex = 9;
            this.btnGenerarFactura.Text = "Generar factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // dgvGenerarFactura
            // 
            this.dgvGenerarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenerarFactura.Location = new System.Drawing.Point(27, 12);
            this.dgvGenerarFactura.Name = "dgvGenerarFactura";
            this.dgvGenerarFactura.Size = new System.Drawing.Size(1068, 222);
            this.dgvGenerarFactura.TabIndex = 10;
            this.dgvGenerarFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DespacharVino
            // 
            this.DespacharVino.Location = new System.Drawing.Point(27, 303);
            this.DespacharVino.Name = "DespacharVino";
            this.DespacharVino.Size = new System.Drawing.Size(139, 33);
            this.DespacharVino.TabIndex = 12;
            this.DespacharVino.Text = "Despachar Vino";
            this.DespacharVino.UseVisualStyleBackColor = true;
            this.DespacharVino.Click += new System.EventHandler(this.DespacharVino_Click);
            // 
            // frmGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 357);
            this.Controls.Add(this.DespacharVino);
            this.Controls.Add(this.dgvGenerarFactura);
            this.Controls.Add(this.btnGenerarFactura);
            this.Name = "frmGenerarFactura";
            this.Text = ",k,k";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerarFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerarFactura_Load);
            this.VisibleChanged += new System.EventHandler(this.frmGenerarFactura_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.DataGridView dgvGenerarFactura;
        private System.Windows.Forms.Button DespacharVino;
    }
}