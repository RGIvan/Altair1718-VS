using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocioyADatos.DataSet1TableAdapters;
using LogicaNegocioyADatos.Entidades;

namespace LogicaNegocioyADatos
{
    public class LNyAD
    {
        static usuarioTableAdapter usuariosAdapter = new usuarioTableAdapter();
        static DataSet1.usuarioDataTable usuariosTabla = new DataSet1.usuarioDataTable();

        static restauranteTableAdapter restauranteAdapter = new restauranteTableAdapter();
        static DataSet1.restauranteDataTable restauranteTabla = new DataSet1.restauranteDataTable();

        static productoTableAdapter productosAdapter = new productoTableAdapter();
        static DataSet1.productoDataTable productosTabla = new DataSet1.productoDataTable();

        static public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            usuariosTabla = usuariosAdapter.GetData(); 

            foreach (DataSet1.usuarioRow regUsuario in usuariosTabla)
                listaUsuarios.Add(new Usuario(regUsuario)); 
            return listaUsuarios;
        }
        static public List<Restaurante> ListaRestaurantes()
        {
            List<Restaurante> listaRestaurantes = new List<Restaurante>();
            restauranteTabla = restauranteAdapter.GetData();

            foreach (DataSet1.restauranteRow regRestaurante in restauranteTabla)
                listaRestaurantes.Add(new Restaurante(regRestaurante)); 
            return listaRestaurantes;
        }
        static public List<Producto> ListaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            productosTabla = productosAdapter.GetData(); 

            foreach (DataSet1.productoRow regProducto in productosTabla)
                listaProductos.Add(new Producto(regProducto));
            return listaProductos;
        }

    }
}
