using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProDocente.dominio;
using System.IO;
using ProDocente.fichero;

namespace ProDocente.visual
{
    public partial class InsertarEstudiante : Form
    {
        private CEstudiante est;

        public CEstudiante Est
        {
            get { return est; }
            set { est = value; }
        }

        private List<CEstudiante> listEstud;

        public List<CEstudiante> ListEstud
        {
            get { return listEstud; }
            set { listEstud = value; }
        }


        public InsertarEstudiante(CEstudiante est, List<CEstudiante> listEstud)
        {
            InitializeComponent();
            this.est = est;
            this.listEstud = listEstud;
        }

        public Boolean existeEstudiante(String ci)
        {
          Boolean existe = false;
            foreach (CEstudiante var in this.listEstud)
            {
                if (var.CI == ci)
                    existe = true;
            }
            return existe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox1.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {

                if (textBox5.Text.Length == 11)
                {
                    if (!existeEstudiante(textBox5.Text))
                    {
                        this.est.PrimerNombre = textBox1.Text;
                        this.est.SegundoNombre = textBox2.Text;
                        this.est.PrimerApellido = textBox3.Text;
                        this.est.SegundoApellido = textBox4.Text;
                        this.est.CI = textBox5.Text;                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Este CI ya pertenece a un estudiante, por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;

                     }
                }
                else
                {
                    MessageBox.Show("El CI es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(textBox5.Text.Length!=0)
            {
                panel1.BackgroundImage = Image.FromFile(CFichero.DirImg(textBox5.Text));
                MessageBox.Show("Imagen cargada satisfactoriamente, En el futuro no se debe cambiar la imagen de la presente ubicación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe escribir el CI antes de realizar esta operación, y tener copiada la imagen(.jpg) con nombre de CI en la carpeta imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            
            /*Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "imagen files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    panel1.BackgroundImage = Image.FromStream(myStream);
                    myStream.Close();
                }
            }*/

        }
    }
}