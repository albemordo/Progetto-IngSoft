using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IControllerAutenticazione controller = ControllerAutenticazione.GetIstanza();
            IUtente utente = controller.GetUtenteAutenticato();
            automezzo.codiceDelegato = utente.idAziendale;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaAutomezzo repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.crea(automezzo);
        }
    }
}
