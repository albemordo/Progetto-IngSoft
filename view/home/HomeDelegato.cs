using AutotrasportiFantini.view.gestione;
using System;

namespace AutotrasportiFantini.view
{
    public partial class HomeDelegato : AutotrasportiFantini.view.templates.HomeTemplate
    {
        public HomeDelegato()
        {
            InitializeComponent();
            setup();
        }  

        private void setup()
        {
            viewGestioneSpedizione.TopLevel = false;
            viewGestioneSpedizione.AutoScroll = true;
            viewGestioneAutomezzo.TopLevel = false;
            viewGestioneAutomezzo.AutoScroll = true;
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneSpedizione);
            viewGestioneSpedizione.Show();
        }

        private void gestioneAutomezziButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneAutomezzo);
            viewGestioneAutomezzo.Show();
        }

        private void gestioneSpedizioniAssegnateButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneSpedizione);
            viewGestioneAutomezzo.Show();
        }

        ViewAssegnazioneSpedizione viewGestioneSpedizione = new ViewAssegnazioneSpedizione();
        ViewGestioneAutomezzo viewGestioneAutomezzo = new ViewGestioneAutomezzo();
    }
}
