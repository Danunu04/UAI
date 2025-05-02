namespace Registro_lluvia_Ivan_Dana
{
    partial class GestionUsuarios
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
            this.LBLCargarUsuario = new System.Windows.Forms.Label();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.LBLApellido = new System.Windows.Forms.Label();
            this.LBLDni = new System.Windows.Forms.Label();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.LBLContraseña = new System.Windows.Forms.Label();
            this.LBLRol = new System.Windows.Forms.Label();
            this.BTNCargar = new System.Windows.Forms.Button();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.TXTApellido = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContraseña = new System.Windows.Forms.TextBox();
            this.TXTRol = new System.Windows.Forms.TextBox();
            this.BTNMostrarContra = new System.Windows.Forms.Button();
            this.DGUsuarioRol = new System.Windows.Forms.DataGridView();
            this.LBLUsuarioRol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarioRol)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLCargarUsuario
            // 
            this.LBLCargarUsuario.AutoSize = true;
            this.LBLCargarUsuario.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCargarUsuario.Location = new System.Drawing.Point(37, 43);
            this.LBLCargarUsuario.Name = "LBLCargarUsuario";
            this.LBLCargarUsuario.Size = new System.Drawing.Size(189, 28);
            this.LBLCargarUsuario.TabIndex = 0;
            this.LBLCargarUsuario.Tag = "LBLCargarUsuario";
            this.LBLCargarUsuario.Text = "Cargar Usuario";
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNombre.Location = new System.Drawing.Point(37, 101);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(90, 26);
            this.LBLNombre.TabIndex = 1;
            this.LBLNombre.Tag = "LBLNombre";
            this.LBLNombre.Text = "Nombre";
            // 
            // LBLApellido
            // 
            this.LBLApellido.AutoSize = true;
            this.LBLApellido.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLApellido.Location = new System.Drawing.Point(37, 155);
            this.LBLApellido.Name = "LBLApellido";
            this.LBLApellido.Size = new System.Drawing.Size(92, 26);
            this.LBLApellido.TabIndex = 2;
            this.LBLApellido.Tag = "LBLApellido";
            this.LBLApellido.Text = "Apellido";
            // 
            // LBLDni
            // 
            this.LBLDni.AutoSize = true;
            this.LBLDni.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDni.Location = new System.Drawing.Point(37, 205);
            this.LBLDni.Name = "LBLDni";
            this.LBLDni.Size = new System.Drawing.Size(50, 26);
            this.LBLDni.TabIndex = 3;
            this.LBLDni.Tag = "LBLDni";
            this.LBLDni.Text = "DNI";
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuario.Location = new System.Drawing.Point(37, 266);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(92, 26);
            this.LBLUsuario.TabIndex = 4;
            this.LBLUsuario.Tag = "LBLUsuario";
            this.LBLUsuario.Text = "Usuario";
            this.LBLUsuario.Click += new System.EventHandler(this.LBLUsuario_Click);
            // 
            // LBLContraseña
            // 
            this.LBLContraseña.AutoSize = true;
            this.LBLContraseña.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContraseña.Location = new System.Drawing.Point(37, 321);
            this.LBLContraseña.Name = "LBLContraseña";
            this.LBLContraseña.Size = new System.Drawing.Size(134, 26);
            this.LBLContraseña.TabIndex = 5;
            this.LBLContraseña.Tag = "LBLContraseña";
            this.LBLContraseña.Text = "Contraseña";
            // 
            // LBLRol
            // 
            this.LBLRol.AutoSize = true;
            this.LBLRol.Font = new System.Drawing.Font("Dana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRol.Location = new System.Drawing.Point(46, 379);
            this.LBLRol.Name = "LBLRol";
            this.LBLRol.Size = new System.Drawing.Size(45, 26);
            this.LBLRol.TabIndex = 6;
            this.LBLRol.Tag = "LBLRol";
            this.LBLRol.Text = "Rol";
            // 
            // BTNCargar
            // 
            this.BTNCargar.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCargar.Location = new System.Drawing.Point(42, 489);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(131, 32);
            this.BTNCargar.TabIndex = 7;
            this.BTNCargar.Tag = "BTNCargar";
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = true;
            this.BTNCargar.Click += new System.EventHandler(this.BTNCargar_Click);
            // 
            // TXTNombre
            // 
            this.TXTNombre.Location = new System.Drawing.Point(259, 92);
            this.TXTNombre.Multiline = true;
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(175, 35);
            this.TXTNombre.TabIndex = 8;
            this.TXTNombre.Tag = "TXTNombre";
            // 
            // TXTApellido
            // 
            this.TXTApellido.Location = new System.Drawing.Point(259, 146);
            this.TXTApellido.Multiline = true;
            this.TXTApellido.Name = "TXTApellido";
            this.TXTApellido.Size = new System.Drawing.Size(175, 35);
            this.TXTApellido.TabIndex = 9;
            this.TXTApellido.Tag = "TXTApellido";
            // 
            // TXTDni
            // 
            this.TXTDni.Location = new System.Drawing.Point(259, 196);
            this.TXTDni.Multiline = true;
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(175, 35);
            this.TXTDni.TabIndex = 10;
            this.TXTDni.Tag = "TXTDni";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.Location = new System.Drawing.Point(259, 257);
            this.TXTUsuario.Multiline = true;
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(175, 35);
            this.TXTUsuario.TabIndex = 11;
            this.TXTUsuario.Tag = "TXTUsuario";
            // 
            // TXTContraseña
            // 
            this.TXTContraseña.Location = new System.Drawing.Point(259, 312);
            this.TXTContraseña.Multiline = true;
            this.TXTContraseña.Name = "TXTContraseña";
            this.TXTContraseña.Size = new System.Drawing.Size(175, 35);
            this.TXTContraseña.TabIndex = 12;
            this.TXTContraseña.Tag = "TXTContraseña";
            this.TXTContraseña.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TXTRol
            // 
            this.TXTRol.Location = new System.Drawing.Point(259, 370);
            this.TXTRol.Multiline = true;
            this.TXTRol.Name = "TXTRol";
            this.TXTRol.Size = new System.Drawing.Size(175, 35);
            this.TXTRol.TabIndex = 13;
            this.TXTRol.Tag = "TXTRol";
            // 
            // BTNMostrarContra
            // 
            this.BTNMostrarContra.Font = new System.Drawing.Font("Dana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMostrarContra.Location = new System.Drawing.Point(440, 312);
            this.BTNMostrarContra.Name = "BTNMostrarContra";
            this.BTNMostrarContra.Size = new System.Drawing.Size(34, 35);
            this.BTNMostrarContra.TabIndex = 14;
            this.BTNMostrarContra.Tag = "BTNMostrarContra";
            this.BTNMostrarContra.UseVisualStyleBackColor = true;
            this.BTNMostrarContra.Click += new System.EventHandler(this.BTNMostrarContra_Click);
            // 
            // DGUsuarioRol
            // 
            this.DGUsuarioRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarioRol.Location = new System.Drawing.Point(563, 92);
            this.DGUsuarioRol.Name = "DGUsuarioRol";
            this.DGUsuarioRol.Size = new System.Drawing.Size(521, 383);
            this.DGUsuarioRol.TabIndex = 15;
            this.DGUsuarioRol.Tag = "DGUsuarioRol";
            // 
            // LBLUsuarioRol
            // 
            this.LBLUsuarioRol.AutoSize = true;
            this.LBLUsuarioRol.Font = new System.Drawing.Font("Dana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuarioRol.Location = new System.Drawing.Point(569, 33);
            this.LBLUsuarioRol.Name = "LBLUsuarioRol";
            this.LBLUsuarioRol.Size = new System.Drawing.Size(145, 28);
            this.LBLUsuarioRol.TabIndex = 16;
            this.LBLUsuarioRol.Tag = "LBLUsuarioRol";
            this.LBLUsuarioRol.Text = "Usuario Rol";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Registro_lluvia_Ivan_Dana.Properties.Resources.Fondo_gestion_usuario;
            this.ClientSize = new System.Drawing.Size(1123, 580);
            this.Controls.Add(this.LBLUsuarioRol);
            this.Controls.Add(this.DGUsuarioRol);
            this.Controls.Add(this.BTNMostrarContra);
            this.Controls.Add(this.TXTRol);
            this.Controls.Add(this.TXTContraseña);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.TXTDni);
            this.Controls.Add(this.TXTApellido);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.BTNCargar);
            this.Controls.Add(this.LBLRol);
            this.Controls.Add(this.LBLContraseña);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.LBLDni);
            this.Controls.Add(this.LBLApellido);
            this.Controls.Add(this.LBLNombre);
            this.Controls.Add(this.LBLCargarUsuario);
            this.Name = "GestionUsuarios";
            this.Tag = "GestionUsuarios";
            this.Text = "Gestión_Usuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarioRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCargarUsuario;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Label LBLApellido;
        private System.Windows.Forms.Label LBLDni;
        private System.Windows.Forms.Label LBLUsuario;
        private System.Windows.Forms.Label LBLContraseña;
        private System.Windows.Forms.Label LBLRol;
        private System.Windows.Forms.Button BTNCargar;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.TextBox TXTApellido;
        private System.Windows.Forms.TextBox TXTDni;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTContraseña;
        private System.Windows.Forms.TextBox TXTRol;
        private System.Windows.Forms.Button BTNMostrarContra;
        private System.Windows.Forms.DataGridView DGUsuarioRol;
        private System.Windows.Forms.Label LBLUsuarioRol;
    }
}