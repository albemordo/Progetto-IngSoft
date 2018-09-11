using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliSpedizioneDelegato : Form
    {
        public ViewDettagliSpedizioneDelegato(ISpedizione spedizione)
        {
            InitializeComponent();
            this.spedizione = spedizione;
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
            this.fillComboBoxAutisti();
            this.fillComboBoxAutomezzi();
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
        private void fillComboBoxAutomezzi()
        {
            List<IAutomezzo> automezzi = controllerAutomezzi.ListaAutomezzi((IDelegato)controllerAutenticazione.GetUtenteAutenticato());
            this.automezzoComboBox.DataSource = automezzi;
        }

        private void fillComboBoxAutisti()
        {
            List<IAutista> autisti = controllerGestioneDipendenti.ListaAutisti();
            this.autistaComboBox.DataSource = autisti;
        }

        private void modificaButton_Click(object sender, System.EventArgs e)
        {
            controllerAssegnazioneSpedizione.AssegnaOrari(spedizione, this.dateTimePickerPartenzaPrevisto.Value, this.dateTimePickerArrivoPrevisto.Value);
        }

        private void autistaButton_Click(object sender, System.EventArgs e)
        {
            controllerAssegnazioneSpedizione.AssegnaAutista(spedizione, (IAutista)this.autistaComboBox.SelectedItem);
            controllerAssegnazioneSpedizione.AssegnaAutomezzo(spedizione, (IAutomezzo)this.automezzoComboBox.SelectedItem);
        }

        IControllerAssegnazioneSpedizione controllerAssegnazioneSpedizione = new ControllerAssegnazioneSpedizione();
        IControllerGestioneSpedizione controllerSpedizioni = new ControllerGestioneSpedizione();
        IControllerAutenticazione controllerAutenticazione = ControllerAutenticazione.GetIstanza();
        IControllerGestioneDipendenti controllerGestioneDipendenti = new ControllerGestioneDipendenti();
        IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
        private ISpedizione spedizione;
        private IPuntoSpedizione puntoSpedizione; 
    }
}
