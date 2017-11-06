using System;

namespace TiendaBasica
{
    class Alimento:Producto
    {
        private int fechaCad;	// Fecha caducidad. 6 cifras (AAMMDD)

        public Alimento(string nombre, double costo, int beneficio, int cantidad, int fechaCad)
            base(nombre, costo, beneficio, cantidad)
        {
            
        }

    }
}

/*
    // Para calcular el PVP de un alimento se hará
       pvp = 1.2*costo; // (ojo: el PVP no es un campo) 
*/
