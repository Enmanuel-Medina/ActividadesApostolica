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
        public int PersonaId { get; set; }
        public int AsistenciaId { get; set; }
        public string Nombre { get; set; }
        public bool Presente { get; set; }
        public bool Ausente { get; set; }
        public bool Excusa { get; set; }

        public AsistenciasDetalle()
        {
            PersonaId = 0;
            AsistenciaId = 0;
            Nombre = string.Empty;
            Presente = false;
            Ausente = true;
            Excusa = false;
        }
    }
}
