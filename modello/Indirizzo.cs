﻿using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;

namespace AutotrasportiFantini.modello
{
    class Indirizzo : IIndirizzo
	{

        public int id { get; set; }
        public string qualificatore { get; set; }
        public string nome { get; set; }
        public string civico { get; set; }
        public string cap { get; set; }
        public string localita { get; set; }
        public string provincia { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
    }
}
