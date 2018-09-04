using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerTipologieMerce
    {
        List<ITipologiaMerce> ListaTipologieMerce();
        ITipologiaMerce CreaTipologiaMerce(String tipologia);
        ITipologiaMerce ModificaTipologiaMerce(ITipologiaMerce tipologia, String nomeTipologia);
        void EliminaTipologiaMerce(ITipologiaMerce tipologia);
    }
}
