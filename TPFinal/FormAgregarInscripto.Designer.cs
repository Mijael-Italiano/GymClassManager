namespace TPFinal
{
    partial class FormAgregarInscripto
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAlta = new Button();
            GbAgregarInscripto = new GroupBox();
            GbAgregarInscripto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(76, 73);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(76, 107);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 3;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(41, 148);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(90, 24);
            btnAlta.TabIndex = 6;
            btnAlta.Text = "Aceptar";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // GbAgregarInscripto
            // 
            GbAgregarInscripto.Controls.Add(label1);
            GbAgregarInscripto.Controls.Add(btnAlta);
            GbAgregarInscripto.Controls.Add(txtNombre);
            GbAgregarInscripto.Controls.Add(txtDNI);
            GbAgregarInscripto.Controls.Add(label3);
            GbAgregarInscripto.Controls.Add(label2);
            GbAgregarInscripto.Controls.Add(txtApellido);
            GbAgregarInscripto.Location = new Point(12, 12);
            GbAgregarInscripto.Name = "GbAgregarInscripto";
            GbAgregarInscripto.Size = new Size(190, 183);
            GbAgregarInscripto.TabIndex = 7;
            GbAgregarInscripto.TabStop = false;
            GbAgregarInscripto.Text = "Agregar Inscripto";
            // 
            // FormAgregarInscripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 206);
            Controls.Add(GbAgregarInscripto);
            Name = "FormAgregarInscripto";
            Text = "FormAgregarInscripto";
            Load += FormAgregarInscripto_Load;
            GbAgregarInscripto.ResumeLayout(false);
            GbAgregarInscripto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label2;
        private Label label3;
        private Button btnAlta;
        private GroupBox GbAgregarInscripto;
    }
}