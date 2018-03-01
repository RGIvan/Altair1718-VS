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
        int idRestaurante;
        #endregion

        #region Constructores
        public Producto(int idProducto, string nombre, double precio, int cantidad, int idRestaurante)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.idRestaurante = idRestaurante;
        }

        public Producto(DataSet1.productoRow regProducto)
        {
            this.idProducto = regProducto.idproducto;
            this.nombre = regProducto.nombre;
            this.precio = regProducto.precio;
            this.cantidad = regProducto.cantidad;
            this.idRestaurante = regProducto.idrestaurante;
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

        public int IdRestaurante
        {
            get
            {
                return idRestaurante;
            }

            set
            {
                idRestaurante = value;
            }
        }
        #endregion
    }
}
