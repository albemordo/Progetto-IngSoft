using System;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IAutomezzo
    {
        int id { get; set; }
        String targa { get; set; }
        String prod { get; set; }
        String modello { get; set; }
        String tr { get; set; }
        String cod { get; set; }
    }
}
