using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaEntero
{
    class Metodo
    {
        public static int CapturaEntero(string enunciado, int min, int max)

        {
            int valor = 0;
            bool esCorrecto;

            do

            {
                Console.Write("\n\n\t{2} [{0}..{1}]: ", min, max, enunciado);

                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);


                if (!esCorrecto)

                    Console.WriteLine("\n\t** Error el dato tiene que ser un número entero ** ");

                else if (valor < min || valor > max)

                    Console.Write("\n\t** Error valor fuera de rango ** ");

            } while (valor < min || valor > max || !esCorrecto);

            Console.WriteLine("\n Pulse intro para continuar...");
            Console.ReadLine();

            return valor;
        }
    }
}
