using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Windows.Forms;



//TODO INSERIMENTO
namespace AutotrasportiFantini.view
{
    public partial class ViewCreazioneSpedizione : Form
    {
        public ViewCreazioneSpedizione()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ISpedizione spedizione = new RisorseFactory().GetSpedizione();
            
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaSpedizione repoPersistenza = factoryPersistenza.GetPersistenzaSpedizione();
            repoPersistenza.crea(spedizione);
        }
    }
}
