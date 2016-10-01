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
    public partial class Insertar_Habilidad : Form
    {



        public void actualizarHab(List<CHabilidad> listHabi, String proceHab)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = listHabi.Count + 1;
            
            for (int i = 0; i < listHabi.Count; i++)
            {
                dataGridView1[0, i].Value = listHabi[i].Nombre;
                dataGridView1[1, i].Value = listHabi[i].Descripcion;
            }

            label5.Text = proceHab;
        }

        public Insertar_Habilidad(List<CDisciplina> listDisciplinas)
        {
            InitializeComponent();
            
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listDisciplinas.ToArray());
        }

        private void Insertar_Habilidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
          if (comboBox1.SelectedIndex != -1)
           {
               Boolean disAs = false;

              CHabilidad nueva = new CHabilidad();
              CDisciplina tem = ((CDisciplina)comboBox1.SelectedItem);
              nueva.Identificador = tem.ListHabilidad.Count+1;
              nueva.Descripcion = textBox2.Text;
              nueva.Nombre = "A"+nueva.Identificador;
              tem.ListHabilidad.Add(nueva);
              if (comboBox2.SelectedIndex != -1)
              {
                  CAsignatura asi = ((CAsignatura)comboBox2.SelectedItem);
                  asi.ListHab.Add(nueva);
                  disAs = true;
              }

              if (disAs)
              {
                  actualizarHab(((CAsignatura)comboBox2.SelectedItem).ListHab, "Asignatura: " + ((CAsignatura)comboBox2.SelectedItem).Nombre);
                  MessageBox.Show("La Habilidad fue insertada en la disciplina y la asignatura seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                  MessageBox.Show("La Habilidad solo fue insertada en la disciplina seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  actualizarHab(((CDisciplina)comboBox1.SelectedItem).ListHabilidad, "Disciplina: " + ((CDisciplina)comboBox1.SelectedItem).Nombre);
              }
           }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(((CDisciplina)comboBox1.SelectedItem).ListAsignatura.ToArray());

                actualizarHab(((CDisciplina)comboBox1.SelectedItem).ListHabilidad, "Disciplina: "+((CDisciplina)comboBox1.SelectedItem).Nombre);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
               actualizarHab(((CAsignatura)comboBox2.SelectedItem).ListHab, "Asignatura: " + ((CAsignatura)comboBox2.SelectedItem).Nombre);
            }
        }
    }
}