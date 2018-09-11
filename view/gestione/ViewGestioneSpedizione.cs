﻿using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.view.dettagli;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewGestioneSpedizione : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneSpedizione()
        {
            InitializeComponent();
        }

        private void createViewDettagliSpedizione()
        {
            spedizione = spedizioni[dataTable.CurrentCell.RowIndex];
            viewDettagliSpedizione = new ViewDettagliSpedizione(spedizione);
            viewDettagliSpedizione.ShowDialog();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createViewDettagliSpedizione();
        }
        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            createViewDettagliSpedizione();
        }

        private void creaSpedizioneButton_Click(object sender, EventArgs e)
        {
            viewCreaSpedizione = new ViewCreazioneSpedizione();
            viewCreaSpedizione.ShowDialog();
        }
        protected override void addTableColumns()
        {
            dataTable.Columns.Add("identificatoSpedizione", "Identificativo Spedizione");
            dataTable.Columns.Add("luogoPartenza", "Luogo Partenza");
            dataTable.Columns.Add("luogoArrivo", "Luogo Arrivo");
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
            dataTable.Columns.Add("chilometriPercorsi", "Chilometri Percorsi");
            dataTable.Columns.Add("tempoPercorrenza", "Tempo Percorrenza");
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
            PuntoSpedizione puntoSpedizione = new PuntoSpedizione();
            puntoSpedizione.id = 1;
            Indirizzo indirizzoPuntoSpedizione = new Indirizzo();
            indirizzoPuntoSpedizione.id = 1;
            indirizzoPuntoSpedizione.localita = "puntoSpedizione1";
            indirizzoPuntoSpedizione.nome = "mmmh nome?";
            indirizzoPuntoSpedizione.provincia = "random";
            indirizzoPuntoSpedizione.qualificatore = "asd";
            indirizzoPuntoSpedizione.cap = "12322";
            indirizzoPuntoSpedizione.civico = "lknasd";
            puntoSpedizione.indirizzo = indirizzoPuntoSpedizione;
            puntoSpedizione.orarioArrivo= new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 14, 00, 00);
            puntoSpedizione.spedizione = 1;
            puntiSpedizione.Add(puntoSpedizione);
            Indirizzo indirizzoPuntoSpedizione2 = new Indirizzo();
            PuntoSpedizione puntoSpedizione2 = new PuntoSpedizione();
            indirizzoPuntoSpedizione2.id = 1;
            indirizzoPuntoSpedizione2.localita = "puntoSpedizione2";
            indirizzoPuntoSpedizione2.nome = "asasdw?";
            indirizzoPuntoSpedizione2.provincia = "raagwgagasndom";
            indirizzoPuntoSpedizione2.qualificatore = "aasgasgsd";
            indirizzoPuntoSpedizione2.cap = "12123322";
            indirizzoPuntoSpedizione2.civico = "lknasd";
            puntoSpedizione2.indirizzo = indirizzoPuntoSpedizione2;
            puntoSpedizione2.orarioArrivo = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 15, 00, 00);
            puntoSpedizione2.spedizione = 2;
            puntiSpedizione.Add(puntoSpedizione2);
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
            ///CODICE DI PROVA
            //////CODICE DI PROVA

            ///CODICE REALE
            ///
            //IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
            //IControllerListaSpedizioni controllerListaSpedizioni = new ControllerListaSpedizioni();
            //List<ISpedizione> spedizioni = controllerListaSpedizioni.ListaSpedizioni(Controller.GetUtenteAutenticato());
            ///CODICE REALE
            ///

            spedizioni = new List<ISpedizione>();
            spedizioni.Add(spedizione);
            dataTable.Rows.Clear();

            int max = 0;
            foreach(Spedizione sp in spedizioni)
            {
                if (sp.puntiSpedizione.Count > max)
                    max = sp.puntiSpedizione.Count;
            }

            for (int i = 0; i < max; i++)
            {
                dataTable.Columns.Add("puntoSpedizione"+i, "Punto Spedizione " +i);
                dataTable.Columns.Add("orarioArrivoEffettivoPuntoSpedizione" + i, "O.E Arrivo P.D.S " + i);
            }

            for (int i = 0; i < spedizioni.Count; i++)
            {
                ISpedizione spedizioneTemp = new RisorseFactory().GetSpedizione();
                spedizioneTemp = spedizioni[i];
                this.dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = spedizioneTemp.id;
                dataTable.Rows[i].Cells[1].Value = spedizioneTemp.partenza.localita;
                dataTable.Rows[i].Cells[2].Value = spedizioneTemp.destinazione.localita;
                dataTable.Rows[i].Cells[3].Value = spedizioneTemp.distanzaStimata;
                dataTable.Rows[i].Cells[4].Value = spedizioneTemp.tipologiaMerce.tipologia;
                dataTable.Rows[i].Cells[5].Value = spedizioneTemp.quantitaMerce;
                dataTable.Rows[i].Cells[6].Value = spedizioneTemp.autista.cognome;
                dataTable.Rows[i].Cells[7].Value = spedizioneTemp.automezzo.targa;
                dataTable.Rows[i].Cells[8].Value = spedizioneTemp.delegato.cognome;
                dataTable.Rows[i].Cells[9].Value = spedizioneTemp.orarioPrevistoPartenza;
                dataTable.Rows[i].Cells[10].Value = spedizioneTemp.orarioPrevistoArrivo;
                dataTable.Rows[i].Cells[11].Value = spedizioneTemp.orarioEffettivoPartenza;
                dataTable.Rows[i].Cells[12].Value = spedizioneTemp.orarioEffettivoArrivo;
                dataTable.Rows[i].Cells[13].Value = spedizioneTemp.distanzaEffettiva;
                dataTable.Rows[i].Cells[14].Value = spedizioneTemp.tempoPercorrenza;
                for (int j = 0; j < spedizioneTemp.puntiSpedizione.Count; j++)
                {
                    dataTable.Rows[i].Cells[15 + j * 2].Value = spedizioneTemp.puntiSpedizione[j].indirizzo.localita;
                    dataTable.Rows[i].Cells[16 + j * 2].Value = spedizioneTemp.puntiSpedizione[j].orarioArrivo;
                }
            }
        }

        ViewDettagliSpedizione viewDettagliSpedizione;
        ViewCreazioneSpedizione viewCreaSpedizione;
        ISpedizione spedizione = new RisorseFactory().GetSpedizione();
        List<ISpedizione> spedizioni;
    }
}
