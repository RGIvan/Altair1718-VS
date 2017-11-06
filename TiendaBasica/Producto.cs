using System;

namespace TiendaBasica
{

    class Producto
    {	//--- Los campos 
        private string nombre; // Nombre del producto
        private double costo;  // Cuánto le cuesta a la tienda la unidad (Sin IVA)
        private int beneficio;  // Qué porcentaje se le gana a este producto
        private int cantidad; // Cantidad que tenemos de dicho producto

        TiendaBasica()
        {

        }

        #region Constructores
        public Producto(string nombre, double costo, int beneficio, int cantidad)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.beneficio = beneficio;
            this.cantidad = cantidad;
        }

        public Producto(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.beneficio = 50;
            this.cantidad = 10;
        } 
        #endregion



        //--- Las Propiedades 

        


        //--- Los Métodos
        public double PVP()
        {
            double pvp = beneficio * costo / 100 + costo;

            return pvp;
        }
    }
}

/*
    // Para calcular el PVP de un producto se hará
       pvp = 1.5*costo; // (ojo: el PVP no es un campo) 
    // Para Presentar el producto puede que te haga falta esto...
       Console.WriteLine(" {0}	 {1}\t{2}\t{3}", nombre, cantidad, costo, PVP());
*/