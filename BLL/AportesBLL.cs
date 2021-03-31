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
    public class AportesBLL
    {

        public static bool Guardar(Aportes aportes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            var Colecta = ColectasBLL.Buscar(aportes.ColectaId);
            try
            {
                Colecta.Logrado += aportes.Contribucion;

                if (db.Aportes.Add(aportes) != null)
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

        public static bool Modificar(Aportes aportes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Aportes aporteAnterior = AportesBLL.Buscar(aportes.AportesId);
            var Colecta = ColectasBLL.Buscar(aportes.ColectaId);

            try
            {
                Colecta.Logrado -= aporteAnterior.Contribucion;
                Colecta.Logrado += aportes.Contribucion;

                db.Entry(aportes).State = EntityState.Modified;
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

        private static bool Insertar(Aportes aportes)
        {
            bool paso = false;
            var contexto = new Contexto();

            try
            {
                contexto.Aportes.Add(aportes);
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
            Aportes Aportes = Buscar(id);
            var Colecta = ColectasBLL.Buscar(Aportes.ColectaId);
            try
            {
                Colecta.Logrado -= Aportes.Contribucion;

                var eliminar = db.Aportes.Find(id);
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

        public static Aportes Buscar(int id)
        {
            Contexto db = new Contexto();
            Aportes aportes = new Aportes();
            try
            {
                aportes = db.Aportes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return aportes;
        }

        public static List<Aportes> GetList(Expression<Func<Aportes, bool>> evaluacion)
        {
            var lista = new List<Aportes>();
            var db = new Contexto();
            try
            {
                lista = db.Aportes.Where(evaluacion).ToList();
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



