using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotrasportiFantini.modello.interfacce;

namespace AutotrasportiFantini.controller.interfacce
{
    interface IControllerIndirizzi
    {
        IIndirizzo CreaIndirizzo(String qualificatore, String nome, String civico, String cap, String localita, String provincia);
        void EliminaIndirizzo(IIndirizzo indirizzo);
        IIndirizzo ModificaIndirizzo(IIndirizzo indirizzo, String qualificatore, String nome, String civico, String cap, String localita, String provincia);
    }
}
