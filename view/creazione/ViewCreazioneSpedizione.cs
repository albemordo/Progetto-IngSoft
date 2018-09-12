using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewCreazioneSpedizione : Form
    {
        public ViewCreazioneSpedizione()
        {
            InitializeComponent();
        }
        
        private void setup()
        {
            this.dateTimePickerArrivoPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.merceListBox.Items.Clear();
            MessageBox.Show("" + controllerTipologiaMerce.ListaTipologieMerce().Count, "Errore Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            foreach (ITipologiaMerce tipologiaMerce in controllerTipologiaMerce.ListaTipologieMerce())
            {
                this.merceListBox.Items.Add(tipologiaMerce);
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            IIndirizzo partenza = controllerIndirizzi.CreaIndirizzo(this.qualificatorePartenzaBox.Text, this.nomePartenzaBox.Text, this.civicoPartenzaBox.Text, this.capPartenzaBox.Text, this.localitaPartenzaBox.Text, this.provinciaPartenzaBox.Text);
            IIndirizzo arrivo = controllerIndirizzi.CreaIndirizzo(this.qualificatoreArrivoBox.Text, this.nomeArrivoBox.Text, this.civicoArrivoBox.Text, this.capArrivoBox.Text, this.localitaArrivoBox.Text, this.provinciaArrivoBox.Text);
            ISpedizione spedizione = controllerSpedizioni.CreaSpedizione(partenza, arrivo, puntiSpedizione, float.Parse(this.distanzaBox.Text), (ITipologiaMerce)this.merceListBox.SelectedItem, float.Parse(this.quantitaBox.Text));
            foreach(IPuntoSpedizione ps in puntiSpedizione)
            {
                controllerIndirizzi.CreaIndirizzo(ps.indirizzo.qualificatore, ps.indirizzo.nome, ps.indirizzo.civico, ps.indirizzo.cap, ps.indirizzo.localita, ps.indirizzo.provincia);
            }
            this.pulisciCampi();
        }

        private void pulisciCampi()
        {
            this.pulisciAltriCampi();
            this.pulisciCampiPuntoSpedizione();
        }
        private void inserisciPuntoSpedizioneButton_Click(object sender, EventArgs e)
        {
            puntoSpedizione = new RisorseFactory().GetPuntoSpedizione();
            puntoSpedizione.indirizzo.qualificatore = this.qualificatorePunto.Text;
            puntoSpedizione.indirizzo.nome = this.nomePunto.Text;
            puntoSpedizione.indirizzo.civico = this.civicoPunto.Text;
            puntoSpedizione.indirizzo.cap = this.capPunto.Text;
            puntoSpedizione.indirizzo.localita = this.localitaPunto.Text;
            puntoSpedizione.indirizzo.provincia = this.provinciaPunto.Text;
            puntiSpedizione.Add(puntoSpedizione);
            pulisciCampiPuntoSpedizione();
        }

        private void pulisciCampiPuntoSpedizione()
        {
            this.qualificatorePunto.Text = "";
            this.nomePunto.Text = "";
            this.civicoPunto.Text = "";
            this.capPunto.Text = "";
            this.localitaPunto.Text = "";
            this.provinciaPunto.Text = "";
        }

        private void pulisciAltriCampi()
        {
            this.qualificatorePartenzaBox.Text = "";
            this.nomePartenzaBox.Text = "";
            this.civicoPartenzaBox.Text = "";
            this.capPartenzaBox.Text = "";
            this.localitaPartenzaBox.Text = "";
            this.provinciaPartenzaBox.Text = "";
            this.qualificatoreArrivoBox.Text = "";
            this.nomeArrivoBox.Text = "";
            this.civicoArrivoBox.Text = "";
            this.capArrivoBox.Text = "";
            this.localitaArrivoBox.Text = "";
            this.provinciaArrivoBox.Text = "";
            this.distanzaBox.Text = "";
            this.quantitaBox.Text = "";
        }

        IControllerGestioneSpedizione controllerSpedizioni = new ControllerGestioneSpedizione();
        IControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
        IControllerIndirizzi controllerIndirizzi = new ControllerIndirizzi();
        List<IPuntoSpedizione> puntiSpedizione = new List<IPuntoSpedizione>();
        IPuntoSpedizione puntoSpedizione;
    }
}
