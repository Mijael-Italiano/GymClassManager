using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace TPFinal
{
    public partial class FormDetalleClase : Form
    {
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();

        /*private void LlenarGrillaDetalleClase()
        {
            grillaClaseDetalle.DataSource = null;
            grillaClaseDetalle.DataSource = detalleClaseBusiness.GetLista();
        }*/

        private void FormDetalleClase_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            UIHelper.setDatagridDefault(grillaClaseDetalle);
        }

        private void LlenarGrillaDetalleClase()
        {
            try
            {
                List<DetalleClase> detalles = detalleClaseBusiness.GetPorClase(ClaseSeleccionada.Clase);

                DataTable tabla = new DataTable();
                tabla.Columns.Add("ID_Detalle_Clases", typeof(int));
                tabla.Columns.Add("ID_Clase", typeof(int));
                tabla.Columns.Add("Nombre_Profesor", typeof(string));
                tabla.Columns.Add("Apellido_Profesor", typeof(string));
                tabla.Columns.Add("Dia", typeof(string));
                tabla.Columns.Add("Horario_Inicio", typeof(string));
                tabla.Columns.Add("Horario_Fin", typeof(string));

                foreach (DetalleClase detalle in detalles)
                {
                    DataRow fila = tabla.NewRow();
                    fila["ID_Detalle_Clases"] = detalle.Id_Detalle_Clases;
                    fila["ID_Clase"] = detalle.clase.Id_Clase;
                    if (detalle.profesor != null)
                    {
                        fila["Nombre_Profesor"] = detalle.profesor.Nombre;
                        fila["Apellido_Profesor"] = detalle.profesor.Apellido;
                    }
                    else
                    {
                        fila["Nombre_Profesor"] = "SIN PROFESOR";
                        fila["Apellido_Profesor"] = "-";
                    }
                    fila["Dia"] = detalle.Dia;
                    fila["Horario_Inicio"] = detalle.Horario_Inicio.ToString(@"hh\:mm");
                    fila["Horario_Fin"] = detalle.Horario_Fin.ToString(@"hh\:mm");
                    tabla.Rows.Add(fila);
                }

                grillaClaseDetalle.DataSource = null;
                grillaClaseDetalle.DataSource = tabla;
                grillaClaseDetalle.Columns["ID_Detalle_Clases"].Visible = false;
                grillaClaseDetalle.Columns["ID_Clase"].Visible = false;
                grillaClaseDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public FormDetalleClase()
        {
            InitializeComponent();
            LlenarGrillaDetalleClase();
            this.Text = "Detalle de la Clase";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarTurno formAgregarTurno = new FormAgregarTurno();
            if (formAgregarTurno.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaDetalleClase();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClaseDetalle.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idDetalle = Convert.ToInt32(grillaClaseDetalle.SelectedRows[0].Cells["ID_Detalle_Clases"].Value);
                detalleClaseBusiness.DeleteById(idDetalle);
                LlenarGrillaDetalleClase(); // asumimos que ya tenés esta función
                MessageBox.Show("Turno eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grillaClaseDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un turno para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idDetalle = Convert.ToInt32(grillaClaseDetalle.SelectedRows[0].Cells["ID_Detalle_Clases"].Value);
            DetalleClaseSeleccionada.DetalleClase = detalleClaseBusiness.GetDetalleClaseById(idDetalle);

            FormModificarDetalleClase formModificar = new FormModificarDetalleClase();
            if (formModificar.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaDetalleClase();
            }
        }

    }
}
