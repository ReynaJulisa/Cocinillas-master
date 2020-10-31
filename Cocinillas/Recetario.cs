using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cocinillas
{
    /// <summary>
    /// Encapsula un cojunto de recetas
    /// </summary>
    [Serializable]
    public class Recetario
    {
        // Propiedades
        /// <summary>
        /// Devuelve o asigna el nombre del recetario
        /// </summary>
        public String Nombre { get; set;  }

        // Propiedades
        /// <summary>
        /// Devuelve o asigna la descripción del recetario
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// Devuelve o asigna el color del recetario
        /// </summary>
        public Color ColorR { get; set; }

        /// <summary>
        /// Devuelve o asigna la fecha del recetario
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Devuelve o asigna los tipos de comida incluidos en el recetario. Su almacenamiento se realiza mediante
        /// un byte. Cada una de las posciones indica un 1 si está incluido y un 0 si no lo está
        /// </summary>
        public Byte Tipos { get; set; }

        /// <summary>
        /// Devuelve el número de recetas del recetario
        /// </summary>
        public int NumRecetas {  get { return recetario.Count; } }

        // Miembros privados
        private List<Receta> recetario;

        /// <summary>
        /// Constructor
        /// </summary>
        public Recetario()  {  recetario = new List<Receta>();  }

        /// <summary>
        /// Añade una receta al recetario
        /// </summary>
        /// <param name="receta">Receta a añadir</param>
        public void AddReceta(Receta receta) 
        {
            recetario.Add(receta);
        }

        /// <summary>
        /// Borra la receta idx del recetario
        /// </summary>
        /// <param name="idx">Índice de la receta a borrar</param>
        public void BorraReceta(int idx) 
        { 
            recetario.RemoveAt(idx);
        }

        /// <summary>
        /// Modifica una receta del recetario
        /// </summary>
        /// <param name="idx">Índice de la receta a borrar</param>
        /// <param name="receta">Receta modificada</param>
        public void ModificaReceta(int idx,Receta receta) 
        {
            recetario.RemoveAt(idx);
            recetario.Insert(idx, receta);
        }

        /// <summary>
        /// Propiedad indizadora
        /// </summary>
        /// <param name="id">indice que se quiere recuperar</param>
        /// <returns>Objeto receta en la posicion id</returns>
        public Receta this[int id] { get { return recetario[id];  } }

    }

    /// <summary>
    /// Encapsula una receta, con sus ingredientes y sus pasos de realización 
    /// </summary>
    [Serializable]
    public class Receta
    {
        /// <summary>
        /// Devuelve o asigna el nombre de la receta
        /// </summary>
        public String Nombre { get; set; }

        /// <summary>
        /// Devuelve el número de pasos de una receta
        /// </summary>
        public int NumPasos {  get { return pasos.Count; } }

        /// <summary>
        /// Propiedad indizadora
        /// </summary>
        /// <param name="id">Índice que se quiere recuperar</param>
        /// <returns>Paso en la posición id</returns>
        public String this[int id] { get { return pasos[id]; } }

        /// <summary>
        /// Devuelve o asigna un vector de ingredientes a la receta
        /// </summary>
        public IngredienteReceta[] Ingredientes
        {
            get {  return ingredientes.ToArray(); }

            set {  ingredientes.AddRange(value); }
        }

        /// <summary>
        ///  Miembros privados
        /// </summary>
        private List<IngredienteReceta> ingredientes;
        private List<String> pasos;

        /// <summary>
        /// Constructor
        /// </summary>
        public Receta() {
        
            ingredientes = new List<IngredienteReceta>();
            pasos = new List<String>();
        }

        /// <summary>
        /// Añade un paso a la receta
        /// </summary>
        /// <param name="paso">Cadena que describe el paso</param>
        public void AddPaso(String paso) { pasos.Add(paso); }

        /// <summary>
        /// Borra toda la lista de ingredientes
        /// </summary>
        public void BorrarTodosIngredientes() { ingredientes.Clear(); }


        
        public override String ToString(){
            return this.Nombre;
        }
    }

        
    /// <summary>
    /// Encapsula in ingrediente en una receta
    /// </summary>
    [Serializable]
    public class IngredienteReceta 
    { 
        // Miembros privados
        private Ingrediente ing;
        int cantidad;

        /// <summary>
        /// Devuelve el ingrediente
        /// </summary>
        public Ingrediente Ingrediente { get { return ing;  } }

        /// <summary>
        /// Devuelve la cantidad a utilizar de ese ingrediente
        /// </summary>
        public int Cantidad { get { return cantidad; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="i">Objeto ingrediente</param>
        /// <param name="cant">cantidad (en las unidades del ingrediente)</param>
        public IngredienteReceta(Ingrediente i, int cant)
        {
            ing = i;
            cantidad = cant;
        }

        /// <summary>
        /// Sobreescritura de la función ToString()
        /// </summary>
        /// <returns>La cantidad, unidades y nombre del ingrediente</returns>
        public override String ToString()
        {
            return "["+cantidad+" " +ing.Unidades +"] " + ing.Nombre;
        }

    }

    /// <summary>
    /// Encapsula un ingrediente a utilizar en las recetas
    /// </summary>
    [Serializable]
    public class Ingrediente
    {
        /// <summary>
        /// Devuelve el identificado del ingrediente
        /// </summary>
        public int ID { get { return id; }   }

        /// <summary>
        /// Devuelve el nombre del ingrediente
        /// </summary>
        public String Nombre { get { return nombre; } }

        /// <summary>
        /// Devuelve en que se mide el igrediente
        /// </summary>
        public String Unidades { get { return unidades; } }

        /// <summary>
        /// Devuelve las calorias del ingrediente cada 100gr
        /// </summary>
        public int Calorias { get { return calorias;} }

        // Miembros privados
        private int id;
        private String nombre;
        private String unidades;
        private int calorias;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="unidades">Tipo de unidad</param>
        /// <param name="calorias">calorias por 100gr</param>
        public Ingrediente(int id, String nombre, string unidades,int calorias)
        {
            this.id = id;
            this.nombre = nombre;
            this.unidades = unidades;
            this.calorias = calorias;
        }

        /// <summary>
        /// Sobreescritura de la función ToString()
        /// </summary>
        /// <returns>El nombre y las calorías cada 100gr</returns>
        public override String ToString() {  return nombre + " (" + calorias + " / 100gr)"; }

    }
}
