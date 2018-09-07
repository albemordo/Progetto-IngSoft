using System;
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
