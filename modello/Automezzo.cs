using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class Automezzo : IAutomezzo
    {
        public Automezzo()
        {
        }

        public Automezzo(int id, string targa, string prod, string modello, string tr, string cod)
        {
            this.id = id;
            this.targa = targa;
            this.prod = prod;
            this.modello = modello;
            this.tr = tr;
            this.cod = cod;
        }

        public int id { get; set; }
        public String targa { get; set; }
        public String prod { get; set; }
        public String modello { get; set; }
        public String tr { get; set; }
        public String cod { get; set; }
    }
}
