using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioyADatos.Entidades
{
<<<<<<< HEAD
    class Grupo
    {
=======
    public struct Grupo
    {
        private int idGrupo;
        private string nombre;
        private string alias;

        public Grupo(int idGrupo, string nombre, string alias)
        {
            this.idGrupo = idGrupo;
            this.nombre = nombre;
            this.alias = alias;
        }

        #region Propiedades
        public int IdGrupo
        {
            get
            {
                return idGrupo;
            }

            set
            {
                idGrupo = value;
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

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        } 
        #endregion
>>>>>>> a15c4e1838895338c99de307af6206cc774984f7

    }
}
