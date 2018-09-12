using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliPuntiSpedizioneAutista : Form
    {
        public ViewDettagliPuntiSpedizioneAutista(ISpedizione spedizione, IPuntoSpedizione puntoSpedizione)
        {
            InitializeComponent();

            this.puntoSpedizione = puntoSpedizione;
            this.spedizione = spedizione;
            this.setup();
        }
        private void setup()
        {
            this.localitaBox.Text = puntoSpedizione.indirizzo.localita;
            this.nomeBox.Text = puntoSpedizione.indirizzo.nome;
            this.provinciaBox.Text = puntoSpedizione.indirizzo.provincia;
            this.qualificatoreBox.Text = puntoSpedizione.indirizzo.qualificatore;
            this.capBox.Text = puntoSpedizione.indirizzo.cap;
            this.civicoBox.Text = puntoSpedizione.indirizzo.civico;
            if (puntoSpedizione.orarioArrivo != DateTime.MinValue)
                this.dateTimePicker.Value = puntoSpedizione.orarioArrivo;
            this.dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }
        private void inserisciOrarioButton_Click(object sender, EventArgs e)
        {
            controllerSpedizioniAutista.RegistraPuntoSpedizione(spedizione, puntoSpedizione, this.dateTimePicker.Value);
        }

        IPuntoSpedizione puntoSpedizione;
        ISpedizione spedizione;
        IControllerSpedizioniAutista controllerSpedizioniAutista = new ControllerSpedizioniAutista();
    }
}
