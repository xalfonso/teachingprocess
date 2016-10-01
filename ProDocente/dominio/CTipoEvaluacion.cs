using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CTipoEvaluacion
    {
        public const  String TipoEv_TrabajoControl = "Prueba Parcial";
        public const  String TipoEv_PreguntaEscrita = "Pregunta Escrita";
        
        
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public CTipoEvaluacion()
        {
            this.nombre = "";
        }

        public override string ToString()
        {
            return this.nombre;
        }

        
    }
}
