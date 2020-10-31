using System;
using System.Runtime.Serialization;

namespace Cocinillas
{
    class MiEnlazador : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {

            // cambia el nombre del proyecto serializado por el vuestro
            typeName = typeName.Replace("Cocinillas-P001", "Cocinillas");
            // cambia el nombre denamespac serializado por el vuestro
            typeName = typeName.Replace("Cocinillas_P001", "Cocinillas");
            return Type.GetType(typeName);
        }
    }
}
