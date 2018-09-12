using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.view.dettagli;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.gestione
{
    public partial class ViewGestioneSpedizioneAssegnata : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneSpedizioneAssegnata()
        {
            InitializeComponent();
        }

        private void createViewDettagliSpedizioneAutista()
        {
            spedizione = spedizioni[dataTable.CurrentCell.RowIndex];
            viewDettagliSpedizioneAutista = new ViewDettagliSpedizioneAutista(spedizione);
            viewDettagliSpedizioneAutista.ShowDialog();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createViewDettagliSpedizioneAutista();
        }

        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            createViewDettagliSpedizioneAutista();
        }

        protected override void addTableColumns()
        {
            dataTable.Columns.Clear();
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
            spedizioni = controllerListaSpedizioni.ListaSpedizioni(Controller.UtenteAutenticato);
            dataTable.Rows.Clear();

            int max = 0;
            foreach (Spedizione sp in spedizioni)
            {
                if (sp.puntiSpedizione.Count > max)
                    max = sp.puntiSpedizione.Count;
            }

            for (int i = 0; i < max; i++)
            {
                dataTable.Columns.Add("puntoSpedizione" + i, "Punto Spedizione " + i);
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

                if (spedizioneTemp.autista is null == false)
                {
                    dataTable.Rows[i].Cells[6].Value = spedizioneTemp.autista.cognome;
                }

                if (spedizioneTemp.automezzo is null == false)
                {
                    dataTable.Rows[i].Cells[7].Value = spedizioneTemp.automezzo.targa;
                }

                if (spedizioneTemp.delegato is null == false)
                {
                    dataTable.Rows[i].Cells[8].Value = spedizioneTemp.delegato.cognome;
                }

                if (spedizioneTemp.orarioPrevistoPartenza != DateTime.MinValue)
                {
                    dataTable.Rows[i].Cells[9].Value = spedizioneTemp.orarioPrevistoPartenza;
                }

                if (spedizioneTemp.orarioPrevistoPartenza != DateTime.MinValue)
                {
                    dataTable.Rows[i].Cells[10].Value = spedizioneTemp.orarioPrevistoArrivo;
                }

                if (spedizioneTemp.orarioEffettivoPartenza != DateTime.MinValue)
                {
                    dataTable.Rows[i].Cells[11].Value = spedizioneTemp.orarioEffettivoPartenza;
                }

                if (spedizioneTemp.orarioEffettivoArrivo != DateTime.MinValue)
                {
                    dataTable.Rows[i].Cells[12].Value = spedizioneTemp.orarioEffettivoArrivo;
                }

                dataTable.Rows[i].Cells[13].Value = spedizioneTemp.distanzaEffettiva;
                dataTable.Rows[i].Cells[14].Value = spedizioneTemp.tempoPercorrenza;
                for (int j = 0; j < spedizioneTemp.puntiSpedizione.Count; j++)
                {
                    dataTable.Rows[i].Cells[15 + j * 2].Value = spedizioneTemp.puntiSpedizione[j].indirizzo.localita;
                    if (spedizioneTemp.puntiSpedizione[j].orarioArrivo != DateTime.MinValue)
                    {
                        dataTable.Rows[i].Cells[16 + j * 2].Value = spedizioneTemp.puntiSpedizione[j].orarioArrivo;
                    }
                }
            }
        }

        ViewDettagliSpedizioneAutista viewDettagliSpedizioneAutista;
        ISpedizione spedizione = new RisorseFactory().GetSpedizione();
        List<ISpedizione> spedizioni;
        IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
        IControllerListaSpedizioni controllerListaSpedizioni = new ControllerListaSpedizioni();
    }
}
