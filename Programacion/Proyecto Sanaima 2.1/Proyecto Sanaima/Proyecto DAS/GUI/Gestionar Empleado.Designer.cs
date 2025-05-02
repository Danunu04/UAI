namespace Proyecto_DAS
{
    partial class Gestionar_Empleado
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnHabiDesa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.DtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.CmbIdioma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.DgvHabilitado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DgvDeshabilitado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblContra = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabilitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeshabilitado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.Location = new System.Drawing.Point(93, 86);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(240, 123);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnHabiDesa
            // 
            this.BtnHabiDesa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnHabiDesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHabiDesa.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHabiDesa.Location = new System.Drawing.Point(468, 86);
            this.BtnHabiDesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHabiDesa.Name = "BtnHabiDesa";
            this.BtnHabiDesa.Size = new System.Drawing.Size(240, 123);
            this.BtnHabiDesa.TabIndex = 1;
            this.BtnHabiDesa.Text = "Habilitar/Deshabilitar";
            this.BtnHabiDesa.UseVisualStyleBackColor = false;
            this.BtnHabiDesa.Click += new System.EventHandler(this.BtnHabiDesa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 575);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 18);
            this.label9.TabIndex = 56;
            this.label9.Tag = "TagTipoRol";
            this.label9.Text = "1 - Administrador | 2 - Super-Empleado | 3 - Empleado ";
//            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbRol.Location = new System.Drawing.Point(343, 571);
            this.CmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(40, 24);
            this.CmbRol.TabIndex = 55;
 //           this.CmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // DtpFecNac
            // 
            this.DtpFecNac.Location = new System.Drawing.Point(341, 516);
            this.DtpFecNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFecNac.Name = "DtpFecNac";
            this.DtpFecNac.Size = new System.Drawing.Size(281, 22);
            this.DtpFecNac.TabIndex = 54;
  //          this.DtpFecNac.ValueChanged += new System.EventHandler(this.DtpFecNac_ValueChanged);
            // 
            // CmbIdioma
            // 
            this.CmbIdioma.FormattingEnabled = true;
            this.CmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues"});
            this.CmbIdioma.Location = new System.Drawing.Point(343, 629);
            this.CmbIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbIdioma.Name = "CmbIdioma";
            this.CmbIdioma.Size = new System.Drawing.Size(281, 24);
            this.CmbIdioma.TabIndex = 53;
          //  this.CmbIdioma.SelectedIndexChanged += new System.EventHandler(this.CmbIdioma_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 629);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 52;
            this.label8.Tag = "TagIdioma";
            this.label8.Text = "Idioma";
          //  this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 575);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 51;
            this.label7.Tag = "TagRol";
            this.label7.Text = "Rol";
          //  this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 523);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 49;
            this.label5.Tag = "TagFechaNacimeinto";
            this.label5.Text = "Fecha de nacimiento";
          //  this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 48;
            this.label4.Tag = "TagMail";
            this.label4.Text = "Mail";
          //  this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 47;
            this.label3.Tag = "TagNombre";
            this.label3.Text = "Nombre";
          //  this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 46;
            this.label2.Tag = "TagApellido";
            this.label2.Text = "Apellido";
           // this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 45;
            this.label1.Tag = "TagDocumento";
            this.label1.Text = "Documento";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDoc
            // 
            this.TxtDoc.Enabled = false;
            this.TxtDoc.Location = new System.Drawing.Point(341, 297);
            this.TxtDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(281, 22);
            this.TxtDoc.TabIndex = 44;
          //  this.TxtDoc.TextChanged += new System.EventHandler(this.TxtDoc_TextChanged);
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(341, 350);
            this.TxtApe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(281, 22);
            this.TxtApe.TabIndex = 43;
           // this.TxtApe.TextChanged += new System.EventHandler(this.TxtApe_TextChanged);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(341, 404);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(281, 22);
            this.TxtNom.TabIndex = 42;
          //  this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Enabled = false;
            this.TxtMail.Location = new System.Drawing.Point(341, 462);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(281, 22);
            this.TxtMail.TabIndex = 41;
           // this.TxtMail.TextChanged += new System.EventHandler(this.TxtMail_TextChanged);
            // 
            // DgvHabilitado
            // 
            this.DgvHabilitado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHabilitado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column7,
            this.Column6,
            this.Column8});
            this.DgvHabilitado.Location = new System.Drawing.Point(839, 44);
            this.DgvHabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvHabilitado.Name = "DgvHabilitado";
            this.DgvHabilitado.RowHeadersWidth = 51;
            this.DgvHabilitado.Size = new System.Drawing.Size(988, 311);
            this.DgvHabilitado.TabIndex = 57;
          //  this.DgvHabilitado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgvHabilitado.SelectionChanged += new System.EventHandler(this.DgvHabilitado_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Documento";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Nacimiento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mail";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Contraseña";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rol";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Idioma";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Estado";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(865, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 59;
            this.label10.Tag = "TagDocumento";
            this.label10.Text = "Deshabilitado:";
          //  this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(865, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 60;
            this.label11.Tag = "TagDocumento";
            this.label11.Text = "Habilitado:";
           // this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // DgvDeshabilitado
            // 
            this.DgvDeshabilitado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeshabilitado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DgvDeshabilitado.Location = new System.Drawing.Point(839, 414);
            this.DgvDeshabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvDeshabilitado.Name = "DgvDeshabilitado";
            this.DgvDeshabilitado.RowHeadersWidth = 51;
            this.DgvDeshabilitado.Size = new System.Drawing.Size(988, 311);
            this.DgvDeshabilitado.TabIndex = 61;
            this.DgvDeshabilitado.SelectionChanged += new System.EventHandler(this.DgvDeshabilitado_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Contraseña";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            this.Column10.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Idioma";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Location = new System.Drawing.Point(497, 709);
            this.LblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(44, 16);
            this.LblContra.TabIndex = 62;
            this.LblContra.Text = "label6";
            this.LblContra.Visible = false;
//            this.LblContra.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(677, 709);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(51, 16);
            this.LblEstado.TabIndex = 63;
            this.LblEstado.Text = "label12";
            this.LblEstado.Visible = false;
            // 
            // Gestionar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1861, 764);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblContra);
            this.Controls.Add(this.DgvDeshabilitado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvHabilitado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.DtpFecNac);
            this.Controls.Add(this.CmbIdioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDoc);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.BtnHabiDesa);
            this.Controls.Add(this.BtnModificar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gestionar_Empleado";
            this.Text = "Gestionar_Empleado";
            this.Load += new System.EventHandler(this.Gestionar_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabilitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeshabilitado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnHabiDesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.DateTimePicker DtpFecNac;
        private System.Windows.Forms.ComboBox CmbIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.DataGridView DgvHabilitado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvDeshabilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Label LblEstado;
    }
}