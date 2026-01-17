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
    public class ProfesorBusiness
    {
        ProfesorData profesorData = new ProfesorData();
        DetalleClaseBusiness detalleClaseBusiness = new DetalleClaseBusiness();

        public List<Profesor> GetLista()
        {
            try
            {
                return profesorData.ObtenerProfesores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener profesores", ex);
            }
        }






        public List<Profesor> GetPorDisciplina(int idDisciplina)
        {
            try
            {
                return profesorData.ObtenerProfesoresPorDisciplina(idDisciplina);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener profesores por disciplina", ex);
            }
        }


        public Profesor GetProfesorById(int id)
        {
            try
            {
                return profesorData.GetProfesorById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el profesor.", ex);
            }
        }
        public void DeleteById(int idProfesor)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    detalleClaseBusiness.QuitarReferenciaProfesor(idProfesor); //
                    profesorData.DeleteById(idProfesor);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el profesor", ex);
            }
        }




        public void AgregarProfesor(Profesor profesor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ValidarProfesor(profesor);
                    profesorData.AgregarProfesor(profesor);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarProfesor(Profesor profesor)
        {
            if (string.IsNullOrWhiteSpace(profesor.Nombre))
            {
                throw new Exception("Debe ingresar un nombre.");
            }

            if (string.IsNullOrWhiteSpace(profesor.Apellido))
            {
                throw new Exception("Debe ingresar un apellido.");
            }

            if (profesor.DNI <= 0)
            {
                throw new Exception("El DNI debe ser un número válido mayor a cero.");
            }

            if (profesor.Disciplina == null)
            {
                throw new Exception("Debe seleccionar una disciplina.");
            }

            if (profesor.Sueldo < 0)
            {
                throw new Exception("El sueldo debe ser mayor o igual a cero.");
            }

            if (profesor.ID_Profesor != null)
            {
                Profesor profesorBd = profesorData.getProfesorByDNI(profesor.DNI);
                if (profesorBd != null && profesorBd.ID_Profesor != profesor.ID_Profesor)
                {
                    throw new Exception("El DNI ingresado ya se encuentra registrado.");
                }
            }

        }

        public void ModificarProfesor(Profesor profesor)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    ValidarProfesor(profesor);
                    profesorData.Modificar(profesor);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
