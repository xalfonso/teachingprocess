using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CActividad
    {

        private int horasClase;

        public int HorasClase
        {
            get { return horasClase; }
            set { horasClase = value; }
        }


        private CTema tema;

        public CTema Tema
        {
            get { return tema; }
            set { tema = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private CTipoActividad tipo;

        public CTipoActividad Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private String objetivo;

        public String Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }

        private List<CHabilidad> listHabilidad;

        public List<CHabilidad> ListHabilidad
        {
            get { return listHabilidad; }
            set { listHabilidad = value; }
        }

        
        private List<CEstud_Actividad> listTI_Es_Act;

        public List<CEstud_Actividad> ListTI_Es_Act
        {
            get { return listTI_Es_Act; }
            set { listTI_Es_Act = value; }
        }

        public DateTime obtenerFechaActividadDelGrupo(CGrupo grop)
        {
            DateTime fecha = new DateTime();
          foreach (CEstud_Actividad var in this.listTI_Es_Act)
            {
                if (var.Estudiante.Grupo.Equals(grop))
                {
                    fecha = var.Fecha;
                }
            }
            return fecha;
        }

        public int canTipoAsistenciaActividadGrupo(CGrupo grup,CTipoAsistencia tipo)
        {
            int cant = 0;
            foreach (CEstud_Actividad var in this.listTI_Es_Act)
            {
                if (var.Estudiante.Grupo.Equals(grup) && var.TipoAsistencia.Equals(tipo))
                    cant++;
            }
            return cant;
        }

        private List<CEvaluación> listEva;

        public List<CEvaluación> ListEva
        {
            get { return listEva; }
            set { listEva = value; }
        }

        public CActividad()
        {
            this.nombre = "";
            this.numero = -1;
            this.objetivo = "";
            this.horasClase = -1;            
            this.listHabilidad = new List<CHabilidad>();
            this.tema = new CTema();
            this.tipo = new CTipoActividad();
            this.listTI_Es_Act = new List<CEstud_Actividad>();
            this.listEva = new List<CEvaluación>();
        }

        public override string ToString()
        {
            return this.tipo+". Act # "+this.numero+" "+this.nombre+" ("+this.horasClase+"h)";
        }
    }
}
