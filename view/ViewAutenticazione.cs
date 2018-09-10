using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (/*Controller.Autentica(this.UsernameBox.Text, this.PasswordBox.Text.GetHashCode().ToString()) */ true)
            {
                //this.Hide();
                HomeResponsabile homeResponsabile = new HomeResponsabile();
                homeResponsabile.Show();
                HomeAutista homeAutista = new HomeAutista();
                homeAutista.Show();
                HomeDelegato homeDelegato = new HomeDelegato();
                homeDelegato.Show();

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
