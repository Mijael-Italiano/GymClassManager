namespace TPFinal
{
    partial class FormModificarInscripto
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
            txtModificarDNI = new TextBox();
            txtModificarNombre = new TextBox();
            txtModificarApellido = new TextBox();
            btnModificar = new Button();
            GbModificarInscripto = new GroupBox();
            GbModificarInscripto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // txtModificarDNI
            // 
            txtModificarDNI.Location = new Point(68, 108);
            txtModificarDNI.Name = "txtModificarDNI";
            txtModificarDNI.Size = new Size(100, 23);
            txtModificarDNI.TabIndex = 3;
            txtModificarDNI.KeyPress += txtModificarDNI_KeyPress;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Location = new Point(68, 36);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(100, 23);
            txtModificarNombre.TabIndex = 4;
            // 
            // txtModificarApellido
            // 
            txtModificarApellido.Location = new Point(68, 70);
            txtModificarApellido.Name = "txtModificarApellido";
            txtModificarApellido.Size = new Size(100, 23);
            txtModificarApellido.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(37, 148);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // GbModificarInscripto
            // 
            GbModificarInscripto.Controls.Add(label1);
            GbModificarInscripto.Controls.Add(btnModificar);
            GbModificarInscripto.Controls.Add(txtModificarNombre);
            GbModificarInscripto.Controls.Add(txtModificarDNI);
            GbModificarInscripto.Controls.Add(txtModificarApellido);
            GbModificarInscripto.Controls.Add(label3);
            GbModificarInscripto.Controls.Add(label2);
            GbModificarInscripto.Location = new Point(12, 12);
            GbModificarInscripto.Name = "GbModificarInscripto";
            GbModificarInscripto.Size = new Size(181, 188);
            GbModificarInscripto.TabIndex = 7;
            GbModificarInscripto.TabStop = false;
            GbModificarInscripto.Text = "Modificar Inscripto";
            // 
            // FormModificarInscripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 214);
            Controls.Add(GbModificarInscripto);
            Name = "FormModificarInscripto";
            Text = "FormModificarInscripto";
            Load += FormModificarInscripto_Load;
            GbModificarInscripto.ResumeLayout(false);
            GbModificarInscripto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtModificarDNI;
        private TextBox txtModificarNombre;
        private TextBox txtModificarApellido;
        private Button btnModificar;
        private GroupBox GbModificarInscripto;
    }
}