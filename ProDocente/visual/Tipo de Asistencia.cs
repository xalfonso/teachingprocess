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
    public partial class Tipo_de_Asistencia : Form
    {

        private List<CTipoAsistencia> listTipoAsistencia;

        public List<CTipoAsistencia> ListTipoAsistencia
        {
            get { return listTipoAsistencia; }
            set { listTipoAsistencia = value; }
        }



        public Tipo_de_Asistencia(List<CTipoAsistencia> listTipoAsistencia)
        {
            InitializeComponent();
            this.listTipoAsistencia = listTipoAsistencia;
            actualizarListado();
        }

        void actualizarListado()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(this.listTipoAsistencia.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length !=-1)
           {
            CTipoAsistencia nuevo = new CTipoAsistencia();
            nuevo.Nombre = textBox1.Text;
            this.listTipoAsistencia.Add(nuevo);
            actualizarListado();
            textBox1.Clear();
           }
            else
                MessageBox.Show("Faltan fatos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}