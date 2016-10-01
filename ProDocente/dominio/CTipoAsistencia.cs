using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CTipoAsistencia
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public CTipoAsistencia()
        {
            this.nombre = "";
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }
}
