namespace TPFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grillaInscripto = new DataGridView();
            grillaClase = new DataGridView();
            grillaProfesor = new DataGridView();
            btnDetalleClase = new Button();
            btnAgregarInscripto = new Button();
            btnModificarInscripto = new Button();
            btnEliminarInscripto = new Button();
            BtnAsignarClase = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnMostrarPorProfesor = new Button();
            cmbDisciplinaProfesor = new ComboBox();
            label1 = new Label();
            btnVerListaCompleta = new Button();
            button7 = new Button();
            button8 = new Button();
            cmbDisciplinaClase = new ComboBox();
            label3 = new Label();
            btnMostrarListaCompletaClases = new Button();
            button10 = new Button();
            GbInscriptos = new GroupBox();
            GbClases = new GroupBox();
            GbProfesores = new GroupBox();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).BeginInit();
            GbInscriptos.SuspendLayout();
            GbClases.SuspendLayout();
            GbProfesores.SuspendLayout();
            SuspendLayout();
            // 
            // grillaInscripto
            // 
            grillaInscripto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInscripto.Location = new Point(18, 22);
            grillaInscripto.Name = "grillaInscripto";
            grillaInscripto.Size = new Size(584, 302);
            grillaInscripto.TabIndex = 0;
            // 
            // grillaClase
            // 
            grillaClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClase.Location = new Point(18, 22);
            grillaClase.Name = "grillaClase";
            grillaClase.Size = new Size(505, 306);
            grillaClase.TabIndex = 1;
            // 
            // grillaProfesor
            // 
            grillaProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaProfesor.Location = new Point(18, 20);
            grillaProfesor.Name = "grillaProfesor";
            grillaProfesor.Size = new Size(769, 170);
            grillaProfesor.TabIndex = 3;
            // 
            // btnDetalleClase
            // 
            btnDetalleClase.Location = new Point(27, 340);
            btnDetalleClase.Name = "btnDetalleClase";
            btnDetalleClase.Size = new Size(122, 32);
            btnDetalleClase.TabIndex = 4;
            btnDetalleClase.Text = "Ver detalle clase";
            btnDetalleClase.UseVisualStyleBackColor = true;
            btnDetalleClase.Click += btnDetalleClase_Click;
            // 
            // btnAgregarInscripto
            // 
            btnAgregarInscripto.Location = new Point(27, 339);
            btnAgregarInscripto.Name = "btnAgregarInscripto";
            btnAgregarInscripto.Size = new Size(121, 33);
            btnAgregarInscripto.TabIndex = 5;
            btnAgregarInscripto.Text = "Agregar Inscripto";
            btnAgregarInscripto.UseVisualStyleBackColor = true;
            btnAgregarInscripto.Click += btnAgregarInscripto_Click;
            // 
            // btnModificarInscripto
            // 
            btnModificarInscripto.Location = new Point(165, 339);
            btnModificarInscripto.Name = "btnModificarInscripto";
            btnModificarInscripto.Size = new Size(133, 33);
            btnModificarInscripto.TabIndex = 6;
            btnModificarInscripto.Text = "Modificar Inscripto";
            btnModificarInscripto.UseVisualStyleBackColor = true;
            btnModificarInscripto.Click += btnModificarInscripto_Click;
            // 
            // btnEliminarInscripto
            // 
            btnEliminarInscripto.Location = new Point(311, 339);
            btnEliminarInscripto.Name = "btnEliminarInscripto";
            btnEliminarInscripto.Size = new Size(115, 33);
            btnEliminarInscripto.TabIndex = 7;
            btnEliminarInscripto.Text = "Eliminar Inscripto";
            btnEliminarInscripto.UseVisualStyleBackColor = true;
            btnEliminarInscripto.Click += btnEliminarInscripto_Click;
            // 
            // BtnAsignarClase
            // 
            BtnAsignarClase.Location = new Point(444, 339);
            BtnAsignarClase.Name = "BtnAsignarClase";
            BtnAsignarClase.Size = new Size(134, 33);
            BtnAsignarClase.TabIndex = 8;
            BtnAsignarClase.Text = "Asignar clase";
            BtnAsignarClase.UseVisualStyleBackColor = true;
            BtnAsignarClase.Click += BtnAsignarClase_Click;
            // 
            // button1
            // 
            button1.Location = new Point(155, 340);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 9;
            button1.Text = "Agregar clase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(404, 340);
            button2.Name = "button2";
            button2.Size = new Size(119, 33);
            button2.TabIndex = 10;
            button2.Text = "Borrar clase";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 340);
            button3.Name = "button3";
            button3.Size = new Size(107, 32);
            button3.TabIndex = 11;
            button3.Text = "Modificar clase";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(817, 26);
            button4.Name = "button4";
            button4.Size = new Size(112, 33);
            button4.TabIndex = 12;
            button4.Text = "Agregar profesor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(945, 26);
            button5.Name = "button5";
            button5.Size = new Size(121, 33);
            button5.TabIndex = 13;
            button5.Text = "Modificar profesor";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1079, 26);
            button6.Name = "button6";
            button6.Size = new Size(119, 33);
            button6.TabIndex = 14;
            button6.Text = "Eliminar profesor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnMostrarPorProfesor
            // 
            btnMostrarPorProfesor.Location = new Point(945, 154);
            btnMostrarPorProfesor.Name = "btnMostrarPorProfesor";
            btnMostrarPorProfesor.Size = new Size(121, 32);
            btnMostrarPorProfesor.TabIndex = 15;
            btnMostrarPorProfesor.Text = "Mostrar";
            btnMostrarPorProfesor.UseVisualStyleBackColor = true;
            btnMostrarPorProfesor.Click += btnMostrarPorProfesor_Click;
            // 
            // cmbDisciplinaProfesor
            // 
            cmbDisciplinaProfesor.FormattingEnabled = true;
            cmbDisciplinaProfesor.Location = new Point(945, 91);
            cmbDisciplinaProfesor.Name = "cmbDisciplinaProfesor";
            cmbDisciplinaProfesor.Size = new Size(121, 23);
            cmbDisciplinaProfesor.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(817, 91);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 17;
            label1.Text = "Mostrar profesores \r\npor actividad";
            // 
            // btnVerListaCompleta
            // 
            btnVerListaCompleta.Location = new Point(817, 154);
            btnVerListaCompleta.Name = "btnVerListaCompleta";
            btnVerListaCompleta.Size = new Size(113, 32);
            btnVerListaCompleta.TabIndex = 18;
            btnVerListaCompleta.Text = "Ver lista completa";
            btnVerListaCompleta.UseVisualStyleBackColor = true;
            btnVerListaCompleta.Click += btnVerListaCompleta_Click;
            // 
            // button7
            // 
            button7.Location = new Point(27, 387);
            button7.Name = "button7";
            button7.Size = new Size(121, 44);
            button7.TabIndex = 19;
            button7.Text = "Mostrar Alumnos Por Clase";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(165, 387);
            button8.Name = "button8";
            button8.Size = new Size(133, 44);
            button8.TabIndex = 22;
            button8.Text = "Ver lista de inscriptos \r\ncompleta";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // cmbDisciplinaClase
            // 
            cmbDisciplinaClase.FormattingEnabled = true;
            cmbDisciplinaClase.Location = new Point(128, 394);
            cmbDisciplinaClase.Name = "cmbDisciplinaClase";
            cmbDisciplinaClase.Size = new Size(104, 23);
            cmbDisciplinaClase.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 387);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 24;
            label3.Text = "Mostrar clases\r\npor disciplina";
            // 
            // btnMostrarListaCompletaClases
            // 
            btnMostrarListaCompletaClases.Location = new Point(404, 383);
            btnMostrarListaCompletaClases.Name = "btnMostrarListaCompletaClases";
            btnMostrarListaCompletaClases.Size = new Size(119, 48);
            btnMostrarListaCompletaClases.TabIndex = 25;
            btnMostrarListaCompletaClases.Text = "Mostrar lista \r\ncompleta";
            btnMostrarListaCompletaClases.UseVisualStyleBackColor = true;
            btnMostrarListaCompletaClases.Click += btnMostrarListaCompletaClases_Click;
            // 
            // button10
            // 
            button10.Location = new Point(291, 383);
            button10.Name = "button10";
            button10.Size = new Size(107, 48);
            button10.TabIndex = 26;
            button10.Text = "Mostrar por \r\ndisciplina";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // GbInscriptos
            // 
            GbInscriptos.Controls.Add(button9);
            GbInscriptos.Controls.Add(grillaInscripto);
            GbInscriptos.Controls.Add(btnAgregarInscripto);
            GbInscriptos.Controls.Add(btnModificarInscripto);
            GbInscriptos.Controls.Add(btnEliminarInscripto);
            GbInscriptos.Controls.Add(BtnAsignarClase);
            GbInscriptos.Controls.Add(button8);
            GbInscriptos.Controls.Add(button7);
            GbInscriptos.Location = new Point(12, 1);
            GbInscriptos.Name = "GbInscriptos";
            GbInscriptos.Size = new Size(627, 448);
            GbInscriptos.TabIndex = 27;
            GbInscriptos.TabStop = false;
            GbInscriptos.Text = "Inscriptos";
            // 
            // GbClases
            // 
            GbClases.Controls.Add(grillaClase);
            GbClases.Controls.Add(btnDetalleClase);
            GbClases.Controls.Add(button1);
            GbClases.Controls.Add(btnMostrarListaCompletaClases);
            GbClases.Controls.Add(button10);
            GbClases.Controls.Add(button3);
            GbClases.Controls.Add(button2);
            GbClases.Controls.Add(cmbDisciplinaClase);
            GbClases.Controls.Add(label3);
            GbClases.Location = new Point(687, 1);
            GbClases.Name = "GbClases";
            GbClases.Size = new Size(551, 448);
            GbClases.TabIndex = 28;
            GbClases.TabStop = false;
            GbClases.Text = "Clases Disponibles";
            // 
            // GbProfesores
            // 
            GbProfesores.Controls.Add(grillaProfesor);
            GbProfesores.Controls.Add(label1);
            GbProfesores.Controls.Add(cmbDisciplinaProfesor);
            GbProfesores.Controls.Add(btnVerListaCompleta);
            GbProfesores.Controls.Add(button4);
            GbProfesores.Controls.Add(btnMostrarPorProfesor);
            GbProfesores.Controls.Add(button6);
            GbProfesores.Controls.Add(button5);
            GbProfesores.Location = new Point(12, 466);
            GbProfesores.Name = "GbProfesores";
            GbProfesores.Size = new Size(1226, 218);
            GbProfesores.TabIndex = 29;
            GbProfesores.TabStop = false;
            GbProfesores.Text = "Profesores";
            // 
            // button9
            // 
            button9.Location = new Point(311, 387);
            button9.Name = "button9";
            button9.Size = new Size(115, 44);
            button9.TabIndex = 23;
            button9.Text = "Mostrar Alumnos sin Clase";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 718);
            Controls.Add(GbProfesores);
            Controls.Add(GbClases);
            Controls.Add(GbInscriptos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInscripto).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaClase).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaProfesor).EndInit();
            GbInscriptos.ResumeLayout(false);
            GbClases.ResumeLayout(false);
            GbClases.PerformLayout();
            GbProfesores.ResumeLayout(false);
            GbProfesores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaInscripto;
        private DataGridView grillaClase;
        private DataGridView grillaProfesor;
        private Button btnDetalleClase;
        private Button btnAgregarInscripto;
        private Button btnModificarInscripto;
        private Button btnEliminarInscripto;
        private Button BtnAsignarClase;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnMostrarPorProfesor;
        private ComboBox cmbDisciplinaProfesor;
        private Label label1;
        private Button btnVerListaCompleta;
        private Button button7;
        private Button button8;
        private ComboBox cmbDisciplinaClase;
        private Label label3;
        private Button btnMostrarListaCompletaClases;
        private Button button10;
        private GroupBox GbInscriptos;
        private GroupBox GbClases;
        private GroupBox GbProfesores;
        private Button button9;
    }
}
