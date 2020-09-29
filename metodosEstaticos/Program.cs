using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0, y = 0, opcionNum;
            String opcion, opc;
            do
            {
                Console.WriteLine("Seleccione la operacion que desea realizar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");
                opc = Console.ReadLine();
                opcionNum = Convert.ToInt32(opc);

                if (opcionNum != 3)
                {
                    Console.WriteLine("Ingrese el numero 1");
                    opcion = Console.ReadLine();
                    x = Convert.ToInt32(opcion);

                    Console.WriteLine("Ingrese el numero 2");
                    opcion = Console.ReadLine();
                    y = Convert.ToInt32(opcion);
                }
                    
                switch (opcionNum)
                {
                    case 1:
                        Operacion.suma(x, y);
                        break;
                    case 2:
                        Operacion.resta(x, y);
                        break;
                    case 3:
                        Console.WriteLine("Adios :)");
                        break;
                    default:
                        break;
                }
            }
            while (opcionNum != 3);

            Console.ReadKey();
        }
    }
}
