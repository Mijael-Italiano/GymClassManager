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
    public class DetalleClaseBusiness
    {
        DetalleClaseData detalleClaseData = new DetalleClaseData();
        public List<DetalleClase> GetLista()
        {
            DetalleClaseData detalleClaseData = new DetalleClaseData();
            try
            {
                return detalleClaseData.ObtenerDetalleClases();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle de clases", ex);
            }
        }

        public void AgregarDetalleClase(DetalleClase detalle)
        {
            List<DetalleClase> turnosExistentes = detalleClaseData.ObtenerDetalleClasesPorProfesor(detalle.profesor);
            using (TransactionScope scope = new TransactionScope())
            {
                ValidarDetalleClase(detalle, turnosExistentes);
                detalleClaseData.Agregar(detalle);
                scope.Complete();
            }
        }

        public void EliminarPorClase(int idClase)
        {
            try
            {
                detalleClaseData.EliminarPorClase(idClase);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los detalles de la clase.", ex);
            }
        }


        public void QuitarReferenciaProfesor(int idProfesor)
        {
            try
            {
                detalleClaseData.QuitarReferenciaProfesor(idProfesor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al quitar referencia del profesor", ex);
            }
        }


        private void ValidarDetalleClase(DetalleClase detalle, List<DetalleClase> turnosExistentes)
        {
            if (string.IsNullOrWhiteSpace(detalle.Dia))
                throw new Exception("El día no puede estar vacío.");

            if (detalle.Horario_Inicio >= detalle.Horario_Fin)
                throw new Exception("La hora de finalización debe ser posterior a la de inicio.");

            if (detalle.profesor == null)
                throw new Exception("Debe seleccionar un profesor.");

            if (detalle.Horario_Inicio < TimeSpan.FromHours(6) ||
                detalle.Horario_Fin >= TimeSpan.FromHours(22).Add(TimeSpan.FromMinutes(1)))
            {
                throw new Exception("El horario debe estar entre las 06:00 y las 22:00.");
            }


            foreach (var turno in turnosExistentes)
            {
                if (turno.Dia == detalle.Dia)
                {
                    var inicioNuevo = TimeSpan.FromMinutes(
                        Math.Round(detalle.Horario_Inicio.TotalMinutes)
                    );

                    var finNuevo = TimeSpan.FromMinutes(
                        Math.Round(detalle.Horario_Fin.TotalMinutes)
                    );

                    var inicioExistente = TimeSpan.FromMinutes(
                        Math.Round(turno.Horario_Inicio.TotalMinutes)
                    );

                    var finExistente = TimeSpan.FromMinutes(
                        Math.Round(turno.Horario_Fin.TotalMinutes)
                    );

                    bool seSolapa =
                        inicioNuevo < finExistente &&
                        finNuevo > inicioExistente;

                    if (seSolapa)
                    {
                        throw new Exception($"El profesor ya tiene un turno el {detalle.Dia} de {turno.Horario_Inicio:hh\\:mm} a {turno.Horario_Fin:hh\\:mm}.");
                    }
                }
            }
        }
        public List<DetalleClase> GetPorClase(Clase clase)
        {
            try
            {
                return detalleClaseData.ObtenerDetalleClasesPorClase(clase.Id_Clase);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los detalles de la clase en la capa Business.", ex);
            }
        }

        public void DeleteById(int id)
        {
            try
            {

                using (TransactionScope trx = new TransactionScope())
                {
                    detalleClaseData.DeleteById(id);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ModificarDetalleClase(DetalleClase detalle)
        {
            try
            {

                List<DetalleClase> turnosExistentes = detalleClaseData.ObtenerDetalleClasesPorProfesor(detalle.profesor)
               .Where(t => t.Id_Detalle_Clases != detalle.Id_Detalle_Clases).ToList();

                ValidarDetalleClase(detalle, turnosExistentes);

                detalleClaseData.Modificar(detalle);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el turno: " + ex.Message, ex);
            }
        }

        public DetalleClase GetDetalleClaseById(int id)
        {
            try
            {
                return detalleClaseData.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el detalle de clase por ID", ex);
            }
        }

    }
}
