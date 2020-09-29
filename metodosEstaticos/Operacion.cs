using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEstaticos
{
    class Operacion
    {
        public static void suma(int x, int y)
        {
            int respuesta;
            respuesta = x + y;
            Console.WriteLine("El resultado de la suma es: " + respuesta);
        }

        public static void resta(int x, int y)
        {
            int respuesta;
            respuesta = x - y;
            Console.WriteLine("El resultado de la resta es: " + respuesta);
        }
    }  
}
