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
    public partial class CrearGrupo : Form
    {
        private List<CGrupo> listGrupos;

        public List<CGrupo> ListGrupos
        {
            get { return listGrupos; }
            set { listGrupos = value; }
        }

        
        private CGrupo grupo;

        public CGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private List<CEstudiante> listaEstu;

        public List<CEstudiante> ListaEstu
        {
            get { return listaEstu; }
            set { listaEstu = value; }
        }





        public CrearGrupo(CGrupo grup, List<CEstudiante> listaEst, List<CGrupo> listaGrupos)
        {
            InitializeComponent();
            this.grupo = grup;
            this.listaEstu = listaEst;
            this.listGrupos = listaGrupos;
            actualizarEstudianteSinGrupo();
            actualizarGrupos();
        }

        public void actualizarGrupos()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listGrupos.ToArray());

        }

        public void actualizarEstudianteSinGrupo()
        {
            listBox1.Items.Clear();
            foreach (CEstudiante var in this.listaEstu)
            {
                if (var.Grupo.Nombre.Equals(""))
                    listBox1.Items.Add(var);

            }
        }

        private void CrearGrupo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEstudiante temp = null;
            if (!listBox1.SelectedIndex.Equals(-1))
            {
                temp = (CEstudiante)listBox1.SelectedItem;


                foreach (CEstudiante var in this.listaEstu)
                {
                    if (var.CI == temp.CI)
                    {
                        var.Grupo.Nombre = ".";
                        listBox2.Items.Add(var);
                    }
                }

                actualizarEstudianteSinGrupo();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (!checkBox1.Checked)
            {
                this.grupo.Nombre = textBox1.Text;
                this.grupo.Descripcion = textBox2.Text;
            }
            else
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    this.grupo = (CGrupo)comboBox1.SelectedItem;
                   
                }
            }
            
            
            CEstudiante temp = null;


            foreach (object var in listBox2.Items)
            {
                temp = (CEstudiante)var;

                foreach (CEstudiante var1 in this.listaEstu)
                {
                    if (var1.CI == temp.CI)
                    {
                        var1.Grupo = this.grupo;
                        this.grupo.ListEstudiante.Add(var1);
                    }
                }

            }

            if (!checkBox1.Checked)
              this.listGrupos.Add(this.grupo);

        }

        public void limpiarGrupoTentativo()
        {
            foreach (CEstudiante var1 in this.listaEstu)
            {
                if (var1.Grupo.Nombre.Equals("."))
                {
                    var1.Grupo.Nombre = "";
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            limpiarGrupoTentativo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible= false;
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