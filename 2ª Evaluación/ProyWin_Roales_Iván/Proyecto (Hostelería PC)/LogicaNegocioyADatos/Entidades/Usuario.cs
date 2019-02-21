﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos.Entidades
{
    public class Usuario
    {
        #region Campos
        int idUsuario;
        String login;
        String nombre;
        String apellidos;
        String password;
        String tipo;
        String email;
        int acceso;
        int telefono;
        #endregion

        #region Constructores
        public Usuario(int idUsuario, string login, string nombre, string apellidos, string password, string tipo, string email, int acceso, int telefono)
        {
            this.idUsuario = idUsuario;
            this.login = login;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.password = password;
            this.acceso = acceso;
            this.tipo = tipo;
            this.email = email;
            this.telefono = telefono;
        }

        public Usuario()
        {
            this.idUsuario = -1;
            this.login = String.Empty;
            this.password = String.Empty;
            this.Nombre = String.Empty;
            this.apellidos = String.Empty;
            this.acceso = 2;
            this.tipo = String.Empty;
            this.email = String.Empty;
            this.telefono = 0;
        }


        public Usuario(DataSet1.usuarioRow regUsuarios)
        {
            this.idUsuario = regUsuarios.idusuario;
            this.login = regUsuarios.usuario;
            this.nombre = regUsuarios.nombre;
            this.apellidos = regUsuarios.apellidos;
            this.password = regUsuarios.password;
            this.acceso = regUsuarios.acceso;
            this.tipo = regUsuarios.tipo;
            this.email = regUsuarios.email;
        }
        #endregion

        #region Propiedades
        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
            }
        } 
        #endregion
    }
}