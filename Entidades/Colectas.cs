using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesApostolica.Entidades
{
   public class Colectas
    {
        public int ColectasId { get; set; }

        public string Descripcion { get; set; }

        public double Meta { get; set; }

        public double Logrado { get; set; }



        public DateTime Vence { get; set; }
    }
}
