using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocioyADatos.monteriaDataSetTableAdapters;
using LogicaNegocioyADatos.Entidades;

namespace LogicaNegocioyADatos
{
    public class LNyAD
    {
        static usuarioTableAdapter usuariosAdapter = new usuarioTableAdapter();
        static monteriaDataSet.usuarioDataTable usuariosTabla = new monteriaDataSet.usuarioDataTable();

        static restauranteTableAdapter restauranteAdapter = new restauranteTableAdapter();
        static monteriaDataSet.restauranteDataTable restauranteTabla = new monteriaDataSet.restauranteDataTable();

        static productoTableAdapter productosAdapter = new productoTableAdapter();
        static monteriaDataSet.productoDataTable productosTabla = new monteriaDataSet.productoDataTable();

        #region Listas Combo
        static public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            usuariosTabla = usuariosAdapter.GetData();

            foreach (monteriaDataSet.usuarioRow regUsuario in usuariosTabla)
                listaUsuarios.Add(new Usuario(regUsuario));
            return listaUsuarios;
        }

        static public List<Restaurante> ListaRestaurantes()
        {
            List<Restaurante> listaRestaurantes = new List<Restaurante>();
            restauranteTabla = restauranteAdapter.GetData();

            foreach (monteriaDataSet.restauranteRow regRestaurante in restauranteTabla)
                listaRestaurantes.Add(new Restaurante(regRestaurante));
            return listaRestaurantes;
        }
        static public List<Producto> ListaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            productosTabla = productosAdapter.GetData();

            foreach (monteriaDataSet.productoRow regProducto in productosTabla)
                listaProductos.Add(new Producto(regProducto));
            return listaProductos;
        }
        #endregion

        #region Tablas

        static public monteriaDataSet.usuarioDataTable TablaUsuarios()
        {
            usuariosTabla = usuariosAdapter.GetData();
            return usuariosTabla;
        }

        static public monteriaDataSet.restauranteDataTable TablaRestaurante()
        {
            restauranteTabla = restauranteAdapter.GetData();
            return restauranteTabla;
        }

        static public monteriaDataSet.productoDataTable TablaProducto()
        {
            productosTabla = productosAdapter.GetData();
            return productosTabla;
        }

        static public monteriaDataSet.usuarioDataTable TablaUsuarios(int idUsuario)
        {
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);
            return usuariosTabla;
        }

        #endregion

        #region Consultas Usuario

        static public Usuario BuscarLogin(string user, string pass)
        {
            Usuario usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorUserPass(user, pass);

            if (usuariosTabla.Count != 0)
            {
                monteriaDataSet.usuarioRow regUsuarios = usuariosTabla[0];
                usuario = new Usuario(regUsuarios);
            }

            return usuario;
        }

        public static void BorrarUsuario(int idUsuario)
        {
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);

            DataSet1.usuarioRow regUsuario = usuariosTabla[0];

            regUsuario.Delete();

            LNyAD.usuariosAdapter.Update(regUsuario);
        }

        static public void EditarUsuario(Usuario usu)
        {

            usuariosTabla = usuariosAdapter.BuscarPorId(usu.IdUsuario);
            monteriaDataSet.usuarioRow regUsuario = usuariosTabla[0];

            regUsuario.nombre = usu.Nombre;
            regUsuario.apellidos = usu.Apellidos;
            regUsuario.usuario = usu.Login;
            regUsuario.password = usu.Password;
            regUsuario.acceso = usu.Acceso;

            usuariosAdapter.Update(regUsuario);
        }

        static public List<Usuario> BuscarAdmin()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            usuariosTabla = usuariosAdapter.BuscaAdmin();

            foreach (monteriaDataSet.usuarioRow regUsuarios in usuariosTabla)
                listaUsuarios.Add(new Usuario(regUsuarios));

            return listaUsuarios;
        }

        static public Usuario BuscarUsuario(string user)
        {
            Usuario usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorUsuario(user);

            if (usuariosTabla.Count != 0)
            {
                monteriaDataSet.usuarioRow regUsuarios = usuariosTabla[0];
                usuario = new Usuario(regUsuarios);
            }

            return usuario;
        }

        static public void AgregarUsuario(string nombre, string apellidos, string usuario, string password)
        {
            usuariosAdapter.AgregarUsuario(usuario, nombre, apellidos, password, 0);
        }

        static public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            Usuario usuario = null;
            usuariosTabla = usuariosAdapter.BuscarPorId(idUsuario);

            if (usuariosTabla.Count != 0)
            {
                monteriaDataSet.usuarioRow regUsuarios = usuariosTabla[0];
                usuario = new Usuario(regUsuarios);
            }

            return usuario;

            #endregion

        }
    }
}