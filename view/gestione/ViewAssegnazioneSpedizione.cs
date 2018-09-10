using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.view.dettagli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.gestione
{
    public partial class ViewAssegnazioneSpedizione : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewAssegnazioneSpedizione()
        {
            InitializeComponent();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDettagliSpedizioneDelegato viewDettagliSpedizioneDelegato = new ViewDettagliSpedizioneDelegato();
            viewDettagliSpedizioneDelegato.ShowDialog();
        }

        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            ViewDettagliSpedizioneDelegato viewDettagliSpedizioneDelegato = new ViewDettagliSpedizioneDelegato();
            viewDettagliSpedizioneDelegato.ShowDialog();
        }
        protected override void addTableColumns()
        {
            dataTable.Columns.Add("identificatoSpedizione", "Identificativo Spedizione");
            dataTable.Columns.Add("luogoPartenza", "Luogo Partenza");
            dataTable.Columns.Add("luogoArrivo", "Luogo Arrivo");
            dataTable.Columns.Add("puntiSpedizione", "Punti Spedizione");
            dataTable.Columns.Add("tipologiaMerce", "Tipologia Merce");
            dataTable.Columns.Add("quantitaMerce", "Quantita Merce");
            dataTable.Columns.Add("Autista", "Autista");
            dataTable.Columns.Add("Automezzo", "Automezzo");
            dataTable.Columns.Add("orarioPartenzaPrevisto", "Orario Partenza Previsto");
            dataTable.Columns.Add("orarioArrivoPrevisto", "Orario Arrivo Previsto");
        }

        protected override void addTableRows()
        {
            ///CODICE DI PROVA
            ///
            TipologiaMerce tipologiaMerce = new TipologiaMerce();
            tipologiaMerce.id = 1;
            tipologiaMerce.tipologia = "droga";
            Automezzo automezzo = new Automezzo();
            automezzo.targa = "randomTarga";
            automezzo.produttore = "randomproduttore";
            automezzo.modello = "randommodello";
            automezzo.targaRimorchio = "random targa rimorchio";
            automezzo.codiceDelegato = "random code";
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
            Spedizione spedizione = new Spedizione();
            spedizione.autista = autista;
            spedizione.automezzo = automezzo;
            spedizione.destinazione = arrivo;
            spedizione.id = 1;
            spedizione.orarioPrevistoArrivo = orarioPrevistoArrivo;
            spedizione.orarioPrevistoPartenza = orarioPrevistoPartenza;
            spedizione.partenza = partenza;
            spedizione.destinazione = arrivo;
            spedizione.puntiSpedizione = puntiSpedizione;
            spedizione.quantitaMerce = 1000;
            spedizione.tipologiaMerce = tipologiaMerce;
            ///CODICE DI PROVA
            //////CODICE DI PROVA

            ///CODICE REALE
            ///
            IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
            ControllerListaSpedizioni controllerListaSpedizioni = new ControllerListaSpedizioni();
            List<ISpedizione> spedizioni = controllerListaSpedizioni.ListaSpedizioni(Controller.GetUtenteAutenticato());
            ///CODICE REALE
            ///

            spedizioni = new List<ISpedizione>();
            spedizioni.Add(spedizione);
            foreach (Spedizione sp in spedizioni)
            {
                dataTable.Rows.Add(sp.id, sp.partenza.localita, sp.destinazione.localita, sp.puntiSpedizione,sp.tipologiaMerce.tipologia, sp.quantitaMerce,
                    sp.autista.cognome, sp.automezzo.targa, sp.orarioPrevistoPartenza, sp.orarioPrevistoArrivo);
            }
        }
    }
}
