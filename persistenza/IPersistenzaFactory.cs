using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.persistenza
{
    interface IPersistenzaFactory
    {
        IPersistenzaAutomezzo GetPersistenzaAutomezzo();
        IPersistenzaIndirizzo GetPersistenzaIndirizzo();
        IPersistenzaSpedizione GetPersistenzaSpedizione();
        IPersistenzaTipologiaMerce GetPersistenzaTipologiaMerce();
    }
}
