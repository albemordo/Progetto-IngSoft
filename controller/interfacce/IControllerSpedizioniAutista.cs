using System;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerSpedizioniAutista
    {
        void RegistraPartenza(ISpedizione spedizione, DateTime partenza);
        void RegistraFineSpedizione(ISpedizione spedizione, DateTime arrivo, float distanzaEffettiva, int tempoEffettivo);
        void RegistraPuntoSpedizione(ISpedizione spedizione, IPuntoSpedizione punto, DateTime orario);
    }
}
