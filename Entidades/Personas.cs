using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.Entidades
{
  public class Personas
    {
        [Key]

        public int UsuarioId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public int Cedula { get; set; }



    }
}
