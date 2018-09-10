using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.persistenza
{
    interface IPersistenzaIndirizzo : IPersistenzaCRUD<IIndirizzo, int>
    {
        IIndirizzo cercaIndirizzo(String qualificatore, String nome, String civico, String cap,
            String localita, String provincia);
    }
}
