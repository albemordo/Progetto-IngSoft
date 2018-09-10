using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


//Da dove prendo tutti i dati? Come gestisco il fatto di molteplici punti di spedizione?
//Inserimento nella tabella molto provvisorio
namespace AutotrasportiFantini.view
{
    public partial class ViewGestioneSpedizione : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneSpedizione()
        {
            InitializeComponent();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewCreazioneSpedizione viewDettagliTipologiaSpedizione = new ViewCreazioneSpedizione();
            viewDettagliTipologiaSpedizione.ShowDialog();
        }

        protected override void addTableColumns()
        {
            dataTable.Columns.Add("identificatoSpedizione", "Identificativo Spedizione");
            dataTable.Columns.Add("luogoPartenza", "Luogo Partenza");
            dataTable.Columns.Add("luogoArrivo", "Luogo Arrivo");
            dataTable.Columns.Add("puntiSpedizione", "Punti Spedizione");
            dataTable.Columns.Add("distanzaStimata", "Distanza Stimata");
            dataTable.Columns.Add("tipologiaMerce", "Tipologia Merce");
            dataTable.Columns.Add("quantitaMerce", "Quantita Merce");
            dataTable.Columns.Add("Autista", "Autista");
            dataTable.Columns.Add("Automezzo", "Automezzo");
            dataTable.Columns.Add("Delegato", "Delegato");
            dataTable.Columns.Add("orarioPartenzaPrevisto", "Orario Partenza Previsto");
            dataTable.Columns.Add("orarioArrivoPrevisto", "Orario Arrivo Previsto");
            dataTable.Columns.Add("orarioPartenzaEffettivo", "Orario Partenza Effettivo");
            dataTable.Columns.Add("orarioArrivoEffettivo", "Orario Arrivo Effettivo");
            dataTable.Columns.Add("orariEffettiviPuntiSpedizione", "Orari Effettivi Punti Spedizione");
            dataTable.Columns.Add("chilometriPercorsi", "Chilometri Percorsi");
            dataTable.Columns.Add("tempoPercorrenza", "Tempo Percorrenza");
        }

        protected override void addTableRows()
        {
            TipologiaMerce tipologiaMerce = new TipologiaMerce();
            tipologiaMerce.id = 1;
            tipologiaMerce.tipologia = "droga";
            Automezzo automezzo = new Automezzo();
            automezzo.id = 1;
            automezzo.targa = "randomTarga";
            automezzo.prod = "randomproduttore";
            automezzo.modello = "randommodello";
            automezzo.tr = "random targa rimorchio";
            automezzo.cod = "random code";
            Delegato delegato = new Delegato();
            delegato.cognome = "fantini";
            delegato.idAziendale = "1";
            delegato.nome = "davide";
            Autista autista = new Autista();
            autista.cognome = "progetto";
            autista.idAziendale = "2";
            autista.nome = "luca";
            Indirizzo partenza = new Indirizzo();
            partenza.id = 1;
            partenza.localita = "bologna";
            partenza.nome = "mmmh nome?";
            partenza.provincia = "random";
            partenza.qualificatore = "asd";
            partenza.cap = "12322";
            partenza.civico = "lknasd";
            Indirizzo arrivo = new Indirizzo();
            arrivo.id = 1;
            arrivo.localita = "reggio";
            arrivo.nome = "mmmh nome?";
            arrivo.provincia = "random";
            arrivo.qualificatore = "asd";
            arrivo.cap = "12322";
            arrivo.civico = "lknasd";
            List<IPuntoSpedizione> puntiSpedizione = new List<IPuntoSpedizione>();
            DateTime orarioPrevistoPartenza = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 00, 00);
            DateTime orarioPrevistoArrivo = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1, 20, 00, 00);
            DateTime orarioEffettivoPartenza = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 1, 0);
            DateTime orarioEffettivoArrivo = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1, 20, 1, 0);
            Spedizione spedizione = new Spedizione();
            spedizione.autista = autista;
            spedizione.automezzo = automezzo;
            spedizione.delegato = delegato;
            spedizione.destinazione = arrivo;
            spedizione.distanzaEffettiva = 1200;
            spedizione.distanzaStimata = 1000;
            spedizione.id = 1;
            spedizione.orarioEffettivoArrivo = orarioEffettivoArrivo;
            spedizione.orarioEffettivoPartenza = orarioEffettivoPartenza;
            spedizione.orarioPrevistoArrivo = orarioPrevistoArrivo;
            spedizione.orarioPrevistoPartenza = orarioPrevistoPartenza;
            spedizione.partenza = partenza;
            spedizione.destinazione = arrivo;
            spedizione.puntiSpedizione = puntiSpedizione;
            spedizione.quantitaMerce = 1000;
            spedizione.tempoPercorrenza = 10;
            spedizione.tipologiaMerce = tipologiaMerce;
            List<Spedizione> spedizioni = new List<Spedizione>();
            spedizioni.Add(spedizione);

            foreach (Spedizione sp in spedizioni)
            {
                dataTable.Rows.Add(sp.id, sp.partenza.localita, sp.destinazione.localita, sp.puntiSpedizione, sp.distanzaStimata, sp.tipologiaMerce.tipologia, sp.quantitaMerce,
                    sp.autista.cognome, sp.automezzo.targa, sp.delegato.cognome, sp.orarioPrevistoPartenza, sp.orarioPrevistoArrivo, sp.orarioEffettivoPartenza, sp.orarioEffettivoArrivo,
                    "boh", sp.distanzaEffettiva, sp.tempoPercorrenza);
            }
        }

        private void creaSpedizioneButton_Click(object sender, EventArgs e)
        {
            ViewCreazioneSpedizione viewCreaSpedizione = new ViewCreazioneSpedizione();
            viewCreaSpedizione.ShowDialog();
        }
    }
}
