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

        private static bool Insertar(Asistencias asistencia)
        {
            bool paso = false;
            var contexto = new Contexto();

            int presente = 0;
            int ausentes = 0;
            int excusas = 0;

            try
            {
                foreach (var item in asistencia.AsistenciasDetalle)
                {
                    if (item.Presente)
                        presente += 1;

                    if (item.Ausente)
                        ausentes += 1;

                    if (item.Excusa)
                        excusas += 1;
                }

                asistencia.CantidadAusentes = ausentes;
                asistencia.CantidadExcusas = excusas;
                asistencia.CantidadPresentes = presente;

                contexto.Asistencias.Add(asistencia);
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

            try
            {
                contexto.Database.ExecuteSqlRaw($"DELETE FROM AsistenciasDetalle WHERE ProyectoId = {asistencia.AsistenciaId}");

                int presente = 0;
                int ausentes = 0;
                int excusas = 0;

                foreach (var anterior in asistencia.AsistenciasDetalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;

                    if (anterior.Presente)
                        presente += 1;

                    if (anterior.Ausente)
                        ausentes += 1;

                    if (anterior.Excusa)
                        excusas += 1;
                }

                asistencia.CantidadAusentes = ausentes;
                asistencia.CantidadExcusas = excusas;
                asistencia.CantidadPresentes = presente;

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

        public static bool Guardar(Asistencias asistencia)
        {
            if (!Existe(asistencia.AsistenciaId))
                return Insertar(asistencia);
            else
                return Modificar(asistencia);

        }

        public static Asistencias Buscar(int id)
        {
            var contexto = new Contexto();
            var asistencia = new Asistencias();

            try
            {
                asistencia = contexto.Asistencias.Include(x => x.AsistenciasDetalle).Where(p => p.AsistenciaId == id).SingleOrDefault();
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

            try
            {
                var eliminarProyecto = contexto.Asistencias.Find(id);
                contexto.Entry(eliminarProyecto).State = EntityState.Deleted;

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
