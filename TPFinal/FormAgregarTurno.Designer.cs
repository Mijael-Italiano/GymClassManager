namespace TPFinal
{
    partial class FormAgregarTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarTurno = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbAgregarTurnoDia = new ComboBox();
            cmbAgregarTurnoIdProfesor = new ComboBox();
            GbAgregarTurno = new GroupBox();
            agregarFinalizacionTurno = new DateTimePicker();
            agregarInicioTurno = new DateTimePicker();
            GbAgregarTurno.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarTurno
            // 
            btnAgregarTurno.Location = new Point(93, 170);
            btnAgregarTurno.Name = "btnAgregarTurno";
            btnAgregarTurno.Size = new Size(101, 31);
            btnAgregarTurno.TabIndex = 0;
            btnAgregarTurno.Text = "Agregar";
            btnAgregarTurno.UseVisualStyleBackColor = true;
            btnAgregarTurno.Click += btnAgregarTurno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 43);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 76);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Finalizacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 140);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Profesor Apellido";
            // 
            // cmbAgregarTurnoDia
            // 
            cmbAgregarTurnoDia.FormattingEnabled = true;
            cmbAgregarTurnoDia.Location = new Point(152, 35);
            cmbAgregarTurnoDia.Name = "cmbAgregarTurnoDia";
            cmbAgregarTurnoDia.Size = new Size(121, 23);
            cmbAgregarTurnoDia.TabIndex = 7;
            // 
            // cmbAgregarTurnoIdProfesor
            // 
            cmbAgregarTurnoIdProfesor.FormattingEnabled = true;
            cmbAgregarTurnoIdProfesor.Location = new Point(152, 132);
            cmbAgregarTurnoIdProfesor.Name = "cmbAgregarTurnoIdProfesor";
            cmbAgregarTurnoIdProfesor.Size = new Size(121, 23);
            cmbAgregarTurnoIdProfesor.TabIndex = 8;
            // 
            // GbAgregarTurno
            // 
            GbAgregarTurno.Controls.Add(agregarFinalizacionTurno);
            GbAgregarTurno.Controls.Add(agregarInicioTurno);
            GbAgregarTurno.Controls.Add(label1);
            GbAgregarTurno.Controls.Add(btnAgregarTurno);
            GbAgregarTurno.Controls.Add(cmbAgregarTurnoIdProfesor);
            GbAgregarTurno.Controls.Add(cmbAgregarTurnoDia);
            GbAgregarTurno.Controls.Add(label4);
            GbAgregarTurno.Controls.Add(label2);
            GbAgregarTurno.Controls.Add(label3);
            GbAgregarTurno.Location = new Point(12, 12);
            GbAgregarTurno.Name = "GbAgregarTurno";
            GbAgregarTurno.Size = new Size(299, 220);
            GbAgregarTurno.TabIndex = 9;
            GbAgregarTurno.TabStop = false;
            GbAgregarTurno.Text = "Agregar Turno";
            // 
            // agregarFinalizacionTurno
            // 
            agregarFinalizacionTurno.Location = new Point(152, 100);
            agregarFinalizacionTurno.Name = "agregarFinalizacionTurno";
            agregarFinalizacionTurno.Size = new Size(121, 23);
            agregarFinalizacionTurno.TabIndex = 10;
            // 
            // agregarInicioTurno
            // 
            agregarInicioTurno.Location = new Point(152, 68);
            agregarInicioTurno.Name = "agregarInicioTurno";
            agregarInicioTurno.Size = new Size(121, 23);
            agregarInicioTurno.TabIndex = 9;
            // 
            // FormAgregarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 243);
            Controls.Add(GbAgregarTurno);
            Name = "FormAgregarTurno";
            Text = "FormAgregarTurno";
            Load += FormAgregarTurno_Load;
            GbAgregarTurno.ResumeLayout(false);
            GbAgregarTurno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarTurno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbAgregarTurnoDia;
        private ComboBox cmbAgregarTurnoIdProfesor;
        private GroupBox GbAgregarTurno;
        private DateTimePicker agregarInicioTurno;
        private DateTimePicker agregarFinalizacionTurno;
    }
}