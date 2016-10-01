using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProDocente.dominio;

namespace ProDocente.visual
{
    public partial class EvaluarHabilidadEstudiante : Form
    {


        private CEvaluación eval;

        public CEvaluación Eval
        {
            get { return eval; }
            set { eval = value; }
        }



        private CEvaluacionEstudiante nuevEvaEs;

        public CEvaluacionEstudiante NuevaEvaEs
        {
            get { return nuevEvaEs; }
            set { nuevEvaEs = value; }
        }

        private List<CTipoResultado> listTipoResultado;

        public List<CTipoResultado> ListResult
        {
            get { return listTipoResultado; }
            set { listTipoResultado = value; }
        }

        public EvaluarHabilidadEstudiante(CEvaluación eval, CEvaluacionEstudiante nuevEvaEs, List<CTipoResultado> listTipoResultado)
        {
            InitializeComponent();
            this.eval = eval;


            this.nuevEvaEs = nuevEvaEs;
            this.listTipoResultado = listTipoResultado;

            label2.Text = this.NuevaEvaEs.Estudiante.ToString();
            label4.Text = this.eval.ToString();



            dataGridView1.RowCount = this.eval.ListHabilidad.Count + 1;
            for (int i = 0; i < this.eval.ListHabilidad.Count; i++)
            {
                dataGridView1[0, i].Value = this.eval.ListHabilidad[i].Identificador;
                dataGridView1[1, i].Value = this.eval.ListHabilidad[i].Nombre;
                dataGridView1[3, i].Value = this.eval.ListHabilidad[i].Descripcion;

            }
        }

        public CTipoResultado buscarTipoResultado(String nombre)
        {
            CTipoResultado ti = null;
            foreach (CTipoResultado var in this.listTipoResultado)
            {
                if (var.Nombre == nombre)
                    ti = var;
            }
            return ti;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < this.eval.ListHabilidad.Count; i++)
            {
                CResultadoHabilidadEvaluada nueRes = new CResultadoHabilidadEvaluada();
                nueRes.Estudiante = this.nuevEvaEs.Estudiante;
                nueRes.Evaluacion = this.eval;
                nueRes.Habilidad = this.eval.ListHabilidad[i];
                nueRes.TipoResultado = buscarTipoResultado(dataGridView1[2, i].Value.ToString());

                this.nuevEvaEs.ListaHabilidadEvaluada.Add(nueRes);

            }

        }
    }
}