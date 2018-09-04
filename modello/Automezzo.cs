using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class Automezzo : IAutomezzo
    {
        public int id { get; set; }
        public String targa { get; set; }
        public String prod { get; set; }
        public String modello { get; set; }
        public String tr { get; set; }
        public String cod { get; set; }
    }
}
