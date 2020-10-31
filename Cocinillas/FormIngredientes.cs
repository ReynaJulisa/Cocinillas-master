using System;
using System.Windows.Forms;


namespace Cocinillas
{
    public partial class FormIngredientes : Form
    {
        public FormIngredientes()
        {
            InitializeComponent();
        }

        private void listBoxIngredientes_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxIngredientes.DoDragDrop((Ingrediente)listBoxIngredientes.SelectedItem, DragDropEffects.Copy);

        }

        private void FormIngredientes_VisibleChanged(object sender, EventArgs e)
        {
            cargarIngredientes();
        }

        public void cargarIngredientes() {

            listBoxIngredientes.Items.Clear();

            Ingrediente[] ingredientes = new Ingrediente[12];

            ingredientes[0] = new Ingrediente(0, Properties.Resources.Huevo, "unidades", 155);
            ingredientes[1] = new Ingrediente(1, Properties.Resources.Arroz, "gr", 130);
            ingredientes[2] = new Ingrediente(2, Properties.Resources.Pollo, "gr", 239);
            ingredientes[3] = new Ingrediente(3, Properties.Resources.Judias, "gr", 31);
            ingredientes[4] = new Ingrediente(4, Properties.Resources.Tomate, "unidades", 18);
            ingredientes[5] = new Ingrediente(5, Properties.Resources.Lechuga, "unidades", 15);
            ingredientes[6] = new Ingrediente(6, Properties.Resources.Maiz, "gr", 365);
            ingredientes[7] = new Ingrediente(7, Properties.Resources.Salmon, "gr", 208);
            ingredientes[8] = new Ingrediente(8, Properties.Resources.Harina, "gr", 344);
            ingredientes[9] = new Ingrediente(9, Properties.Resources.Aceite, "ml", 862);
            ingredientes[10] = new Ingrediente(10, Properties.Resources.Azucar, "gr", 387);
            ingredientes[11] = new Ingrediente(11, Properties.Resources.Sal, "gr", 208);

            listBoxIngredientes.Items.AddRange(ingredientes);
      
        }
    }
}
