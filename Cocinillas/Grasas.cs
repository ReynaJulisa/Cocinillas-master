using System;

namespace Cocinillas
{
    public class Grasas
    {
        public static int calculaGrasas(int calorias, int cantidad, int proteina)
        {

            int resultado = calorias * cantidad * proteina;

            return resultado;
        }

        public static int calculaGrasas(int calorias, int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
