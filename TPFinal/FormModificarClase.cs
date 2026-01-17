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
    public partial class FormModificarClase : Form
    {
        ClaseBusiness claseBusiness = new ClaseBusiness();
        public FormModificarClase()
        {
            InitializeComponent();
            this.Text = "Modificar Clase";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormModificarClase_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtModificarCuota.MaxLength = UIHelper.MAXLENGTHIMPORTE;
            txtModificarMaximoInscriptos.MaxLength = UIHelper.MAXLENGTHNUMERO;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int nuevaCuota;
                if (!Int32.TryParse(txtModificarCuota.Text, out nuevaCuota))
                {
                    MessageBox.Show("La cuota ingresada no es válido");
                    return;
                }

                int nuevoMaximo;
                if (!Int32.TryParse(txtModificarMaximoInscriptos.Text, out nuevoMaximo))
                {
                    MessageBox.Show("El maximo de inscripciones no es válido");
                    return;
                }

                ClaseSeleccionada.Clase.CuotaMensual = nuevaCuota;
                ClaseSeleccionada.Clase.Maximo_Alumnos = nuevoMaximo;

                claseBusiness.ModificarClase(ClaseSeleccionada.Clase);

                MessageBox.Show("Clase modificada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtModificarCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox) {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroConDecimal(textBox, e);
            }
        }

        private void txtModificarMaximoInscriptos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }
    }
}
