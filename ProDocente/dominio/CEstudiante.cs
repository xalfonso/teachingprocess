using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System;

namespace ProDocente.dominio
{
    [Serializable]
   public class CEstudiante :CPersona
    {
        public CEstudiante(String primerNombre, String segundoNombre, String primerApellido, String segundoApellido, String ci)
            : base(primerNombre, segundoNombre, primerApellido, segundoApellido, ci)
        {
            this.grupo = new CGrupo();
            this.listTI_Es_Act = new List<CEstud_Actividad>();
            this.historialGrupo = new List<CGrupo>();
            this.listEvaEst = new List<CEvaluacionEstudiante>();
            
        }
       public CEstudiante()
           : base()
       {
           this.grupo = new CGrupo();
           this.listTI_Es_Act = new List<CEstud_Actividad>();
           this.historialGrupo = new List<CGrupo>();
           this.listEvaEst = new List<CEvaluacionEstudiante>();
          
       }

       

       private List<CEvaluacionEstudiante> listEvaEst;

       public List<CEvaluacionEstudiante> ListEvaEst
       {
           get { return listEvaEst; }
           set { listEvaEst = value; }
       }

        private CGrupo grupo;

        public CGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private List<CGrupo> historialGrupo;

        public List<CGrupo> HistorialGrupo
        {
            get { return historialGrupo; }
            set { historialGrupo = value; }
        }


        private List<CEstud_Actividad> listTI_Es_Act;

        public List<CEstud_Actividad> ListTI_Es_Act
        {
            get { return listTI_Es_Act; }
            set { listTI_Es_Act = value; }
        }

       public CTipoAsistencia obtenerTipoAsistenciaActividad(CActividad acti)
       {
           CTipoAsistencia newo = new CTipoAsistencia();
           foreach (CEstud_Actividad var in this.listTI_Es_Act)
           {
               if (var.Actividad.Equals(acti))
                   newo = var.TipoAsistencia;
           }

           return newo;
       }

       public override string ToString()
       {
           return base.ToString();
       }

       public int canHorasTipoAsistenciaActividadAsignatura(CAsignatura asi, CTipoAsistencia tipo)
       {
           int cant = 0;
           foreach (CEstud_Actividad var in this.listTI_Es_Act)
           {
               if (var.Actividad.Tema.Asignatura.Equals(asi) && var.TipoAsistencia.Equals(tipo))
                   cant += var.Actividad.HorasClase;
           }
           return cant;
       }

    }
}
