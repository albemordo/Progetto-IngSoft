using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
    class ControllerAssegnazioneSpedizione : IControllerAssegnazioneSpedizione
    {
        public void AssegnaAutista(ISpedizione spedizione, IAutista autista)
        {
            throw new NotImplementedException();
        }

        public void AssegnaAutomezzo(ISpedizione spedizione, IAutomezzo automezzo)
        {
            throw new NotImplementedException();
        }

        public void AssegnaOrari(ISpedizione spedizione, DateTime partenzaPrevista, DateTime arrivoPrevisto)
        {
            throw new NotImplementedException();
        }
    }
}
