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
    public partial class Registro_Asistencia : Form
    {

        private List<CGrupo> listGrupo;

        public List<CGrupo> ListGrupo
        {
            get { return listGrupo; }
            set { listGrupo = value; }
        }
        private List<CDisciplina> listDisciplina;

        public List<CDisciplina> ListDisciplina
        {
            get { return listDisciplina; }
            set { listDisciplina = value; }
        }

        private List<CTipoAsistencia> listTipoAsist;

        public List<CTipoAsistencia> ListTipoAsis
        {
            get { return listTipoAsist; }
            set { listTipoAsist = value; }
        }




        public Registro_Asistencia(List<CGrupo> ListGrupo, List<CDisciplina> listDisciplina, List<CTipoAsistencia> listTipoAsist)
        {
            InitializeComponent();
            this.listGrupo = ListGrupo;
            this.listDisciplina = listDisciplina;
            this.listTipoAsist = listTipoAsist;

            comboBox1.Items.AddRange(this.listGrupo.ToArray());
            comboBox2.Items.AddRange(this.listDisciplina.ToArray());

        }

        private void Registro_Asistencia_Load(object sender, EventArgs e)
        {

        }
        public void actualizarAsign()
        {

            if (comboBox2.SelectedIndex != -1)
            {
                CDisciplina nu = (CDisciplina)comboBox2.SelectedItem;
                comboBox3.SelectedItem = null;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(nu.ListAsignatura.ToArray());
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarAsign();
        }

        public void generarRegistro()
        {
              CAsignatura asig = (CAsignatura)comboBox3.SelectedItem;
              List<CActividad> listAct = asig.obtenerTodasActi();

              CGrupo grupo1 = ((CGrupo)comboBox1.SelectedItem);


              DataGridViewCell template = dataGridView1.Columns[0].CellTemplate;
              dataGridView1.ColumnCount = listAct.Count + 2 + this.listTipoAsist.Count; //para sacar los porcentajes
              for (int i = 0; i < listAct.Count; i++)
              {
                 DateTime feh = listAct[i].obtenerFechaActividadDelGrupo(grupo1);
                  if (feh.Year != 1)
                      dataGridView1.Columns[i + 2].Name = listAct[i].ToString()+" "+feh.Day+"/"+feh.Month+"/"+feh.Year;
                  else
                      dataGridView1.Columns[i + 2].Name = listAct[i].ToString();
                  
                  dataGridView1.Columns[i + 2].ReadOnly = true;
                  dataGridView1.Columns[i + 2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
              }


              List<CEstudiante> lisEst = ((CGrupo)comboBox1.SelectedItem).ListEstudiante;
              dataGridView1.RowCount = lisEst.Count + 1 + this.listTipoAsist.Count; //para sacar los porcentajes por actividad.


             

              for (int i = 0; i < lisEst.Count; i++)
              {
                  dataGridView1[0, i].Value = i + 1;
                  dataGridView1[1, i].Value = lisEst[i].ToString();
                  for (int j = 0; j < listAct.Count; j++) //j+2 porque la primera columana y la segunda es del nombre del estudiante y el numero
                  {
                       dataGridView1[j + 2, i].Value = lisEst[i].obtenerTipoAsistenciaActividad(listAct[j]);
                  }
              }


              //porcentajes de asistencia por actividad.
              for (int i = 0; i < listTipoAsist.Count; i++)
              {
                 
                  CTipoAsistencia temp = listTipoAsist[i];
                  dataGridView1[1, i + lisEst.Count].Value = "% " + temp.ToString();

                  for (int j = 0; j < listAct.Count; j++) 
                  {
                      int cantt = listAct[j].canTipoAsistenciaActividadGrupo(grupo1, temp);
                      double porc = cantt*100/grupo1.ListEstudiante.Count;
                      dataGridView1[j + 2, i + lisEst.Count].Value = porc+ "% ("+cantt+")";
                  }
              }




            //porcentajes de asistencia por estudiante.
              for (int i = 0; i < listTipoAsist.Count; i++)
              {
                   CTipoAsistencia temp = listTipoAsist[i];
                   dataGridView1.Columns[i + 2 + listAct.Count].Name = "% " + temp.ToString();
                     for (int k = 0; k < lisEst.Count; k++)
                     {
                         int cantt = lisEst[k].canHorasTipoAsistenciaActividadAsignatura(asig, temp);
                         double porc = cantt * 100 / asig.obtenerHorasTotales();
                         dataGridView1[i + 2 + listAct.Count, k].Value = porc + "% (" + cantt + ")";
                     }
              }
              
                    
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (comboBox3.SelectedIndex != -1 && comboBox1.SelectedIndex!=-1)
               {
                   dataGridView1.Rows.Clear();
                   dataGridView1.Visible = true;
                   generarRegistro();
               }
              
        }
    }
}