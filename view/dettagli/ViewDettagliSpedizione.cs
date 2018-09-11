using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliSpedizione : Form
    {
        public ViewDettagliSpedizione(ISpedizione spedizione)
        {
            InitializeComponent();
            this.spedizione = spedizione;
            setup();
        }

        private void setup()
        {
            this.addTableColumns();
            this.addTableRows();
            this.quantitaBox.Text = spedizione.quantitaMerce.ToString();
            this.localitaArrivoBox.Text = spedizione.destinazione.localita;
            this.nomeArrivoBox.Text = spedizione.destinazione.nome;
            this.provinciaArrivoBox.Text = spedizione.destinazione.provincia;
            this.qualificatoreArrivoBox.Text = spedizione.destinazione.qualificatore;
            this.capArrivoBox.Text = spedizione.destinazione.cap;
            this.civicoArrivoBox.Text = spedizione.destinazione.civico;
            this.localitaPartenzaBox.Text = spedizione.partenza.localita;
            this.nomePartenzaBox.Text = spedizione.partenza.nome;
            this.provinciaPartenzaBox.Text = spedizione.partenza.provincia;
            this.capPartenzaBox.Text = spedizione.partenza.cap;
            this.civicoPartenzaBox.Text = spedizione.partenza.civico;
            this.qualificatorePartenzaBox.Text = spedizione.partenza.qualificatore;
            this.distanzaBox.Text = spedizione.distanzaStimata.ToString();
            this.distanzaEffettivaBox.Text = spedizione.distanzaEffettiva.ToString();
            this.provinciaPartenzaBox.Text = spedizione.partenza.localita;
            this.dateTimePickerArrivoPrevisto.Value = spedizione.orarioPrevistoArrivo;
            this.dateTimePickerArrivoEffettivo.Value = spedizione.orarioEffettivoArrivo;
            this.dateTimePickerPartenzaEffettivo.Value = spedizione.orarioEffettivoPartenza;
            this.dateTimePickerPartenzaPrevisto.Value = spedizione.orarioPrevistoPartenza;
            this.dateTimePickerArrivoEffettivo.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoEffettivo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerArrivoPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaEffettivo.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaEffettivo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.fillComboBoxAutisti();
            this.fillComboBoxDelegati();
            foreach (ITipologiaMerce tipologiaMerce in controllerTipologiaMerce.ListaTipologieMerce())
            {
                this.merceListBox.Items.Add(tipologiaMerce);
            }
        }
        private void fillComboBoxAutomezzi()
        {
            this.listBoxAutomezzo.Items.Clear();
            foreach (IAutomezzo automezzo in controllerAutomezzi.ListaAutomezzi((IDelegato)this.listBoxDelegato.SelectedItem))
            {
                this.listBoxAutomezzo.Items.Add(automezzo);
            }
        }
        private void fillComboBoxAutisti()
        {
            this.listBoxAutista.Items.Clear();
            foreach (IAutista autista in controllerGestioneDipendenti.ListaAutisti())
            {
                this.listBoxAutista.Items.Add(autista);
            }
        }
        private void fillComboBoxDelegati()
        {
            this.listBoxDelegato.Items.Clear();
            foreach (IAutomezzo automezzo in controllerGestioneDipendenti.ListaDelegati())
            {
                this.listBoxDelegato.Items.Add(automezzo);
            }
        }
        private void addTableColumns()
        {
            dataTable.Columns.Add("localita", "Località");
            dataTable.Columns.Add("nome", "Nome");
            dataTable.Columns.Add("provincia", "Provincia");
            dataTable.Columns.Add("qualificatore", "Qualificatore");
            dataTable.Columns.Add("cap", "Cap");
            dataTable.Columns.Add("civico", "Civico");
            dataTable.Columns.Add("orarioArrivo", "Orario Arrivo");
        }

        private void addTableRows()
        {
            for (int i = 0; i < spedizione.puntiSpedizione.Count; i++)
            {
                this.dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = spedizione.puntiSpedizione[i].indirizzo.localita;
                dataTable.Rows[i].Cells[1].Value = spedizione.puntiSpedizione[i].indirizzo.nome;
                dataTable.Rows[i].Cells[2].Value = spedizione.puntiSpedizione[i].indirizzo.provincia;
                dataTable.Rows[i].Cells[3].Value = spedizione.puntiSpedizione[i].indirizzo.qualificatore;
                dataTable.Rows[i].Cells[4].Value = spedizione.puntiSpedizione[i].indirizzo.cap;
                dataTable.Rows[i].Cells[5].Value = spedizione.puntiSpedizione[i].indirizzo.civico;
                dataTable.Rows[i].Cells[6].Value = spedizione.puntiSpedizione[i].orarioArrivo;
            }
        }
 
        private void modificaButton_Click(object sender, EventArgs e)
        {
            IIndirizzo arrivo = controllerIndirizzi.CreaIndirizzo(this.qualificatoreArrivoBox.Text, this.nomeArrivoBox.Text, this.civicoArrivoBox.Text, this.capArrivoBox.Text, this.localitaArrivoBox.Text, this.provinciaArrivoBox.Text);
            IIndirizzo partenza = controllerIndirizzi.CreaIndirizzo(this.qualificatorePartenzaBox.Text, this.nomePartenzaBox.Text, this.civicoPartenzaBox.Text, this.capPartenzaBox.Text, this.localitaPartenzaBox.Text, this.provinciaPartenzaBox.Text);
            List<IPuntoSpedizione> listaPuntiSpedizione = new List<IPuntoSpedizione>();
            ITipologiaMerce tipologiaMerceTemp = (TipologiaMerce) this.merceListBox.SelectedItem;
            for (int i = 0; i < dataTable.RowCount; i++)
            {
                IPuntoSpedizione puntoSpedizioneTemp = new RisorseFactory().GetPuntoSpedizione();
                puntoSpedizioneTemp = spedizione.puntiSpedizione[dataTable.CurrentCell.RowIndex];
                listaPuntiSpedizione.Add(puntoSpedizioneTemp);
            }
            controllerSpedizioni.ModificaDati(spedizione, partenza, arrivo, listaPuntiSpedizione, float.Parse(this.distanzaBox.Text), float.Parse(this.distanzaEffettivaBox.Text),
                int.Parse(this.tempoStimatoBox.Text), tipologiaMerceTemp, float.Parse(this.quantitaBox.Text), (IAutista)this.listBoxAutista.SelectedItem, (IAutomezzo)this.listBoxAutomezzo.SelectedItem,
                (IDelegato)this.listBoxDelegato.SelectedItem, this.dateTimePickerPartenzaPrevisto.Value, this.dateTimePickerArrivoPrevisto.Value, this.dateTimePickerPartenzaEffettivo.Value,
                this.dateTimePickerArrivoPrevisto.Value);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            controllerSpedizioni.EliminaSpedizione(spedizione);
        }
        
        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            puntoSpedizione = spedizione.puntiSpedizione[dataTable.CurrentCell.RowIndex];
            viewDettagliPuntoSpedizione = new ViewDettagliPuntoSpedizione(puntoSpedizione);
            viewDettagliPuntoSpedizione.ShowDialog();
        }
        private void delegaButton_Click(object sender, EventArgs e)
        {
            controllerSpedizioni.AssegnaDelegato(spedizione, (IDelegato)this.listBoxDelegato.SelectedItem);
        }
        private void delegatoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillComboBoxAutomezzi();
        }

        IControllerGestioneSpedizione controllerSpedizioni = new ControllerGestioneSpedizione();
        IControllerGestioneDipendenti controllerGestioneDipendenti = new ControllerGestioneDipendenti();
        IControllerIndirizzi controllerIndirizzi = new ControllerIndirizzi();
        IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
        ViewDettagliPuntoSpedizione viewDettagliPuntoSpedizione;
        ISpedizione spedizione;
        IPuntoSpedizione puntoSpedizione;
        IControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
    }
}
