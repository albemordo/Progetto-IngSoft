using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
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
