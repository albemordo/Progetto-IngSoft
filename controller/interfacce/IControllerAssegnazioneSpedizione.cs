using System;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerAssegnazioneSpedizione
    {
        void AssegnaAutista(ISpedizione spedizione, IAutista autista);
        void AssegnaAutomezzo(ISpedizione spedizione, IAutomezzo automezzo);
        void AssegnaOrari(ISpedizione spedizione, DateTime partenzaPrevista, DateTime arrivoPrevisto);
    }
}
