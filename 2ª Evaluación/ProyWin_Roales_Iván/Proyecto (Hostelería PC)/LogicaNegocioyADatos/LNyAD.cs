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

        #region Listas
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
        #endregion

        #region Tablas

        static public DataSet1.usuarioDataTable TablaUsuarios()
        {
            usuariosTabla = usuariosAdapter.GetData();
            return usuariosTabla;
        }

        static public DataSet1.restauranteDataTable TablaRestaurante()
        {
            restauranteTabla = restauranteAdapter.GetData();
            return restauranteTabla;
        }

        static public DataSet1.productoDataTable TablaProducto()
        {
            productosTabla = productosAdapter.GetData();
            return productosTabla;
        }

        #endregion

        #region Consultas Usuario

        static public Usuario BuscarPorUserPass(String user, String pass)
        {
            Usuario usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorUserPass(user, pass);

            if (usuariosTabla.Count != 0)
            {
                DataSet1.usuarioRow regUsuario = usuariosTabla[0];
                usuario = new Usuario(regUsuario);
            }

            return usuario;
        }

        public static void BorrarUsuario(int idUsuario)
        {
            DataSet1.usuarioRow regUsuario = usuariosTabla.FindByidusuario(idUsuario);

            regUsuario.Delete();

            usuariosAdapter.Update(regUsuario);
        }

        static public List<Usuario> BuscarAdministrador()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            usuariosTabla = usuariosAdapter.BuscarAdministrador();

            foreach (DataSet1.usuarioRow regUsuario in usuariosTabla)
                listaUsuarios.Add(new Usuario(regUsuario));

            return listaUsuarios;
        }

        public static Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            DataSet1.usuarioRow regUsuario = usuariosTabla.FindByidusuario(idUsuario);
            
            Usuario usu = new Usuario(regUsuario);
            return usu;
        }

        static public void EditarUsuario(Usuario usu)
        {
            DataSet1.usuarioRow regUsuario = usuariosTabla.FindByidusuario(usu.IdUsuario);
            regUsuario.usuario = usu.Login;
            regUsuario.nombre = usu.Nombre;
            regUsuario.password = usu.Password;
            regUsuario.apellidos = usu.Apellidos;

            usuariosAdapter.Update(regUsuario);
        }

        static public Usuario BuscarUsuario(string user)
        {
            Usuario usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorUsuario(user);

            if (usuariosTabla.Count != 0)
            {
                DataSet1.usuarioRow regUsuario = usuariosTabla[0];
                usuario = new Usuario(regUsuario);
            }

            return usuario;
        }

        static public void AgregarUsuario(Usuario usu)
        {
            DataSet1.usuarioRow regUsuario = usuariosTabla.NewusuarioRow();

            regUsuario.usuario = usu.Login;
            regUsuario.password = usu.Password;
            regUsuario.nombre = usu.Nombre;
            regUsuario.apellidos = usu.Apellidos;
            regUsuario.acceso = usu.Acceso;

            usuariosTabla.AddusuarioRow(regUsuario);
            
            usuariosAdapter.Update(regUsuario);
        }
        #endregion

        #region Consultas Producto

        public static void BorrarProducto(int idProducto)
        {
            DataSet1.productoRow regProducto = productosTabla.FindByidproducto(idProducto);

            regProducto.Delete();

            productosAdapter.Update(regProducto);
        }

        public static Producto ObtenerProductoPorId(int idProducto)
        {
            DataSet1.productoRow regProducto = productosTabla.FindByidproducto(idProducto);

            Producto pro = new Producto(regProducto);
            return pro;
        }

        static public void EditarProducto(Producto pro)
        {
            DataSet1.productoRow regProducto = productosTabla.FindByidproducto(pro.IdProducto);
            regProducto.nombre = pro.Nombre;
            regProducto.cantidad = pro.Cantidad;
            regProducto.precio = pro.Precio;

            productosAdapter.Update(regProducto);
        }

        static public void AgregarProducto(Producto pro)
        {
            DataSet1.productoRow regProducto = productosTabla.NewproductoRow();

            regProducto.nombre = pro.Nombre;
            regProducto.precio = pro.Precio;
            regProducto.cantidad = pro.Cantidad;

            productosTabla.AddproductoRow(regProducto);

            productosAdapter.Update(regProducto);
        }

        #endregion

        #region Consultas Restaurante

        public static void BorrarRestaurante(int idRestaurante)
        {
            DataSet1.restauranteRow regRestaurante = restauranteTabla.FindByidrestaurante(idRestaurante);

            regRestaurante.Delete();

            restauranteAdapter.Update(regRestaurante);
        }

        public static Restaurante ObtenerRestaurantePorId(int idRestaurante)
        {
            DataSet1.restauranteRow regRestaurante = restauranteTabla.FindByidrestaurante(idRestaurante);

            Restaurante res = new Restaurante(regRestaurante);
            return res;
        }

        static public void EditarRestaurante(Restaurante res)
        {
            DataSet1.restauranteRow regRestaurante = restauranteTabla.FindByidrestaurante(res.IdRestaurante);

            regRestaurante.nombre = res.Nombre;
            regRestaurante.nif = res.Nif;
            regRestaurante.ciudad = res.Ciudad;
            regRestaurante.descripcion = res.Descripcion;
            regRestaurante.telefono = res.Telefono;

            restauranteAdapter.Update(regRestaurante);
        }

        static public void AgregarRestaurante(Restaurante res)
        {
            DataSet1.restauranteRow regRestaurante = restauranteTabla.NewrestauranteRow();

            regRestaurante.nombre = res.Nombre;
            regRestaurante.nif = res.Nif;
            regRestaurante.ciudad = res.Ciudad;
            regRestaurante.descripcion = res.Descripcion;
            regRestaurante.telefono = res.Telefono;

            restauranteTabla.AddrestauranteRow(regRestaurante);

            restauranteAdapter.Update(regRestaurante);
        }

        #endregion
    }
}