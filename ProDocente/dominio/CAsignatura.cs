using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CAsignatura
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int semestre;

        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        private List<CTema> listTemas;

        public List<CTema> ListTemas
        {
            get { return listTemas; }
            set { listTemas = value; }
        }

        private CDisciplina disciplina;

        public CDisciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        private List<CHabilidad> listHab; 

        public List<CHabilidad> ListHab
        {
            get { return listHab; }
            set { listHab = value; }
        }
        private List<CEvaluación> listEva; 

        public List<CEvaluación> ListEva
        {
            get { return listEva; }
            set { listEva = value; }
        }

        public List<CActividad> obtenerTodasActi()
        {
            List<CActividad> listAc = new List<CActividad>();
            foreach (CTema var in this.listTemas)
            {
                foreach (CActividad var1 in var.ListActividad)
                {
                    listAc.Add(var1);
                }
            }
            return listAc;
        }


        public int obtenerHorasTotales()
        {
            int hor = 0;
            List<CActividad> listAc = new List<CActividad>();
            foreach (CTema var in this.listTemas)
            {
                foreach (CActividad var1 in var.ListActividad)
                {
                    hor += var1.HorasClase;
                }
            }
            return hor;
        }

        public CAsignatura()
        {
            this.nombre = "";
            this.descripcion = "";
            this.semestre = -1;
            this.listTemas = new List<CTema>();
            this.disciplina = new CDisciplina();
            this.listHab = new List<CHabilidad>();
            this.listEva = new List<CEvaluación>();

        }

        public override string ToString()
        {
             return nombre;
        }
    }
}
