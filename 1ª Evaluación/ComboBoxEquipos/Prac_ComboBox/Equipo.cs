namespace Prac_ComboBox
{

    public struct Equipo
    {
        private int idEquipo;
        private string nombre;
        private int puntos;

        //-- El constructor
        public Equipo(int idEquipo, string nombre, int puntos)
        {
            this.idEquipo = idEquipo;
            this.nombre = nombre;
            this.puntos = puntos;
        }

        //-- Las propiedades
        public int IDEquipo
        {
            get { return idEquipo; }
            set { idEquipo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public Equipo EsteEquipo
        {
            get { return this; }
        }

        public override string ToString()
        {
            return (idEquipo + "; " + nombre + "; " + puntos);
        }

    }
}