using ActividadesApostolica.DAL;
using ActividadesApostolica.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.BLL
{
    public class AsistenciasBLL
    {
        public static void AgregarAsistencia(Asistencias asistencia)
        {
            foreach (var item in asistencia.AsistenciasDetalle)
            {
                if (item.Presente == true)
                    asistencia.CantidadPresentes++;

                if (item.Ausente == true)
                    asistencia.CantidadAusentes++;

                if (item.Excusa == true)
                    asistencia.CantidadExcusas++;
            }
        }

        public static void EliminarAsistencia(Asistencias asistencia)
        {
            foreach (var item in asistencia.AsistenciasDetalle)
            {
                if (item.Presente == true)
                    asistencia.CantidadPresentes--;

                if (item.Ausente == true)
                    asistencia.CantidadAusentes--;

                if (item.Excusa == true)
                    asistencia.CantidadExcusas--;
            }
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Asistencias.Any(x => x.AsistenciaId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Guardar(Asistencias asistencia)
        {
            if (!Existe(asistencia.AsistenciaId))
                return Insertar(asistencia);
            else
                return Modificar(asistencia);
        }

        private static bool Insertar(Asistencias asistencia)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Asistencias.Add(asistencia);
                AgregarAsistencia(asistencia);

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Asistencias asistencia)
        {
            bool paso = false;
            var contexto = new Contexto();
            Asistencias asistenciaAnterior = new Asistencias();
            asistenciaAnterior = Buscar(asistencia.AsistenciaId);

            try
            {
                EliminarAsistencia(asistenciaAnterior);
                contexto.Database.ExecuteSqlRaw($"DELETE FROM AsistenciasDetalle WHERE AsistenciaId = {asistencia.AsistenciaId}");

                foreach (var anterior in asistencia.AsistenciasDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }

                AgregarAsistencia(asistencia);

                contexto.Entry(asistencia).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Asistencias Buscar(int id)
        {
            var contexto = new Contexto();
            var asistencia = new Asistencias();

            try
            {
                asistencia = contexto.Asistencias
                    .Where(e => e.AsistenciaId == id)
                    .Include(e => e.AsistenciasDetalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return asistencia;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            var contexto = new Contexto();
            Asistencias asistencia = Buscar(id);

            try
            {
                if (asistencia != null)
                {
                    EliminarAsistencia(asistencia);

                    var eliminarProyecto = contexto.Asistencias.Find(id);
                    contexto.Entry(eliminarProyecto).State = EntityState.Deleted;

                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static List<Asistencias> GetList(Expression<Func<Asistencias, bool>> criterio)
        {
            List<Asistencias> lista = new List<Asistencias>();
            var contexto = new Contexto();

            try
            {
                lista = contexto.Asistencias.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
