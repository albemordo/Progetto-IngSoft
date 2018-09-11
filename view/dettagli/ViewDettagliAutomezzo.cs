using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliAutomezzo : Form
    {
        public ViewDettagliAutomezzo(IAutomezzo automezzo)
        {
            InitializeComponent();
            this.automezzo = automezzo;
            this.modelloBox.Text = automezzo.modello;
            this.targaBox.Text = automezzo.targa;
            this.targaRimorchioBox.Text = automezzo.targaRimorchio;
            this.marcaBox.Text = automezzo.produttore;
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            controllerAutomezzi.ModificaAutomezzo(automezzo, this.targaBox.Text, this.marcaBox.Text, this.modelloBox.Text, this.targaRimorchioBox.Text, (Delegato)controllerAutenticazione.GetUtenteAutenticato());
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            controllerAutomezzi.EliminaAutomezzo(automezzo);
        }

        IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
        IControllerAutenticazione controllerAutenticazione = ControllerAutenticazione.GetIstanza();
        private IAutomezzo automezzo;
    }
}
