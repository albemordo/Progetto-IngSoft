using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerGestioneDipendenti
    {
        IUtente VerificaCredenziali(String username, String password);
        String RuoloUtente(IUtente utente);
        List<IDelegato> ListaDelegati();
        List<IAutista> ListaAutisti();
    }
}
