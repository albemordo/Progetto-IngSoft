using System;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerAutenticazione
    {
		Boolean Autentica(String username, String password);
        Boolean IsAutenticato();
        IUtente UtenteAutenticato { get; set; }
        void ChiudiSessione();
    }
}
