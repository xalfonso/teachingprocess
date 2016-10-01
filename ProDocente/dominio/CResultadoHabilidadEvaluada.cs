using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CResultadoHabilidadEvaluada
    {
        private CHabilidad habilidad;

        public CHabilidad Habilidad
        {
            get { return habilidad; }
            set { habilidad = value; }
        }


        private CEstudiante estudiante;

        public CEstudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        private CTipoResultado tipoResultado;

        public CTipoResultado TipoResultado
        {
            get { return tipoResultado; }
            set { tipoResultado = value; }
        }

        private CEvaluaci�n evaluacion;

        public CEvaluaci�n Evaluacion
        {
            get { return evaluacion; }
            set { evaluacion = value; }
        }

        public CResultadoHabilidadEvaluada()
        {
            this.habilidad = new CHabilidad();
            this.estudiante = new CEstudiante();
            this.tipoResultado = new CTipoResultado();
            this.evaluacion = new CEvaluaci�n();
        }

    }
}
