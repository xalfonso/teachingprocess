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
    public partial class Agrupar_Asignaturas : Form
    {

        private CDisciplina disciplina;

        public CDisciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        private List<CDisciplina> listDisciplina;

        public List<CDisciplina> ListDisciplina
        {
            get { return listDisciplina; }
            set { listDisciplina = value; }
        }

        private List<CAsignatura> listAsignatura;

        public List<CAsignatura> ListAsigantura
        {
            get { return listAsignatura; }
            set { listAsignatura = value; }
        }




        public Agrupar_Asignaturas(List<CDisciplina> listDisciplina, List<CAsignatura> listAsignatura, CDisciplina disciplina)
        {
            InitializeComponent();
            this.listAsignatura = listAsignatura;
            this.listDisciplina = listDisciplina;
            this.disciplina = disciplina;
            actualizarDisciplinas();
            actualizarAsignturasSinDisciplinas();
        }

        public void actualizarDisciplinas()
        {
            comboBox1.Items.Clear();
            foreach (CDisciplina var in this.listDisciplina)
            {
                comboBox1.Items.Add(var);

            }
        }

        public void actualizarAsignturasSinDisciplinas()
        {
            listBox1.Items.Clear();
            foreach (CAsignatura var in this.listAsignatura)
            {
                if (var.Disciplina.Nombre.Equals(""))
                    listBox1.Items.Add(var);


            }
        }

        private void Agrupar_Asignaturas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAsignatura temp = null;
            if (!listBox1.SelectedIndex.Equals(-1))
            {
                temp = (CAsignatura)listBox1.SelectedItem;


                foreach (CAsignatura var in this.listAsignatura)
                {
                    if (var.Nombre == temp.Nombre)
                    {
                        var.Disciplina.Nombre = ".";
                        listBox2.Items.Add(var);
                    }
                }

                actualizarAsignturasSinDisciplinas();

            }
        }
        public void limpiarDisciplinaTentativo()
        {
            foreach (CAsignatura var1 in this.listAsignatura)
            {
                if (var1.Disciplina.Nombre.Equals("."))
                {
                    var1.Disciplina.Nombre = "";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (!checkBox1.Checked)
            {
                this.disciplina.Nombre = textBox1.Text;
                this.disciplina.Descripcion = textBox2.Text;
                this.disciplina.Fundamentacion = textBox3.Text;
            }
            else
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    this.disciplina = (CDisciplina)comboBox1.SelectedItem;

                    foreach (CDisciplina var in this.listDisciplina)
                    {
                        if (var.Nombre == this.disciplina.Nombre)
                            this.disciplina = var;
                    }
                }
            }


            CAsignatura temp = null;


            foreach (object var in listBox2.Items)
            {
                temp = (CAsignatura)var;

                foreach (CAsignatura var1 in this.listAsignatura)
                {
                    if (var1.Nombre == temp.Nombre)
                    {
                        var1.Disciplina = this.disciplina;
                        this.disciplina.ListAsignatura.Add(var1);
                    }
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarDisciplinaTentativo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;

            }
        }
    }
}