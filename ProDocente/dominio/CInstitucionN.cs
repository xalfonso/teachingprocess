using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
   [Serializable]
   public class CInstitucionN
    {
        private List<CEstudiante> listEstudiantes;

        public List<CEstudiante> ListEstudiantes
        {
            get { return listEstudiantes; }
            set { listEstudiantes = value; }
        }

        private List<CDisciplina> listDisciplina;

        public List<CDisciplina> ListDisciplina
        {
            get { return listDisciplina; }
            set { listDisciplina = value; }
        }

        private List<CGrupo> listGrupo;

        public List<CGrupo> ListGrupo
        {
            get { return listGrupo; }
            set { listGrupo = value; }
        }

        private List<CTipoActividad> listTipoActividad;

        public List<CTipoActividad> ListaTipoActividad
        {
            get { return listTipoActividad; }
            set { listTipoActividad = value; }
        }

        private List<CTipoEvaluacion> listTipoEva;

        public List<CTipoEvaluacion> ListaTipoEva
        {
            get { return listTipoEva; }
            set { listTipoEva = value; }
        }

        private List<CTipoResultado> listTipoResutado;

        public List<CTipoResultado> ListTipoResultado
        {
            get { return listTipoResutado; }
            set { listTipoResutado = value; }
        }

        private List<CAsignatura> listAsignatura;

        public List<CAsignatura> ListAsigantura
        {
            get { return listAsignatura; }
            set { listAsignatura = value; }
        }

        private List<CTipoAsistencia> listTipoAsistencia;

        public List<CTipoAsistencia> ListTipoAsistencia
        {
            get { return listTipoAsistencia; }
            set { listTipoAsistencia = value; }
        }

        /*private List<CHabilidad> listHab; //Esto deberia ir en Asignatura

        public List<CHabilidad> ListHab
        {
            get { return listHab; }
            set { listHab = value; }
        }*/

       /* private List<CEvaluación> listEva; //Esto deberia ir en Asignatura

       public List<CEvaluación> ListEva
        {
            get { return listEva; }
            set { listEva = value; }
        }
       */
       /*
        private List<CEvaluacionEstudiante> listEvaEst; //esto deberia ir en evaluacion y Estud (mucho a mucho)

        public List<CEvaluacionEstudiante> ListEvaEst
        {
            get { return listEvaEst; }
            set { listEvaEst = value; }
        }
       */
       
       

        public CInstitucionN()
        {
            this.listEstudiantes = new List<CEstudiante>();
            this.listGrupo = new List<CGrupo>();
            this.listTipoActividad = new List<CTipoActividad>();
            this.listTipoEva = new List<CTipoEvaluacion>();
            this.listTipoResutado = new List<CTipoResultado>();
            this.listAsignatura = new List<CAsignatura>();
            this.listDisciplina = new List<CDisciplina>();
            this.listTipoAsistencia = new List<CTipoAsistencia>();
            
        }
    }
}
