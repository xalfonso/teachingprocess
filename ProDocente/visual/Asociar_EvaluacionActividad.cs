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
    public partial class Asociar_EvaluacionActividad : Form
    {

       
	
        
        
        
        public Asociar_EvaluacionActividad(List<CDisciplina> listDisciplina)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(listDisciplina.ToArray());
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                comboBox2.Items.AddRange(((CDisciplina)comboBox1.SelectedItem).ListAsignatura.ToArray());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                comboBox3.Text = "";
                comboBox3.Items.AddRange(((CAsignatura)comboBox2.SelectedItem).ListTemas.ToArray());

                listBox1.Items.Clear();
                listBox1.Items.AddRange(((CAsignatura)comboBox2.SelectedItem).ListEva.ToArray());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox4.Items.Clear();
                comboBox4.Text = "";
                comboBox4.Items.AddRange(((CTema)comboBox3.SelectedItem).ListActividad.ToArray());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1 && listBox2.Items.Count!=0)
            {

                CActividad act = (CActividad)comboBox4.SelectedItem;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    act.ListEva.Add((CEvaluación)listBox2.Items[i]);

                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la operación, faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
            
        }
    }
}