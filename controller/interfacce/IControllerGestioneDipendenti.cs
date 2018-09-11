using System;
using System.Collections.Generic;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerGestioneDipendenti
    {
        IUtente VerificaCredenziali(String username, String password);
		IUtente OttieniUtente(String idAziendale);
        String RuoloUtente(IUtente utente);
        List<IDelegato> ListaDelegati();
        List<IAutista> ListaAutisti();
    }
}
