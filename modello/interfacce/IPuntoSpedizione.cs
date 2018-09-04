using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IPuntoSpedizione
    {
        int id { get; set; }
        IIndirizzo indirizzo { get; set; }
        ISpedizione spedizione { get; set; }
        DateTime orarioArrivo { get; set; }
    }
}
