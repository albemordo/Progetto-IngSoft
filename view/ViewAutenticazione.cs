using System;
using System.Windows.Forms;
using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.view.viewRuoli;

//TODO LIST
//Va bene il messaggio di errore così? Meglio se vengano gestiti in modo diverso? Tipo che rilevino il codice di errore e il messaggio da qualche parte?
//Non e' ancora stato implementato il controller.autentica quindi ho impostato semplicemente un true per il momento
//Decommentare this.hide() e HomeUtente.Closed
//Fare che crei, chiaramente, l'interfaccia in base al ruolo dell'utente. Da dove si prende il ruolo?

namespace AutotrasportiFantini.view
{
    public partial class ViewAutenticazione : Form
    {
        public ViewAutenticazione()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (/*Controller.Autentica(this.UsernameBox.Text, this.PasswordBox.Text.GetHashCode().ToString()) */ true) 
            {
                //this.Hide();
                HomeTemplate HomeUtente = new HomeResponsabile();
                HomeUtente.Show();
                HomeUtente = new HomeAutista();
                HomeUtente.Show();
                HomeUtente = new HomeDelegato();
                HomeUtente.Show();

                //HomeUtente.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Il Login non è andato a buon fine, riprova", "Errore Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        IControllerAutenticazione Controller = ControllerAutenticazione.getIstanza();
    }
}
