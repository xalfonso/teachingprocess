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
    public partial class RegistrarEvaluacionPorEstudiante : Form
    {
        private List<CEstudiante> listEstud;

        public List<CEstudiante> ListEstud
        {
            get { return listEstud; }
            set { listEstud = value; }
        }
        private CEstudiante estSelec;

        public CEstudiante EstSelec
        {
            get { return estSelec; }
            set { estSelec = value; }
        }

        private CEvaluacionEstudiante evaEst;

        public CEvaluacionEstudiante EvaEst
        {
            get { return evaEst; }
            set { evaEst = value; }
        }
        private List<CTipoResultado> listTipoResultado;
        public List<CTipoResultado> ListResult
        {
            get { return listTipoResultado; }
            set { listTipoResultado = value; }
        }

        public RegistrarEvaluacionPorEstudiante(List<CEstudiante> listEstud, List<CDisciplina> listDisci, List<CTipoResultado> ListResult)
        {
            InitializeComponent();

            comboBox3.Items.AddRange(listDisci.ToArray());
            this.estSelec = null;
            this.evaEst = new CEvaluacionEstudiante();

            this.listTipoResultado = ListResult;
            comboBox1.Items.AddRange(this.listTipoResultado.ToArray());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox2.Items.AddRange(((CDisciplina)comboBox3.SelectedItem).ListAsignatura.ToArray());
            }
        }

        private void RegistrarEvaluacionPorEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox4.Items.AddRange(((CAsignatura)comboBox2.SelectedItem).ListTemas.ToArray());
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                comboBox5.Items.AddRange(((CTema)comboBox4.SelectedItem).ListActividad.ToArray());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                comboBox6.Items.AddRange(((CActividad)comboBox5.SelectedItem).ListEva.ToArray());
            }
        }
        public CEstudiante buscarEstudCarnet(String ci)
        {
            CEstudiante est = null;
            foreach (CEstudiante var in this.listEstud)
            {
                if (var.CI == ci)
                    est = var;
            }
            return est;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text.Length != 0 && textBox1.Text.Length == 11)
            {
                this.estSelec = buscarEstudCarnet(textBox1.Text);
                if (this.estSelec != null)
                {
                    label9.Text = this.estSelec.ToString();
                }
                else
                    MessageBox.Show("No se ha encontrado un estudiante con ese CI", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(comboBox6.SelectedIndex!=-1)
           {
               CEvaluación selec = (CEvaluación)comboBox6.SelectedItem;

               EvaluarHabilidadEstudiante form = new EvaluarHabilidadEstudiante(selec, this.evaEst, this.listTipoResultado);
               form.ShowDialog();
             
            
           }
       }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.estSelec != null && comboBox1.SelectedIndex != -1 && comboBox6.SelectedIndex != -1 && textBox2.Text.Length != -1)
            {
                this.evaEst.Estudiante = estSelec;
                this.evaEst.Resultado = (CTipoResultado)comboBox1.SelectedItem;
                this.evaEst.Evaluacion = (CEvaluación)comboBox6.SelectedItem;
                this.evaEst.FechaI = dateTimePicker1.Value;
                this.evaEst.FechaFin = dateTimePicker2.Value;
                this.evaEst.Comentario = textBox2.Text;
                this.evaEst.Estudiante.ListEvaEst.Add(this.evaEst);
                this.evaEst.Evaluacion.ListEvaEst.Add(this.evaEst);
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("No se puede realizar la operación, faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}