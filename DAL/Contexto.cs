using ActividadesApostolica.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\ActividadesApostolicas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Fecha = DateTime.Now,
                Nombres = "Admin",
                Apellidos = "Admin",
                Telefono = "0123456789",
                Celular = "0123456789",
                Email = "Admin@hotmail.com",
                Direccion = "Admin",
                NombreUsuario = "Admin",
                ClaveUsuario = "admin",
                ClaveConfirmada = "admin",
                TipoUsuario = "Administrador"
            });
        }
    }
}
