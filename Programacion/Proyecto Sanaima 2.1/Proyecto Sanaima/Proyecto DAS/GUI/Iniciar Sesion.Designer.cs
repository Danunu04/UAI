namespace Proyecto_DAS
{
    partial class Iniciar_Sesion
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
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtConstraseña = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConfirmar.Location = new System.Drawing.Point(147, 156);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.BtnConfirmar.TabIndex = 9;
            this.BtnConfirmar.Tag = "TagConfirmar";
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // TxtConstraseña
            // 
            this.TxtConstraseña.Location = new System.Drawing.Point(195, 95);
            this.TxtConstraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConstraseña.Name = "TxtConstraseña";
            this.TxtConstraseña.PasswordChar = '*';
            this.TxtConstraseña.Size = new System.Drawing.Size(181, 22);
            this.TxtConstraseña.TabIndex = 8;
            this.TxtConstraseña.Tag = "";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(147, 54);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(229, 22);
            this.TxtMail.TabIndex = 7;
            this.TxtMail.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 6;
            this.label2.Tag = "TaglblIngreseContra";
            this.label2.Text = "Ingrese su contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 5;
            this.label1.Tag = "TaglblIngreseMail";
            this.label1.Text = "Ingrese su mail:";
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 226);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.TxtConstraseña);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Iniciar_Sesion";
            this.Text = "Iniciar_Sesion";
            this.Load += new System.EventHandler(this.Iniciar_Sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtConstraseña;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}