namespace TPFinal
{
    partial class FormModificarClase
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
            txtModificarCuota = new TextBox();
            txtModificarMaximoInscriptos = new TextBox();
            button1 = new Button();
            GbModificarClase = new GroupBox();
            GbModificarClase.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuota mensual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Maximo inscriptos";
            // 
            // txtModificarCuota
            // 
            txtModificarCuota.Location = new Point(135, 33);
            txtModificarCuota.Name = "txtModificarCuota";
            txtModificarCuota.Size = new Size(100, 23);
            txtModificarCuota.TabIndex = 3;
            txtModificarCuota.KeyPress += txtModificarCuota_KeyPress;
            // 
            // txtModificarMaximoInscriptos
            // 
            txtModificarMaximoInscriptos.Location = new Point(135, 65);
            txtModificarMaximoInscriptos.Name = "txtModificarMaximoInscriptos";
            txtModificarMaximoInscriptos.Size = new Size(100, 23);
            txtModificarMaximoInscriptos.TabIndex = 4;
            txtModificarMaximoInscriptos.KeyPress += txtModificarMaximoInscriptos_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(77, 104);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 6;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GbModificarClase
            // 
            GbModificarClase.Controls.Add(label1);
            GbModificarClase.Controls.Add(button1);
            GbModificarClase.Controls.Add(txtModificarCuota);
            GbModificarClase.Controls.Add(txtModificarMaximoInscriptos);
            GbModificarClase.Controls.Add(label2);
            GbModificarClase.Location = new Point(12, 12);
            GbModificarClase.Name = "GbModificarClase";
            GbModificarClase.Size = new Size(256, 149);
            GbModificarClase.TabIndex = 7;
            GbModificarClase.TabStop = false;
            GbModificarClase.Text = "Modificar Clase";
            // 
            // FormModificarClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 174);
            Controls.Add(GbModificarClase);
            Name = "FormModificarClase";
            Text = "FormModificarClase";
            Load += FormModificarClase_Load;
            GbModificarClase.ResumeLayout(false);
            GbModificarClase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtModificarCuota;
        private TextBox txtModificarMaximoInscriptos;
        private Button button1;
        private GroupBox GbModificarClase;
    }
}