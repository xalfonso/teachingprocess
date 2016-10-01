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
    public partial class Insertar_Actividad : Form
    {
        private List<CDisciplina> listDisciplina;

        public List<CDisciplina> ListDisciplina
        {
            get { return listDisciplina; }
            set { listDisciplina = value; }
        }

        

        public Insertar_Actividad(List<CDisciplina> listDisciplina, List<CTipoActividad> listTipoActividad)
        {
            InitializeComponent();
            this.listDisciplina = listDisciplina;
            comboBox1.Items.AddRange(this.listDisciplina.ToArray());
            comboBox4.Items.AddRange(listTipoActividad.ToArray());

        }

        public void actualizarAsign()
        {
            
            if (comboBox1.SelectedIndex != -1)
            {
                CDisciplina nu = (CDisciplina)comboBox1.SelectedItem;
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(nu.ListAsignatura.ToArray());
            }
        }

       

        public void actualizarTema()
        {

            
                CAsignatura nu = (CAsignatura)comboBox2.SelectedItem;
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(nu.ListTemas.ToArray());
            
        }

        public void actualizarHabilidadesAsig()
        {

            CAsignatura nu = (CAsignatura)comboBox2.SelectedItem;
            listBox3.Items.Clear();
            listBox3.Items.AddRange(nu.ListHab.ToArray());

        }


        private void Insertar_Actividad_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarAsign();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (comboBox2.SelectedIndex != -1)
            {
               actualizarTema();
               actualizarHabilidadesAsig();
            }
        }

        public void actualizarActporTema()
        {
            if (comboBox3.SelectedIndex != -1)
            {
                CTema te = (CTema)comboBox3.SelectedItem;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(te.ListActividad.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && comboBox4.SelectedIndex!=-1 && listBox2.Items.Count!=0)
            {
                CActividad nueva = new CActividad();
                nueva.Nombre = textBox1.Text;
                nueva.Numero = int.Parse(textBox2.Text);
                nueva.HorasClase = int.Parse(textBox3.Text);
                nueva.Objetivo = textBox4.Text;
                nueva.Tipo = (CTipoActividad)comboBox4.SelectedItem;

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    nueva.ListHabilidad.Add((CHabilidad)listBox2.Items[i]);
                }
                CTema te = (CTema)comboBox3.SelectedItem;
                nueva.Tema = te;
                te.ListActividad.Add(nueva);
                actualizarActporTema();
            }
            else
                MessageBox.Show("No se puede realizar la operación, faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarActporTema();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox3.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox3.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
    }
}