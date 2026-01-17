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
    public partial class FormAgregarProfesor : Form
    {
        DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        public FormAgregarProfesor()
        {
            InitializeComponent();
            this.Text = "Agregar Profesor";
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboDisciplinas();
        }
        private void FormAgregarProfesor_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtAgregarProfesorDNI.MaxLength = UIHelper.MAXLENGTHNUMERO;
            txtAgregarProfesorSueldo.MaxLength = UIHelper.MAXLENGTHIMPORTE;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Profesor nuevoProfesor = new Profesor();
                nuevoProfesor.Nombre = txtAgregarProfesorNombre.Text;
                nuevoProfesor.Apellido = txtAgregarProfesorApellido.Text;

                int dni;
                if (!Int32.TryParse(txtAgregarProfesorDNI.Text, out dni))
                {
                    MessageBox.Show("El DNI ingresado no es válido o es muy largo");
                    return;
                }
                nuevoProfesor.DNI = dni;

                int sueldo;
                if (!Int32.TryParse(txtAgregarProfesorSueldo.Text, out sueldo))
                {
                    MessageBox.Show("El Sueldo ingresado no es válido o es muy largo");
                    return;
                }
                nuevoProfesor.Sueldo = sueldo;

                nuevoProfesor.Disciplina = (Disciplina)cmbAgregarProfesorDisciplina.SelectedItem;

                profesorBusiness.AgregarProfesor(nuevoProfesor); // asumimos que existe
                this.DialogResult = DialogResult.OK;
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarComboDisciplinas()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();
            cmbAgregarProfesorDisciplina.DataSource = disciplinas;
            cmbAgregarProfesorDisciplina.DisplayMember = "Nombre_Disciplina";
            cmbAgregarProfesorDisciplina.ValueMember = "Id_Disciplina";
        }

        private void txtAgregarProfesorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }

        private void txtAgregarProfesorSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroConDecimal(textBox, e);
            }
        }
    }
}
