using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Transactions;

namespace Business
{
    public class ClaseBusiness
    {
        ClaseData claseData = new ClaseData();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();
        //      InscriptoBusiness inscriptoBusiness = new InscriptoBusiness();

        public List<Clase> GetLista()
        {
            try
            {
                return claseData.ObtenerClases();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clases", ex);
            }
        }

        public Clase GetById(int id)
        {
            try
            {
                return claseData.GetClaseById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la clase por ID", ex);
            }
        }

        public void DisminuirCantidadInscriptos(int idClase)
        {
            claseData.DecrementarCantidadInscriptos(idClase);
        }




        public void AgregarClase(Clase clase)
        {
            try
            {
                List<Clase> clasesExistentes = GetLista();
                using (TransactionScope scope = new TransactionScope())
                {
                    Clase claseGimnasioExistente = clasesExistentes.Find(c => c.Disciplina.Nombre_Disciplina == "Gimnasio");
                    if (clase.Disciplina.Nombre_Disciplina == "Gimnasio" && claseGimnasioExistente != null)
                    {
                        throw new Exception("Ya existe una clase para la disciplina 'Gimnasio'.");
                    }
                    ValidarClase(clase);
                    claseData.AgregarClase(clase);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarClase(Clase clase)
        {
            if (clase.CuotaMensual <= 0)
            {
                throw new Exception("La cuota mensual debe ser mayor a cero.");
            }

            if (clase.Maximo_Alumnos <= 0)
            {
                throw new Exception("El máximo de inscriptos debe ser mayor a cero.");
            }

            if (clase.Disciplina == null)
            {
                throw new Exception("Debe seleccionar una disciplina.");
            }

            if (clase.Maximo_Alumnos < clase.Cantidad_Inscriptos)
            {
                throw new Exception($"El nuevo máximo de alumnos ({clase.Maximo_Alumnos}) no puede ser menor a la cantidad actual de inscriptos ({clase.Cantidad_Inscriptos}).");
            }
        }


        public void ModificarClase(Clase clase)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    ValidarClase(clase);
                    claseData.Modificar(clase);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la clase.", ex);
            }
        }

        public void DeleteById(int idClase)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    detalleClaseBusiness.EliminarPorClase(idClase);
                    claseData.DeleteById(idClase);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase: " + ex.Message, ex);
            }
        }



        public List<Clase> ObtenerClasesPorDisciplina(int idDisciplina)
        {
            try
            {
                return claseData.ObtenerClasesPorDisciplina(idDisciplina);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las clases por disciplina.", ex);
            }
        }

        public void AumentarCantidadInscriptos(int idClase)
        {
            claseData.IncrementarCantidadInscriptos(idClase);
        }
    }
}
