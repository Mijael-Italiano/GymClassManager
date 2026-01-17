using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Business;

namespace TPFinal
{
    public partial class FormAgregarClase : Form
    {
        DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
        ClaseBusiness claseBusiness = new ClaseBusiness();
        public FormAgregarClase()
        {
            InitializeComponent();
            this.Text = "Agregar Clase";
            this.StartPosition = FormStartPosition.CenterScreen;
            CargarComboDisciplinas();
        }
        private void FormAgregarClase_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            txtAgregarCuotaMensual.MaxLength = UIHelper.MAXLENGTHIMPORTE;
            txtAgregarMaximoInscriptos.MaxLength = UIHelper.MAXLENGTHNUMERO;
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            try
            {
                Clase nuevaClase = new Clase();
                nuevaClase.Cantidad_Inscriptos = 0;

                int cuotaMensual;
                if (!Int32.TryParse(txtAgregarCuotaMensual.Text, out cuotaMensual))
                {
                    MessageBox.Show("La cuota mensual no es válida");
                    return;
                }

                int maximoAlumnos;
                if (!Int32.TryParse(txtAgregarMaximoInscriptos.Text, out maximoAlumnos))
                {
                    MessageBox.Show("El maximo de alumnos no es válido");
                    return;
                }

                nuevaClase.CuotaMensual = cuotaMensual;
                nuevaClase.Maximo_Alumnos = maximoAlumnos;
                nuevaClase.Disciplina = (Disciplina)cmbAgregarClase.SelectedItem;
                List<Clase> clasesExistentes = claseBusiness.GetLista();
                claseBusiness.AgregarClase(nuevaClase);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarComboDisciplinas()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();
            cmbAgregarClase.DataSource = disciplinas;
            cmbAgregarClase.DisplayMember = "Nombre_Disciplina";
            cmbAgregarClase.ValueMember = "Id_Disciplina";
        }

        private void txtAgregarMaximoInscriptos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sender is TextBox) { 
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroSinDecimal(textBox, e);
            }
        }

        private void txtAgregarCuotaMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                UIHelper.setTextBoxNumeroConDecimal(textBox, e);
            }
        }

    }
}
