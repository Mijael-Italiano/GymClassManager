namespace TPFinal
{
    partial class FormDetalleClase
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
            grillaClaseDetalle = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            GbDetalleClase = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).BeginInit();
            GbDetalleClase.SuspendLayout();
            SuspendLayout();
            // 
            // grillaClaseDetalle
            // 
            grillaClaseDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClaseDetalle.Location = new Point(15, 22);
            grillaClaseDetalle.Name = "grillaClaseDetalle";
            grillaClaseDetalle.Size = new Size(551, 189);
            grillaClaseDetalle.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(125, 227);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 26);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(246, 227);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 26);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(363, 227);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 26);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // GbDetalleClase
            // 
            GbDetalleClase.Controls.Add(grillaClaseDetalle);
            GbDetalleClase.Controls.Add(btnEliminar);
            GbDetalleClase.Controls.Add(btnAgregar);
            GbDetalleClase.Controls.Add(btnModificar);
            GbDetalleClase.Location = new Point(12, 12);
            GbDetalleClase.Name = "GbDetalleClase";
            GbDetalleClase.Size = new Size(583, 270);
            GbDetalleClase.TabIndex = 4;
            GbDetalleClase.TabStop = false;
            GbDetalleClase.Text = "Detalle de la Clase";
            // 
            // FormDetalleClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 306);
            Controls.Add(GbDetalleClase);
            Name = "FormDetalleClase";
            Text = "FormDetalleClase";
            Load += FormDetalleClase_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClaseDetalle).EndInit();
            GbDetalleClase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaClaseDetalle;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox GbDetalleClase;
    }
}