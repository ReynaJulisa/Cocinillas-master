namespace Cocinillas
{
    partial class FormRecetario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecetario));
            this.btnNuevaReceta = new System.Windows.Forms.Button();
            this.listBoxRecetas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNuevaReceta
            // 
            resources.ApplyResources(this.btnNuevaReceta, "btnNuevaReceta");
            this.btnNuevaReceta.Name = "btnNuevaReceta";
            this.btnNuevaReceta.UseVisualStyleBackColor = true;
            this.btnNuevaReceta.Click += new System.EventHandler(this.btnNuevaReceta_Click);
            // 
            // listBoxRecetas
            // 
            resources.ApplyResources(this.listBoxRecetas, "listBoxRecetas");
            this.listBoxRecetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRecetas.FormattingEnabled = true;
            this.listBoxRecetas.Name = "listBoxRecetas";
            this.listBoxRecetas.SelectedIndexChanged += new System.EventHandler(this.listBoxRecetas_SelectedIndexChanged);
            // 
            // FormRecetario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxRecetas);
            this.Controls.Add(this.btnNuevaReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecetario";
            this.ShowIcon = false;
            this.Activated += new System.EventHandler(this.FormRecetario_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecetario_FormClosing);
            this.Load += new System.EventHandler(this.FormRecetario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaReceta;
        private System.Windows.Forms.ListBox listBoxRecetas;
    }
}