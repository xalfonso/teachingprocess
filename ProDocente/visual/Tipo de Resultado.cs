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
    public partial class Tipo_de_Resultado : Form
    {

        private List<CTipoResultado> listTipoResutado;

        public List<CTipoResultado> ListTipoResultado
        {
            get { return listTipoResutado; }
            set { listTipoResutado = value; }
        }


        public Tipo_de_Resultado(List<CTipoResultado> listTipoResutado)
        {
            InitializeComponent();
            this.listTipoResutado = listTipoResutado;
            actualizarListado();
        }

        void actualizarListado()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(this.listTipoResutado.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != -1)
            {
                CTipoResultado nuevo = new CTipoResultado();
                nuevo.Nombre = textBox1.Text;
                this.listTipoResutado.Add(nuevo);
                actualizarListado();
                textBox1.Clear();
            }
            else
                MessageBox.Show("Faltan fatos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}