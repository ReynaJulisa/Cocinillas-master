namespace Cocinillas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.ficheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRecetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirRecetarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardartoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarRecetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStripPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // menuStripPrincipal
            // 
            resources.ApplyResources(this.menuStripPrincipal, "menuStripPrincipal");
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheroToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripPrincipal.MdiWindowListItem = this.verToolStripMenuItem;
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            // 
            // ficheroToolStripMenuItem
            // 
            resources.ApplyResources(this.ficheroToolStripMenuItem, "ficheroToolStripMenuItem");
            this.ficheroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRecetarioToolStripMenuItem,
            this.abrirRecetarioToolStripMenuItem1,
            this.guardartoolStripMenuItem,
            this.cerrarRecetarioToolStripMenuItem});
            this.ficheroToolStripMenuItem.Name = "ficheroToolStripMenuItem";
            // 
            // nuevoRecetarioToolStripMenuItem
            // 
            resources.ApplyResources(this.nuevoRecetarioToolStripMenuItem, "nuevoRecetarioToolStripMenuItem");
            this.nuevoRecetarioToolStripMenuItem.Name = "nuevoRecetarioToolStripMenuItem";
            this.nuevoRecetarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoRecetarioToolStripMenuItem_Click);
            // 
            // abrirRecetarioToolStripMenuItem1
            // 
            resources.ApplyResources(this.abrirRecetarioToolStripMenuItem1, "abrirRecetarioToolStripMenuItem1");
            this.abrirRecetarioToolStripMenuItem1.Name = "abrirRecetarioToolStripMenuItem1";
            this.abrirRecetarioToolStripMenuItem1.Click += new System.EventHandler(this.abrirRecetarioToolStripMenuItem1_Click);
            // 
            // guardartoolStripMenuItem
            // 
            resources.ApplyResources(this.guardartoolStripMenuItem, "guardartoolStripMenuItem");
            this.guardartoolStripMenuItem.Name = "guardartoolStripMenuItem";
            this.guardartoolStripMenuItem.Click += new System.EventHandler(this.guardartoolStripMenuItem_Click);
            // 
            // cerrarRecetarioToolStripMenuItem
            // 
            resources.ApplyResources(this.cerrarRecetarioToolStripMenuItem, "cerrarRecetarioToolStripMenuItem");
            this.cerrarRecetarioToolStripMenuItem.Name = "cerrarRecetarioToolStripMenuItem";
            this.cerrarRecetarioToolStripMenuItem.Click += new System.EventHandler(this.cerrarRecetarioToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetarioToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            // 
            // recetarioToolStripMenuItem
            // 
            resources.ApplyResources(this.recetarioToolStripMenuItem, "recetarioToolStripMenuItem");
            this.recetarioToolStripMenuItem.Name = "recetarioToolStripMenuItem";
            this.recetarioToolStripMenuItem.Click += new System.EventHandler(this.recetarioToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            resources.ApplyResources(this.verToolStripMenuItem, "verToolStripMenuItem");
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientesToolStripMenuItem,
            this.organizarHorizontalToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            // 
            // ingredientesToolStripMenuItem
            // 
            resources.ApplyResources(this.ingredientesToolStripMenuItem, "ingredientesToolStripMenuItem");
            this.ingredientesToolStripMenuItem.CheckOnClick = true;
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ingredientesToolStripMenuItem_CheckedChanged);
            // 
            // organizarHorizontalToolStripMenuItem
            // 
            resources.ApplyResources(this.organizarHorizontalToolStripMenuItem, "organizarHorizontalToolStripMenuItem");
            this.organizarHorizontalToolStripMenuItem.Name = "organizarHorizontalToolStripMenuItem";
            this.organizarHorizontalToolStripMenuItem.Click += new System.EventHandler(this.organizarHorizontalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localizaciónToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            // 
            // localizaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.localizaciónToolStripMenuItem, "localizaciónToolStripMenuItem");
            this.localizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEspañol,
            this.toolStripMenuItemIngles});
            this.localizaciónToolStripMenuItem.Name = "localizaciónToolStripMenuItem";
            // 
            // toolStripMenuItemEspañol
            // 
            resources.ApplyResources(this.toolStripMenuItemEspañol, "toolStripMenuItemEspañol");
            this.toolStripMenuItemEspañol.Checked = true;
            this.toolStripMenuItemEspañol.CheckOnClick = true;
            this.toolStripMenuItemEspañol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemEspañol.Name = "toolStripMenuItemEspañol";
            this.toolStripMenuItemEspañol.Click += new System.EventHandler(this.ToolStripMenuItemEsp_Click);
            // 
            // toolStripMenuItemIngles
            // 
            resources.ApplyResources(this.toolStripMenuItemIngles, "toolStripMenuItemIngles");
            this.toolStripMenuItemIngles.CheckOnClick = true;
            this.toolStripMenuItemIngles.Name = "toolStripMenuItemIngles";
            this.toolStripMenuItemIngles.Click += new System.EventHandler(this.toolStripMenuItemIngles_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem1, "ayudaToolStripMenuItem1");
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.abrirToolStripButton,
            this.guardarToolStripButton});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // nuevoToolStripButton
            // 
            resources.ApplyResources(this.nuevoToolStripButton, "nuevoToolStripButton");
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Click += new System.EventHandler(this.nuevoToolStripButton_Click);
            // 
            // abrirToolStripButton
            // 
            resources.ApplyResources(this.abrirToolStripButton, "abrirToolStripButton");
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // guardarToolStripButton
            // 
            resources.ApplyResources(this.guardarToolStripButton, "guardarToolStripButton");
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Click += new System.EventHandler(this.guardarToolStripButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem nuevoRecetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirRecetarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarRecetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardartoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEspañol;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIngles;
        internal System.Windows.Forms.MenuStrip menuStripPrincipal;
    }
}

