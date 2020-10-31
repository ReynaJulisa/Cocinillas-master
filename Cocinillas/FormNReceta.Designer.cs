namespace Cocinillas
{
    partial class FormNReceta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNReceta));
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.listBoxIngredientes = new System.Windows.Forms.ListBox();
            this.richTextBoxPasos = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgreso = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.labelCalorias = new System.Windows.Forms.Label();
            this.menuStripReceta = new System.Windows.Forms.MenuStrip();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            resources.ApplyResources(this.labelNombre, "labelNombre");
            this.labelNombre.Name = "labelNombre";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxNombre
            // 
            resources.ApplyResources(this.textBoxNombre, "textBoxNombre");
            this.textBoxNombre.Name = "textBoxNombre";
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.AllowDrop = true;
            this.listBoxIngredientes.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxIngredientes, "listBoxIngredientes");
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredientes_SelectedIndexChanged);
            this.listBoxIngredientes.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxIngredientes_DragDrop);
            this.listBoxIngredientes.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxIngredientes_DragEnter);
            // 
            // richTextBoxPasos
            // 
            resources.ApplyResources(this.richTextBoxPasos, "richTextBoxPasos");
            this.richTextBoxPasos.Name = "richTextBoxPasos";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Step = 1;
            // 
            // labelProgreso
            // 
            resources.ApplyResources(this.labelProgreso, "labelProgreso");
            this.labelProgreso.Name = "labelProgreso";
            // 
            // buttonLeft
            // 
            resources.ApplyResources(this.buttonLeft, "buttonLeft");
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            resources.ApplyResources(this.buttonRight, "buttonRight");
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonMore
            // 
            resources.ApplyResources(this.buttonMore, "buttonMore");
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // buttonAceptar
            // 
            resources.ApplyResources(this.buttonAceptar, "buttonAceptar");
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            resources.ApplyResources(this.buttonCancelar, "buttonCancelar");
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            resources.ApplyResources(this.buttonCrear, "buttonCrear");
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // labelCalorias
            // 
            resources.ApplyResources(this.labelCalorias, "labelCalorias");
            this.labelCalorias.Name = "labelCalorias";
            // 
            // menuStripReceta
            // 
            this.menuStripReceta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetaToolStripMenuItem});
            resources.ApplyResources(this.menuStripReceta, "menuStripReceta");
            this.menuStripReceta.Name = "menuStripReceta";
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.recetaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.recetaToolStripMenuItem.MergeIndex = 2;
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            resources.ApplyResources(this.recetaToolStripMenuItem, "recetaToolStripMenuItem");
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            resources.ApplyResources(this.nuevaToolStripMenuItem, "nuevaToolStripMenuItem");
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            resources.ApplyResources(this.borrarToolStripMenuItem, "borrarToolStripMenuItem");
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // FormNReceta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCalorias);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelProgreso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBoxPasos);
            this.Controls.Add(this.listBoxIngredientes);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.menuStripReceta);
            this.MainMenuStrip = this.menuStripReceta;
            this.Name = "FormNReceta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNReceta_FormClosed);
            this.Load += new System.EventHandler(this.FormNReceta_Load);
            this.menuStripReceta.ResumeLayout(false);
            this.menuStripReceta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ListBox listBoxIngredientes;
        private System.Windows.Forms.RichTextBox richTextBoxPasos;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgreso;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelCalorias;
        private System.Windows.Forms.MenuStrip menuStripReceta;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}