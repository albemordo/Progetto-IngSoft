using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class PuntoSpedizione : IPuntoSpedizione
    {
        public int id { get; set; }
        public IIndirizzo indirizzo { get; set; }
        public ISpedizione spedizione { get; set; }
        public DateTime orarioArrivo { get; set; }
    }
}
