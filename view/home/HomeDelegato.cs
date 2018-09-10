using AutotrasportiFantini.view.gestione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class HomeDelegato : AutotrasportiFantini.view.templates.HomeTemplate
    {
        public HomeDelegato()
        {
            InitializeComponent();
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
        private ViewAssegnazioneSpedizione viewGestioneSpedizione = new ViewAssegnazioneSpedizione();
        private ViewGestioneAutomezzo viewGestioneAutomezzo = new ViewGestioneAutomezzo();
    }
}
