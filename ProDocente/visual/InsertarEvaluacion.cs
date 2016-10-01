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
    public partial class InsertarEvaluacion : Form
    {
        
        private List<CDisciplina> listDisciplina;

        public List<CDisciplina> ListDisci
        {
            get { return listDisciplina; }
            set { listDisciplina = value; }
        }

        
        public InsertarEvaluacion(List<CDisciplina> listDisciplina, List<CTipoEvaluacion> listTipoEva)
        {
            InitializeComponent();
           
            
            this.listDisciplina = listDisciplina;
            comboBox3.Items.AddRange(this.listDisciplina.ToArray());

            comboBox1.Items.AddRange(listTipoEva.ToArray());
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1 && listBox1.Items.Count != 0 && comboBox2.SelectedIndex != -1 && comboBox1.SelectedIndex != -1 && textBox1.Text.Length!=0 && textBox2.Text.Length!=0)
            {
                CEvaluación nue = new CEvaluación();
                nue.Nombre = textBox1.Text;
                nue.Descr = textBox2.Text;
                

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    nue.ListHabilidad.Add((CHabilidad)listBox1.Items[i]);
                }

                nue.TipoEvaluacion = (CTipoEvaluacion)comboBox1.SelectedItem;
                CAsignatura asignat = (CAsignatura)comboBox2.SelectedItem;
                nue.Asi = asignat;

                asignat.ListEva.Add(nue);
                actualizarEvaluaciones();

            }
            else
            {
                MessageBox.Show("No se puede realizar la operación, faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                CDisciplina nue = (CDisciplina)comboBox3.SelectedItem;
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(nue.ListAsignatura.ToArray());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                CAsignatura nue = (CAsignatura)comboBox2.SelectedItem;
                listBox2.Items.Clear();
                listBox2.Items.AddRange(nue.ListHab.ToArray());

                actualizarEvaluaciones();
            }
        }

        public void actualizarEvaluaciones()
        {
            CAsignatura nue = (CAsignatura)comboBox2.SelectedItem;
            listBox3.Items.Clear();
            listBox3.Items.AddRange(nue.ListEva.ToArray());
            label8.Text = nue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}