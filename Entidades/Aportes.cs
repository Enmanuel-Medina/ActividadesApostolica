using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.Entidades
{
    public class Aportes
    {
        public int AportesId { get; set; }

        public DateTime Fecha { get; set; }

        public int ColectaId { get; set; }

        public int Meta { get; set; }

        public int Persona { get; set; }

        public int Contribucion { get; set; }

        public int Resta { get; set; }

    }
}

