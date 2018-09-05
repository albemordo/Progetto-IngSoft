using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
    class ControllerGestioneDipendenti : IControllerGestioneDipendenti
    {
        public List<IUtente> utenti;
        /**
         *  Viene creata una struttura dati statica per simulare
         *  il comportamento del sistema esterno
         */
        public ControllerGestioneDipendenti()
        {
            utenti = new List<IUtente>();

            /**
             *  Responsabili
             */
            utenti.Add(new Responsabile("AB100", "Federico", "Masoni"));
            utenti.Add(new Responsabile("BM412", "Marta", "Reverberi"));

            /**
             *  Delegati 
             */
            utenti.Add(new Delegato("FX420", "Ruben", "Prandini"));
            utenti.Add(new Delegato("AL174", "Mario", "Rossi"));
            utenti.Add(new Delegato("GN471", "Lucia", "Marinacci"));
            utenti.Add(new Delegato("ASK438", "Sergio", "Coppola"));

            /**
             *  Autisti 
             */
            utenti.Add(new Autista("VND921", "Laura", "Capiluppi"));
            utenti.Add(new Autista("CNS247", "Dario", "Piccinini"));
            utenti.Add(new Autista("JNA382", "Dario", "Buttiglioni"));
            utenti.Add(new Autista("AHD148", "Alice", "Polluzzi"));
            utenti.Add(new Autista("FKJ532", "Alberto", "Fava"));
        }

        public List<IAutista> ListaAutisti()
        {
            List<IAutista> result = new List<IAutista>();
            
            foreach (IUtente u in utenti)
            {
                if (u is IAutista)
                    result.Add((IAutista)u);
            }

            return result;
        }

        public List<IDelegato> ListaDelegati()
        {
            List<IDelegato> result = new List<IDelegato>();

            foreach (IUtente u in utenti)
            {
                if (u is IDelegato)
                    result.Add((IDelegato)u);
            }

            return result;
        }

        public string RuoloUtente(IUtente utente)
        {
            throw new NotImplementedException();
        }

        public IUtente VerificaCredenziali(string username, string password)
        {
            throw new NotImplementedException();
        }

        public static void Main(string[] args)
        {
            IControllerGestioneDipendenti dip = new ControllerGestioneDipendenti();
            System.Console.WriteLine(dip.ListaAutisti().Count());
        }
    }
}
