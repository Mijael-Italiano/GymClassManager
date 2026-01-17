namespace TPFinal
{
    partial class FormAgregarClase
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
            cmbAgregarClase = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtAgregarCuotaMensual = new TextBox();
            label3 = new Label();
            btnAgregarClase = new Button();
            txtAgregarMaximoInscriptos = new TextBox();
            GbAgregarClase = new GroupBox();
            GbAgregarClase.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAgregarClase
            // 
            cmbAgregarClase.FormattingEnabled = true;
            cmbAgregarClase.Location = new Point(142, 35);
            cmbAgregarClase.Name = "cmbAgregarClase";
            cmbAgregarClase.Size = new Size(121, 23);
            cmbAgregarClase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Clase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 72);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Maximo de inscriptos";
            // 
            // txtAgregarCuotaMensual
            // 
            txtAgregarCuotaMensual.Location = new Point(142, 93);
            txtAgregarCuotaMensual.Name = "txtAgregarCuotaMensual";
            txtAgregarCuotaMensual.Size = new Size(121, 23);
            txtAgregarCuotaMensual.TabIndex = 4;
            txtAgregarCuotaMensual.KeyPress += txtAgregarCuotaMensual_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 101);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Cuota mensual";
            // 
            // btnAgregarClase
            // 
            btnAgregarClase.Location = new Point(74, 134);
            btnAgregarClase.Name = "btnAgregarClase";
            btnAgregarClase.Size = new Size(113, 31);
            btnAgregarClase.TabIndex = 7;
            btnAgregarClase.Text = "Agregar clase";
            btnAgregarClase.UseVisualStyleBackColor = true;
            btnAgregarClase.Click += btnAgregarClase_Click;
            // 
            // txtAgregarMaximoInscriptos
            // 
            txtAgregarMaximoInscriptos.Location = new Point(142, 64);
            txtAgregarMaximoInscriptos.Name = "txtAgregarMaximoInscriptos";
            txtAgregarMaximoInscriptos.Size = new Size(121, 23);
            txtAgregarMaximoInscriptos.TabIndex = 8;
            txtAgregarMaximoInscriptos.KeyPress += txtAgregarMaximoInscriptos_KeyPress;
            // 
            // GbAgregarClase
            // 
            GbAgregarClase.Controls.Add(cmbAgregarClase);
            GbAgregarClase.Controls.Add(btnAgregarClase);
            GbAgregarClase.Controls.Add(txtAgregarMaximoInscriptos);
            GbAgregarClase.Controls.Add(txtAgregarCuotaMensual);
            GbAgregarClase.Controls.Add(label3);
            GbAgregarClase.Controls.Add(label1);
            GbAgregarClase.Controls.Add(label2);
            GbAgregarClase.Location = new Point(12, 12);
            GbAgregarClase.Name = "GbAgregarClase";
            GbAgregarClase.Size = new Size(277, 192);
            GbAgregarClase.TabIndex = 9;
            GbAgregarClase.TabStop = false;
            GbAgregarClase.Text = "Agregar Clase";
            // 
            // FormAgregarClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 214);
            Controls.Add(GbAgregarClase);
            Name = "FormAgregarClase";
            Text = "gr";
            Load += FormAgregarClase_Load;
            GbAgregarClase.ResumeLayout(false);
            GbAgregarClase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbAgregarClase;
        private Label label1;
        private Label label2;
        private TextBox txtAgregarCuotaMensual;
        private Label label3;
        private Button btnAgregarClase;
        private TextBox txtAgregarMaximoInscriptos;
        private GroupBox GbAgregarClase;
    }
}