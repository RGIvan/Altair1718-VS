using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaBasica
{
    class AppTienda
    {
        static void Main(string[] args)
        {
            double saldo = 6000;       // <-- Euros de los que parte la aplicación
            int fechaMovis = 110102;   // <-- Se supone la fecha de las compras/ventas que hagas
            int opcion = 0;
            //--- Variables auxiliares para los formularios
            int id, cantidad, esAlimento; 
            string nombre;
            double costo;
            Movimiento movi;

            Catalogo catalogo = new Catalogo();

            //// Productos inicales
            //new Producto("Balón Fut.", 10.5, 20);
            //new Producto("Grapadora", 5.5);
            //new Alimento("Naranjas", 1.5, 20, 110521);
            //new Alimento("Manzanas", 2.3, 110221);
            //new Producto("Cuaderno", 1.0, 20);
            //new Alimento("Melón Sapo", 2.3, 110221);

            Tienda tienda = new TiendaBasica.Tienda();
            //--- Entramos en el Menú
            do
            {
                opcion = Util.Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1:  // LISTAR CATÁLOGO

                        break;

                    case 2: // NUEVA FECHA DE MOVIMIENTOS


                        break;

                    case 3: // COMPRAR
                        "\n\t\t¿Id del artículo a comprar? [0=Nuevo]: "


                        break;

                    case 4: // VENDER
                        "\n\t\t¿Id del artículo a VENDER?: "
                        


                        break;


                    case 5: // LISTAR MOVIMIENTOS

                        break;
                }

                    Console.WriteLine("\n\n\t\tPulse una tecla para volver al menu");
                    Console.ReadLine();


            } while;
        }
 
    }
}
