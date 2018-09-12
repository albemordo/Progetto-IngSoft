using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using Newtonsoft.Json;
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
            setup();
        }
        
        private void setup()
        {
            this.merceListBox.Items.Clear();
            foreach (ITipologiaMerce tipologiaMerce in controllerTipologiaMerce.ListaTipologieMerce())
            {
                this.merceListBox.Items.Add(tipologiaMerce);
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            IIndirizzo partenza = controllerIndirizzi.CreaIndirizzo(this.qualificatorePartenzaBox.Text, this.nomePartenzaBox.Text, this.civicoPartenzaBox.Text, this.capPartenzaBox.Text, this.localitaPartenzaBox.Text, this.provinciaPartenzaBox.Text);
            IIndirizzo arrivo = controllerIndirizzi.CreaIndirizzo(this.qualificatoreArrivoBox.Text, this.nomeArrivoBox.Text, this.civicoArrivoBox.Text, this.capArrivoBox.Text, this.localitaArrivoBox.Text, this.provinciaArrivoBox.Text);
            foreach (IPuntoSpedizione ps in puntiSpedizione)
            {
                ps.indirizzo = controllerIndirizzi.CreaIndirizzo(ps.indirizzo.qualificatore, ps.indirizzo.nome, ps.indirizzo.civico, ps.indirizzo.cap, ps.indirizzo.localita, ps.indirizzo.provincia);
            }
            ISpedizione spedizione = controllerSpedizioni.CreaSpedizione(partenza, arrivo, puntiSpedizione, float.Parse(this.distanzaBox.Text), (ITipologiaMerce)this.merceListBox.SelectedItem, float.Parse(this.quantitaBox.Text));
            
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
            indirizzo = new RisorseFactory().GetIndirizzo();
            indirizzo.qualificatore = this.qualificatorePunto.Text;
            indirizzo.nome = this.nomePunto.Text;
            indirizzo.civico = this.civicoPunto.Text;
            indirizzo.cap = this.capPunto.Text;
            indirizzo.localita = this.localitaPunto.Text;
            indirizzo.provincia = this.provinciaPunto.Text;
            puntoSpedizione.indirizzo = indirizzo;
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
        IIndirizzo indirizzo;
    }
}
