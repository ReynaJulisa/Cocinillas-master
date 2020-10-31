using System;
using Cocinillas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prueba05
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                int cantidad = 2;
                int calorias = 10;
                int proteinas = 78;
                int resultado;

                //Ejecución de la funcionalidad. Action
                resultado = Grasas.calculaGrasas(calorias, cantidad, proteinas);


                //Comprobación de Resultado. Assert
                Assert.AreEqual(resultado, 1500, "ES SALUDABLE TU RECETA!!!!");

            }
        }
    }
}
