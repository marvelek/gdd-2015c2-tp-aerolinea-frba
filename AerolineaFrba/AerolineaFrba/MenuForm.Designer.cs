namespace AerolineaFrba
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaAereaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeronavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeLlegadaADestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajesYEncomiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelacionDevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIllasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canjeDeMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.pasajesYEncomiendasToolStripMenuItem,
            this.mIllasToolStripMenuItem,
            this.listadoEstadisticoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.rolesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutaAereaToolStripMenuItem,
            this.aeronavesToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aBMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "&ABM";
            // 
            // rutaAereaToolStripMenuItem
            // 
            this.rutaAereaToolStripMenuItem.Name = "rutaAereaToolStripMenuItem";
            this.rutaAereaToolStripMenuItem.ShowShortcutKeys = false;
            this.rutaAereaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rutaAereaToolStripMenuItem.Text = "&Rutas aereas";
            this.rutaAereaToolStripMenuItem.Click += new System.EventHandler(this.rutaAereaToolStripMenuItem_Click);
            // 
            // aeronavesToolStripMenuItem
            // 
            this.aeronavesToolStripMenuItem.Name = "aeronavesToolStripMenuItem";
            this.aeronavesToolStripMenuItem.ShowShortcutKeys = false;
            this.aeronavesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aeronavesToolStripMenuItem.Text = "A&eronaves";
            this.aeronavesToolStripMenuItem.Click += new System.EventHandler(this.aeronavesToolStripMenuItem_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarViajeToolStripMenuItem,
            this.registroDeLlegadaADestinoToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "&Viajes";
            // 
            // generarViajeToolStripMenuItem
            // 
            this.generarViajeToolStripMenuItem.Name = "generarViajeToolStripMenuItem";
            this.generarViajeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.generarViajeToolStripMenuItem.Text = "&Generar viaje";
            this.generarViajeToolStripMenuItem.Click += new System.EventHandler(this.generarViajeToolStripMenuItem_Click);
            // 
            // registroDeLlegadaADestinoToolStripMenuItem
            // 
            this.registroDeLlegadaADestinoToolStripMenuItem.Name = "registroDeLlegadaADestinoToolStripMenuItem";
            this.registroDeLlegadaADestinoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.registroDeLlegadaADestinoToolStripMenuItem.Text = "&Registro de llegada a destino";
            this.registroDeLlegadaADestinoToolStripMenuItem.Click += new System.EventHandler(this.registroDeLlegadaADestinoToolStripMenuItem_Click);
            // 
            // pasajesYEncomiendasToolStripMenuItem
            // 
            this.pasajesYEncomiendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.cancelacionDevolucionToolStripMenuItem});
            this.pasajesYEncomiendasToolStripMenuItem.Name = "pasajesYEncomiendasToolStripMenuItem";
            this.pasajesYEncomiendasToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.pasajesYEncomiendasToolStripMenuItem.Text = "&Pasajes y encomiendas";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.compraToolStripMenuItem.Text = "&Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // cancelacionDevolucionToolStripMenuItem
            // 
            this.cancelacionDevolucionToolStripMenuItem.Name = "cancelacionDevolucionToolStripMenuItem";
            this.cancelacionDevolucionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cancelacionDevolucionToolStripMenuItem.Text = "Cancelacion/&Devolucion";
            this.cancelacionDevolucionToolStripMenuItem.Click += new System.EventHandler(this.cancelacionDevolucionToolStripMenuItem_Click);
            // 
            // mIllasToolStripMenuItem
            // 
            this.mIllasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeMillasToolStripMenuItem,
            this.canjeDeMillasToolStripMenuItem});
            this.mIllasToolStripMenuItem.Name = "mIllasToolStripMenuItem";
            this.mIllasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mIllasToolStripMenuItem.Text = "&Millas";
            // 
            // consultaDeMillasToolStripMenuItem
            // 
            this.consultaDeMillasToolStripMenuItem.Name = "consultaDeMillasToolStripMenuItem";
            this.consultaDeMillasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultaDeMillasToolStripMenuItem.Text = "&Consulta de millas";
            this.consultaDeMillasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeMillasToolStripMenuItem_Click);
            // 
            // canjeDeMillasToolStripMenuItem
            // 
            this.canjeDeMillasToolStripMenuItem.Name = "canjeDeMillasToolStripMenuItem";
            this.canjeDeMillasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.canjeDeMillasToolStripMenuItem.Text = "C&anje de millas";
            this.canjeDeMillasToolStripMenuItem.Click += new System.EventHandler(this.canjeDeMillasToolStripMenuItem_Click);
            // 
            // listadoEstadisticoToolStripMenuItem
            // 
            this.listadoEstadisticoToolStripMenuItem.Name = "listadoEstadisticoToolStripMenuItem";
            this.listadoEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadisticoToolStripMenuItem.Text = "&Listado estadistico";
            this.listadoEstadisticoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstadisticoToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 533);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Menu Aerolineas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaAereaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aeronavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeLlegadaADestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajesYEncomiendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelacionDevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIllasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeMillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canjeDeMillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadisticoToolStripMenuItem;
    }
}

