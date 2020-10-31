using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace Cocinillas
{
    public partial class Form1 : Form
    {
        private Recetario recetario;
        private FormIngredientes frmIng;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoRecetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoRecetario();
        }

        private void cerrarRecetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            nuevoRecetario();
        }

      

        private void ingredientesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (frmIng == null) {
                frmIng = new FormIngredientes();
            }
            if (ingredientesToolStripMenuItem.Checked)
            {
                frmIng.Show();
            }
            else 
            {
                frmIng.Hide();
            }
        }


        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            guardarRecetario();
        }

        private void guardartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarRecetario();
        }

        private void abrirRecetarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirRecetario();

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            abrirRecetario();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://..\\Ayuda\\Ayuda.chm");
        }



        private void recetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editarRecetario();
        }

        private void organizarHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Cambiar al ingles
        private void ToolStripMenuItemEsp_Click(object sender, EventArgs e)
        {
            toolStripMenuItemIngles.Checked = false;
            toolStripMenuItemIngles.Text = "Inglés";
            toolStripMenuItemEspañol.Checked = true;
            toolStripMenuItemEspañol.Text = "Español";
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ES-ES");
            if (frmIng != null)
            {
                frmIng.cargarIngredientes();
            }
            LocalizaMenus();
        }

        //Cambiar al español
        private void toolStripMenuItemIngles_Click(object sender, EventArgs e)
        {
            toolStripMenuItemEspañol.Checked = false;
            toolStripMenuItemEspañol.Text = "Spanish";
            toolStripMenuItemIngles.Checked = true;
            toolStripMenuItemIngles.Text = "English";
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("EN-GB");
            if (frmIng != null)
            {
                frmIng.cargarIngredientes();
            }
            LocalizaMenus();
        }


        //Abrir Recetario
        private void abrirRecetario(){
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter = " Recetario (*.cocinillas) | *.cocinillas";

            FileStream miStream;

            if (abrir.ShowDialog() == DialogResult.OK)
            {

                Recetario rece = new Recetario();
                miStream = new FileStream(abrir.FileName, FileMode.Open);

                BinaryFormatter formateador = new BinaryFormatter();
                MiEnlazador binder = new MiEnlazador();
                formateador.Binder = binder;
                rece = (Recetario)formateador.Deserialize(miStream);

                FormRecetario recetarioHijo = new FormRecetario();

                recetarioHijo.MdiParent = this;
                recetarioHijo.recetario = rece;
                recetarioHijo.Show();
                miStream.Close();
                recetarioToolStripMenuItem.Enabled = true;
            }

        }

        //Crear nuevo Recetario
        private void nuevoRecetario()
        {
            FormNuevoRecetario formrecetario = new FormNuevoRecetario();

            if (formrecetario.ShowDialog() == DialogResult.OK)
            {

                recetario = formrecetario.recetario;
                FormRecetario recetarioHijo = new FormRecetario();
                recetarioHijo.MdiParent = this;
                recetarioHijo.recetario = recetario;
                recetarioHijo.Show();
                recetarioToolStripMenuItem.Enabled = true;
               
            }
        }

        //Guardar Recetario
        private void guardarRecetario ()
        { 
           if (ActiveMdiChild != null) {
                SaveFileDialog guarda = new SaveFileDialog();
                guarda.Filter = "Recetarios (*.cocinillas)| *.cocinillas";

                FileStream miStream;

                FormRecetario frmRec;
                frmRec = (FormRecetario)ActiveMdiChild;
                recetario = frmRec.recetario;

                if (guarda.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    miStream = new FileStream(guarda.FileName, FileMode.Create);

                     formateador.Serialize(miStream, recetario);
                     miStream.Close();
                
                }
            }
        
        }

        //Editar Recetario
        private void editarRecetario() {
            if(this.ActiveMdiChild != null){
                FormRecetario frmRecetario = (FormRecetario)this.ActiveMdiChild;
            
                FormNuevoRecetario frmEditarRecetario = new FormNuevoRecetario();
                frmEditarRecetario.Text = "Editar Recetario";
                frmEditarRecetario.recetario = frmRecetario.recetario;

                if (frmEditarRecetario.ShowDialog() == DialogResult.OK)
                {

                    frmRecetario.recetario = frmEditarRecetario.recetario;
                    frmRecetario.cargarControles();
                }
            }
                
        }

        //Crear Formulario Nueva Receta
        public void nuevaReceta() {
            FormRecetario frmRecetario = (FormRecetario)this.ActiveMdiChild;
            recetario = frmRecetario.recetario;

            FormNReceta frmNReceta = new FormNReceta();
            frmNReceta.recetario = recetario;
            frmNReceta.MdiParent = this;
            frmNReceta.hermano = frmRecetario;
            frmRecetario.hermano = frmNReceta;
            frmNReceta.receta = frmRecetario.receta;
         
            frmNReceta.indReceta = frmRecetario.indReceta;
            frmNReceta.Show();
        }



        /// <summary>
        /// Fuerza una actualización de los menus para localizarlos.
        /// TODO: eliminar los foreach para centrarse unicamente en los menus
        /// TODO: hacer la función recursiva para acceder a más niveles de submenus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalizaMenus()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

            foreach (Control c in this.Controls)
            {
                if (c is MenuStrip)
                {
                    foreach (ToolStripMenuItem c1 in ((MenuStrip)c).Items)
                    {
                        resources.ApplyResources(c1, c1.Name, System.Threading.Thread.CurrentThread.CurrentUICulture);

                        foreach (ToolStripItem c2 in c1.DropDownItems)
                        {
                            resources.ApplyResources(c2, c2.Name, System.Threading.Thread.CurrentThread.CurrentUICulture);
                            
                        }
                    }
                }
            }

        }

        public void actualizaLabel() {

            FormRecetario frmRecetario = (FormRecetario)this.ActiveMdiChild;
            toolStripStatusLabel1.Text = "Total Recetas: " + frmRecetario.recetario.NumRecetas;
        
        }
    }
}
