// Nota: Lo que tienes escrito aquí es orientativo. Puedes quitar o poner lo que te interese.

using System;

namespace TiendaBasica
{
    public class Util
    {
        //----DEVUELVE LA OPCION SELECCIONADA
        public static int Menu()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|             MENU               | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    1) Listar Catálogo          | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    2) Fecha de Movimientos     | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    3) Comprar Artículo         | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    4) Vender Articulo          | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t|    5) Listar Movimientos       | ");
            Console.WriteLine("\t\t\t|                                | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");
            Console.WriteLine("\t\t\t|         0) Salir               | ");
            Console.WriteLine("\t\t\t+--------------------------------+ ");

    //          opcion = CapturaEntero("\n\n\t\tIntroduzca opción: ", 0, 5);

            return opcion;
        }

      
        public static int CapturaEntero(string enunciado, int min, int max)
        {
            int valor = 0;


             
            return valor;
        }

        public static int CapturaEntero(string enunciado, int min)
        {
            int valor = 0;



            return valor;
        }


      public static double CapturaDouble(String enunciado)
      {
          double valor = 0;


          return valor;
      }

        // Devuelve una fecha en formato AAMMDD
      public static int CapturaFecha()
      {
          int fecha;
          ...
          int año = CapturaEntero("\n\n\t\tIntroduzca el Año", 11, 20);
          int mes = CapturaEntero("\n\t\t           el Mes", 1, 12);
          int dia = CapturaEntero("\n\t\t           el Día", 1, ¿?);
          fecha=
          return fecha;
      }

    }
}