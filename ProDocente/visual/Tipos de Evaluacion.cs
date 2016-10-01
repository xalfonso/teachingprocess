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
    public partial class Tipos_de_Evaluacion : Form
    {

        private List<CTipoEvaluacion> listTipoEva;

        public List<CTipoEvaluacion> ListaTipoEva
        {
            get { return listTipoEva; }
            set { listTipoEva = value; }
        }
	
        public Tipos_de_Evaluacion(List<CTipoEvaluacion> listTipoEva)
        {
            InitializeComponent();
            this.listTipoEva = listTipoEva;
            actualizarListado();
        }
        void actualizarListado()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(this.listTipoEva.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0)
            {
                CTipoEvaluacion nuevo = new CTipoEvaluacion();
                nuevo.Nombre = textBox1.Text;
                this.listTipoEva.Add(nuevo);
                actualizarListado();
                textBox1.Clear();
            }
            else
                MessageBox.Show("Faltan fatos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}