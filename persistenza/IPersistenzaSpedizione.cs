using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.persistenza
{
    interface IPersistenzaSpedizione : IPersistenzaCRUD<ISpedizione, int>
    {
        List<ISpedizione> cercaPerDelegato(String codiceDelegato);
        List<ISpedizione> cercaPerAutista(String codiceAutista);
    }
}
