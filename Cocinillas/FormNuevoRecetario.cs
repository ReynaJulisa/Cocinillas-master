using System;
using System.Drawing;
using System.Windows.Forms;


namespace Cocinillas
{
    public partial class FormNuevoRecetario : Form
    {
        public Recetario recetario;

        public FormNuevoRecetario()
        {
            InitializeComponent();
        }

        private void bColorRecetario_Click(object sender, EventArgs e)
        {
            ColorDialog MiDialogo = new ColorDialog();

            MiDialogo.Color = bColorRecetario.BackColor;

            if (MiDialogo.ShowDialog() == DialogResult.OK) 
            {
                bColorRecetario.BackColor = MiDialogo.Color;
            }


        }

        private void  FormNuevoRecetario_Load(object sender, EventArgs e)
        {
           
            if (recetario != null)
            {
                bColorRecetario.BackColor = recetario.ColorR;
                dTFechaRecetario.Value = recetario.Fecha;
                rTBDescripRecetario.Text = recetario.Descripcion;
                tbNombreRecetario.Text = recetario.Nombre;

                String tipos = Convert.ToString(recetario.Tipos, 2);
                char[] caracter = tipos.ToCharArray();
                char cara = (char)49; //Equivale al "1" 
                for (int i = 0; i < caracter.Length; i++) { 
                    if(caracter[i].Equals(cara)){
                        cLBTipoRecetario.SetItemCheckState(i, CheckState.Checked);
                    }

                }

            }
            else {
                //Crear color aleatorio
                Random randonGen = new Random();
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                randonGen.Next(255));

                //Asignar el color al boton
                bColorRecetario.BackColor = randomColor;
 
            }
        }

        private void bAceptarRecetario_Click(object sender, EventArgs e)
        {
            recetario = new Recetario();
            recetario.ColorR = bColorRecetario.BackColor;
            recetario.Fecha = dTFechaRecetario.Value;
            if (tbNombreRecetario.Text == "")
            {
                MessageBox.Show("No puedes dejar el nombre en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                recetario.Nombre = tbNombreRecetario.Text; 
                this.DialogResult = DialogResult.OK;
            }

            recetario.Descripcion = rTBDescripRecetario.Text;


           byte tipos = 0;
           string prueba = "0";
            
            for (int i = 0; i < cLBTipoRecetario.Items.Count; i++ )
            {
                if (cLBTipoRecetario.GetItemCheckState(i) == CheckState.Checked)
                {
                    prueba = prueba + "1";
                }
                else
                { 
                    prueba = prueba + "0";
                }
              
            }

            tipos = Convert.ToByte(prueba, 2);
            recetario.Tipos = tipos;
           
           
        }
   
    }
}
