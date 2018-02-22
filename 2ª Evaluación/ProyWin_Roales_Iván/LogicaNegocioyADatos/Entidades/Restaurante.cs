using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos.Entidades
{
    public class Restaurante
    {
        #region Campos
        int idRestaurante;
        string nif;
        string descripcion;
        string ciudad;
        int telefono;
        int idProducto;

        #endregion

        #region Constructores
        public Restaurante(int idRestaurante, string nif, string descripcion, string ciudad, int telefono, int idProducto)
        {
            this.idRestaurante = idRestaurante;
            this.nif = nif;
            this.descripcion = descripcion;
            this.ciudad = ciudad;
            this.telefono = telefono;
            this.idProducto = idProducto;
        }

        public Restaurante(DataSet1.restauranteRow regRestaurante)
        {
            this.idRestaurante = regRestaurante.idrestaurante;
            this.nif = regRestaurante.nif;
            this.descripcion = regRestaurante.descripcion;
            this.ciudad = regRestaurante.ciudad;
            this.telefono = regRestaurante.telefono;
            this.idProducto = regRestaurante.idproducto;
        }
        #endregion

        #region Propiedades
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

        public string Nif
        {
            get
            {
                return nif;
            }

            set
            {
                nif = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

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
    #endregion
    }
}
