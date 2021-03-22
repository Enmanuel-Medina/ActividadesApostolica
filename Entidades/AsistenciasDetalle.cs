using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.Entidades
{
    public class AsistenciasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AsistenciaId { get; set; }
        public int PersonaId { get; set; }
        public bool Presente { get; set; }
        public bool Ausente { get; set; }
        public bool Excusa { get; set; }

        public AsistenciasDetalle()
        {
            Id = 0;
            AsistenciaId = 0;
            PersonaId = 0;
            Presente = false;
            Ausente = true;
            Excusa = false;
        }

        public AsistenciasDetalle(int id, int asistencia, int personaId, bool presente, bool ausente, bool excusa)
        {
            Id = id;
            AsistenciaId = asistencia;
            PersonaId = personaId;
            Presente = presente;
            Ausente = ausente;
            Excusa = excusa;
        }
    }
}