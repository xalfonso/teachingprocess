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
    public partial class Asistencia : Form
    {

        private List<CTipoAsistencia> lisTipoAsistencia;

        public List<CTipoAsistencia> LisTipoAsistencia
        {
            get { return lisTipoAsistencia; }
            set { lisTipoAsistencia = value; }
        }

        public void actualizarAsign()
        {

            if (comboBox3.SelectedIndex != -1)
            {
                CDisciplina nu = (CDisciplina)comboBox3.SelectedItem;
                comboBox2.SelectedItem = null;
                comboBox2.Items.Clear();                
                comboBox2.Items.AddRange(nu.ListAsignatura.ToArray());
            }
        }


        public Asistencia(List<CGrupo> listG, List<CTipoAsistencia> listTipoAsistencia,List<CDisciplina> listDisciplinas)
        {
            InitializeComponent();
            this.lisTipoAsistencia = listTipoAsistencia;
           
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listG.ToArray());

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(listDisciplinas.ToArray());

        }

        public CTipoAsistencia buscarTipoAsistencia(String nombre)
        {
            CTipoAsistencia ti = null;
            foreach (CTipoAsistencia var in this.lisTipoAsistencia)
            {
                if (var.Nombre == nombre)
                    ti = var;
            }
            return ti;
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1)
            {
                List<CEstudiante> listEsdeGrupo = ((CGrupo)comboBox1.SelectedItem).ListEstudiante;

                dataGridView1.RowCount = listEsdeGrupo.Count + 1;
                for (int i = 0; i < listEsdeGrupo.Count; i++)
                {
                    dataGridView1[0, i].Value = i + 1;
                    dataGridView1[1, i].Value = listEsdeGrupo[i].ToString();
                    dataGridView1[2, i].Value = listEsdeGrupo[i].CI;
                  
                }
                

            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarAsign();
        }
        public void actualizarTema()
        {

            if (comboBox2.SelectedIndex != -1)
            {
                CAsignatura nu = (CAsignatura)comboBox2.SelectedItem;
                comboBox4.SelectedItem = null;
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(nu.ListTemas.ToArray());
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarTema();
        }
        public void actualizarActporTema()
        {
            if (comboBox4.SelectedIndex != -1)
            {
                CTema te = (CTema)comboBox4.SelectedItem;
                comboBox5.SelectedItem = null;
                comboBox5.Items.Clear();                
                comboBox5.Items.AddRange(te.ListActividad.ToArray());
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarActporTema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox5.SelectedIndex != -1)
            {
                CGrupo grou = (CGrupo)comboBox1.SelectedItem;
                String temCI = "";

                for (int i = 0; i < grou.ListEstudiante.Count; i++)
                {
                    temCI = dataGridView1[2, i].Value.ToString();
                    CEstudiante ep = grou.buscarEstudCarnet(temCI);
                    
                    CEstud_Actividad actiEst = new CEstud_Actividad();
                    actiEst.Estudiante = ep;
                    actiEst.Actividad = (CActividad)comboBox5.SelectedItem;
                    if (dataGridView1[4, i].Value != null)
                    {
                        actiEst.ComentarioAsistencia = dataGridView1[4, i].Value.ToString();
                    }
                    else
                    {
                        actiEst.ComentarioAsistencia = "";
                    }
                    if (dataGridView1[5, i].Value != null)
                    {
                        actiEst.ComentarioEstAct = dataGridView1[5, i].Value.ToString();
                    }
                    else
                    {
                        actiEst.ComentarioEstAct = "";
                    }
                    actiEst.Fecha = dateTimePicker1.Value;
                    actiEst.TipoAsistencia = buscarTipoAsistencia(dataGridView1[3, i].Value.ToString());
                    
                    ep.ListTI_Es_Act.Add(actiEst);

                    actiEst.Actividad.ListTI_Es_Act.Add(actiEst);

                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}