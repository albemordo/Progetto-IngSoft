using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliSpedizioneAutista : Form
    {
        public ViewDettagliSpedizioneAutista(ISpedizione spedizione)
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
            this.tipologiaMerceBox.Text = spedizione.tipologiaMerce.tipologia;
            this.provinciaPartenzaBox.Text = spedizione.partenza.localita;
            this.dateTimePickerArrivoPrevisto.Value = spedizione.orarioPrevistoArrivo;
            this.dateTimePickerPartenzaPrevisto.Value = spedizione.orarioPrevistoPartenza;
            this.dateTimePickerArrivoEffettivo.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoEffettivo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerArrivoPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaEffettiva.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaEffettiva.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.fillComboBoxAutisti();
            this.fillComboBoxAutomezzi();
        }
        private void addTableColumns()
        {
            this.dataTable.Columns.Clear();
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
            this.dataTable.Rows.Clear();
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
        private void fillComboBoxAutomezzi()
        {
            this.automezzoComboBox.SelectedItem = spedizione.automezzo;
        }

        private void fillComboBoxAutisti()
        {
            this.autistaComboBox.SelectedItem = spedizione.autista;
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            puntoSpedizione = spedizione.puntiSpedizione[dataTable.CurrentCell.RowIndex];
            viewDettagliPuntoSpedizione = new ViewDettagliPuntiSpedizioneAutista(spedizione, puntoSpedizione);
            viewDettagliPuntoSpedizione.ShowDialog();
        }

        private void modificaButton_Click(object sender, System.EventArgs e)
        {
            controllerSpedizioniAutista.RegistraPartenza(spedizione, this.dateTimePickerPartenzaEffettiva.Value);
        }

        private void terminaButton_Click(object sender, System.EventArgs e)
        {
            controllerSpedizioniAutista.RegistraFineSpedizione(spedizione, this.dateTimePickerArrivoEffettivo.Value, float.Parse(this.distanzaEffettivaBox.Text), int.Parse(this.tempoPercorrenzaBox.Text));
        }

        private void aggiornaTabellaButton_Click(object sender, EventArgs e)
        {
            this.addTableColumns();
            this.addTableRows();
        }

        IControllerSpedizioniAutista controllerSpedizioniAutista = new ControllerSpedizioniAutista();
        ViewDettagliPuntiSpedizioneAutista viewDettagliPuntoSpedizione;
        private ISpedizione spedizione;
        private IPuntoSpedizione puntoSpedizione;

        
    }
}
