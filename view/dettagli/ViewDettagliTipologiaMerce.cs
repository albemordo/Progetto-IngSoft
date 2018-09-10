using AutotrasportiFantini.modello;
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
    public partial class ViewDettagliTipologiaMerce : Form
    {
        public ViewDettagliTipologiaMerce()
        {
            InitializeComponent();
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            ITipologiaMerce tipologia = new RisorseFactory().GetTipologiaMerce();
            tipologia.tipologia = this.nomeTipologiaMerceBox.Text;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaTipologiaMerce repoPersistenza = factoryPersistenza.GetPersistenzaTipologiaMerce();
            repoPersistenza.aggiorna(tipologia);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            ITipologiaMerce tipologia = new RisorseFactory().GetTipologiaMerce();
            tipologia.tipologia = this.nomeTipologiaMerceBox.Text;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaTipologiaMerce repoPersistenza = factoryPersistenza.GetPersistenzaTipologiaMerce();
            repoPersistenza.elimina(0);
        }
    }
}
