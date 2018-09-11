using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewCreazioneAutomezzo : Form
    {
        public ViewCreazioneAutomezzo()
        {
            InitializeComponent();
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            controllerAutomezzi.CreaAutomezzo(this.targaBox.Text, this.marcaBox.Text, this.modelloBox.Text, this.targaRimorchioBox.Text,(IDelegato) controllerAutenticazione.GetUtenteAutenticato());
            this.pulisciCampi();
        }

        private void pulisciCampi()
        {
            this.targaBox.Text = "";
            this.marcaBox.Text = "";
            this.modelloBox.Text = "";
            this.targaRimorchioBox.Text = "";
        }

        IControllerAutenticazione controllerAutenticazione = ControllerAutenticazione.GetIstanza();
        IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
    }
}
