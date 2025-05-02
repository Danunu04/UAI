namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class GestionDeFamilias
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTFamilia = new System.Windows.Forms.TextBox();
            this.BTNCrearFamilia = new System.Windows.Forms.Button();
            this.BTNEliminarFamilia = new System.Windows.Forms.Button();
            this.BTNAgregarPermiso = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBPermisos = new System.Windows.Forms.ComboBox();
            this.CBFamilias = new System.Windows.Forms.ComboBox();
            this.BTNAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre de la familia:";
            // 
            // TXTFamilia
            // 
            this.TXTFamilia.Location = new System.Drawing.Point(12, 140);
            this.TXTFamilia.Name = "TXTFamilia";
            this.TXTFamilia.Size = new System.Drawing.Size(129, 20);
            this.TXTFamilia.TabIndex = 52;
            // 
            // BTNCrearFamilia
            // 
            this.BTNCrearFamilia.Location = new System.Drawing.Point(15, 17);
            this.BTNCrearFamilia.Name = "BTNCrearFamilia";
            this.BTNCrearFamilia.Size = new System.Drawing.Size(129, 36);
            this.BTNCrearFamilia.TabIndex = 51;
            this.BTNCrearFamilia.Text = "Crear familia";
            this.BTNCrearFamilia.UseVisualStyleBackColor = true;
            this.BTNCrearFamilia.Click += new System.EventHandler(this.BTNCrearFamilia_Click);
            // 
            // BTNEliminarFamilia
            // 
            this.BTNEliminarFamilia.Location = new System.Drawing.Point(15, 59);
            this.BTNEliminarFamilia.Name = "BTNEliminarFamilia";
            this.BTNEliminarFamilia.Size = new System.Drawing.Size(129, 36);
            this.BTNEliminarFamilia.TabIndex = 50;
            this.BTNEliminarFamilia.Text = "Eliminar familia";
            this.BTNEliminarFamilia.UseVisualStyleBackColor = true;
            this.BTNEliminarFamilia.Click += new System.EventHandler(this.BTNEliminarFamilia_Click);
            // 
            // BTNAgregarPermiso
            // 
            this.BTNAgregarPermiso.Location = new System.Drawing.Point(432, 72);
            this.BTNAgregarPermiso.Name = "BTNAgregarPermiso";
            this.BTNAgregarPermiso.Size = new System.Drawing.Size(129, 23);
            this.BTNAgregarPermiso.TabIndex = 49;
            this.BTNAgregarPermiso.Text = "Agregar permiso";
            this.BTNAgregarPermiso.UseVisualStyleBackColor = true;
            this.BTNAgregarPermiso.Click += new System.EventHandler(this.BTNAgregarPermiso_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(162, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(214, 212);
            this.treeView1.TabIndex = 48;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Familias";
            // 
            // CBPermisos
            // 
            this.CBPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPermisos.FormattingEnabled = true;
            this.CBPermisos.Location = new System.Drawing.Point(432, 32);
            this.CBPermisos.Name = "CBPermisos";
            this.CBPermisos.Size = new System.Drawing.Size(129, 21);
            this.CBPermisos.TabIndex = 45;
            // 
            // CBFamilias
            // 
            this.CBFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFamilias.FormattingEnabled = true;
            this.CBFamilias.Location = new System.Drawing.Point(432, 137);
            this.CBFamilias.Name = "CBFamilias";
            this.CBFamilias.Size = new System.Drawing.Size(129, 21);
            this.CBFamilias.TabIndex = 44;
            this.CBFamilias.SelectedIndexChanged += new System.EventHandler(this.CBFamilias_SelectedIndexChanged);
            // 
            // BTNAplicar
            // 
            this.BTNAplicar.Location = new System.Drawing.Point(432, 180);
            this.BTNAplicar.Name = "BTNAplicar";
            this.BTNAplicar.Size = new System.Drawing.Size(143, 23);
            this.BTNAplicar.TabIndex = 43;
            this.BTNAplicar.Text = "Aplicar";
            this.BTNAplicar.UseVisualStyleBackColor = true;
            this.BTNAplicar.Click += new System.EventHandler(this.BTNAplicar_Click);
            // 
            // GestionDeFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(689, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTFamilia);
            this.Controls.Add(this.BTNCrearFamilia);
            this.Controls.Add(this.BTNEliminarFamilia);
            this.Controls.Add(this.BTNAgregarPermiso);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBPermisos);
            this.Controls.Add(this.CBFamilias);
            this.Controls.Add(this.BTNAplicar);
            this.Name = "GestionDeFamilias";
            this.Text = "GestionDeFamilias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionDeFamilias_FormClosing);
            this.Load += new System.EventHandler(this.GestionDeFamilias_Load);
            this.VisibleChanged += new System.EventHandler(this.GestionDeFamilias_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTFamilia;
        private System.Windows.Forms.Button BTNCrearFamilia;
        private System.Windows.Forms.Button BTNEliminarFamilia;
        private System.Windows.Forms.Button BTNAgregarPermiso;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBPermisos;
        private System.Windows.Forms.ComboBox CBFamilias;
        private System.Windows.Forms.Button BTNAplicar;
    }
}