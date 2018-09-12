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
    public partial class ViewAssegnazioneSpedizione : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewAssegnazioneSpedizione()
        {
            InitializeComponent();
        }
        private void createViewDettagliSpedizioneDelegato() {
            spedizione = spedizioni[dataTable.CurrentCell.RowIndex];
            viewDettagliSpedizioneDelegato = new ViewDettagliSpedizioneDelegato(spedizione);
            viewDettagliSpedizioneDelegato.ShowDialog();
        }

        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createViewDettagliSpedizioneDelegato();
        }

        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            createViewDettagliSpedizioneDelegato();
        }
        protected override void addTableColumns()
        {
            dataTable.Columns.Add("identificatoSpedizione", "Identificativo Spedizione");
            dataTable.Columns.Add("luogoPartenza", "Luogo Partenza");
            dataTable.Columns.Add("luogoArrivo", "Luogo Arrivo");
            dataTable.Columns.Add("tipologiaMerce", "Tipologia Merce");
            dataTable.Columns.Add("quantitaMerce", "Quantita Merce");
            dataTable.Columns.Add("Autista", "Autista");
            dataTable.Columns.Add("Automezzo", "Automezzo");
            dataTable.Columns.Add("orarioPartenzaPrevisto", "Orario Partenza Previsto");
            dataTable.Columns.Add("orarioArrivoPrevisto", "Orario Arrivo Previsto");
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
            }

            for (int i = 0; i < spedizioni.Count; i++)
            {
                ISpedizione spedizioneTemp = new RisorseFactory().GetSpedizione();
                spedizioneTemp = spedizioni[i];
                this.dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = spedizioneTemp.id;
                dataTable.Rows[i].Cells[1].Value = spedizioneTemp.partenza.localita;
                dataTable.Rows[i].Cells[2].Value = spedizioneTemp.destinazione.localita;
                dataTable.Rows[i].Cells[3].Value = spedizioneTemp.tipologiaMerce.tipologia;
                dataTable.Rows[i].Cells[4].Value = spedizioneTemp.quantitaMerce;
                dataTable.Rows[i].Cells[5].Value = spedizioneTemp.autista.cognome;
                dataTable.Rows[i].Cells[6].Value = spedizioneTemp.automezzo.targa;
                dataTable.Rows[i].Cells[7].Value = spedizioneTemp.orarioPrevistoPartenza;
                dataTable.Rows[i].Cells[8].Value = spedizioneTemp.orarioPrevistoArrivo;
                for (int j = 0; j < spedizioneTemp.puntiSpedizione.Count; j++)
                {
                    dataTable.Rows[i].Cells[9 + j].Value = spedizioneTemp.puntiSpedizione[j].indirizzo.localita;
                }

            }
        }
        ISpedizione spedizione;
        List<ISpedizione> spedizioni;
        IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
        IControllerListaSpedizioni controllerListaSpedizioni = new ControllerListaSpedizioni();
        ViewDettagliSpedizioneDelegato viewDettagliSpedizioneDelegato;
    }
}
