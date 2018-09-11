using System;

namespace AutotrasportiFantini.view
{
    public partial class HomeResponsabile : AutotrasportiFantini.view.templates.HomeTemplate
    {
        public HomeResponsabile()
        {
            InitializeComponent();
            viewGestioneSpedizione.TopLevel = false;
            viewGestioneSpedizione.AutoScroll = true;
            viewGestioneTipologiaMerce.TopLevel = false;
            viewGestioneTipologiaMerce.AutoScroll = true;
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneSpedizione);
            viewGestioneSpedizione.Show();
        }

        private void gestioneSpedizioniButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneSpedizione);
            viewGestioneSpedizione.Show();
        }

        private void gestioneTipologiaMerce_Click(object sender, EventArgs e)
        {
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneTipologiaMerce);
            viewGestioneTipologiaMerce.Show();
        }

        private ViewGestioneSpedizione viewGestioneSpedizione = new ViewGestioneSpedizione();
        private ViewGestioneTipologieMerce viewGestioneTipologiaMerce = new ViewGestioneTipologieMerce();
    }


}
