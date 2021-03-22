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
        public int AsistenciaId { get; set; }
        public int PersonaId { get; set; }
        public int ActividadId { get; set; }
        public bool Presente { get; set; }
        public bool Ausente { get; set; }
        public bool Excusa { get; set; }

        public AsistenciasDetalle()
        {
            AsistenciaId = 0;
            PersonaId = 0;
            ActividadId = 0;
            Presente = false;
            Ausente = true;
            Excusa = false;
        }

        public AsistenciasDetalle(int personaId, int actividadId, bool presente, bool ausente, bool excusa)
        {
            PersonaId = personaId;
            ActividadId = actividadId;
            Presente = presente;
            Ausente = ausente;
            Excusa = excusa;
        }
    }
}