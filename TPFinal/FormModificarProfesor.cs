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
    public partial class FormModificarProfesor : Form
    {
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        public FormModificarProfesor()
        {
            InitializeComponent();
            this.Text = "Modificar Profesor";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormModificarProfesor_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtDNIProfesor.MaxLength = UIHelper.MAXLENGTHNUMERO;
            txtSueldoProfesor.MaxLength = UIHelper.MAXLENGTHIMPORTE;
        }
        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorSeleccionado.Profesor.Nombre = txtNombreProfesor.Text;
                ProfesorSeleccionado.Profesor.Apellido = txtApellidoProfesor.Text;

                int dni;
                if (!Int32.TryParse(txtDNIProfesor.Text, out dni))
                {
                    MessageBox.Show("El maximo del DNI no es válido o es muy largo");
                    return;
                }

                int sueldo;
                if (!Int32.TryParse(txtSueldoProfesor.Text, out sueldo))
                {
                    MessageBox.Show("El maximo del sueldo no es válido o es muy largo");
                    return;
                }

                ProfesorSeleccionado.Profesor.DNI = dni;
                ProfesorSeleccionado.Profesor.Sueldo = sueldo;

                profesorBusiness.ModificarProfesor(ProfesorSeleccionado.Profesor);

                MessageBox.Show("Profesor modificado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNIProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }
    }
}
