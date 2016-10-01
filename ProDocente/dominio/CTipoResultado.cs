using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CTipoResultado
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

        public CTipoResultado()
        {
            this.nombre = "";
            this.descripcion = "";
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
