using AutotrasportiFantini.view.gestione;

namespace AutotrasportiFantini.view
{
    public partial class HomeAutista : AutotrasportiFantini.view.templates.HomeTemplate
    {
        public HomeAutista()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            viewGestioneSpedizioneAssegnata.TopLevel = false;
            viewGestioneSpedizioneAssegnata.AutoScroll = true;
            this.formPanel.Controls.Clear();
            this.formPanel.Controls.Add(viewGestioneSpedizioneAssegnata);
            viewGestioneSpedizioneAssegnata.Show();
        }
        ViewGestioneSpedizioneAssegnata viewGestioneSpedizioneAssegnata = new ViewGestioneSpedizioneAssegnata();
    }
}
