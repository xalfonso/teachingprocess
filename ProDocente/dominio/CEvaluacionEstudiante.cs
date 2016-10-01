using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
     public class CEvaluacionEstudiante
    {
        private CEstudiante estudiante;

        public CEstudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }
        private CEvaluación evaluacion;

        public CEvaluación Evaluacion
        {
            get { return evaluacion; }
            set { evaluacion = value; }
        }

        private CTipoResultado resultado;

        public CTipoResultado Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        private List<CResultadoHabilidadEvaluada> listhabilidadEvaluada;

        public List<CResultadoHabilidadEvaluada> ListaHabilidadEvaluada
        {
            get { return listhabilidadEvaluada; }
            set { listhabilidadEvaluada = value; }
        }

        private DateTime fechaI;

        public DateTime FechaI
        {
            get { return fechaI; }
            set { fechaI = value; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private String comentario;

        public String Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }


         public CEvaluacionEstudiante()
         {
             this.estudiante = new CEstudiante();
             this.evaluacion = new CEvaluación();
             this.resultado = new CTipoResultado();
             this.listhabilidadEvaluada = new List<CResultadoHabilidadEvaluada>();
             fechaI = new DateTime();
             fechaFin = new DateTime();
             this.comentario = "";
         }

    }
}
