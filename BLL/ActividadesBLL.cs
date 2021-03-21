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
   public class ActividadesBLL
    {
        public static bool Guardar(Actividades actividad)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Actividades.Add(actividad) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Actividades actividad)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(actividad).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        private static bool Insertar(Actividades actividad)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Actividades.Add(actividad);
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

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Actividades.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Actividades Buscar(int id)
        {
            Contexto db = new Contexto();
            Actividades actividad = new Actividades();
            try
            {
                actividad = db.Actividades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return actividad;
        }

        public static List<Actividades> GetList(Expression<Func<Actividades, bool>> evaluacion)
        {
            var lista = new List<Actividades>();
            var db = new Contexto();
            try
            {
                lista = db.Actividades.Where(evaluacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }

}

