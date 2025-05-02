namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class frmInicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaestros = new FontAwesome.Sharp.IconMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.bitacoraDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMaestros,
            this.menuAdmin,
            this.menuVentas,
            this.menuReportes,
            this.menuAyuda});
            this.menu.Location = new System.Drawing.Point(0, 63);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1252, 73);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.menuUsuarios.Text = "Usuario";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            this.cambiarClaveToolStripMenuItem.Visible = false;
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Visible = false;
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click_1);
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar idioma";
            this.cambiarIdiomaToolStripMenuItem.Visible = false;
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuMaestros
            // 
            this.menuMaestros.AutoSize = false;
            this.menuMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuMaestros.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.menuMaestros.IconColor = System.Drawing.Color.Black;
            this.menuMaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMaestros.IconSize = 50;
            this.menuMaestros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMaestros.Name = "menuMaestros";
            this.menuMaestros.Size = new System.Drawing.Size(122, 69);
            this.menuMaestros.Text = "Maestros";
            this.menuMaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuMaestros.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Visible = false;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Visible = false;
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.AutoSize = false;
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuariosToolStripMenuItem,
            this.gestionPerfilesToolStripMenuItem,
            this.bitacoraDeEventosToolStripMenuItem});
            this.menuAdmin.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuAdmin.IconColor = System.Drawing.Color.Black;
            this.menuAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAdmin.IconSize = 50;
            this.menuAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(122, 69);
            this.menuAdmin.Text = "Admin";
            this.menuAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Visible = false;
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // gestionPerfilesToolStripMenuItem
            // 
            this.gestionPerfilesToolStripMenuItem.Name = "gestionPerfilesToolStripMenuItem";
            this.gestionPerfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionPerfilesToolStripMenuItem.Text = "Gestion Perfiles";
            this.gestionPerfilesToolStripMenuItem.Visible = false;
            this.gestionPerfilesToolStripMenuItem.Click += new System.EventHandler(this.gestionPerfilesToolStripMenuItem_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carritoToolStripMenuItem});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(122, 69);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Visible = false;
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.carritoToolStripMenuItem_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem});
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(122, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.reporte1ToolStripMenuItem.Text = "Reporte 1";
            this.reporte1ToolStripMenuItem.Visible = false;
            // 
            // menuAyuda
            // 
            this.menuAyuda.AutoSize = false;
            this.menuAyuda.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAyuda.IconColor = System.Drawing.Color.Black;
            this.menuAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAyuda.IconSize = 50;
            this.menuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(122, 69);
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Red;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1252, 63);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip1";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Vinicola";
            // 
            // bitacoraDeEventosToolStripMenuItem
            // 
            this.bitacoraDeEventosToolStripMenuItem.Name = "bitacoraDeEventosToolStripMenuItem";
            this.bitacoraDeEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitacoraDeEventosToolStripMenuItem.Text = "Bitacora de eventos";
            this.bitacoraDeEventosToolStripMenuItem.Visible = false;
            this.bitacoraDeEventosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeEventosToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuAyuda;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMaestros;
        private FontAwesome.Sharp.IconMenuItem menuAdmin;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionPerfilesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem bitacoraDeEventosToolStripMenuItem;
    }
}