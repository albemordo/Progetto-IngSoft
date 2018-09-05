using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
    class ControllerPuntiSpedizione : IControllerPuntiSpedizione
    {
        public IPuntoSpedizione AggiornaIndirizzo(IPuntoSpedizione puntoSpedizione, IIndirizzo indirizzo)
        {
            throw new NotImplementedException();
        }

        public IPuntoSpedizione CreaPuntoSpedizione(IIndirizzo indirizzo)
        {
            throw new NotImplementedException();
        }

        public void EliminaPuntoSpedizione(IPuntoSpedizione puntoSpedizione)
        {
            throw new NotImplementedException();
        }

        public IPuntoSpedizione RegistraArrivo(IPuntoSpedizione puntoSpedizione, DateTime orario)
        {
            throw new NotImplementedException();
        }
    }
}
