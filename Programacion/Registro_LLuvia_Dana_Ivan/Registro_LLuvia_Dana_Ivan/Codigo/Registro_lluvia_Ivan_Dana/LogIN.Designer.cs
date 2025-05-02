namespace Registro_lluvia_Ivan_Dana
{
    partial class LogIN
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
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContraseña = new System.Windows.Forms.TextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNContraseña = new System.Windows.Forms.Button();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.LBLContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Location = new System.Drawing.Point(22, 37);
            this.TXTUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(194, 20);
            this.TXTUsuario.TabIndex = 0;
            // 
            // TXTContraseña
            // 
            this.TXTContraseña.Location = new System.Drawing.Point(22, 83);
            this.TXTContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTContraseña.Name = "TXTContraseña";
            this.TXTContraseña.Size = new System.Drawing.Size(166, 20);
            this.TXTContraseña.TabIndex = 1;
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.Location = new System.Drawing.Point(22, 128);
            this.BTNIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(54, 24);
            this.BTNIngresar.TabIndex = 2;
            this.BTNIngresar.Tag = "BTNIngresar";
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = true;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(161, 128);
            this.BTNCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(54, 24);
            this.BTNCancelar.TabIndex = 3;
            this.BTNCancelar.Tag = "BTNCancelar";
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNContraseña
            // 
            this.BTNContraseña.Location = new System.Drawing.Point(192, 83);
            this.BTNContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNContraseña.Name = "BTNContraseña";
            this.BTNContraseña.Size = new System.Drawing.Size(23, 18);
            this.BTNContraseña.TabIndex = 4;
            this.BTNContraseña.Tag = "BTNContraseña";
            this.BTNContraseña.UseVisualStyleBackColor = true;
            this.BTNContraseña.Click += new System.EventHandler(this.BTNContraseña_Click);
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.Location = new System.Drawing.Point(20, 22);
            this.LBLUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(43, 13);
            this.LBLUsuario.TabIndex = 5;
            this.LBLUsuario.Tag = "LBLUsuario";
            this.LBLUsuario.Text = "Usuario";
            this.LBLUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLContraseña
            // 
            this.LBLContraseña.AutoSize = true;
            this.LBLContraseña.Location = new System.Drawing.Point(20, 67);
            this.LBLContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLContraseña.Name = "LBLContraseña";
            this.LBLContraseña.Size = new System.Drawing.Size(61, 13);
            this.LBLContraseña.TabIndex = 6;
            this.LBLContraseña.Tag = "LBLContraseña";
            this.LBLContraseña.Text = "Contraseña";
            // 
            // LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(242, 179);
            this.Controls.Add(this.LBLContraseña);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.BTNContraseña);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNIngresar);
            this.Controls.Add(this.TXTContraseña);
            this.Controls.Add(this.TXTUsuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogIN";
            this.Tag = "LogIN";
            this.Text = "Log IN";
            this.Load += new System.EventHandler(this.LogIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTContraseña;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNContraseña;
        private System.Windows.Forms.Label LBLUsuario;
        private System.Windows.Forms.Label LBLContraseña;
    }
}