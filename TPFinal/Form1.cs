using Business;
using Entity;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TPFinal
{
    public partial class Form1 : Form
    {
        ClaseBusiness claseBusiness = new ClaseBusiness();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();
        ProfesorBusiness profesorBusiness = new ProfesorBusiness();
        DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Gestión de Clases";
            this.StartPosition = FormStartPosition.CenterScreen;
            LlenarGrillaClase();
            LlenarGrillaInscripto();
            LlenarGrillaProfesor();
            CargarComboDisciplinaClase();
            CargarComboDisciplinaProfesor();
            inscriptoBusiness.ClaseLlena += InscriptoBusiness_ClaseLlena;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIHelper.setDefaultStyleForm(this);
            UIHelper.setDatagridDefault(grillaClase);
            UIHelper.setDatagridDefault(grillaInscripto);
            UIHelper.setDatagridDefault(grillaProfesor);

        }


        private void LlenarGrillaClase(List<Clase> clases)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Clase", typeof(int));
            tabla.Columns.Add("Cantidad Inscriptos", typeof(int));
            tabla.Columns.Add("Cuota Mensual", typeof(decimal));
            tabla.Columns.Add("Disciplina", typeof(string));
            tabla.Columns.Add("Maximo Inscriptos", typeof(int));

            foreach (Clase c in clases)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Clase"] = c.Id_Clase;
                fila["Cantidad Inscriptos"] = c.Cantidad_Inscriptos;
                fila["Cuota Mensual"] = c.CuotaMensual;
                fila["Disciplina"] = c.Disciplina.Nombre_Disciplina;
                fila["Maximo Inscriptos"] = c.Maximo_Alumnos;
                tabla.Rows.Add(fila);
            }
            grillaClase.DataSource = null;
            grillaClase.DataSource = tabla;
            grillaClase.Columns["ID_Clase"].Visible = false;
            grillaClase.Columns["Cuota Mensual"].DefaultCellStyle.Format = "C2";
            grillaClase.Columns["Cuota Mensual"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");
            grillaClase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Aprovechando el polimorfismo
        private void LlenarGrillaClase()
        {
            List<Clase> clases = claseBusiness.GetLista();
            LlenarGrillaClase(clases);
        }

        private void LlenarGrillaProfesor(List<Profesor> profesores)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Profesor", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("DNI", typeof(int));
            tabla.Columns.Add("Disciplina", typeof(string));
            tabla.Columns.Add("Sueldo", typeof(decimal)); // 

            foreach (Profesor p in profesores)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Profesor"] = p.ID_Profesor;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                fila["DNI"] = p.DNI;
                fila["Disciplina"] = p.Disciplina.Nombre_Disciplina;
                fila["Sueldo"] = p.Sueldo;
                tabla.Rows.Add(fila);
            }

            grillaProfesor.DataSource = null;
            grillaProfesor.DataSource = tabla;
            grillaProfesor.Columns["ID_Profesor"].Visible = false;
            grillaProfesor.Columns["DNI"].DefaultCellStyle.Format = "#,##0";
            grillaProfesor.Columns["Sueldo"].DefaultCellStyle.Format = "C2";
            grillaProfesor.Columns["Sueldo"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");
            grillaProfesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LlenarGrillaProfesor()
        {
            List<Profesor> profesores = profesorBusiness.GetLista();
            LlenarGrillaProfesor(profesores);
        }

        private void LlenarGrillaInscripto(List<Inscripto> inscriptos)
        {
            //        List<Inscripto> inscriptos = inscriptoBusiness.GetLista();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_Inscripto", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("DNI", typeof(int));
            tabla.Columns.Add("ID_Clase", typeof(object));

            foreach (Inscripto i in inscriptos)
            {
                DataRow fila = tabla.NewRow();
                fila["ID_Inscripto"] = i.ID_Inscripto;
                fila["Nombre"] = i.Nombre;
                fila["Apellido"] = i.Apellido;
                fila["DNI"] = i.DNI;
                fila["ID_Clase"] = i.clase?.Id_Clase ?? (object)DBNull.Value;
                tabla.Rows.Add(fila);
            }

            grillaInscripto.DataSource = null;
            grillaInscripto.DataSource = tabla;
            grillaInscripto.Columns["ID_Inscripto"].Visible = false;
            grillaInscripto.Columns["ID_Clase"].Visible = false;
            grillaInscripto.Columns["DNI"].DefaultCellStyle.Format = "#,##0";
            grillaInscripto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LlenarGrillaInscripto()
        {
            List<Inscripto> inscriptos = inscriptoBusiness.GetLista();
            LlenarGrillaInscripto(inscriptos);
        }

        private void btnDetalleClase_Click(object sender, EventArgs e)
        {
            if (grillaClase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una clase de la grilla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idClaseSeleccionada = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);
            ClaseSeleccionada.Clase = claseBusiness.GetById(idClaseSeleccionada);

            using (FormDetalleClase detalle = new FormDetalleClase())
            {
                detalle.ShowDialog();
            }

        }

        private void btnAgregarInscripto_Click(object sender, EventArgs e)
        {
            FormAgregarInscripto formAgregarInscripto = new FormAgregarInscripto();
            if (formAgregarInscripto.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaInscripto();
            }
        }

        private void BtnAsignarClase_Click(object sender, EventArgs e)
        {
            if (grillaInscripto.SelectedRows.Count == 0 || grillaClase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un inscripto y una clase.");
                return;
            }
            else
            {
                int idInscripto = Convert.ToInt32(grillaInscripto.SelectedRows[0].Cells["ID_Inscripto"].Value);
                int idClase = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);
                int cantidadInscriptos = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["Cantidad Inscriptos"].Value);
                int maximoInscriptos = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["Maximo Inscriptos"].Value);

                inscriptoBusiness.AsignarClaseAInscripto(idInscripto, idClase, maximoInscriptos, cantidadInscriptos);
                LlenarGrillaInscripto();
                LlenarGrillaClase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarClase formAgregarClase = new FormAgregarClase();
            if (formAgregarClase.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaClase();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAgregarProfesor formAgregarProfesor = new FormAgregarProfesor();
            if (formAgregarProfesor.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaProfesor();
            }
        }

        private void btnEliminarInscripto_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaInscripto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idInscripto = Convert.ToInt32(grillaInscripto.SelectedRows[0].Cells["ID_Inscripto"].Value);
                inscriptoBusiness.DeleteById(idInscripto);
                LlenarGrillaInscripto();
                MessageBox.Show("Inscripto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar inscripto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaProfesor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un profesor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idProfesor = Convert.ToInt32(grillaProfesor.SelectedRows[0].Cells["ID_Profesor"].Value);
                profesorBusiness.DeleteById(idProfesor);
                LlenarGrillaProfesor();
                MessageBox.Show("Profesor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar profesor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaClase.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una clase para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idClase = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);
                inscriptoBusiness.QuitarReferenciaClase(idClase);
                claseBusiness.DeleteById(idClase);
                LlenarGrillaClase();
                LlenarGrillaInscripto();
                MessageBox.Show("Clase eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarComboDisciplinaClase()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();

            cmbDisciplinaClase.DataSource = new List<Disciplina>(disciplinas);
            cmbDisciplinaClase.DisplayMember = "Nombre_Disciplina";
            cmbDisciplinaClase.ValueMember = "Id_Disciplina";
        }

        private void CargarComboDisciplinaProfesor()
        {
            List<Disciplina> disciplinas = disciplinaBusiness.ObtenerDisciplinas();

            cmbDisciplinaProfesor.DataSource = new List<Disciplina>(disciplinas);
            cmbDisciplinaProfesor.DisplayMember = "Nombre_Disciplina";
            cmbDisciplinaProfesor.ValueMember = "Id_Disciplina";
        }


        private void btnModificarInscripto_Click(object sender, EventArgs e)
        {
            if (grillaInscripto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un inscripto para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idInscripto = Convert.ToInt32(grillaInscripto.SelectedRows[0].Cells["ID_Inscripto"].Value);
            InscriptoSeleccionado.Inscripto = inscriptoBusiness.GetInscriptoById(idInscripto);

            FormModificarInscripto formModificarInscripto = new FormModificarInscripto();
            if (formModificarInscripto.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaInscripto();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grillaClase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una clase para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idClase = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);
            ClaseSeleccionada.Clase = claseBusiness.GetById(idClase);

            FormModificarClase formModificar = new FormModificarClase();
            if (formModificar.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaClase();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (grillaProfesor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un profesor para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idProfesor = Convert.ToInt32(grillaProfesor.SelectedRows[0].Cells["ID_Profesor"].Value);
            ProfesorSeleccionado.Profesor = profesorBusiness.GetProfesorById(idProfesor);

            FormModificarProfesor formModificarProfesor = new FormModificarProfesor();
            if (formModificarProfesor.ShowDialog() == DialogResult.OK)
            {
                LlenarGrillaProfesor();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cmbDisciplinaClase.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una disciplina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Disciplina seleccionada = (Disciplina)cmbDisciplinaClase.SelectedItem;
            int idDisciplina = seleccionada.Id_Disciplina;
            List<Clase> clasesFiltradas = claseBusiness.ObtenerClasesPorDisciplina(idDisciplina);
            grillaClase.DataSource = null;
            LlenarGrillaClase(clasesFiltradas);
        }

        private void btnMostrarListaCompletaClases_Click(object sender, EventArgs e)
        {
            LlenarGrillaClase();
        }

        private void btnMostrarPorProfesor_Click(object sender, EventArgs e)
        {
            if (cmbDisciplinaProfesor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una disciplina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Disciplina seleccionada = (Disciplina)cmbDisciplinaProfesor.SelectedItem;
            int idDisciplina = seleccionada.Id_Disciplina;

            List<Profesor> profesoresFiltrados = profesorBusiness.GetPorDisciplina(idDisciplina);
            LlenarGrillaProfesor(profesoresFiltrados);
        }

        private void btnVerListaCompleta_Click(object sender, EventArgs e)
        {
            LlenarGrillaProfesor();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int? idClase = null;

            try
            {
                if (grillaClase.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una clase de la grilla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                idClase = Convert.ToInt32(grillaClase.SelectedRows[0].Cells["ID_Clase"].Value);

                List<Inscripto> inscriptos = inscriptoBusiness.ObtenerInscriptosPorClase(idClase);
                LlenarGrillaInscripto(inscriptos);

            }
            catch (Exception)
            {
                MessageBox.Show("ID inválido.");
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LlenarGrillaInscripto();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                List<Inscripto> inscriptos = inscriptoBusiness.ObtenerInscriptosPorClase(null);
                LlenarGrillaInscripto(inscriptos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void InscriptoBusiness_ClaseLlena(object sender, ClaseLlenaEventArgs e)
        {
            MessageBox.Show("Esta clase está llena", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
