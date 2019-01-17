using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioYAccesoDatos.Entidades
{
    // La estructura Provincia
    public struct Provincia
    {
        private byte idProvincia;
        private string nombre;
        private int prefijo;

        //-- El constructor
        public Provincia(byte idProvincia, string nombre, int prefijo)
        {
            this.idProvincia = idProvincia;
            this.nombre = nombre;
            this.prefijo = prefijo;
        }
        public Provincia (DataSet1.ProvinciasRow regProvincia)
        {
            this.idProvincia = regProvincia.idProvincia;
            this.nombre = regProvincia.nombre;
            this.prefijo = regProvincia.prefijo;
        }

        //-- Las propiedades
        public byte IDProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int IDPrefijo
        {
            get { return prefijo; }
            set { prefijo = value; }
        }
    }

}
