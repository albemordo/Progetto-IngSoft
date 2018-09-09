using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;

namespace AutotrasportiFantini.controller
{
    class ControllerIndirizzi : IControllerIndirizzi
    {
        public IIndirizzo CreaIndirizzo(string qualificatore, string nome, string civico, string cap, string localita, string provincia)
        {
            throw new NotImplementedException();
			
        }

        public void EliminaIndirizzo(IIndirizzo indirizzo)
        {
            throw new NotImplementedException();
        }

        public IIndirizzo ModificaIndirizzo(IIndirizzo indirizzo, string qualificatore, string nome, string civico, string cap, string localita, string provincia)
        {
            throw new NotImplementedException();
        }
    }
}
