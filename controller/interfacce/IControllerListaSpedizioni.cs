using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerListaSpedizioni
    {
        List<ISpedizione> ListaSpedizioni(IUtente utente);
    }
}
