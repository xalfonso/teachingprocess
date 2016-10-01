using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProDocente.dominio;
using ProDocente.fichero;

namespace ProDocente.visual
{
    public partial class Form1 : Form
    {
       /* private CInstitución inst;

        public CInstitución Insti
        {
            get { return inst; }
            set { inst = value; }
        }*/

        private CInstitucionN inst;

        public CInstitucionN Insti
        {
            get { return inst; }
            set { inst = value; }
        }



        public Form1()
        {
            InitializeComponent();
           // this.Insti = new CInstitución();
            this.inst = new CInstitucionN();
        }

        private void insertarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEstudiante est = new CEstudiante();
            InsertarEstudiante forma = new InsertarEstudiante(est, this.inst.ListEstudiantes);
            if (forma.ShowDialog().Equals(DialogResult.OK))
            {
                Insti.ListEstudiantes.Add(est);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de salvar la información.¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                  CFichero.escribirFicheroBinario(this.inst);
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de cargar la información.¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.inst = (CInstitucionN)CFichero.leerFicheroBinario(this.inst);
            }
           
        }

        private void listarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarEstudiantes form = new ListarEstudiantes(this.Insti.ListEstudiantes);
            form.ShowDialog();
        
        }

        private void crearGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CGrupo nuevoGr = new CGrupo();
            CrearGrupo form = new CrearGrupo(nuevoGr,this.Insti.ListEstudiantes, this.Insti.ListGrupo);
            form.ShowDialog();
           
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verAgregarTipologíaDeClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipos_de_Actividad form = new Tipos_de_Actividad(this.Insti.ListaTipoActividad);
            form.ShowDialog();
        }

        private void verAgregarTipologíaDeClaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tipos_de_Evaluacion form = new Tipos_de_Evaluacion(this.Insti.ListaTipoEva);
            form.ShowDialog();
        }

        private void verAgregarTiposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_de_Resultado form = new Tipo_de_Resultado(this.Insti.ListTipoResultado);
            form.ShowDialog();
        }

        private void agregarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar_Asignaturas forma = new Insertar_Asignaturas(this.inst.ListAsigantura);
            forma.ShowDialog();
        }

        private void listarAsiganaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Asignaturas fork = new Listar_Asignaturas(this.inst.ListAsigantura);
            fork.ShowDialog();
        }

        private void agruparAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDisciplina nuevoDs = new CDisciplina();
            Agrupar_Asignaturas form = new Agrupar_Asignaturas(this.inst.ListDisciplina,this.inst.ListAsigantura,nuevoDs);
            if (form.ShowDialog().Equals(DialogResult.OK))
            {
                this.Insti.ListDisciplina.Add(nuevoDs);
            }
        }

        private void verAgregarTipoDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_de_Asistencia form = new Tipo_de_Asistencia(this.inst.ListTipoAsistencia);
            form.ShowDialog();
        }

        private void pasarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Asistencia form = new Asistencia(this.inst.ListGrupo,this.inst.ListTipoAsistencia,this.inst.ListDisciplina);
            form.ShowDialog();
        }

        private void verAgregarTemaAAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarTemaAsignatura form = new InsertarTemaAsignatura(this.inst.ListAsigantura);
            form.ShowDialog();

        }

        private void verAgregarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar_Actividad form = new Insertar_Actividad(this.inst.ListDisciplina,this.inst.ListaTipoActividad);
            form.ShowDialog();
        }

        private void verRegistroAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Asistencia nufor = new Registro_Asistencia(this.inst.ListGrupo,this.inst.ListDisciplina,this.inst.ListTipoAsistencia);
            nufor.ShowDialog();
        }

        private void verAgregarHabilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar_Habilidad form = new Insertar_Habilidad(this.inst.ListDisciplina);
            form.ShowDialog();
        }

        private void verAgregarEvaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarEvaluacion form = new InsertarEvaluacion(this.inst.ListDisciplina, this.inst.ListaTipoEva);
            form.ShowDialog();
        }

        private void registrarEvaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verEvaluaciónDeEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvaluacionesEstudiante forma = new EvaluacionesEstudiante(this.inst.ListGrupo, this.inst.ListDisciplina);
            forma.ShowDialog();
        }

        private void asociarEvaluacionesAActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asociar_EvaluacionActividad formar = new Asociar_EvaluacionActividad(this.inst.ListDisciplina);
            formar.ShowDialog();
        }

        private void porToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEvaluacionPorEstudiante gfr = new RegistrarEvaluacionPorEstudiante(this.inst.ListEstudiantes, this.inst.ListDisciplina, this.inst.ListTipoResultado);
            gfr.ShowDialog();
        }

        private void porGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEvaluacion forma = new RegistrarEvaluacion(this.inst.ListTipoResultado, this.inst.ListGrupo, this.inst.ListDisciplina);
            forma.ShowDialog();
        }
    }
}