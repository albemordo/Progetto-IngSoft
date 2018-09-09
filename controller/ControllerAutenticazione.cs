using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerAutenticazione : IControllerAutenticazione
    {
        protected static IControllerAutenticazione istanza;

        private ControllerAutenticazione() { }

        /**
         *  Singleton
         */
        public static IControllerAutenticazione getIstanza()
        {
            if (istanza == null)
                istanza = new ControllerAutenticazione();

            return istanza;
        }

        public bool Autentica(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void ChiudiSessione()
        {
            throw new NotImplementedException();
        }

        public IUtente GetUtenteAutenticato()
        {
            throw new NotImplementedException();
        }

        /**
         *  Non era da eliminare??
         */
        public bool IsAutenticato()
        {
            throw new NotImplementedException();
        }

    }
}
