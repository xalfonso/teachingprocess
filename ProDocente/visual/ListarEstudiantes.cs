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
    public partial class ListarEstudiantes : Form
    {
        
        public ListarEstudiantes(List<CEstudiante> listEst)
        {
            InitializeComponent();
            this.listEstudiante = listEst;
            dataGridView1.RowCount = this.listEstudiante.Count + 1;

            for (int i = 0; i < this.listEstudiante.Count; i++)
            {
                dataGridView1[0, i].Value = i + 1;
                dataGridView1[1, i].Value = listEstudiante[i].PrimerNombre;
                dataGridView1[2, i].Value = listEstudiante[i].SegundoNombre;
                dataGridView1[3, i].Value = listEstudiante[i].PrimerApellido;
                dataGridView1[4, i].Value = listEstudiante[i].SegundoApellido;
                dataGridView1[5, i].Value = listEstudiante[i].CI;
                dataGridView1[6, i].Value = listEstudiante[i].Grupo;
            }
        }

        private List<CEstudiante> listEstudiante;

        public List<CEstudiante> ListEstudiante
        {
            get { return listEstudiante; }
            set { listEstudiante = value; }
        }


        private void ListarEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}