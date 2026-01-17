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
    public class InscriptoBusiness
    {
        InscriptoData inscriptoData = new InscriptoData();
        ClaseBusiness claseBusiness = new ClaseBusiness();
        public event EventHandler<ClaseLlenaEventArgs> ClaseLlena;
        public List<Inscripto> GetLista()
        {
            try
            {
                return inscriptoData.ObtenerInscriptos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener inscriptos", ex);
            }
        }

        public Inscripto GetInscriptoById(int id)
        {
            try
            {
                return inscriptoData.GetInscriptoById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el inscripto por ID.", ex);
            }
        }

        public void ModificarInscripto(Inscripto inscripto)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    ValidarInscripto(inscripto);
                    inscriptoData.Modificar(inscripto);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void ValidarInscripto(Inscripto inscripto)
        {
            if (string.IsNullOrWhiteSpace(inscripto.Nombre))
            {
                throw new Exception("Nombre requerido");
            }

            if (string.IsNullOrWhiteSpace(inscripto.Apellido))
            {
                throw new Exception("Apellido requerido");
            }

            if (inscripto.DNI <= 0)
            {
                throw new Exception("El DNI debe ser un número positivo.");
            }

            if (inscripto.DNI.ToString().Length <= 5)
            {
                throw new Exception("El DNI debe tener más de 5 dígitos.");
            }

            if(inscripto.ID_Inscripto != null)
            {
                Inscripto inscriptoBd = inscriptoData.GetInscriptoByDNI(inscripto.DNI);
                if (inscriptoBd != null && inscriptoBd.ID_Inscripto != inscripto.ID_Inscripto)
                {
                    throw new Exception("El DNI ingresado ya se encuentra registrado.");
                }
            }


        }

        public List<Inscripto> ObtenerInscriptosPorClase(int? idClase)
        {
            try
            {
                return inscriptoData.ObtenerInscriptosPorClase(idClase);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los inscriptos por clase.", ex);
            }
        }


        public void AddInscripto(Inscripto inscripto)
        {

            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    ValidarInscripto(inscripto);
                    inscriptoData.AddInscripto(inscripto);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AsignarClaseAInscripto(int idInscripto, int idClase, int maximoInscriptos, int cantidadInscriptos)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (cantidadInscriptos >= maximoInscriptos)
                    {
                        ClaseLlena?.Invoke(this, new ClaseLlenaEventArgs(idClase, idInscripto));
                        return; 
                    }
                    int? idClaseActual = inscriptoData.GetIdClaseDeInscripto(idInscripto);

                    if (idClaseActual.HasValue)
                    {
                        if (idClaseActual.Value == idClase)
                        {
                            return;
                        }
                        claseBusiness.DisminuirCantidadInscriptos(idClaseActual.Value);
                    }

                    inscriptoData.AsociarClase(idInscripto, idClase);
                    claseBusiness.AumentarCantidadInscriptos(idClase);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar la clase al inscripto.", ex);
            }
        }

        public void DeleteById(int idInscripto)
        {
            try
            {
                Inscripto inscriptoFromDb = inscriptoData.GetInscriptoById(idInscripto);

                using (TransactionScope trx = new TransactionScope())
                {
                    if (inscriptoFromDb.clase != null)
                    {
                        claseBusiness.DisminuirCantidadInscriptos(inscriptoFromDb.clase.Id_Clase);
                    }
                    inscriptoData.DeleteById(idInscripto);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el inscripto.", ex);
            }
        }
        public void QuitarReferenciaClase(int idClase)
        {
            try
            {
                inscriptoData.QuitarReferenciaClase(idClase);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al quitar la referencia de la clase en los inscriptos.", ex);
            }
        }

    }
}
