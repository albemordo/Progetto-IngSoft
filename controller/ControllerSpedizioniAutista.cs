using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
    class ControllerSpedizioniAutista : IControllerSpedizioniAutista
    {
        public void RegistraFineSpedizione(ISpedizione spedizione, DateTime arrivo, float distanzaEffettiva, int tempoEffettivo)
        {
            throw new NotImplementedException();
        }

        public void RegistraPartenza(ISpedizione spedizione, DateTime partenza)
        {
            throw new NotImplementedException();
        }

        public void RegistraPuntoSpedizione(ISpedizione spedizione, IPuntoSpedizione punto, DateTime orario)
        {
            throw new NotImplementedException();
        }
    }
}
