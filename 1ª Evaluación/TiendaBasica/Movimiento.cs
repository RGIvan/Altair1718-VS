using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace TiendaBasica
{
    class Movimiento
    {
        int fechaMov; // Fecha del moviemiento en formato AAMMDD
        char cv; // Sólo puede valer 'C' si es una compra o 'V' si es una venta 
        int idCatalogo; // El id del Catálogo que corresponde al artículo comprado o vendido.
        int cantMov; // Cantidad que hemos comprado o vendido

        public Movimiento(int fechaMov, char cv, int idCatalogo, int cantMov)
        {
            this.FechaMov = fechaMov;
            this.Cv = cv;
            this.IdCatalogo = idCatalogo;
            this.CantMov = cantMov;
        }

        public int FechaMov
        {
            get
            {
                return fechaMov;
            }

            set
            {
                fechaMov = value;
            }
        }

        public char Cv
        {
            get
            {
                return cv;
            }

            set
            {
                cv = value;
            }
        }

        public int IdCatalogo
        {
            get
            {
                return idCatalogo;
            }

            set
            {
                idCatalogo = value;
            }
        }

        public int CantMov
        {
            get
            {
                return cantMov;
            }

            set
            {
                cantMov = value;
            }
        }


    }
    /*
    // Para Presentar el Movimiento puede que te haga falta esto...
       Console.WriteLine("\t{0}\t {1}\t{2}\t{3}\t{4}", fechaMov, cv, cat[idCatalogo].Nombre, cantMov, euros);

       donde los euros de la compra/venta un producto se hará
       Si es una compra:  euros = -cantMov * costo del artículo
     * Si es una venta:   euros = +cantMov * PVP del artículo

*/
}
