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
    public partial class FormAgregarInscripto : Form
    {
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();

        public FormAgregarInscripto()
        {
            InitializeComponent();
            this.Text = "Agregar Inscripto";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormAgregarInscripto_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtDNI.MaxLength = UIHelper.MAXLENGTHNUMERO;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Inscripto nuevoInscripto = new Inscripto();
                nuevoInscripto.Nombre = txtNombre.Text;
                nuevoInscripto.Apellido = txtApellido.Text;
                int dni;
                if (!Int32.TryParse(txtDNI.Text, out dni))
                {
                    MessageBox.Show("El DNI ingresado no es válido o es muy largo");
                    return;
                }
                nuevoInscripto.DNI = dni;
                inscriptoBusiness.AddInscripto(nuevoInscripto);
                MessageBox.Show("Inscripto guardado exitosamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox) {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }
    }
}
