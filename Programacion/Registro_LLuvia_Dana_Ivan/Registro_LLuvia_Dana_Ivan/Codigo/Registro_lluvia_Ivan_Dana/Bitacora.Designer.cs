namespace Registro_lluvia_Ivan_Dana
{
    partial class Bitacora
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNIntrigar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CDCritic = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTModulo = new System.Windows.Forms.TextBox();
            this.TXTOperacion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDCritic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 1;
            this.label1.Tag = "LBLBitacora";
            this.label1.Text = "Bitacora";
            // 
            // BTNIntrigar
            // 
            this.BTNIntrigar.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIntrigar.Location = new System.Drawing.Point(555, 12);
            this.BTNIntrigar.Name = "BTNIntrigar";
            this.BTNIntrigar.Size = new System.Drawing.Size(179, 27);
            this.BTNIntrigar.TabIndex = 2;
            this.BTNIntrigar.Tag = "Imprimir";
            this.BTNIntrigar.Text = "Imprimir";
            this.BTNIntrigar.UseVisualStyleBackColor = true;
            this.BTNIntrigar.Click += new System.EventHandler(this.BTNIntrigar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 3;
            this.label2.Tag = "LBLFiltrar";
            this.label2.Text = "Filtrar";
            // 
            // fechaDTP
            // 
            this.fechaDTP.Location = new System.Drawing.Point(17, 321);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(200, 20);
            this.fechaDTP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 5;
            this.label3.Tag = "LBLFecha";
            this.label3.Text = "Fecha Inicio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 6;
            this.label4.Tag = "LBLCriticidad";
            this.label4.Text = "Criticidad";
            // 
            // CDCritic
            // 
            this.CDCritic.Location = new System.Drawing.Point(238, 321);
            this.CDCritic.Name = "CDCritic";
            this.CDCritic.Size = new System.Drawing.Size(114, 20);
            this.CDCritic.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 29);
            this.button1.TabIndex = 8;
            this.button1.Tag = "BTNAplicar";
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 10;
            this.label5.Tag = "LBLFechaFinal";
            this.label5.Text = "Fecha Final";
            // 
            // FechaFinal
            // 
            this.FechaFinal.Location = new System.Drawing.Point(17, 383);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(200, 20);
            this.FechaFinal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 11;
            this.label6.Tag = "Usuario";
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(388, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 12;
            this.label7.Tag = "Modulo";
            this.label7.Text = "Modulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 13;
            this.label8.Tag = "Operacion";
            this.label8.Text = "Operacion";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Location = new System.Drawing.Point(238, 383);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(114, 20);
            this.TXTUsuario.TabIndex = 14;
            // 
            // TXTModulo
            // 
            this.TXTModulo.Location = new System.Drawing.Point(391, 321);
            this.TXTModulo.Name = "TXTModulo";
            this.TXTModulo.Size = new System.Drawing.Size(114, 20);
            this.TXTModulo.TabIndex = 15;
            // 
            // TXTOperacion
            // 
            this.TXTOperacion.Location = new System.Drawing.Point(391, 383);
            this.TXTOperacion.Name = "TXTOperacion";
            this.TXTOperacion.Size = new System.Drawing.Size(114, 20);
            this.TXTOperacion.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(564, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 29);
            this.button2.TabIndex = 17;
            this.button2.Tag = "Borrar";
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXTOperacion);
            this.Controls.Add(this.TXTModulo);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CDCritic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNIntrigar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bitacora";
            this.Tag = "FRMBitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDCritic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNIntrigar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CDCritic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTModulo;
        private System.Windows.Forms.TextBox TXTOperacion;
        private System.Windows.Forms.Button button2;
    }
}