using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CTema
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

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private List<CActividad> listActividad;

        public List<CActividad> ListActividad
        {
            get { return listActividad; }
            set { listActividad = value; }
        }

        private CAsignatura asignatura;

        public CAsignatura Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }


        public CTema()
        {
            this.nombre = "";
            this.numero = 0;
            this.descripcion = "";
            this.listActividad = new List<CActividad>();
            this.asignatura = new CAsignatura();
        }

        public override string ToString()
        {
            return "# " + this.numero + " " + this.nombre;
        }
    }
}
