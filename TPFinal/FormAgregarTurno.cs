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
    public partial class FormAgregarTurno : Form
    {
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        public FormAgregarTurno()
        {
            InitializeComponent();
            this.Text = "Agregar Turno";
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarDiasDeLaSemana();
            CargarProfesoresPorDisciplinaSeleccionada();
        }
        private void FormAgregarTurno_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            UIHelper.setHoraPickerDefault(agregarInicioTurno);
            UIHelper.setHoraPickerDefault(agregarFinalizacionTurno);

        }

        private void CargarDiasDeLaSemana()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            cmbAgregarTurnoDia.Items.AddRange(dias);
            cmbAgregarTurnoDia.SelectedIndex = 0;
        }

        private void CargarProfesoresPorDisciplinaSeleccionada()
        {
            try
            {
                int idDisciplina = ClaseSeleccionada.Clase.Disciplina.Id_Disciplina;
                List<Profesor> profesores = profesorBusiness.GetPorDisciplina(idDisciplina);
                cmbAgregarTurnoIdProfesor.DataSource = profesores;
                cmbAgregarTurnoIdProfesor.DisplayMember = "Apellido";
                cmbAgregarTurnoIdProfesor.ValueMember = "ID_Profesor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los profesores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = cmbAgregarTurnoDia.SelectedItem.ToString();
                TimeSpan horaInicio = agregarInicioTurno.Value.TimeOfDay;
                TimeSpan horaFin = agregarFinalizacionTurno.Value.TimeOfDay;
                Profesor profesorSeleccionado = (Profesor)cmbAgregarTurnoIdProfesor.SelectedItem;
                Clase claseSeleccionada = ClaseSeleccionada.Clase;

                DetalleClase detalle = new DetalleClase
                {
                    Dia = dia,
                    Horario_Inicio = horaInicio,
                    Horario_Fin = horaFin,
                    profesor = profesorSeleccionado,
                    clase = claseSeleccionada
                };

                detalleClaseBusiness.AgregarDetalleClase(detalle);

                MessageBox.Show("Turno agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
