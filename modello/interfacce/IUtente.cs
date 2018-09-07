using System;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IUtente
    {
        String idAziendale { get; set; }
        String nome { get; set; }
        String cognome { get; set; }
    }
}
