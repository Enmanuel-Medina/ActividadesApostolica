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
   public class ColectasBLL
    {

        public static bool Guardar(Colectas colectas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Colectas.Add(colectas) != null)
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

        public static bool Modificar(Colectas colectas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(colectas).State = EntityState.Modified;
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

        private static bool Insertar(Colectas colectas)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Colectas.Add(colectas);
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
                var eliminar = db.Colectas.Find(id);
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

        public static Colectas Buscar(int id)
        {
            Contexto db = new Contexto();
            Colectas colectas = new Colectas();
            try
            {
                colectas = db.Colectas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return colectas;
        }

        public static List<Colectas> GetList(Expression<Func<Colectas, bool>> evaluacion)
        {
            var lista = new List<Colectas>();
            var db = new Contexto();
            try
            {
                lista = db.Colectas.Where(evaluacion).ToList();
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


