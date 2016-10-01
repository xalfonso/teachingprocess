namespace ProDocente.visual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarTipologíaDeClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarTipoDeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarEvaluacionesAActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operEvaluaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarTipologíaDeClaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarTiposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarHabilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarEvaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEvaluaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEvaluaciónDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAsiganaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agruparAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgregarTemaAAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.operActividadToolStripMenuItem,
            this.operEvaluaciónToolStripMenuItem,
            this.operDisciplinaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.cargarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarEstudianteToolStripMenuItem,
            this.listarEstudianteToolStripMenuItem,
            this.crearGruposToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.operacionesToolStripMenuItem.Text = "Oper.Estudiante";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // insertarEstudianteToolStripMenuItem
            // 
            this.insertarEstudianteToolStripMenuItem.Name = "insertarEstudianteToolStripMenuItem";
            this.insertarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarEstudianteToolStripMenuItem.Text = "Insertar Estudiante";
            this.insertarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.insertarEstudianteToolStripMenuItem_Click);
            // 
            // listarEstudianteToolStripMenuItem
            // 
            this.listarEstudianteToolStripMenuItem.Name = "listarEstudianteToolStripMenuItem";
            this.listarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarEstudianteToolStripMenuItem.Text = "Listar Estudiante";
            this.listarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.listarEstudianteToolStripMenuItem_Click);
            // 
            // crearGruposToolStripMenuItem
            // 
            this.crearGruposToolStripMenuItem.Name = "crearGruposToolStripMenuItem";
            this.crearGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearGruposToolStripMenuItem.Text = "Agrupar Estudiantes";
            this.crearGruposToolStripMenuItem.Click += new System.EventHandler(this.crearGruposToolStripMenuItem_Click);
            // 
            // operActividadToolStripMenuItem
            // 
            this.operActividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAgregarTipologíaDeClaseToolStripMenuItem,
            this.verAgregarTipoDeAsistenciaToolStripMenuItem,
            this.pasarAsistenciaToolStripMenuItem,
            this.verAgregarActividadToolStripMenuItem,
            this.verRegistroAsistenciaToolStripMenuItem,
            this.asociarEvaluacionesAActividadToolStripMenuItem});
            this.operActividadToolStripMenuItem.Name = "operActividadToolStripMenuItem";
            this.operActividadToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.operActividadToolStripMenuItem.Text = "Oper. Actividad";
            // 
            // verAgregarTipologíaDeClaseToolStripMenuItem
            // 
            this.verAgregarTipologíaDeClaseToolStripMenuItem.Name = "verAgregarTipologíaDeClaseToolStripMenuItem";
            this.verAgregarTipologíaDeClaseToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verAgregarTipologíaDeClaseToolStripMenuItem.Text = "Ver/Agregar Tipología de Clase";
            this.verAgregarTipologíaDeClaseToolStripMenuItem.Click += new System.EventHandler(this.verAgregarTipologíaDeClaseToolStripMenuItem_Click);
            // 
            // verAgregarTipoDeAsistenciaToolStripMenuItem
            // 
            this.verAgregarTipoDeAsistenciaToolStripMenuItem.Name = "verAgregarTipoDeAsistenciaToolStripMenuItem";
            this.verAgregarTipoDeAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verAgregarTipoDeAsistenciaToolStripMenuItem.Text = "Ver/Agregar Tipo de Asistencia";
            this.verAgregarTipoDeAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.verAgregarTipoDeAsistenciaToolStripMenuItem_Click);
            // 
            // pasarAsistenciaToolStripMenuItem
            // 
            this.pasarAsistenciaToolStripMenuItem.Name = "pasarAsistenciaToolStripMenuItem";
            this.pasarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.pasarAsistenciaToolStripMenuItem.Text = "Pasar Asistencia";
            this.pasarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.pasarAsistenciaToolStripMenuItem_Click);
            // 
            // verAgregarActividadToolStripMenuItem
            // 
            this.verAgregarActividadToolStripMenuItem.Name = "verAgregarActividadToolStripMenuItem";
            this.verAgregarActividadToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verAgregarActividadToolStripMenuItem.Text = "Ver/Agregar Actividad";
            this.verAgregarActividadToolStripMenuItem.Click += new System.EventHandler(this.verAgregarActividadToolStripMenuItem_Click);
            // 
            // verRegistroAsistenciaToolStripMenuItem
            // 
            this.verRegistroAsistenciaToolStripMenuItem.Name = "verRegistroAsistenciaToolStripMenuItem";
            this.verRegistroAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.verRegistroAsistenciaToolStripMenuItem.Text = "Ver Registro Asistencia";
            this.verRegistroAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.verRegistroAsistenciaToolStripMenuItem_Click);
            // 
            // asociarEvaluacionesAActividadToolStripMenuItem
            // 
            this.asociarEvaluacionesAActividadToolStripMenuItem.Name = "asociarEvaluacionesAActividadToolStripMenuItem";
            this.asociarEvaluacionesAActividadToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.asociarEvaluacionesAActividadToolStripMenuItem.Text = "Asociar Evaluaciones a Actividad";
            this.asociarEvaluacionesAActividadToolStripMenuItem.Click += new System.EventHandler(this.asociarEvaluacionesAActividadToolStripMenuItem_Click);
            // 
            // operEvaluaciónToolStripMenuItem
            // 
            this.operEvaluaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAgregarTipologíaDeClaseToolStripMenuItem1,
            this.verAgregarTiposDeToolStripMenuItem,
            this.verAgregarHabilidadesToolStripMenuItem,
            this.verAgregarEvaluacionesToolStripMenuItem,
            this.registrarEvaluaciónToolStripMenuItem,
            this.verEvaluaciónDeEstudianteToolStripMenuItem});
            this.operEvaluaciónToolStripMenuItem.Name = "operEvaluaciónToolStripMenuItem";
            this.operEvaluaciónToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.operEvaluaciónToolStripMenuItem.Text = "Oper. Evaluación";
            // 
            // verAgregarTipologíaDeClaseToolStripMenuItem1
            // 
            this.verAgregarTipologíaDeClaseToolStripMenuItem1.Name = "verAgregarTipologíaDeClaseToolStripMenuItem1";
            this.verAgregarTipologíaDeClaseToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.verAgregarTipologíaDeClaseToolStripMenuItem1.Text = "Ver/Agregar Tipos de Evaluaciones";
            this.verAgregarTipologíaDeClaseToolStripMenuItem1.Click += new System.EventHandler(this.verAgregarTipologíaDeClaseToolStripMenuItem1_Click);
            // 
            // verAgregarTiposDeToolStripMenuItem
            // 
            this.verAgregarTiposDeToolStripMenuItem.Name = "verAgregarTiposDeToolStripMenuItem";
            this.verAgregarTiposDeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.verAgregarTiposDeToolStripMenuItem.Text = "Ver/Agregar Tipos de Resultados";
            this.verAgregarTiposDeToolStripMenuItem.Click += new System.EventHandler(this.verAgregarTiposDeToolStripMenuItem_Click);
            // 
            // verAgregarHabilidadesToolStripMenuItem
            // 
            this.verAgregarHabilidadesToolStripMenuItem.Name = "verAgregarHabilidadesToolStripMenuItem";
            this.verAgregarHabilidadesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.verAgregarHabilidadesToolStripMenuItem.Text = "Ver/Agregar Habilidades";
            this.verAgregarHabilidadesToolStripMenuItem.Click += new System.EventHandler(this.verAgregarHabilidadesToolStripMenuItem_Click);
            // 
            // verAgregarEvaluacionesToolStripMenuItem
            // 
            this.verAgregarEvaluacionesToolStripMenuItem.Name = "verAgregarEvaluacionesToolStripMenuItem";
            this.verAgregarEvaluacionesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.verAgregarEvaluacionesToolStripMenuItem.Text = "Ver/Agregar Evaluaciones";
            this.verAgregarEvaluacionesToolStripMenuItem.Click += new System.EventHandler(this.verAgregarEvaluacionesToolStripMenuItem_Click);
            // 
            // registrarEvaluaciónToolStripMenuItem
            // 
            this.registrarEvaluaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porGrupoToolStripMenuItem,
            this.porToolStripMenuItem});
            this.registrarEvaluaciónToolStripMenuItem.Name = "registrarEvaluaciónToolStripMenuItem";
            this.registrarEvaluaciónToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.registrarEvaluaciónToolStripMenuItem.Text = "Registrar Evaluación";
            this.registrarEvaluaciónToolStripMenuItem.Click += new System.EventHandler(this.registrarEvaluaciónToolStripMenuItem_Click);
            // 
            // porGrupoToolStripMenuItem
            // 
            this.porGrupoToolStripMenuItem.Name = "porGrupoToolStripMenuItem";
            this.porGrupoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porGrupoToolStripMenuItem.Text = "Por Grupo";
            this.porGrupoToolStripMenuItem.Click += new System.EventHandler(this.porGrupoToolStripMenuItem_Click);
            // 
            // porToolStripMenuItem
            // 
            this.porToolStripMenuItem.Name = "porToolStripMenuItem";
            this.porToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porToolStripMenuItem.Text = "Por Estudiante";
            this.porToolStripMenuItem.Click += new System.EventHandler(this.porToolStripMenuItem_Click);
            // 
            // verEvaluaciónDeEstudianteToolStripMenuItem
            // 
            this.verEvaluaciónDeEstudianteToolStripMenuItem.Name = "verEvaluaciónDeEstudianteToolStripMenuItem";
            this.verEvaluaciónDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.verEvaluaciónDeEstudianteToolStripMenuItem.Text = "Ver Evaluación de Estudiante";
            this.verEvaluaciónDeEstudianteToolStripMenuItem.Click += new System.EventHandler(this.verEvaluaciónDeEstudianteToolStripMenuItem_Click);
            // 
            // operDisciplinaToolStripMenuItem
            // 
            this.operDisciplinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAsignaturaToolStripMenuItem,
            this.listarAsiganaturasToolStripMenuItem,
            this.agruparAsignaturasToolStripMenuItem,
            this.verAgregarTemaAAsignaturaToolStripMenuItem});
            this.operDisciplinaToolStripMenuItem.Name = "operDisciplinaToolStripMenuItem";
            this.operDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.operDisciplinaToolStripMenuItem.Text = "Oper. Disciplina";
            // 
            // agregarAsignaturaToolStripMenuItem
            // 
            this.agregarAsignaturaToolStripMenuItem.Name = "agregarAsignaturaToolStripMenuItem";
            this.agregarAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.agregarAsignaturaToolStripMenuItem.Text = "Agregar Asignatura";
            this.agregarAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.agregarAsignaturaToolStripMenuItem_Click);
            // 
            // listarAsiganaturasToolStripMenuItem
            // 
            this.listarAsiganaturasToolStripMenuItem.Name = "listarAsiganaturasToolStripMenuItem";
            this.listarAsiganaturasToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.listarAsiganaturasToolStripMenuItem.Text = "Listar Asignaturas";
            this.listarAsiganaturasToolStripMenuItem.Click += new System.EventHandler(this.listarAsiganaturasToolStripMenuItem_Click);
            // 
            // agruparAsignaturasToolStripMenuItem
            // 
            this.agruparAsignaturasToolStripMenuItem.Name = "agruparAsignaturasToolStripMenuItem";
            this.agruparAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.agruparAsignaturasToolStripMenuItem.Text = "Agrupar Asignaturas";
            this.agruparAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.agruparAsignaturasToolStripMenuItem_Click);
            // 
            // verAgregarTemaAAsignaturaToolStripMenuItem
            // 
            this.verAgregarTemaAAsignaturaToolStripMenuItem.Name = "verAgregarTemaAAsignaturaToolStripMenuItem";
            this.verAgregarTemaAAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.verAgregarTemaAAsignaturaToolStripMenuItem.Text = "Ver/Agregar Tema a Asignatura";
            this.verAgregarTemaAAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.verAgregarTemaAAsignaturaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eduardo Alfonso Sánchez";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leydis Esther Garzón Giro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso Docente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarTipologíaDeClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operEvaluaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarTipologíaDeClaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verAgregarTiposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAsiganaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agruparAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarTipoDeAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarTemaAAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRegistroAsistenciaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem verAgregarHabilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgregarEvaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEvaluaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEvaluaciónDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarEvaluacionesAActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porToolStripMenuItem;
    }
}

