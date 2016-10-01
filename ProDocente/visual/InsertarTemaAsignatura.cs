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
    public partial class InsertarTemaAsignatura : Form
    {

        private List<CAsignatura> listAsignatura;

        public List<CAsignatura> ListAsignatura
        {
            get { return listAsignatura; }
            set { listAsignatura = value; }
        }






        public InsertarTemaAsignatura(List<CAsignatura> listAsignatura)
        {
            InitializeComponent();
            this.listAsignatura = listAsignatura;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(this.listAsignatura.ToArray());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void actualizarListaTemasAsi()
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex != -1)
            {
                CAsignatura temp = (CAsignatura)comboBox1.SelectedItem;
                listBox1.Items.AddRange(temp.ListTemas.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                CTema nuev = new CTema();
                nuev.Nombre = textBox1.Text;
                nuev.Numero = int.Parse(textBox2.Text);
                nuev.Descripcion = textBox3.Text;
                CAsignatura temp = (CAsignatura)comboBox1.SelectedItem;

                foreach (CAsignatura var in this.listAsignatura)
                {
                    if (var.Nombre == temp.Nombre)
                        temp = var;
                }

                nuev.Asignatura = temp;
                temp.ListTemas.Add(nuev);
                actualizarListaTemasAsi();
            }
        }

        private void InsertarTemaAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListaTemasAsi();
        }
    }
}