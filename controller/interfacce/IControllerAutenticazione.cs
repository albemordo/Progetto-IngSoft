using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerAutenticazione
    {
        Boolean Autentica(String username, String password);
        Boolean IsAutenticato();
        IUtente GetUtenteAutenticato();
        void ChiudiSessione();
    }
}
