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

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliAutomezzo : Form
    {
        public ViewDettagliAutomezzo()
        {
            InitializeComponent();
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            IAutomezzo automezzo = new RisorseFactory().GetAutomezzo();
            automezzo.modello = this.modelloBox.Text;
            automezzo.produttore = this.marcaBox.Text;
            automezzo.targa = this.targaBox.Text;
            automezzo.targaRimorchio = this.targaRimorchioBox.Text;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaAutomezzo repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.aggiorna(automezzo);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            IAutomezzo automezzo = new RisorseFactory().GetAutomezzo();
            automezzo.modello = this.modelloBox.Text;
            automezzo.produttore = this.marcaBox.Text;
            automezzo.targa = this.targaBox.Text;
            automezzo.targaRimorchio = this.targaRimorchioBox.Text;
            IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
            IPersistenzaAutomezzo repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.elimina(automezzo.targa);
        }
    }
}
