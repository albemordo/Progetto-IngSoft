using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello
{
    class Autista : IAutista
    {
        public Autista()
        {
        }

        public Autista(string idAziendale, string nome, string cognome)
        {
            this.idAziendale = idAziendale;
            this.nome = nome;
            this.cognome = cognome;
        }

        public string idAziendale { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
    }

}
