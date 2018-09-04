using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerListaSpedizioni
    {
        List<ISpedizione> ListaSpedizioni(IUtente utente);
    }
}
