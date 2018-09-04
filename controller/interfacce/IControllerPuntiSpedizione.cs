using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerPuntiSpedizione
    {
        IPuntoSpedizione CreaPuntoSpedizione(IIndirizzo indirizzo);
        IPuntoSpedizione RegistraArrivo(IPuntoSpedizione puntoSpedizione, DateTime orario);
        IPuntoSpedizione AggiornaIndirizzo(IPuntoSpedizione puntoSpedizione, IIndirizzo indirizzo);
        void EliminaPuntoSpedizione(IPuntoSpedizione puntoSpedizione);
    }
}
