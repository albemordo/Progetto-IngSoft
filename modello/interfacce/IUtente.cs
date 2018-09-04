using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotrasportiFantini.modello.interfacce
{
    interface IUtente
    {
        String getIdAziendale();
        void setIdAziendale(String id);
        String getNome();
        void setNome(String nome);
        String getCognome();
        void setCognome(String cognome);
    }
}
