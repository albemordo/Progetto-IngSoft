using System;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IIndirizzo
    {
        int id { get; set; }
        String qualificatore { get; set; }
        String nome { get; set; }
        String civico { get; set; }
        String cap { get; set; }
        String localita { get; set; }
        String provincia { get; set; }
    }
}
