using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliPuntoSpedizioneAutista : Form
    {
        public ViewDettagliPuntoSpedizioneAutista(IPuntoSpedizione puntoSpedizione)
        {
            InitializeComponent();
            this.puntoSpedizione = puntoSpedizione;
            this.localitaBox.Text = puntoSpedizione.indirizzo.localita;
            this.nomeBox.Text = puntoSpedizione.indirizzo.nome;
            this.provinciaBox.Text = puntoSpedizione.indirizzo.provincia;
            this.qualificatoreBox.Text = puntoSpedizione.indirizzo.qualificatore;
            this.capBox.Text = puntoSpedizione.indirizzo.cap;
            this.civicoBox.Text = puntoSpedizione.indirizzo.civico;
            this.dateTimePicker.Value = puntoSpedizione.orarioArrivo;
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            IIndirizzo indirizzo = controllerIndirizzi.CreaIndirizzo(this.qualificatoreBox.Text, this.nomeBox.Text, this.civicoBox.Text, this.capBox.Text, this.localitaBox.Text, this.provinciaBox.Text);
            controllerPuntiSpedizione.AggiornaIndirizzo(puntoSpedizione, indirizzo);
            controllerPuntiSpedizione.RegistraArrivo(puntoSpedizione, dateTimePicker.Value);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            controllerPuntiSpedizione.EliminaPuntoSpedizione(puntoSpedizione);
        }

        private IPuntoSpedizione puntoSpedizione;
        IControllerIndirizzi controllerIndirizzi = new ControllerIndirizzi();
        IControllerPuntiSpedizione controllerPuntiSpedizione = new ControllerPuntiSpedizione();
        IControllerGestioneSpedizione controllerGestioneSpedizione = new ControllerGestioneSpedizione();
    }

    
}
