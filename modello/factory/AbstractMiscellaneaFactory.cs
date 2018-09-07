using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.modello.factory
{
    abstract class AbstractMiscellaneaFactory
    {
        public abstract IPuntoSpedizione CreaPuntoSpedizione(int id, IIndirizzo indirizzo, ISpedizione spedizione, DateTime orarioArrivo);

        public abstract IIndirizzo CreaIndirizzo(int id, string qualificatore, string nome, string civico, string localita, string cap, string provincia);
    }
}
