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
    public partial class Listar_Asignaturas : Form
    {
        public Listar_Asignaturas(List<CAsignatura> listA)
        {
            InitializeComponent();

            dataGridView1.RowCount = listA.Count + 1;
            for (int i = 0; i < listA.Count; i++)
            {
                dataGridView1[0, i].Value = listA[i].Nombre;
                dataGridView1[1, i].Value = listA[i].Disciplina.Nombre;
                dataGridView1[2, i].Value = listA[i].Semestre;
                dataGridView1[3, i].Value = listA[i].Descripcion;
              
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listar_Asignaturas_Load(object sender, EventArgs e)
        {

        }
    }
}