using System;
using System.Windows.Forms;

namespace Cocinillas
{
    public partial class FormRecetario : Form
    {
        public Recetario recetario;
        public FormNReceta hermano;
        public Receta receta;
        public int indReceta;

        public FormRecetario()
        {
            InitializeComponent();
        }

        private void FormRecetario_Load(object sender, EventArgs e)
        {
            cargarControles();
        }

        private void btnNuevaReceta_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Form1.ActiveForm;
            if (listBoxRecetas.SelectedItem == null)
            {
                indReceta = 0;
            }
            else 
            {
                indReceta = listBoxRecetas.SelectedIndex;
            }
            frm.nuevaReceta();
         
        }

        public void cargarControles() {
            listBoxRecetas.Items.Clear();
            
            this.BackColor = recetario.ColorR;
            System.Globalization.CultureInfo ingles = new System.Globalization.CultureInfo("EN-GB");
            if (System.Threading.Thread.CurrentThread.CurrentUICulture == ingles)
            {
                this.Text = "Principal Recipe Window: " + recetario.Nombre;
            }
            else  
            {
                this.Text = "Ventana Principal Recetario: " + recetario.Nombre;
            }
            listBoxRecetas.BackColor = recetario.ColorR;
            for (int i = 0; i < recetario.NumRecetas; i++)
            {
                listBoxRecetas.Items.Add(recetario[i]);
            }
            if (recetario.NumRecetas != 0)
            {
                receta = recetario[0];
            }
        }

        private void FormRecetario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hermano != null)
            {
                if (MessageBox.Show(this, "Se cerraran todas la ventas activas, ¿Quiere continuar?", "Información",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    hermano.Close();
                }
                else {
                    e.Cancel = true;
                }
            }
        }

        private void listBoxRecetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            receta = (Receta)listBoxRecetas.SelectedItem;
        }

        public void FormRecetario_Activated(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Form1.ActiveForm;
            frm.actualizaLabel();
        }

      
    }
}
