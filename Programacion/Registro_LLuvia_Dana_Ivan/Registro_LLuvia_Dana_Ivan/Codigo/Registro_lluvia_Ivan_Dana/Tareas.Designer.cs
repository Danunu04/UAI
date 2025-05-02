namespace Registro_lluvia_Ivan_Dana
{
    partial class Tareas
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
            this.DTIngenieros = new System.Windows.Forms.DataGridView();
            this.DTCargas = new System.Windows.Forms.DataGridView();
            this.LBLReporte = new System.Windows.Forms.Label();
            this.LBLCargas = new System.Windows.Forms.Label();
            this.LBLResponsable = new System.Windows.Forms.Label();
            this.LBLResponsableID = new System.Windows.Forms.Label();
            this.LBLCantidad = new System.Windows.Forms.Label();
            this.LBLFecha = new System.Windows.Forms.Label();
            this.LBLLocalidad = new System.Windows.Forms.Label();
            this.TXTCantidad = new System.Windows.Forms.TextBox();
            this.TXTLocalidad = new System.Windows.Forms.TextBox();
            this.TXTFecha = new System.Windows.Forms.TextBox();
            this.BTNAtreas = new System.Windows.Forms.Button();
            this.BTNCargar = new System.Windows.Forms.Button();
            this.LBLIngenieros = new System.Windows.Forms.Label();
            this.TXTResponsable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTIngenieros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // DTIngenieros
            // 
            this.DTIngenieros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTIngenieros.Location = new System.Drawing.Point(12, 71);
            this.DTIngenieros.Name = "DTIngenieros";
            this.DTIngenieros.Size = new System.Drawing.Size(444, 412);
            this.DTIngenieros.TabIndex = 0;
            this.DTIngenieros.Tag = "DTIngenieros";
            // 
            // DTCargas
            // 
            this.DTCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTCargas.Location = new System.Drawing.Point(855, 71);
            this.DTCargas.Name = "DTCargas";
            this.DTCargas.Size = new System.Drawing.Size(444, 412);
            this.DTCargas.TabIndex = 1;
            this.DTCargas.Tag = "DTCargas";
            // 
            // LBLReporte
            // 
            this.LBLReporte.AutoSize = true;
            this.LBLReporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLReporte.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLReporte.Location = new System.Drawing.Point(477, 29);
            this.LBLReporte.Name = "LBLReporte";
            this.LBLReporte.Size = new System.Drawing.Size(104, 28);
            this.LBLReporte.TabIndex = 3;
            this.LBLReporte.Tag = "LBLReporte";
            this.LBLReporte.Text = "Reporte";
            // 
            // LBLCargas
            // 
            this.LBLCargas.AutoSize = true;
            this.LBLCargas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLCargas.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCargas.Location = new System.Drawing.Point(850, 29);
            this.LBLCargas.Name = "LBLCargas";
            this.LBLCargas.Size = new System.Drawing.Size(96, 28);
            this.LBLCargas.TabIndex = 4;
            this.LBLCargas.Tag = "LBLCargas";
            this.LBLCargas.Text = "Cargas";
            // 
            // LBLResponsable
            // 
            this.LBLResponsable.AutoSize = true;
            this.LBLResponsable.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResponsable.Location = new System.Drawing.Point(478, 76);
            this.LBLResponsable.Name = "LBLResponsable";
            this.LBLResponsable.Size = new System.Drawing.Size(159, 26);
            this.LBLResponsable.TabIndex = 5;
            this.LBLResponsable.Tag = "LBLResponsable";
            this.LBLResponsable.Text = "Responsable: ";
            // 
            // LBLResponsableID
            // 
            this.LBLResponsableID.AutoSize = true;
            this.LBLResponsableID.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResponsableID.Location = new System.Drawing.Point(642, 85);
            this.LBLResponsableID.Name = "LBLResponsableID";
            this.LBLResponsableID.Size = new System.Drawing.Size(0, 26);
            this.LBLResponsableID.TabIndex = 6;
            this.LBLResponsableID.Tag = "LBLResponsableID";
            // 
            // LBLCantidad
            // 
            this.LBLCantidad.AutoSize = true;
            this.LBLCantidad.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCantidad.Location = new System.Drawing.Point(477, 127);
            this.LBLCantidad.Name = "LBLCantidad";
            this.LBLCantidad.Size = new System.Drawing.Size(124, 52);
            this.LBLCantidad.TabIndex = 7;
            this.LBLCantidad.Tag = "LBLCantidad";
            this.LBLCantidad.Text = "Cantidad: \r\n\r\n";
            this.LBLCantidad.Click += new System.EventHandler(this.LBLCantidad_Click);
            // 
            // LBLFecha
            // 
            this.LBLFecha.AutoSize = true;
            this.LBLFecha.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFecha.Location = new System.Drawing.Point(478, 179);
            this.LBLFecha.Name = "LBLFecha";
            this.LBLFecha.Size = new System.Drawing.Size(85, 26);
            this.LBLFecha.TabIndex = 8;
            this.LBLFecha.Tag = "LBLFecha";
            this.LBLFecha.Text = "Fecha: ";
            // 
            // LBLLocalidad
            // 
            this.LBLLocalidad.AutoSize = true;
            this.LBLLocalidad.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLocalidad.Location = new System.Drawing.Point(478, 232);
            this.LBLLocalidad.Name = "LBLLocalidad";
            this.LBLLocalidad.Size = new System.Drawing.Size(120, 26);
            this.LBLLocalidad.TabIndex = 9;
            this.LBLLocalidad.Tag = "LBLLocalidad";
            this.LBLLocalidad.Text = "Localidad:";
            // 
            // TXTCantidad
            // 
            this.TXTCantidad.Location = new System.Drawing.Point(607, 118);
            this.TXTCantidad.Multiline = true;
            this.TXTCantidad.Name = "TXTCantidad";
            this.TXTCantidad.Size = new System.Drawing.Size(209, 29);
            this.TXTCantidad.TabIndex = 10;
            this.TXTCantidad.Tag = "TXTCantidad";
            // 
            // TXTLocalidad
            // 
            this.TXTLocalidad.Location = new System.Drawing.Point(607, 229);
            this.TXTLocalidad.Multiline = true;
            this.TXTLocalidad.Name = "TXTLocalidad";
            this.TXTLocalidad.Size = new System.Drawing.Size(209, 29);
            this.TXTLocalidad.TabIndex = 11;
            this.TXTLocalidad.Tag = "TXTLocalidad";
            // 
            // TXTFecha
            // 
            this.TXTFecha.Location = new System.Drawing.Point(607, 176);
            this.TXTFecha.Multiline = true;
            this.TXTFecha.Name = "TXTFecha";
            this.TXTFecha.Size = new System.Drawing.Size(209, 29);
            this.TXTFecha.TabIndex = 12;
            this.TXTFecha.Tag = "TXTFecha";
            // 
            // BTNAtreas
            // 
            this.BTNAtreas.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAtreas.Location = new System.Drawing.Point(482, 429);
            this.BTNAtreas.Name = "BTNAtreas";
            this.BTNAtreas.Size = new System.Drawing.Size(161, 54);
            this.BTNAtreas.TabIndex = 13;
            this.BTNAtreas.Tag = "BTNAtras";
            this.BTNAtreas.Text = "Atras";
            this.BTNAtreas.UseVisualStyleBackColor = true;
            this.BTNAtreas.Click += new System.EventHandler(this.BTNAtreas_Click);
            // 
            // BTNCargar
            // 
            this.BTNCargar.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCargar.Location = new System.Drawing.Point(655, 429);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(161, 54);
            this.BTNCargar.TabIndex = 14;
            this.BTNCargar.Tag = "BTNCargar";
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = true;
            this.BTNCargar.Click += new System.EventHandler(this.BTNCargar_Click);
            // 
            // LBLIngenieros
            // 
            this.LBLIngenieros.AutoSize = true;
            this.LBLIngenieros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLIngenieros.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIngenieros.Location = new System.Drawing.Point(12, 29);
            this.LBLIngenieros.Name = "LBLIngenieros";
            this.LBLIngenieros.Size = new System.Drawing.Size(145, 28);
            this.LBLIngenieros.TabIndex = 15;
            this.LBLIngenieros.Tag = "LBLIngenieros";
            this.LBLIngenieros.Text = "Ingenieros";
            // 
            // TXTResponsable
            // 
            this.TXTResponsable.Location = new System.Drawing.Point(607, 76);
            this.TXTResponsable.Multiline = true;
            this.TXTResponsable.Name = "TXTResponsable";
            this.TXTResponsable.Size = new System.Drawing.Size(209, 29);
            this.TXTResponsable.TabIndex = 16;
            this.TXTResponsable.Tag = "TXTCantidad";
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 513);
            this.Controls.Add(this.TXTResponsable);
            this.Controls.Add(this.LBLIngenieros);
            this.Controls.Add(this.BTNCargar);
            this.Controls.Add(this.BTNAtreas);
            this.Controls.Add(this.TXTFecha);
            this.Controls.Add(this.TXTLocalidad);
            this.Controls.Add(this.TXTCantidad);
            this.Controls.Add(this.LBLLocalidad);
            this.Controls.Add(this.LBLFecha);
            this.Controls.Add(this.LBLCantidad);
            this.Controls.Add(this.LBLResponsableID);
            this.Controls.Add(this.LBLResponsable);
            this.Controls.Add(this.LBLCargas);
            this.Controls.Add(this.LBLReporte);
            this.Controls.Add(this.DTCargas);
            this.Controls.Add(this.DTIngenieros);
            this.Name = "Tareas";
            this.Tag = "Tareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Tareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTIngenieros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTIngenieros;
        private System.Windows.Forms.DataGridView DTCargas;
        private System.Windows.Forms.Label LBLReporte;
        private System.Windows.Forms.Label LBLCargas;
        private System.Windows.Forms.Label LBLResponsable;
        private System.Windows.Forms.Label LBLResponsableID;
        private System.Windows.Forms.Label LBLCantidad;
        private System.Windows.Forms.Label LBLFecha;
        private System.Windows.Forms.Label LBLLocalidad;
        private System.Windows.Forms.TextBox TXTCantidad;
        private System.Windows.Forms.TextBox TXTLocalidad;
        private System.Windows.Forms.TextBox TXTFecha;
        private System.Windows.Forms.Button BTNAtreas;
        private System.Windows.Forms.Button BTNCargar;
        private System.Windows.Forms.Label LBLIngenieros;
        private System.Windows.Forms.TextBox TXTResponsable;
    }
}