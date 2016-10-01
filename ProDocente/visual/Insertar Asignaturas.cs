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
    public partial class Insertar_Asignaturas : Form
    {

        private List<CAsignatura> listAsignatura;

        public List<CAsignatura> ListAsigantura
        {
            get { return listAsignatura; }
            set { listAsignatura = value; }
        }

        public Insertar_Asignaturas(List<CAsignatura> listAsignatura)
        {
            InitializeComponent();
            this.listAsignatura = listAsignatura;
        }

        private void Insertar_Asignaturas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAsignatura nueva = new CAsignatura();
            nueva.Nombre = textBox1.Text;
            nueva.Semestre = int.Parse(textBox3.Text);
            nueva.Descripcion = textBox2.Text;
            this.listAsignatura.Add(nueva);
        }
    }
}