namespace TPFinal
{
    partial class FormModificarDetalleClase
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbModificarDia = new ComboBox();
            cmbProfesorModificar = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            GbModificarTurno = new GroupBox();
            horarioFinModificar = new DateTimePicker();
            horarioInicioModificar = new DateTimePicker();
            GbModificarTurno.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Horario inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Horario fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Dia";
            // 
            // cmbModificarDia
            // 
            cmbModificarDia.FormattingEnabled = true;
            cmbModificarDia.Location = new Point(104, 100);
            cmbModificarDia.Name = "cmbModificarDia";
            cmbModificarDia.Size = new Size(121, 23);
            cmbModificarDia.TabIndex = 5;
            // 
            // cmbProfesorModificar
            // 
            cmbProfesorModificar.FormattingEnabled = true;
            cmbProfesorModificar.Location = new Point(104, 135);
            cmbProfesorModificar.Name = "cmbProfesorModificar";
            cmbProfesorModificar.Size = new Size(121, 23);
            cmbProfesorModificar.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 143);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Profesor";
            // 
            // button1
            // 
            button1.Location = new Point(64, 173);
            button1.Name = "button1";
            button1.Size = new Size(83, 26);
            button1.TabIndex = 8;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GbModificarTurno
            // 
            GbModificarTurno.Controls.Add(horarioFinModificar);
            GbModificarTurno.Controls.Add(horarioInicioModificar);
            GbModificarTurno.Controls.Add(label1);
            GbModificarTurno.Controls.Add(button1);
            GbModificarTurno.Controls.Add(cmbProfesorModificar);
            GbModificarTurno.Controls.Add(label4);
            GbModificarTurno.Controls.Add(label2);
            GbModificarTurno.Controls.Add(cmbModificarDia);
            GbModificarTurno.Controls.Add(label3);
            GbModificarTurno.Location = new Point(12, 12);
            GbModificarTurno.Name = "GbModificarTurno";
            GbModificarTurno.Size = new Size(245, 214);
            GbModificarTurno.TabIndex = 9;
            GbModificarTurno.TabStop = false;
            GbModificarTurno.Text = "Modificar Turno";
            // 
            // horarioFinModificar
            // 
            horarioFinModificar.Location = new Point(104, 61);
            horarioFinModificar.Name = "horarioFinModificar";
            horarioFinModificar.Size = new Size(121, 23);
            horarioFinModificar.TabIndex = 10;
            // 
            // horarioInicioModificar
            // 
            horarioInicioModificar.Location = new Point(104, 22);
            horarioInicioModificar.Name = "horarioInicioModificar";
            horarioInicioModificar.Size = new Size(121, 23);
            horarioInicioModificar.TabIndex = 10;
            // 
            // FormModificarDetalleClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 236);
            Controls.Add(GbModificarTurno);
            Name = "FormModificarDetalleClase";
            Text = "FormModificarDetalleClase";
            Load += FormModificarDetalleClase_Load;
            GbModificarTurno.ResumeLayout(false);
            GbModificarTurno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbModificarDia;
        private ComboBox cmbProfesorModificar;
        private Label label4;
        private Button button1;
        private GroupBox GbModificarTurno;
        private DateTimePicker horarioFinModificar;
        private DateTimePicker horarioInicioModificar;
    }
}