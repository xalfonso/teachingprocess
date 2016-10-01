using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CEvaluación
    {
        protected String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected CTipoEvaluacion tipoEvaluacion;

        public CTipoEvaluacion TipoEvaluacion
        {
            get { return tipoEvaluacion; }
            set { tipoEvaluacion = value; }
        }

        protected List<CHabilidad> listHabilidad;

        public List<CHabilidad> ListHabilidad
        {
            get { return listHabilidad; }
            set { listHabilidad = value; }
        }

        private CActividad acti;

        public CActividad Acti
        {
            get { return acti; }
            set { acti = value; }
        }

        private CAsignatura asi;

        public CAsignatura Asi
        {
            get { return asi; }
            set { asi = value; }
        }

        protected String descripcion;

        public String Descr
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private List<CEvaluacionEstudiante> listEvaEst;

        public List<CEvaluacionEstudiante> ListEvaEst
        {
            get { return listEvaEst; }
            set { listEvaEst = value; }
        }


        public CEvaluación()
        {
            this.nombre = "";
            this.tipoEvaluacion = new CTipoEvaluacion();
            this.listHabilidad = new List<CHabilidad>();
            this.listEvaEst = new List<CEvaluacionEstudiante>();
            this.Acti = new CActividad();
            this.asi = new CAsignatura();
        }

        public override string ToString()
        {
            return this.nombre + "( "+this.tipoEvaluacion.ToString()+" )";
        }
    }
}
