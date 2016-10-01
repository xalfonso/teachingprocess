using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CHabilidad
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int identificador;

        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public CHabilidad()
        {
            this.nombre = "";
            this.descripcion = "";
            this.identificador = -1;

        }
        public override string ToString()
        {
            return this.nombre;
        }

    }
}
