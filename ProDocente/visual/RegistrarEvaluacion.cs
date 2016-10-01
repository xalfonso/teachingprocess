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
    public partial class RegistrarEvaluacion : Form
    {
        private List<CTipoResultado> listTipoResultado;

        public List<CTipoResultado> ListResult
        {
            get { return listTipoResultado; }
            set { listTipoResultado = value; }
        }

       /* private List<CEvaluacionEstudiante> listEvaEstTotal;

        public List<CEvaluacionEstudiante> ListEvaEstTotal
        {
            get { return listEvaEstTotal; }
            set { listEvaEstTotal = value; }
        }*/

        private List<CEvaluacionEstudiante> listnuevEvaEs;

        public List<CEvaluacionEstudiante> ListNuevaEvaEs
        {
            get { return listnuevEvaEs; }
            set { listnuevEvaEs = value; }
        }

       



        public RegistrarEvaluacion(List<CTipoResultado> listTipoResultado, List<CGrupo> listGrupo, List<CDisciplina> listDisc)
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listGrupo.ToArray());

            
            comboBox3.Items.AddRange(listDisc.ToArray());
            
            
           

            this.listTipoResultado = listTipoResultado;

            

            this.listnuevEvaEs = new List<CEvaluacionEstudiante>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {
                List<CEstudiante> listEsdeGrupo = ((CGrupo)comboBox1.SelectedItem).ListEstudiante;

                this.listnuevEvaEs = new List<CEvaluacionEstudiante>();
                dataGridView1.RowCount = listEsdeGrupo.Count + 1;
                for (int i = 0; i < listEsdeGrupo.Count; i++)
                {
                    dataGridView1[0, i].Value = i + 1;
                    dataGridView1[1, i].Value = listEsdeGrupo[i].ToString();
                    dataGridView1[2, i].Value = listEsdeGrupo[i].CI;
                    CEvaluacionEstudiante nueEva = new CEvaluacionEstudiante();
                    nueEva.Estudiante = listEsdeGrupo[i];
                    this.listnuevEvaEs.Add(nueEva);
                }


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(((CDisciplina)comboBox3.SelectedItem).ListAsignatura.ToArray());
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.AddRange(((CTema)comboBox4.SelectedItem).ListActividad.ToArray());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(((CAsignatura)comboBox2.SelectedItem).ListTemas.ToArray());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                comboBox6.Items.Clear();
                comboBox6.Items.AddRange(((CActividad)comboBox5.SelectedItem).ListEva.ToArray());
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
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {
                CGrupo grou = (CGrupo)comboBox1.SelectedItem;
                String temCI = "";
                CEvaluación nu = (CEvaluación)comboBox6.SelectedItem;

                for (int i = 0; i < grou.ListEstudiante.Count; i++)
                {
                    temCI = dataGridView1[2, i].Value.ToString();
                    CEstudiante ep = grou.buscarEstudCarnet(temCI);

                    this.listnuevEvaEs[i].Estudiante = ep;
                    this.listnuevEvaEs[i].Evaluacion = nu;
                    this.listnuevEvaEs[i].FechaI = dateTimePicker1.Value;
                    this.listnuevEvaEs[i].FechaFin = dateTimePicker2.Value;
                    this.listnuevEvaEs[i].Resultado = buscarTipoResultado(dataGridView1[3, i].Value.ToString());
                    if (dataGridView1[4, i].Value != null)
                    {
                        this.listnuevEvaEs[i].Comentario = dataGridView1[4, i].Value.ToString();
                    }
                    else
                    {
                        this.listnuevEvaEs[i].Comentario = "";
                    }

                    ep.ListEvaEst.Add(this.listnuevEvaEs[i]); 
                    
                }
                nu.ListEvaEst.AddRange(this.listnuevEvaEs);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          if (comboBox1.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {  
            
            CGrupo grou = (CGrupo)comboBox1.SelectedItem;
            String temCI = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //CEstudiante ep = grou.buscarEstudCarnet(temCI);
            CEvaluación nu = (CEvaluación)comboBox6.SelectedItem;


            EvaluarHabilidadEstudiante nueva = new EvaluarHabilidadEstudiante(nu, this.listnuevEvaEs[e.RowIndex], this.listTipoResultado);
            nueva.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1)
            {
                List<CEstudiante> listEsdeGrupo = ((CGrupo)comboBox1.SelectedItem).ListEstudiante;

                this.listnuevEvaEs = new List<CEvaluacionEstudiante>();
                dataGridView1.RowCount = listEsdeGrupo.Count + 1;
                for (int i = 0; i < listEsdeGrupo.Count; i++)
                {
                    dataGridView1[0, i].Value = i + 1;
                    dataGridView1[1, i].Value = listEsdeGrupo[i].ToString();
                    dataGridView1[2, i].Value = listEsdeGrupo[i].CI;
                    CEvaluacionEstudiante nueEva = new CEvaluacionEstudiante();
                    nueEva.Estudiante = listEsdeGrupo[i];
                    this.listnuevEvaEs.Add(nueEva);
                }


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}