namespace Proyecto_DAS
{
    partial class Registrar_Empleado
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
            this.label9 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.DtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.CmbIdioma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 13);
            this.label9.TabIndex = 39;
            this.label9.Tag = "TagTipoRol";
            this.label9.Text = "1 - Administrador | 2 - Super-Empleado | 3 - Empleado ";
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbRol.Location = new System.Drawing.Point(172, 293);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(31, 21);
            this.CmbRol.TabIndex = 38;
            // 
            // DtpFecNac
            // 
            this.DtpFecNac.Location = new System.Drawing.Point(172, 199);
            this.DtpFecNac.Name = "DtpFecNac";
            this.DtpFecNac.Size = new System.Drawing.Size(212, 20);
            this.DtpFecNac.TabIndex = 37;
            // 
            // CmbIdioma
            // 
            this.CmbIdioma.FormattingEnabled = true;
            this.CmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues"});
            this.CmbIdioma.Location = new System.Drawing.Point(172, 340);
            this.CmbIdioma.Name = "CmbIdioma";
            this.CmbIdioma.Size = new System.Drawing.Size(212, 21);
            this.CmbIdioma.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 35;
            this.label8.Tag = "TagIdioma";
            this.label8.Text = "Idioma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 34;
            this.label7.Tag = "TagRol";
            this.label7.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 33;
            this.label6.Tag = "TagContraseña";
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 32;
            this.label5.Tag = "TagFechaNacimeinto";
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 31;
            this.label4.Tag = "TagMail";
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 30;
            this.label3.Tag = "TagNombre";
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 29;
            this.label2.Tag = "TagApellido";
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 28;
            this.label1.Tag = "TagDocumento";
            this.label1.Text = "Documento";
            // 
            // TxtDoc
            // 
            this.TxtDoc.Location = new System.Drawing.Point(172, 21);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(212, 20);
            this.TxtDoc.TabIndex = 27;
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(172, 64);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(212, 20);
            this.TxtApe.TabIndex = 26;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(172, 108);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(212, 20);
            this.TxtNom.TabIndex = 25;
            this.TxtNom.Leave += new System.EventHandler(this.TxtNom_Leave);
            // 
            // TxtMail
            // 
            this.TxtMail.Enabled = false;
            this.TxtMail.Location = new System.Drawing.Point(172, 155);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(212, 20);
            this.TxtMail.TabIndex = 24;
            // 
            // TxtContra
            // 
            this.TxtContra.Location = new System.Drawing.Point(172, 247);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(212, 20);
            this.TxtContra.TabIndex = 23;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegistrar.Location = new System.Drawing.Point(502, 158);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(121, 64);
            this.BtnRegistrar.TabIndex = 22;
            this.BtnRegistrar.Tag = "TagRegistrar";
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // Registrar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 400);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.DtpFecNac);
            this.Controls.Add(this.CmbIdioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDoc);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.BtnRegistrar);
            this.Name = "Registrar_Empleado";
            this.Text = "Registrar_Empleado";
            this.Load += new System.EventHandler(this.Registrar_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.DateTimePicker DtpFecNac;
        private System.Windows.Forms.ComboBox CmbIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}