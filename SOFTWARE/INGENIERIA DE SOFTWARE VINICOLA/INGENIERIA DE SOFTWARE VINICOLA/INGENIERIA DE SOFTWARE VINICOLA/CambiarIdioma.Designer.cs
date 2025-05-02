namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class CambiarIdioma
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
            this.box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.box.Location = new System.Drawing.Point(37, 69);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idioma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar idioma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box);
            this.Name = "CambiarIdioma";
            this.Text = "CambiarIdioma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarIdioma_FormClosing);
            this.Load += new System.EventHandler(this.CambiarIdioma_Load);
            this.VisibleChanged += new System.EventHandler(this.CambiarIdioma_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}