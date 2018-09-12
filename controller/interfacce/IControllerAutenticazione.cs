using System;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerAutenticazione
    {
		IUtente UtenteAutenticato { get; set; }

		Boolean Autentica(String username, String password);
        Boolean IsAutenticato();
        IUtente GetUtenteAutenticato();
        void ChiudiSessione();
    }
}
