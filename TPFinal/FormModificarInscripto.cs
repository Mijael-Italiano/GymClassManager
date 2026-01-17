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
    public partial class FormModificarInscripto : Form
    {
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();
        public FormModificarInscripto()
        {
            InitializeComponent();
            this.Text = "Modificar Inscripto";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormModificarInscripto_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtModificarDNI.MaxLength = UIHelper.MAXLENGTHNUMERO;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                InscriptoSeleccionado.Inscripto.Nombre = txtModificarNombre.Text;
                InscriptoSeleccionado.Inscripto.Apellido = txtModificarApellido.Text;

                int dni;
                if (!Int32.TryParse(txtModificarDNI.Text, out dni))
                {
                    MessageBox.Show("El maximo de DNI no es válido o es muy largo");
                    return;
                }

                InscriptoSeleccionado.Inscripto.DNI = dni;

                inscriptoBusiness.ModificarInscripto(InscriptoSeleccionado.Inscripto);

                MessageBox.Show("Inscripto modificado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el inscripto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModificarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox) {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }
    }
}
