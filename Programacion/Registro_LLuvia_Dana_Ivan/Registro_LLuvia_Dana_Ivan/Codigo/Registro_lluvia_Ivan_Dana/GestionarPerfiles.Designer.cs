namespace Registro_lluvia_Ivan_Dana
{
    partial class GestionarPerfiles
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.BTNAFamilia = new System.Windows.Forms.Button();
            this.BTNEFamilia = new System.Windows.Forms.Button();
            this.BTNAPatente = new System.Windows.Forms.Button();
            this.BTNEPatente = new System.Windows.Forms.Button();
            this.LBLFamilia = new System.Windows.Forms.Label();
            this.LBLPatente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(203, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(470, 406);
            this.treeView1.TabIndex = 0;
            // 
            // BTNAFamilia
            // 
            this.BTNAFamilia.Location = new System.Drawing.Point(33, 124);
            this.BTNAFamilia.Name = "BTNAFamilia";
            this.BTNAFamilia.Size = new System.Drawing.Size(152, 40);
            this.BTNAFamilia.TabIndex = 1;
            this.BTNAFamilia.Tag = "BTNAFamilia";
            this.BTNAFamilia.Text = "Agregar Familia";
            this.BTNAFamilia.UseVisualStyleBackColor = true;
            // 
            // BTNEFamilia
            // 
            this.BTNEFamilia.Location = new System.Drawing.Point(33, 170);
            this.BTNEFamilia.Name = "BTNEFamilia";
            this.BTNEFamilia.Size = new System.Drawing.Size(152, 40);
            this.BTNEFamilia.TabIndex = 2;
            this.BTNEFamilia.Tag = "BTNEFamilia";
            this.BTNEFamilia.Text = "Eliminar Familia";
            this.BTNEFamilia.UseVisualStyleBackColor = true;
            // 
            // BTNAPatente
            // 
            this.BTNAPatente.Location = new System.Drawing.Point(33, 396);
            this.BTNAPatente.Name = "BTNAPatente";
            this.BTNAPatente.Size = new System.Drawing.Size(152, 40);
            this.BTNAPatente.TabIndex = 4;
            this.BTNAPatente.Tag = "BTNAPatente";
            this.BTNAPatente.Text = "Agregar Patente";
            this.BTNAPatente.UseVisualStyleBackColor = true;
            // 
            // BTNEPatente
            // 
            this.BTNEPatente.Location = new System.Drawing.Point(33, 442);
            this.BTNEPatente.Name = "BTNEPatente";
            this.BTNEPatente.Size = new System.Drawing.Size(152, 40);
            this.BTNEPatente.TabIndex = 3;
            this.BTNEPatente.Tag = "BTNEPatente";
            this.BTNEPatente.Text = "Eliminar Patente";
            this.BTNEPatente.UseVisualStyleBackColor = true;
            // 
            // LBLFamilia
            // 
            this.LBLFamilia.AutoSize = true;
            this.LBLFamilia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLFamilia.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFamilia.Location = new System.Drawing.Point(37, 72);
            this.LBLFamilia.Name = "LBLFamilia";
            this.LBLFamilia.Size = new System.Drawing.Size(144, 28);
            this.LBLFamilia.TabIndex = 5;
            this.LBLFamilia.Tag = "LBLFamilia";
            this.LBLFamilia.Text = "Familia      ";
            // 
            // LBLPatente
            // 
            this.LBLPatente.AutoSize = true;
            this.LBLPatente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLPatente.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPatente.Location = new System.Drawing.Point(37, 344);
            this.LBLPatente.Name = "LBLPatente";
            this.LBLPatente.Size = new System.Drawing.Size(146, 28);
            this.LBLPatente.TabIndex = 6;
            this.LBLPatente.Tag = "LBLPatente";
            this.LBLPatente.Text = "Patente     ";
            // 
            // GestionarPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 551);
            this.Controls.Add(this.LBLPatente);
            this.Controls.Add(this.LBLFamilia);
            this.Controls.Add(this.BTNAPatente);
            this.Controls.Add(this.BTNEPatente);
            this.Controls.Add(this.BTNEFamilia);
            this.Controls.Add(this.BTNAFamilia);
            this.Controls.Add(this.treeView1);
            this.Name = "GestionarPerfiles";
            this.Tag = "GestionarPerfiles";
            this.Text = "GestionarPerfiles";
            this.Load += new System.EventHandler(this.GestionarPerfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BTNAFamilia;
        private System.Windows.Forms.Button BTNEFamilia;
        private System.Windows.Forms.Button BTNAPatente;
        private System.Windows.Forms.Button BTNEPatente;
        private System.Windows.Forms.Label LBLFamilia;
        private System.Windows.Forms.Label LBLPatente;
    }
}