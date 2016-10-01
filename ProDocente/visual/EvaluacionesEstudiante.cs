using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProDocente.dominio;
using ProDocente.fichero;

namespace ProDocente.visual
{
    public partial class EvaluacionesEstudiante : Form
    {


        


        public EvaluacionesEstudiante(List<CGrupo> listGrupo,List<CDisciplina> listDisc)
        {
            InitializeComponent();
            
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listGrupo.ToArray());

            
            


            comboBox4.Items.AddRange(listDisc.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!=-1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(((CGrupo)comboBox1.SelectedItem).ListEstudiante.ToArray());
            }
        }
        public CEvaluacionEstudiante obtenerEvaEst(CEstudiante est, CEvaluación eva)
        {
            CEvaluacionEstudiante evaMostrar = null;
            foreach (CEvaluacionEstudiante var in eva.ListEvaEst)
            {
                if(var.Estudiante == est && var.Evaluacion == eva)
                    evaMostrar = var;
            }
            return evaMostrar;
        }

        public void actualizarDatosEva()
        {
            CEvaluacionEstudiante evaMostrar = obtenerEvaEst((CEstudiante)comboBox2.SelectedItem, (CEvaluación)comboBox3.SelectedItem);

            if (evaMostrar != null)
            {
                panel1.BackgroundImage = Image.FromFile(CFichero.DirImg(evaMostrar.Estudiante.CI));
                
                textBox1.Text = evaMostrar.Resultado.ToString();
                textBox2.Text = evaMostrar.FechaI.ToString();
                textBox3.Text = evaMostrar.Comentario;

                dataGridView1.RowCount = evaMostrar.ListaHabilidadEvaluada.Count + 1;

                for (int i = 0; i < evaMostrar.ListaHabilidadEvaluada.Count; i++)
                {
                    dataGridView1[0, i].Value = evaMostrar.ListaHabilidadEvaluada[i].Habilidad.Nombre;
                    dataGridView1[1, i].Value = evaMostrar.ListaHabilidadEvaluada[i].TipoResultado;
                    dataGridView1[2, i].Value = evaMostrar.ListaHabilidadEvaluada[i].Habilidad.Descripcion;
                }
            }
            else
            {
                MessageBox.Show("Este estudiante no se encuentra evaluado en esta evaluación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1)
            {
                actualizarDatosEva();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox5.SelectedIndex != -1)
            {
                actualizarDatosEva();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedIndex!=-1)
            {
             comboBox5.Items.Clear();
             comboBox5.Items.AddRange(((CDisciplina)comboBox4.SelectedItem).ListAsignatura.ToArray());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(((CAsignatura)comboBox5.SelectedItem).ListEva.ToArray());
            }
        }
    }
}