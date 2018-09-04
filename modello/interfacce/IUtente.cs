using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IUtente
    {
        String idAziendale { get; set; }
        String nome { get; set; }
        String cognome { get; set; }
    }
}
