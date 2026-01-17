namespace TPFinal
{
    partial class FormAgregarProfesor
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
            button1 = new Button();
            label4 = new Label();
            txtAgregarProfesorNombre = new TextBox();
            txtAgregarProfesorApellido = new TextBox();
            txtAgregarProfesorDNI = new TextBox();
            cmbAgregarProfesorDisciplina = new ComboBox();
            txtAgregarProfesorSueldo = new TextBox();
            label5 = new Label();
            GbAgregarProfesor = new GroupBox();
            GbAgregarProfesor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 91);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // button1
            // 
            button1.Location = new Point(40, 185);
            button1.Name = "button1";
            button1.Size = new Size(137, 27);
            button1.TabIndex = 3;
            button1.Text = "Agregar profesor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 124);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Disciplina";
            // 
            // txtAgregarProfesorNombre
            // 
            txtAgregarProfesorNombre.Location = new Point(103, 23);
            txtAgregarProfesorNombre.Name = "txtAgregarProfesorNombre";
            txtAgregarProfesorNombre.Size = new Size(117, 23);
            txtAgregarProfesorNombre.TabIndex = 5;
            // 
            // txtAgregarProfesorApellido
            // 
            txtAgregarProfesorApellido.Location = new Point(103, 54);
            txtAgregarProfesorApellido.Name = "txtAgregarProfesorApellido";
            txtAgregarProfesorApellido.Size = new Size(117, 23);
            txtAgregarProfesorApellido.TabIndex = 6;
            // 
            // txtAgregarProfesorDNI
            // 
            txtAgregarProfesorDNI.Location = new Point(103, 83);
            txtAgregarProfesorDNI.Name = "txtAgregarProfesorDNI";
            txtAgregarProfesorDNI.Size = new Size(117, 23);
            txtAgregarProfesorDNI.TabIndex = 7;
            txtAgregarProfesorDNI.KeyPress += txtAgregarProfesorDNI_KeyPress;
            // 
            // cmbAgregarProfesorDisciplina
            // 
            cmbAgregarProfesorDisciplina.FormattingEnabled = true;
            cmbAgregarProfesorDisciplina.Location = new Point(103, 116);
            cmbAgregarProfesorDisciplina.Name = "cmbAgregarProfesorDisciplina";
            cmbAgregarProfesorDisciplina.Size = new Size(121, 23);
            cmbAgregarProfesorDisciplina.TabIndex = 8;
            // 
            // txtAgregarProfesorSueldo
            // 
            txtAgregarProfesorSueldo.Location = new Point(103, 146);
            txtAgregarProfesorSueldo.Name = "txtAgregarProfesorSueldo";
            txtAgregarProfesorSueldo.Size = new Size(117, 23);
            txtAgregarProfesorSueldo.TabIndex = 9;
            txtAgregarProfesorSueldo.KeyPress += txtAgregarProfesorSueldo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 154);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Sueldo";
            // 
            // GbAgregarProfesor
            // 
            GbAgregarProfesor.Controls.Add(label1);
            GbAgregarProfesor.Controls.Add(button1);
            GbAgregarProfesor.Controls.Add(txtAgregarProfesorSueldo);
            GbAgregarProfesor.Controls.Add(label5);
            GbAgregarProfesor.Controls.Add(txtAgregarProfesorNombre);
            GbAgregarProfesor.Controls.Add(label2);
            GbAgregarProfesor.Controls.Add(cmbAgregarProfesorDisciplina);
            GbAgregarProfesor.Controls.Add(txtAgregarProfesorApellido);
            GbAgregarProfesor.Controls.Add(label4);
            GbAgregarProfesor.Controls.Add(txtAgregarProfesorDNI);
            GbAgregarProfesor.Controls.Add(label3);
            GbAgregarProfesor.Location = new Point(12, 12);
            GbAgregarProfesor.Name = "GbAgregarProfesor";
            GbAgregarProfesor.Size = new Size(243, 228);
            GbAgregarProfesor.TabIndex = 11;
            GbAgregarProfesor.TabStop = false;
            GbAgregarProfesor.Text = "Agregar Profesor";
            // 
            // FormAgregarProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 255);
            Controls.Add(GbAgregarProfesor);
            Name = "FormAgregarProfesor";
            Text = "FormAgregarProfesor";
            Load += FormAgregarProfesor_Load;
            GbAgregarProfesor.ResumeLayout(false);
            GbAgregarProfesor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox txtAgregarProfesorNombre;
        private TextBox txtAgregarProfesorApellido;
        private TextBox txtAgregarProfesorDNI;
        private ComboBox cmbAgregarProfesorDisciplina;
        private TextBox txtAgregarProfesorSueldo;
        private Label label5;
        private GroupBox GbAgregarProfesor;
    }
}