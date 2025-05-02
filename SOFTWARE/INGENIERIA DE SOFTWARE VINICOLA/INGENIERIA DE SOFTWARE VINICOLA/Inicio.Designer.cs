namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumaestros = new FontAwesome.Sharp.IconMenuItem();
            this.menuadmin = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuayuda = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despacharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menumaestros,
            this.menuadmin,
            this.MenuVentas,
            this.menureportes,
            this.menuayuda});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1296, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuusuarios
            // 
            this.menuusuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem});
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 50;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(64, 69);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menumaestros
            // 
            this.menumaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menumaestros.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menumaestros.IconColor = System.Drawing.Color.Black;
            this.menumaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumaestros.IconSize = 50;
            this.menumaestros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumaestros.Name = "menumaestros";
            this.menumaestros.Size = new System.Drawing.Size(67, 69);
            this.menumaestros.Text = "Maestros";
            this.menumaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuadmin
            // 
            this.menuadmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.bloquearUsuarioToolStripMenuItem,
            this.desbloquearUsuarioToolStripMenuItem});
            this.menuadmin.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuadmin.IconColor = System.Drawing.Color.Black;
            this.menuadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuadmin.IconSize = 50;
            this.menuadmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuadmin.Name = "menuadmin";
            this.menuadmin.Size = new System.Drawing.Size(62, 69);
            this.menuadmin.Text = "Admin";
            this.menuadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuVentas
            // 
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carritoToolStripMenuItem,
            this.facturarToolStripMenuItem,
            this.despacharToolStripMenuItem});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(62, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureportes
            // 
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(65, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuayuda
            // 
            this.menuayuda.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuayuda.IconColor = System.Drawing.Color.Black;
            this.menuayuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuayuda.IconSize = 50;
            this.menuayuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuayuda.Name = "menuayuda";
            this.menuayuda.Size = new System.Drawing.Size(62, 69);
            this.menuayuda.Text = "Ayuda";
            this.menuayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Red;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1296, 72);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Vinicola";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 544);
            this.panel1.TabIndex = 3;
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carritoToolStripMenuItem.Text = "Carrito";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            // 
            // despacharToolStripMenuItem
            // 
            this.despacharToolStripMenuItem.Name = "despacharToolStripMenuItem";
            this.despacharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.despacharToolStripMenuItem.Text = "Despachar";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de usuarios";
            // 
            // bloquearUsuarioToolStripMenuItem
            // 
            this.bloquearUsuarioToolStripMenuItem.Name = "bloquearUsuarioToolStripMenuItem";
            this.bloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bloquearUsuarioToolStripMenuItem.Text = "Bloquear Usuario";
            // 
            // desbloquearUsuarioToolStripMenuItem
            // 
            this.desbloquearUsuarioToolStripMenuItem.Name = "desbloquearUsuarioToolStripMenuItem";
            this.desbloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.desbloquearUsuarioToolStripMenuItem.Text = "Desbloquear Usuario";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesión";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar idioma";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuayuda;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumaestros;
        private FontAwesome.Sharp.IconMenuItem menuadmin;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despacharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}

