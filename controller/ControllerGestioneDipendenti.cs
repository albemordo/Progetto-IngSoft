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
            utenti = new List<IUtente>
            {
                /**
                 *  Responsabili
                 */
                new Responsabile("AB100", "Federico", "Masoni"),
                new Responsabile("BM412", "Marta", "Reverberi"),

                /**
                 *  Delegati 
                 */
                new Delegato("FX420", "Ruben", "Prandini"),
                new Delegato("AL174", "Mario", "Rossi"),
                new Delegato("GN471", "Lucia", "Marinacci"),
                new Delegato("ASK438", "Sergio", "Coppola"),

                /**
                 *  Autisti 
                 */
                new Autista("VND921", "Laura", "Capiluppi"),
                new Autista("CNS247", "Dario", "Piccinini"),
                new Autista("JNA382", "Dario", "Buttiglioni"),
                new Autista("AHD148", "Alice", "Polluzzi"),
                new Autista("FKJ532", "Alberto", "Fava")
            };
        }

        public List<IAutista> ListaAutisti()
        {
            List<IAutista> result = new List<IAutista>();
            
            foreach (IUtente u in utenti)
            {
                if (u is IAutista)
                    result.Add((IAutista) u);
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

        /**
         *  Anche questo andava eliminato, se non ricordo male
         */
        public string RuoloUtente(IUtente utente)
        {
            string ruolo;

            /**
             *  "GetType" restituisce l'intero namespace dell'istanza, 
             *  es: AutotrasportiFantini.modello.Autista .
             *  "Name" estrae il basename: in questo caso, Autista
             */
            return ((ruolo = utente.GetType().Name) != null) ? ruolo: "";
        }

        public IUtente VerificaCredenziali(string username, string password)
        {
            throw new NotImplementedException();
        }

        /*
        public static void Main(string[] args)
        {
            
            IControllerGestioneDipendenti dip = new ControllerGestioneDipendenti();
            System.Console.WriteLine("Ruolo " +dip.RuoloUtente(dip.ListaAutisti().ElementAt(0)));
        }
        */
    }
}
