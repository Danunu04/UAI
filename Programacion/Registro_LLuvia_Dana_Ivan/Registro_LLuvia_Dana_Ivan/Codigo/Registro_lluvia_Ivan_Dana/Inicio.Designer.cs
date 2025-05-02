namespace Registro_lluvia_Ivan_Dana
{
    partial class Inicio
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
            this.Menustrip = new System.Windows.Forms.MenuStrip();
            this.usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.login = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarclave = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.admin = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.verReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.idioma = new System.Windows.Forms.ToolStripMenuItem();
            this.Menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menustrip
            // 
            this.Menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario,
            this.admin,
            this.reportes,
            this.idioma});
            this.Menustrip.Location = new System.Drawing.Point(0, 0);
            this.Menustrip.Name = "Menustrip";
            this.Menustrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menustrip.Size = new System.Drawing.Size(1370, 24);
            this.Menustrip.TabIndex = 0;
            this.Menustrip.Tag = "Menustrip";
            this.Menustrip.Text = "MenuStrip";
            this.Menustrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuario
            // 
            this.usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login,
            this.cambiarclave,
            this.logout,
            this.Salir});
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(59, 20);
            this.usuario.Tag = "usuario";
            this.usuario.Text = "Usuario";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // login
            // 
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(180, 22);
            this.login.Tag = "Login";
            this.login.Text = "Iniciar Sesion";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cambiarclave
            // 
            this.cambiarclave.Name = "cambiarclave";
            this.cambiarclave.Size = new System.Drawing.Size(180, 22);
            this.cambiarclave.Tag = "cambiarclave";
            this.cambiarclave.Text = "Cambiar Clave";
            this.cambiarclave.Click += new System.EventHandler(this.cambiarclave_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(180, 22);
            this.logout.Tag = "logout";
            this.logout.Text = "Cerrar sesion";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(180, 22);
            this.Salir.Tag = "Salir";
            this.Salir.Text = "Salir";
            // 
            // admin
            // 
            this.admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionUsuarios,
            this.GestionPerfiles,
            this.Bitacora});
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(95, 20);
            this.admin.Tag = "admin";
            this.admin.Text = "Administrador";
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Size = new System.Drawing.Size(177, 22);
            this.GestionUsuarios.Tag = "GestionUsuarios";
            this.GestionUsuarios.Text = "Gestionar Usuarios";
            this.GestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // GestionPerfiles
            // 
            this.GestionPerfiles.Name = "GestionPerfiles";
            this.GestionPerfiles.Size = new System.Drawing.Size(177, 22);
            this.GestionPerfiles.Tag = "GestionPerfiles";
            this.GestionPerfiles.Text = "Gestionar Perfiles";
            this.GestionPerfiles.Click += new System.EventHandler(this.GestionPerfiles_Click);
            // 
            // Bitacora
            // 
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.Size = new System.Drawing.Size(177, 22);
            this.Bitacora.Tag = "Bitacora";
            this.Bitacora.Text = "Bitacora de eventos";
            this.Bitacora.Click += new System.EventHandler(this.Bitacora_Click);
            // 
            // reportes
            // 
            this.reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReportes,
            this.cargarReportes});
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(65, 20);
            this.reportes.Tag = "reportes";
            this.reportes.Text = "Reportes";
            // 
            // verReportes
            // 
            this.verReportes.Name = "verReportes";
            this.verReportes.Size = new System.Drawing.Size(158, 22);
            this.verReportes.Tag = "verReportes";
            this.verReportes.Text = "Ver Reportes";
            this.verReportes.Click += new System.EventHandler(this.verReportes_Click);
            // 
            // cargarReportes
            // 
            this.cargarReportes.Name = "cargarReportes";
            this.cargarReportes.Size = new System.Drawing.Size(158, 22);
            this.cargarReportes.Tag = "cargarReportes";
            this.cargarReportes.Text = "Cargar Reportes";
            this.cargarReportes.Click += new System.EventHandler(this.cargarReportes_Click);
            // 
            // idioma
            // 
            this.idioma.Name = "idioma";
            this.idioma.Size = new System.Drawing.Size(104, 20);
            this.idioma.Tag = "idioma";
            this.idioma.Text = "Cambiar Idioma";
            this.idioma.Click += new System.EventHandler(this.idioma_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Registro_lluvia_Ivan_Dana.Properties.Resources.WhatsApp_Image_2024_09_15_at_15_41_47_9b212626;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 787);
            this.Controls.Add(this.Menustrip);
            this.MainMenuStrip = this.Menustrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.Tag = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menustrip.ResumeLayout(false);
            this.Menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menustrip;
        private System.Windows.Forms.ToolStripMenuItem usuario;
        private System.Windows.Forms.ToolStripMenuItem admin;
        private System.Windows.Forms.ToolStripMenuItem reportes;
        private System.Windows.Forms.ToolStripMenuItem idioma;
        private System.Windows.Forms.ToolStripMenuItem login;
        private System.Windows.Forms.ToolStripMenuItem cambiarclave;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem GestionPerfiles;
        private System.Windows.Forms.ToolStripMenuItem Bitacora;
        private System.Windows.Forms.ToolStripMenuItem verReportes;
        private System.Windows.Forms.ToolStripMenuItem cargarReportes;
    }
}

