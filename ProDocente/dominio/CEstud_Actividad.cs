using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CEstud_Actividad
    {
        private CEstudiante estudiante;

        public CEstudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        private CActividad actividad;

        public CActividad Actividad
        {
            get { return actividad; }
            set { actividad = value; }
        }


        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private CTipoAsistencia tipoAsistencia;

        public CTipoAsistencia TipoAsistencia
        {
            get { return tipoAsistencia; }
            set { tipoAsistencia = value; }
        }

        private String comentarioAsistencia;

        public String ComentarioAsistencia
        {
            get { return comentarioAsistencia; }
            set { comentarioAsistencia = value; }
        }

        private String comentarioEstAct;

        public String ComentarioEstAct
        {
            get { return comentarioEstAct; }
            set { comentarioEstAct = value; }
        }


        public CEstud_Actividad()
        {
            this.estudiante = new CEstudiante();
            this.actividad = new CActividad();
            this.fecha = new DateTime();
            this.tipoAsistencia = new CTipoAsistencia();
            this.comentarioAsistencia = "";
            this.comentarioEstAct = "";
        }

    }
}
