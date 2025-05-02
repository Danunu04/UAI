namespace Proyecto_DAS
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarEmpeladotoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarProductoToolStripMenuItem,
            this.administraciònToolStripMenuItem,
            this.seciónToolStripMenuItem,
            this.rToolStripMenuItem,
            this.eToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(478, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registarProductoToolStripMenuItem
            // 
            this.registarProductoToolStripMenuItem.Enabled = false;
            this.registarProductoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registarProductoToolStripMenuItem.Name = "registarProductoToolStripMenuItem";
            this.registarProductoToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.registarProductoToolStripMenuItem.Tag = "TagProductos";
            this.registarProductoToolStripMenuItem.Text = "Productos";
            this.registarProductoToolStripMenuItem.Click += new System.EventHandler(this.registarProductoToolStripMenuItem_Click);
            // 
            // administraciònToolStripMenuItem
            // 
            this.administraciònToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadoToolStripMenuItem,
            this.verMovimientoToolStripMenuItem,
            this.GestionarEmpeladotoolStripMenuItem2});
            this.administraciònToolStripMenuItem.Enabled = false;
            this.administraciònToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administraciònToolStripMenuItem.Name = "administraciònToolStripMenuItem";
            this.administraciònToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.administraciònToolStripMenuItem.Tag = "TagAdministracion";
            this.administraciònToolStripMenuItem.Text = "Administración";
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.registrarEmpleadoToolStripMenuItem.Tag = "TagRegistrarEmpleado";
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // verMovimientoToolStripMenuItem
            // 
            this.verMovimientoToolStripMenuItem.Name = "verMovimientoToolStripMenuItem";
            this.verMovimientoToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.verMovimientoToolStripMenuItem.Tag = "TagVerMovimientos";
            this.verMovimientoToolStripMenuItem.Text = "Ver movimientos";
            // 
            // GestionarEmpeladotoolStripMenuItem2
            // 
            this.GestionarEmpeladotoolStripMenuItem2.Name = "GestionarEmpeladotoolStripMenuItem2";
            this.GestionarEmpeladotoolStripMenuItem2.Size = new System.Drawing.Size(196, 24);
            this.GestionarEmpeladotoolStripMenuItem2.Tag = "TagGestiónEmpleados";
            this.GestionarEmpeladotoolStripMenuItem2.Text = "Gestión Empleados";
            this.GestionarEmpeladotoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // seciónToolStripMenuItem
            // 
            this.seciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.seciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seciónToolStripMenuItem.Name = "seciónToolStripMenuItem";
            this.seciónToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.seciónToolStripMenuItem.Tag = "TagSesion";
            this.seciónToolStripMenuItem.Text = "Sesión";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.logInToolStripMenuItem.Text = "Login";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Enabled = false;
            this.rToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.rToolStripMenuItem.Tag = "TagReportes";
            this.rToolStripMenuItem.Text = "Reportes";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.eToolStripMenuItem.Tag = "TagSalir";
            this.eToolStripMenuItem.Text = "Salir";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_DAS.Properties.Resources.robotized_industrial_production_cartoon_concept_robotic_hands_working_modern_factory_plant_conveyor_1441_3117_3285035878;
            this.ClientSize = new System.Drawing.Size(478, 274);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarEmpeladotoolStripMenuItem2;
    }
}

