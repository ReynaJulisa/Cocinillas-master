using System;
using Cocinillas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prueba03
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                int cantidad = 20;
                int calorias = 100;
                int resultado;

                //Ejecución de la funcionalidad. Action
                resultado = Proteinas.calculaProteinas(calorias, cantidad);


                //Comprobación de Resultado. Assert
                Assert.AreEqual(resultado, 5, "Calculo de proteinas incorrecto.");

            }
        }
    }
}
