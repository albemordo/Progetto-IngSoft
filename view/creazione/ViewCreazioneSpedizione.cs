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
            this.dateTimePickerArrivoPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerArrivoPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerPartenzaPrevisto.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerPartenzaPrevisto.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            IIndirizzo partenza = controllerIndirizzi.CreaIndirizzo(this.qualificatorePunto.Text, this.nomePunto.Text, this.civicoPunto.Text, this.capPunto.Text, this.localitaPunto.Text, this.provinciaPunto.Text);
            IIndirizzo arrivo = controllerIndirizzi.CreaIndirizzo(this.qualificatorePunto.Text, this.nomePunto.Text, this.civicoPunto.Text, this.capPunto.Text, this.localitaPunto.Text, this.provinciaPunto.Text);
            ITipologiaMerce tipologiaMerce = controllerTipologiaMerce.CreaTipologiaMerce(this.tipologiaMerceBox.Text);
            controllerSpedizioni.CreaSpedizione(partenza, arrivo, puntiSpedizione, float.Parse(this.distanzaBox.Text), tipologiaMerce, float.Parse(this.quantitaBox.Text));
        }

        private void inserisciPuntoSpedizioneButton_Click(object sender, EventArgs e)
        {
            IPuntoSpedizione puntoSpedizione = new RisorseFactory().GetPuntoSpedizione();
            puntoSpedizione.indirizzo = controllerIndirizzi.CreaIndirizzo(this.qualificatorePunto.Text, this.nomePunto.Text, this.civicoPunto.Text, this.capPunto.Text, this.localitaPunto.Text, this.provinciaPunto.Text);
            puntiSpedizione.Add(puntoSpedizione);
        }

        IControllerGestioneSpedizione controllerSpedizioni = new ControllerGestioneSpedizione();
        IControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
        IControllerIndirizzi controllerIndirizzi = new ControllerIndirizzi();
        private List<IPuntoSpedizione> puntiSpedizione;
    }
}
