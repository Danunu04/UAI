namespace Proyecto_DAS
{
    partial class Registrar_Producto
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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.CódigoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsableDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesgasteDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtGastoPrevio = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtResponsable = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Responsable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Desgaste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(57, 90);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(120, 78);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Tag = "TagRegistrar";
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtModificar
            // 
            this.BtModificar.Location = new System.Drawing.Point(57, 212);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(120, 78);
            this.BtModificar.TabIndex = 1;
            this.BtModificar.Tag = "TagModificar";
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(57, 338);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 78);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Tag = "TagEliminar";
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoDGV,
            this.ResponsableDGV,
            this.NombreDGV,
            this.CostoDGV,
            this.DesgasteDGV,
            this.EstadoDGV});
            this.DgvProductos.Location = new System.Drawing.Point(509, 90);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.Size = new System.Drawing.Size(594, 326);
            this.DgvProductos.TabIndex = 3;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick);
            // 
            // CódigoDGV
            // 
            this.CódigoDGV.HeaderText = "Código";
            this.CódigoDGV.MinimumWidth = 6;
            this.CódigoDGV.Name = "CódigoDGV";
            this.CódigoDGV.Width = 70;
            // 
            // ResponsableDGV
            // 
            this.ResponsableDGV.HeaderText = "Responsable";
            this.ResponsableDGV.MinimumWidth = 6;
            this.ResponsableDGV.Name = "ResponsableDGV";
            this.ResponsableDGV.Width = 125;
            // 
            // NombreDGV
            // 
            this.NombreDGV.HeaderText = "Nombre";
            this.NombreDGV.MinimumWidth = 6;
            this.NombreDGV.Name = "NombreDGV";
            this.NombreDGV.Width = 125;
            // 
            // CostoDGV
            // 
            this.CostoDGV.HeaderText = "Costo";
            this.CostoDGV.MinimumWidth = 6;
            this.CostoDGV.Name = "CostoDGV";
            this.CostoDGV.Width = 60;
            // 
            // DesgasteDGV
            // 
            this.DesgasteDGV.HeaderText = "Desgaste";
            this.DesgasteDGV.MinimumWidth = 6;
            this.DesgasteDGV.Name = "DesgasteDGV";
            this.DesgasteDGV.Width = 60;
            // 
            // EstadoDGV
            // 
            this.EstadoDGV.HeaderText = "Estado";
            this.EstadoDGV.MinimumWidth = 6;
            this.EstadoDGV.Name = "EstadoDGV";
            this.EstadoDGV.Width = 125;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(316, 270);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(79, 20);
            this.TxtCosto.TabIndex = 3;
            // 
            // TxtGastoPrevio
            // 
            this.TxtGastoPrevio.Location = new System.Drawing.Point(316, 310);
            this.TxtGastoPrevio.Name = "TxtGastoPrevio";
            this.TxtGastoPrevio.Size = new System.Drawing.Size(79, 20);
            this.TxtGastoPrevio.TabIndex = 4;
            this.TxtGastoPrevio.Leave += new System.EventHandler(this.TxtGastoPrevio_Leave);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Enabled = false;
            this.TxtEstado.Location = new System.Drawing.Point(316, 351);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(127, 20);
            this.TxtEstado.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(316, 229);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(127, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtResponsable
            // 
            this.TxtResponsable.Enabled = false;
            this.TxtResponsable.Location = new System.Drawing.Point(316, 188);
            this.TxtResponsable.Name = "TxtResponsable";
            this.TxtResponsable.Size = new System.Drawing.Size(127, 20);
            this.TxtResponsable.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(316, 148);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(79, 20);
            this.TxtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Tag = "TagCodigoProd";
            this.label1.Text = "Código";
            // 
            // Responsable
            // 
            this.Responsable.AutoSize = true;
            this.Responsable.Location = new System.Drawing.Point(239, 191);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(69, 13);
            this.Responsable.TabIndex = 14;
            this.Responsable.Tag = "TagResponsable";
            this.Responsable.Text = "Responsable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Tag = "TagNombre";
            this.label3.Text = "Nombre";
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Location = new System.Drawing.Point(239, 273);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(34, 13);
            this.Costo.TabIndex = 16;
            this.Costo.Tag = "TagCosto";
            this.Costo.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Tag = "TagEstado";
            this.label5.Text = "Estado";
            // 
            // Desgaste
            // 
            this.Desgaste.AutoSize = true;
            this.Desgaste.Location = new System.Drawing.Point(239, 313);
            this.Desgaste.Name = "Desgaste";
            this.Desgaste.Size = new System.Drawing.Size(52, 13);
            this.Desgaste.TabIndex = 17;
            this.Desgaste.Tag = "TagDesgaste";
            this.Desgaste.Text = "Desgaste";
            // 
            // Registrar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 523);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Desgaste);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Responsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtResponsable);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtGastoPrevio);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtModificar);
            this.Controls.Add(this.BtnRegistrar);
            this.Name = "Registrar_Producto";
            this.Text = "Registrar_Producto";
            this.Load += new System.EventHandler(this.Registrar_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtGastoPrevio;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtResponsable;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Responsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Desgaste;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsableDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesgasteDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDGV;
    }
}