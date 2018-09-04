using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class TipologiaMerce : ITipologiaMerce
    {
        public int id { get; set; }
        public string tipologia { get; set; }
    }
}
