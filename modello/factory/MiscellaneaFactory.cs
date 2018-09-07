using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.modello.factory
{
    class MiscellaneaFactory : AbstractMiscellaneaFactory
    {
        public override IIndirizzo CreaIndirizzo(int id, string qualificatore, string nome, string civico, string localita, string cap, string provincia)
        {
            throw new NotImplementedException();
        }

        public override IPuntoSpedizione CreaPuntoSpedizione(int id, IIndirizzo indirizzo, ISpedizione spedizione, DateTime orarioArrivo)
        {
            throw new NotImplementedException();
        }
    }
}
