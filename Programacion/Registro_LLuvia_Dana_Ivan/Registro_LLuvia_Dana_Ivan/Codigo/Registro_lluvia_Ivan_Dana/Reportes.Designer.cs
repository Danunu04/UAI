namespace Registro_lluvia_Ivan_Dana
{
    partial class Reportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBLReporte = new System.Windows.Forms.Label();
            this.TXTAlertas = new System.Windows.Forms.TextBox();
            this.LBLAlertas = new System.Windows.Forms.Label();
            this.DataPromedioPorZona = new System.Windows.Forms.DataGridView();
            this.LBLPromedioPorZona = new System.Windows.Forms.Label();
            this.BTNLogOUT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPromedioPorZona)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBLReporte
            // 
            this.LBLReporte.AutoSize = true;
            this.LBLReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLReporte.Font = new System.Drawing.Font("Dana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLReporte.Location = new System.Drawing.Point(12, 9);
            this.LBLReporte.Name = "LBLReporte";
            this.LBLReporte.Size = new System.Drawing.Size(178, 42);
            this.LBLReporte.TabIndex = 1;
            this.LBLReporte.Tag = "LBLReporte";
            this.LBLReporte.Text = "Reportes";
            // 
            // TXTAlertas
            // 
            this.TXTAlertas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TXTAlertas.Font = new System.Drawing.Font("Dana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAlertas.Location = new System.Drawing.Point(501, 62);
            this.TXTAlertas.Multiline = true;
            this.TXTAlertas.Name = "TXTAlertas";
            this.TXTAlertas.Size = new System.Drawing.Size(414, 149);
            this.TXTAlertas.TabIndex = 2;
            this.TXTAlertas.Tag = "TXTAlertas";
            this.TXTAlertas.TextChanged += new System.EventHandler(this.TXTAlertas_TextChanged);
            // 
            // LBLAlertas
            // 
            this.LBLAlertas.AutoSize = true;
            this.LBLAlertas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLAlertas.Font = new System.Drawing.Font("Dana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAlertas.Location = new System.Drawing.Point(503, 9);
            this.LBLAlertas.Name = "LBLAlertas";
            this.LBLAlertas.Size = new System.Drawing.Size(149, 42);
            this.LBLAlertas.TabIndex = 3;
            this.LBLAlertas.Tag = "LBLAlertas";
            this.LBLAlertas.Text = "Alertas";
            // 
            // DataPromedioPorZona
            // 
            this.DataPromedioPorZona.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataPromedioPorZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPromedioPorZona.Location = new System.Drawing.Point(501, 282);
            this.DataPromedioPorZona.Name = "DataPromedioPorZona";
            this.DataPromedioPorZona.Size = new System.Drawing.Size(409, 224);
            this.DataPromedioPorZona.TabIndex = 4;
            this.DataPromedioPorZona.Tag = "DataPromedioPorZona";
            // 
            // LBLPromedioPorZona
            // 
            this.LBLPromedioPorZona.AutoSize = true;
            this.LBLPromedioPorZona.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLPromedioPorZona.Font = new System.Drawing.Font("Dana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPromedioPorZona.Location = new System.Drawing.Point(503, 228);
            this.LBLPromedioPorZona.Name = "LBLPromedioPorZona";
            this.LBLPromedioPorZona.Size = new System.Drawing.Size(351, 42);
            this.LBLPromedioPorZona.TabIndex = 5;
            this.LBLPromedioPorZona.Tag = "LBLPromedioPorZona";
            this.LBLPromedioPorZona.Text = "Promedio por ZOna";
            // 
            // BTNLogOUT
            // 
            this.BTNLogOUT.BackColor = System.Drawing.Color.LightBlue;
            this.BTNLogOUT.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogOUT.Location = new System.Drawing.Point(734, 533);
            this.BTNLogOUT.Name = "BTNLogOUT";
            this.BTNLogOUT.Size = new System.Drawing.Size(175, 41);
            this.BTNLogOUT.TabIndex = 6;
            this.BTNLogOUT.Tag = "BTNLogOUT";
            this.BTNLogOUT.Text = "LogOut";
            this.BTNLogOUT.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 583);
            this.Controls.Add(this.BTNLogOUT);
            this.Controls.Add(this.LBLPromedioPorZona);
            this.Controls.Add(this.DataPromedioPorZona);
            this.Controls.Add(this.LBLAlertas);
            this.Controls.Add(this.TXTAlertas);
            this.Controls.Add(this.LBLReporte);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reportes";
            this.Tag = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPromedioPorZona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBLReporte;
        private System.Windows.Forms.TextBox TXTAlertas;
        private System.Windows.Forms.Label LBLAlertas;
        private System.Windows.Forms.DataGridView DataPromedioPorZona;
        private System.Windows.Forms.Label LBLPromedioPorZona;
        private System.Windows.Forms.Button BTNLogOUT;
    }
}