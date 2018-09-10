using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Windows.Forms;

//TODO Come gestisco l'id? Ci pensa la repo?
namespace AutotrasportiFantini.view
{
    public partial class ViewCreazioneTipologiaMerce : Form
    {
        public ViewCreazioneTipologiaMerce()
        {
            InitializeComponent();
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            ITipologiaMerce tipologiaMerce = new RisorseFactory().GetTipologiaMerce();
            tipologiaMerce.tipologia = this.nomeTipologiaBox.Text;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaTipologiaMerce repoPersistenza = factoryPersistenza.GetPersistenzaTipologiaMerce();
            repoPersistenza.crea(tipologiaMerce);
        }
    }
}
