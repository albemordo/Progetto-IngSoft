using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.persistenza
{
    interface IPersistenzaAutomezzo : IPersistenzaCRUD<IAutomezzo, int>
    {
        List<IAutomezzo> elencaPerDelegato(String codiceDelegato);
    }
}
