using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cocinillas
{
    public partial class FormNReceta : Form
    {
        public Recetario recetario;
        public Receta receta;
        public Ingrediente ing;
        public IngredienteReceta ingReceta;
        public FormRecetario hermano;
        private Font fuente;
        public int indReceta;
        private bool Visualizar = false;

        public FormNReceta()
        {
            InitializeComponent();
        }

        //Boton Crear
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (buttonCrear.Text == "Editar")
            {
                editarReceta();

            }
            else
            {
                creaReceta();
            }

        }

        //Drag Drop Enter
        private void listBoxIngredientes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Ingrediente)) && Visualizar == false)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        
        //Drag Drop
        private void listBoxIngredientes_DragDrop(object sender, DragEventArgs e)
        {
            int cantidad = 0;
            FormCantidad frmCant = new FormCantidad();
            ing = (Ingrediente)e.Data.GetData(typeof(Ingrediente));

            if (frmCant.ShowDialog() == DialogResult.OK)
            {

                cantidad = frmCant.cantidad;
                ingReceta = new IngredienteReceta(ing, cantidad);

                listBoxIngredientes.Items.Add(ingReceta);

            }
        }

        //Cambiar ingrediente seleccionado
        private void listBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingReceta = (IngredienteReceta)listBoxIngredientes.SelectedItem;

            int calorias = Calorias.calculaCalorias(ingReceta.Ingrediente.Calorias, ingReceta.Cantidad);
            labelCalorias.Visible = true;
            labelCalorias.Text = calorias.ToString() + " cal";
        }


        //Al cerrar
        private void FormNReceta_FormClosed(object sender, FormClosedEventArgs e)
        {
            hermano.hermano = null;
        }

        //Al cargar
        private void FormNReceta_Load(object sender, EventArgs e)
        {
            fuente = labelNombre.Font;
            if (receta != null)
            {
                cargaReceta();
            }

        }


        //Boton mas +
        private void buttonMore_Click(object sender, EventArgs e)
        {
            richTextBoxPasos.Clear();
            richTextBoxPasos.Enabled = true;
            buttonAceptar.Enabled = true;
            buttonCancelar.Enabled = true;
            buttonLeft.Enabled = false;
            buttonMore.Enabled = false;
            buttonRight.Enabled = false;
        }

        //Boton Aceptar
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            receta.AddPaso(richTextBoxPasos.Text);
            richTextBoxPasos.Enabled = false;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonLeft.Enabled = true;
            buttonMore.Enabled = true;
            buttonRight.Enabled = true;
            progressBar1.Maximum = progressBar1.Maximum + 1;
            progressBar1.Value = progressBar1.Maximum;
            labelProgreso.Text = ("(" + progressBar1.Maximum + "/" + progressBar1.Maximum + ")");
        }

        //Boton derecha
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                string paso = receta[progressBar1.Value - 1];
                richTextBoxPasos.Text = paso;
                labelProgreso.Text = ("(" + progressBar1.Value + "/" + progressBar1.Maximum + ")");
            }
        }

        //Boton izquierda
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 1)
            {
                progressBar1.Value -= 1;
                string paso = receta[progressBar1.Value - 1];
                richTextBoxPasos.Text = paso;
                labelProgreso.Text = ("(" + progressBar1.Value + "/" + progressBar1.Maximum + ")");
            }
        }

        //Boton nueva
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevaReceta();
        }

        //Boton borrar
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Se borrará la receta, ¿Quiere continuar?", "Información",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                hermano.recetario.BorraReceta(indReceta);
                hermano.cargarControles();
                receta = hermano.recetario[0];
                cargaReceta();
            }
        }

        //Boton Editar
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            labelNombre.Text = "Nombre";
            labelNombre.Font = fuente;
            textBoxNombre.Visible = true;
            textBoxNombre.Text = receta.Nombre;
            buttonCrear.Text = "Editar";
            buttonCrear.Enabled = true;
            Visualizar = false;

        }

        //Nueva Receta
        private void nuevaReceta()
        {
            receta = null;
            labelCalorias.Visible = false;
            labelNombre.Font = fuente;
            labelNombre.ResetText();
            labelNombre.Text = "Nombre";
            labelProgreso.Text = "(0/0)";
            textBoxNombre.Visible = true;
            textBoxNombre.Text = "";
            listBoxIngredientes.Items.Clear();
            buttonCrear.Enabled = true;
            progressBar1.Maximum = 0;
            progressBar1.Value = 0;

            buttonCancelar.Enabled = false;
            buttonLeft.Enabled = false;
            buttonMore.Enabled = false;
            richTextBoxPasos.Enabled = false;
            richTextBoxPasos.Text = "";
            buttonRight.Enabled = false;
            buttonAceptar.Enabled = false;
            Visualizar = false;
        }

        //Editar Receta
        private void editarReceta()
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Tiene que tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBoxIngredientes.Items.Count == 0)
            {
                MessageBox.Show("Hacen falta ingredientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                receta.Nombre = textBoxNombre.Text;
                IngredienteReceta[] vecIng = receta.Ingredientes;
                for (int i = 0; i < listBoxIngredientes.Items.Count; i++)
                {
                    listBoxIngredientes.SetSelected(i, true);
                    ingReceta = (IngredienteReceta)listBoxIngredientes.SelectedItem;
                    vecIng[i] = ingReceta;
                }
                receta.Ingredientes = vecIng;
                listBoxIngredientes.Items.Clear();
                buttonCrear.Text = "Crear";
                hermano.recetario.ModificaReceta(indReceta, receta);
                hermano.cargarControles();
                cargaReceta();
            }


        }

        //Cargar Receta
        private void cargaReceta()
        {

            buttonCrear.Enabled = false;
            textBoxNombre.Visible = false;
            labelNombre.Text = receta.Nombre;
            float fontsize = 14;
            labelNombre.Font = new Font(labelNombre.Font.Name, fontsize, FontStyle.Bold);

            IngredienteReceta[] vecIng = receta.Ingredientes;

            listBoxIngredientes.Items.AddRange(vecIng);
            if (receta.NumPasos != 0)
            {
                progressBar1.Maximum = receta.NumPasos;
                labelProgreso.Text = "(1/" + receta.NumPasos + ")";
                string paso = receta[0];
                richTextBoxPasos.Text = paso;
                progressBar1.Value = 1;

                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;

            }
            Visualizar = true;
        }

        //Crear Receta
        private void creaReceta()
        {

            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Tiene que tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listBoxIngredientes.Items.Count == 0)
            {
                MessageBox.Show("Hacen falta ingredientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                receta = new Receta();
                receta.Nombre = textBoxNombre.Text;
                IngredienteReceta[] vecIng = new IngredienteReceta[listBoxIngredientes.Items.Count];

                for (int i = 0; i < listBoxIngredientes.Items.Count; i++)
                {
                    listBoxIngredientes.SetSelected(i, true);
                    ingReceta = (IngredienteReceta)listBoxIngredientes.SelectedItem;
                    vecIng[i] = ingReceta;
                }
                receta.Ingredientes = vecIng;

                recetario.AddReceta(receta);
                hermano.recetario = recetario;
                hermano.cargarControles();

                buttonCrear.Enabled = false;
                textBoxNombre.Visible = false;
                labelNombre.Text = receta.Nombre;
                float fontsize = 14;
                labelNombre.Font = new Font(labelNombre.Font.Name, fontsize, FontStyle.Bold);

                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
                buttonMore.Enabled = true;
                Visualizar = true;
            }

        }
    }
}
