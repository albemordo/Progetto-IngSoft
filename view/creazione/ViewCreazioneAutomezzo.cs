using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
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
            IAutomezzo automezzo = new RisorseFactory().GetAutomezzo();
            automezzo.modello = this.modelloBox.Text;
            automezzo.produttore = this.marcaBox.Text;
            automezzo.targa = this.targaBox.Text;
            automezzo.targaRimorchio = this.targaRimorchioBox.Text;
            utente = ControllerAutenticazione.GetIstanza().GetUtenteAutenticato();
            automezzo.codiceDelegato = utente.idAziendale;
            repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.crea(automezzo);
        }

        private IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
        private IPersistenzaAutomezzo repoPersistenza;
        private IUtente utente;
        IControllerAutenticazione controller;
    }
}
