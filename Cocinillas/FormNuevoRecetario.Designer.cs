namespace Cocinillas
{
    partial class FormNuevoRecetario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoRecetario));
            this.labelNombreRecetario = new System.Windows.Forms.Label();
            this.labelFechaRecetario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTipoRecetario = new System.Windows.Forms.Label();
            this.tbNombreRecetario = new System.Windows.Forms.TextBox();
            this.dTFechaRecetario = new System.Windows.Forms.DateTimePicker();
            this.rTBDescripRecetario = new System.Windows.Forms.RichTextBox();
            this.cLBTipoRecetario = new System.Windows.Forms.CheckedListBox();
            this.bColorRecetario = new System.Windows.Forms.Button();
            this.bAceptarRecetario = new System.Windows.Forms.Button();
            this.bCancelarRecetario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreRecetario
            // 
            resources.ApplyResources(this.labelNombreRecetario, "labelNombreRecetario");
            this.labelNombreRecetario.Name = "labelNombreRecetario";
            // 
            // labelFechaRecetario
            // 
            resources.ApplyResources(this.labelFechaRecetario, "labelFechaRecetario");
            this.labelFechaRecetario.Name = "labelFechaRecetario";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelTipoRecetario
            // 
            resources.ApplyResources(this.labelTipoRecetario, "labelTipoRecetario");
            this.labelTipoRecetario.Name = "labelTipoRecetario";
            // 
            // tbNombreRecetario
            // 
            resources.ApplyResources(this.tbNombreRecetario, "tbNombreRecetario");
            this.tbNombreRecetario.Name = "tbNombreRecetario";
            // 
            // dTFechaRecetario
            // 
            resources.ApplyResources(this.dTFechaRecetario, "dTFechaRecetario");
            this.dTFechaRecetario.Name = "dTFechaRecetario";
            // 
            // rTBDescripRecetario
            // 
            resources.ApplyResources(this.rTBDescripRecetario, "rTBDescripRecetario");
            this.rTBDescripRecetario.Name = "rTBDescripRecetario";
            // 
            // cLBTipoRecetario
            // 
            resources.ApplyResources(this.cLBTipoRecetario, "cLBTipoRecetario");
            this.cLBTipoRecetario.FormattingEnabled = true;
            this.cLBTipoRecetario.Items.AddRange(new object[] {
            resources.GetString("cLBTipoRecetario.Items"),
            resources.GetString("cLBTipoRecetario.Items1"),
            resources.GetString("cLBTipoRecetario.Items2"),
            resources.GetString("cLBTipoRecetario.Items3"),
            resources.GetString("cLBTipoRecetario.Items4"),
            resources.GetString("cLBTipoRecetario.Items5"),
            resources.GetString("cLBTipoRecetario.Items6")});
            this.cLBTipoRecetario.Name = "cLBTipoRecetario";
            // 
            // bColorRecetario
            // 
            resources.ApplyResources(this.bColorRecetario, "bColorRecetario");
            this.bColorRecetario.Name = "bColorRecetario";
            this.bColorRecetario.UseVisualStyleBackColor = true;
            this.bColorRecetario.Click += new System.EventHandler(this.bColorRecetario_Click);
            // 
            // bAceptarRecetario
            // 
            resources.ApplyResources(this.bAceptarRecetario, "bAceptarRecetario");
            this.bAceptarRecetario.Name = "bAceptarRecetario";
            this.bAceptarRecetario.UseVisualStyleBackColor = true;
            this.bAceptarRecetario.Click += new System.EventHandler(this.bAceptarRecetario_Click);
            // 
            // bCancelarRecetario
            // 
            resources.ApplyResources(this.bCancelarRecetario, "bCancelarRecetario");
            this.bCancelarRecetario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelarRecetario.Name = "bCancelarRecetario";
            this.bCancelarRecetario.UseVisualStyleBackColor = true;
            // 
            // FormNuevoRecetario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bCancelarRecetario);
            this.Controls.Add(this.bAceptarRecetario);
            this.Controls.Add(this.bColorRecetario);
            this.Controls.Add(this.cLBTipoRecetario);
            this.Controls.Add(this.rTBDescripRecetario);
            this.Controls.Add(this.dTFechaRecetario);
            this.Controls.Add(this.tbNombreRecetario);
            this.Controls.Add(this.labelTipoRecetario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFechaRecetario);
            this.Controls.Add(this.labelNombreRecetario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoRecetario";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormNuevoRecetario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreRecetario;
        private System.Windows.Forms.Label labelFechaRecetario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTipoRecetario;
        private System.Windows.Forms.TextBox tbNombreRecetario;
        private System.Windows.Forms.DateTimePicker dTFechaRecetario;
        private System.Windows.Forms.RichTextBox rTBDescripRecetario;
        private System.Windows.Forms.CheckedListBox cLBTipoRecetario;
        private System.Windows.Forms.Button bColorRecetario;
        private System.Windows.Forms.Button bAceptarRecetario;
        private System.Windows.Forms.Button bCancelarRecetario;
    }
}