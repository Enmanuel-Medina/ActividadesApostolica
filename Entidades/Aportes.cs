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

        public int Persona { get; set; }

        public double Contribucion { get; set; }

        public double Resta { get; set; }

        public Aportes()
        {
        }
    }
}

