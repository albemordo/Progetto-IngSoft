using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.modello.factory
{
    abstract class AbstractUtenteFactory
    {
        public abstract IAutista CreaAutista(string idAziendale, string nome, string cognome);

        public abstract IDelegato CreaDelegato(string idAziendale, string nome, string cognome);

        public abstract IResponsabile CreaResponsabile(string idAziendale, string nome, string cognome);

    }
}
