
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }

        public int ActividadId { get; set; }

        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }

        public int CantidadPresentes { get; set; }

        public int CantidadAusentes { get; set; }

        public int CantidadExcusas { get; set; }

        public int UsuarioId { get; set; }
        


        public virtual List<AsistenciasDetalle> AsistenciasDetalle { get; set; }

        public Asistencias()
        {
            AsistenciaId = 0;
            ActividadId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            CantidadPresentes = 0;
            CantidadAusentes = 0;
            CantidadExcusas = 0;
            UsuarioId = 0;
            AsistenciasDetalle = new List<AsistenciasDetalle>();
        }
    }
}

