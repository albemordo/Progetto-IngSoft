using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewDettagliTipologiaMerce : Form
    {
        public ViewDettagliTipologiaMerce(ITipologiaMerce tipologiaMerce)
        {
            InitializeComponent();
            this.tipologiaMerce = tipologiaMerce;
            this.nomeTipologiaMerceBox.Text = tipologiaMerce.tipologia;
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            tipologiaMerce.tipologia = this.nomeTipologiaMerceBox.Text;
            repoPersistenza = factoryPersistenza.GetPersistenzaTipologiaMerce();
            repoPersistenza.aggiorna(tipologiaMerce);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            repoPersistenza = factoryPersistenza.GetPersistenzaTipologiaMerce();
            repoPersistenza.elimina(tipologiaMerce.id);
        }

        IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
        IPersistenzaTipologiaMerce repoPersistenza;
        private ITipologiaMerce tipologiaMerce;
    }
}
