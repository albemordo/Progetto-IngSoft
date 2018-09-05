using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.controller
{
    class ControllerAutomezzi : IControllerAutomezzi
    {
        public IAutomezzo CreaAutomezzo(string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
            throw new NotImplementedException();
        }

        public void EliminaAutomezzo(IAutomezzo automezzo)
        {
            throw new NotImplementedException();
        }

        public List<IAutomezzo> ListaAutomezzi(IDelegato delegato)
        {
            throw new NotImplementedException();
        }

        public IAutomezzo ModificaAutomezzo(IAutomezzo automezzo, string targa, string produttore, string modello, string targaRimorchio, IDelegato delegato)
        {
            throw new NotImplementedException();
        }
    }
}
