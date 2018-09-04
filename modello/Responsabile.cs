using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class Responsabile : IResponsabile
    {
        public string idAziendale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
    }
}
