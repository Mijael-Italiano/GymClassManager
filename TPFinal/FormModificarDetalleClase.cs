using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class FormModificarDetalleClase : Form
    {
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        public FormModificarDetalleClase()
        {
            InitializeComponent();
            this.Text = "Modificar Turno";
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarDiasDeLaSemana();
            CargarProfesoresPorDisciplinaSeleccionada();
        }

        private void FormModificarDetalleClase_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            UIHelper.setHoraPickerDefault(horarioInicioModificar);
            UIHelper.setHoraPickerDefault(horarioFinModificar);
        }

        private void CargarProfesoresPorDisciplinaSeleccionada()
        {
            try
            {
                int idDisciplina = DetalleClaseSeleccionada.DetalleClase.clase.Disciplina.Id_Disciplina;
                List<Profesor> profesores = profesorBusiness.GetPorDisciplina(idDisciplina);
                cmbProfesorModificar.DataSource = profesores;
                cmbProfesorModificar.DisplayMember = "Apellido";
                cmbProfesorModificar.ValueMember = "ID_Profesor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los profesores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void CargarDiasDeLaSemana()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            cmbModificarDia.Items.AddRange(dias);
            cmbModificarDia.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = cmbModificarDia.SelectedItem.ToString();
                TimeSpan horaInicio = horarioInicioModificar.Value.TimeOfDay;
                TimeSpan horaFin = horarioFinModificar.Value.TimeOfDay;
                Profesor profesorSeleccionado = (Profesor)cmbProfesorModificar.SelectedItem;

                DetalleClase detalle = DetalleClaseSeleccionada.DetalleClase;
                detalle.Dia = dia;
                detalle.Horario_Inicio = horaInicio;
                detalle.Horario_Fin = horaFin;
                detalle.profesor = profesorSeleccionado;

                detalleClaseBusiness.ModificarDetalleClase(detalle);

                MessageBox.Show("Turno modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
