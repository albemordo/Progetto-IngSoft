using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.view;
using AutotrasportiFantini.view.templates;
using System;
using System.Windows.Forms;


//Come mettere Invio per far in modo che faccia la funzione login?
namespace AutotrasportiFantini
{
    public partial class ViewAutenticazione : Form
    {
        public ViewAutenticazione()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Controller.Autentica(this.UsernameBox.Text, this.PasswordBox.Text.GetHashCode().ToString()) == true)
            {
                this.Hide();
                HomeTemplate homeUtente = new HomeTemplate();
                if (Controller.GetUtenteAutenticato() is Delegato)
                {
                    homeUtente = new HomeDelegato();
                }
                else
                {
                    if(Controller.GetUtenteAutenticato() is Autista)
                    {
                        homeUtente = new HomeAutista();
                    }
                    else
                    {
                        homeUtente = new HomeResponsabile();
                    }
                }

                homeUtente.Closed += (s, args) => this.Close();
                homeUtente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Il Login non è andato a buon fine, riprova", "Errore Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
    }
}
