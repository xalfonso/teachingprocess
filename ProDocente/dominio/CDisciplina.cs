using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CDisciplina
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

        private String fundamentacion;

        public String Fundamentacion
        {
            get { return fundamentacion; }
            set { fundamentacion = value; }
        }

        private List<CAsignatura> listAsignatura;

        public List<CAsignatura> ListAsignatura
        {
            get { return listAsignatura; }
            set { listAsignatura = value; }
        }
        private List<CHabilidad> listHabilidad;

        public List<CHabilidad> ListHabilidad
        {
            get { return listHabilidad; }
            set { listHabilidad = value; }
        }

        public CDisciplina()
        {
            this.nombre = "";
            this.descripcion = "";
            this.fundamentacion = "";
            this.listAsignatura = new List<CAsignatura>();
            this.listHabilidad = new List<CHabilidad>();

        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
