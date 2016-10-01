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
    public partial class Tipos_de_Actividad : Form
    {
        private List<CTipoActividad> listTipoAct;

        public List<CTipoActividad> ListTipoAct
        {
            get { return listTipoAct; }
            set { listTipoAct = value; }
        }




        public Tipos_de_Actividad(List<CTipoActividad> listTi)
        {
            InitializeComponent();
            this.listTipoAct = listTi;
            actualizarListado();
        }

        void actualizarListado()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(this.listTipoAct.ToArray());
        }

        private void Tipos_de_Actividad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text.Length != -1)
            {
                CTipoActividad nuevo = new CTipoActividad();
                nuevo.Nombre = textBox1.Text;
                this.listTipoAct.Add(nuevo);
                actualizarListado();
                textBox1.Clear();
            }
            else
                MessageBox.Show("Faltan fatos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}