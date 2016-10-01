using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CGrupo
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

        public CEstudiante buscarEstudCarnet(String ci)
        {
            CEstudiante est = null;
            foreach (CEstudiante var in this.listEstudiante)
            {
                if (var.CI == ci)
                    est = var;
            }
            return est;
        }


        private List<CEstudiante> listEstudiante;

        public List<CEstudiante> ListEstudiante
        {
            get { return listEstudiante; }
            set { listEstudiante = value; }
        }
        private String curso;

        public String Curso
        {
            get { return curso; }
            set { curso = value; }
        }


        public CGrupo()
        {
            this.nombre = "";
            this.descripcion = "";
            this.curso = "";
            this.listEstudiante = new List<CEstudiante>();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
