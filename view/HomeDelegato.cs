using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


//Deve cominciare con l'altra vista che e' ancora da creare
namespace AutotrasportiFantini.view
{
    public partial class HomeDelegato : AutotrasportiFantini.view.templates.HomeTemplate
    {
        public HomeDelegato()
        {
            InitializeComponent();
            viewGestioneAutomezzo.TopLevel = false;
            viewGestioneAutomezzo.AutoScroll = true;
            this.formPanel.Controls.Clear();
        }  

        private void gestioneAutomezziButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneAutomezzo);
            viewGestioneAutomezzo.Show();
        }

        private ViewGestioneAutomezzo viewGestioneAutomezzo = new ViewGestioneAutomezzo();
    }
}
