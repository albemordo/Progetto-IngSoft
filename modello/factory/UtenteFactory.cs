using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.modello.factory
{
    class UtenteFactory : AbstractUtenteFactory
    {
        public override IAutista CreaAutista(string idAziendale, string nome, string cognome)
        {
            return new Autista(idAziendale, nome, cognome);
        }

        public override IDelegato CreaDelegato(string idAziendale, string nome, string cognome)
        {
            return new Delegato(idAziendale, nome, cognome);
        }

        public override IResponsabile CreaResponsabile(string idAziendale, string nome, string cognome)
        {
            return new Responsabile(idAziendale, nome, cognome);
        }
    }
}
