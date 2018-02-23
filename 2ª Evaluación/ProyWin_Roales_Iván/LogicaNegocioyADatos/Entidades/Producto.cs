using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos.Entidades
{
    public class Producto
    {
        #region Campos
        int idProducto;
        string nombre;
        double precio;
        int cantidad;
        #endregion

        #region Constructores
        public Producto(int idProducto, string nombre, double precio, int cantidad)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public Producto(DataSet1.productoRow regProducto)
        {
            this.idProducto = regProducto.idproducto;
            this.nombre = regProducto.nombre;
            this.precio = regProducto.precio;
            this.cantidad = regProducto.cantidad;
        }
        #endregion

        #region Propiedades
        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
        #endregion
    }
}
