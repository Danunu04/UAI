namespace Intento_2
{
    partial class CalculadoraSimple
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumaButtom = new System.Windows.Forms.Button();
            this.Textop1 = new System.Windows.Forms.TextBox();
            this.Operador1 = new System.Windows.Forms.Label();
            this.Operador2 = new System.Windows.Forms.Label();
            this.Textop2 = new System.Windows.Forms.TextBox();
            this.Textrta = new System.Windows.Forms.TextBox();
            this.Respuesta = new System.Windows.Forms.Label();
            this.RestaButtom = new System.Windows.Forms.Button();
            this.ProductoButtom = new System.Windows.Forms.Button();
            this.CocienteButtom = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.SalirButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumaButtom
            // 
            this.SumaButtom.Location = new System.Drawing.Point(273, 56);
            this.SumaButtom.Name = "SumaButtom";
            this.SumaButtom.Size = new System.Drawing.Size(75, 23);
            this.SumaButtom.TabIndex = 0;
            this.SumaButtom.Text = "Suma";
            this.SumaButtom.UseVisualStyleBackColor = true;
            this.SumaButtom.Click += new System.EventHandler(this.SumaButtom_Click);
            // 
            // Textop1
            // 
            this.Textop1.Location = new System.Drawing.Point(137, 59);
            this.Textop1.Name = "Textop1";
            this.Textop1.Size = new System.Drawing.Size(100, 20);
            this.Textop1.TabIndex = 1;
            // 
            // Operador1
            // 
            this.Operador1.AutoSize = true;
            this.Operador1.Location = new System.Drawing.Point(42, 62);
            this.Operador1.Name = "Operador1";
            this.Operador1.Size = new System.Drawing.Size(69, 13);
            this.Operador1.TabIndex = 2;
            this.Operador1.Text = "1er Operador";
            // 
            // Operador2
            // 
            this.Operador2.AutoSize = true;
            this.Operador2.Location = new System.Drawing.Point(42, 119);
            this.Operador2.Name = "Operador2";
            this.Operador2.Size = new System.Drawing.Size(72, 13);
            this.Operador2.TabIndex = 3;
            this.Operador2.Text = "2do Operador";
            // 
            // Textop2
            // 
            this.Textop2.Location = new System.Drawing.Point(137, 112);
            this.Textop2.Name = "Textop2";
            this.Textop2.Size = new System.Drawing.Size(100, 20);
            this.Textop2.TabIndex = 4;
            // 
            // Textrta
            // 
            this.Textrta.Location = new System.Drawing.Point(137, 172);
            this.Textrta.Name = "Textrta";
            this.Textrta.ReadOnly = true;
            this.Textrta.Size = new System.Drawing.Size(100, 20);
            this.Textrta.TabIndex = 5;
            this.Textrta.TextChanged += new System.EventHandler(this.Textrta_TextChanged);
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Location = new System.Drawing.Point(42, 179);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(55, 13);
            this.Respuesta.TabIndex = 6;
            this.Respuesta.Text = "Resultado";
            // 
            // RestaButtom
            // 
            this.RestaButtom.Location = new System.Drawing.Point(273, 85);
            this.RestaButtom.Name = "RestaButtom";
            this.RestaButtom.Size = new System.Drawing.Size(75, 23);
            this.RestaButtom.TabIndex = 7;
            this.RestaButtom.Text = "Resta";
            this.RestaButtom.UseVisualStyleBackColor = true;
            this.RestaButtom.Click += new System.EventHandler(this.RestaButtom_Click);
            // 
            // ProductoButtom
            // 
            this.ProductoButtom.Location = new System.Drawing.Point(273, 114);
            this.ProductoButtom.Name = "ProductoButtom";
            this.ProductoButtom.Size = new System.Drawing.Size(75, 23);
            this.ProductoButtom.TabIndex = 8;
            this.ProductoButtom.Text = "Producto";
            this.ProductoButtom.UseVisualStyleBackColor = true;
            this.ProductoButtom.Click += new System.EventHandler(this.ProductoButtom_Click);
            // 
            // CocienteButtom
            // 
            this.CocienteButtom.Location = new System.Drawing.Point(273, 143);
            this.CocienteButtom.Name = "CocienteButtom";
            this.CocienteButtom.Size = new System.Drawing.Size(75, 23);
            this.CocienteButtom.TabIndex = 9;
            this.CocienteButtom.Text = "Cociente";
            this.CocienteButtom.UseVisualStyleBackColor = true;
            this.CocienteButtom.Click += new System.EventHandler(this.CocienteButtom_Click);
            // 
            // CleanAll
            // 
            this.CleanAll.Location = new System.Drawing.Point(273, 172);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(75, 23);
            this.CleanAll.TabIndex = 10;
            this.CleanAll.Text = "Vaciar";
            this.CleanAll.UseVisualStyleBackColor = true;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // SalirButtom
            // 
            this.SalirButtom.Location = new System.Drawing.Point(45, 215);
            this.SalirButtom.Name = "SalirButtom";
            this.SalirButtom.Size = new System.Drawing.Size(75, 23);
            this.SalirButtom.TabIndex = 11;
            this.SalirButtom.Text = "Salir";
            this.SalirButtom.UseVisualStyleBackColor = true;
            this.SalirButtom.Click += new System.EventHandler(this.SalirButtom_Click);
            // 
            // CalculadoraSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 293);
            this.Controls.Add(this.SalirButtom);
            this.Controls.Add(this.CleanAll);
            this.Controls.Add(this.CocienteButtom);
            this.Controls.Add(this.ProductoButtom);
            this.Controls.Add(this.RestaButtom);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.Textrta);
            this.Controls.Add(this.Textop2);
            this.Controls.Add(this.Operador2);
            this.Controls.Add(this.Operador1);
            this.Controls.Add(this.Textop1);
            this.Controls.Add(this.SumaButtom);
            this.Name = "CalculadoraSimple";
            this.Text = "Calculadora simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumaButtom;
        private System.Windows.Forms.TextBox Textop1;
        private System.Windows.Forms.Label Operador1;
        private System.Windows.Forms.Label Operador2;
        private System.Windows.Forms.TextBox Textop2;
        private System.Windows.Forms.TextBox Textrta;
        private System.Windows.Forms.Label Respuesta;
        private System.Windows.Forms.Button RestaButtom;
        private System.Windows.Forms.Button ProductoButtom;
        private System.Windows.Forms.Button CocienteButtom;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button SalirButtom;
    }
}

