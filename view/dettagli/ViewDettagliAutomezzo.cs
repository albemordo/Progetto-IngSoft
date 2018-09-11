using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.persistenza;
using AutotrasportiFantini.persistenza.repository.factory;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.dettagli
{
    public partial class ViewDettagliAutomezzo : Form
    {
        public ViewDettagliAutomezzo(IAutomezzo automezzo)
        {
            InitializeComponent();
            this.automezzo = automezzo;
            this.modelloBox.Text = automezzo.modello;
            this.targaBox.Text = automezzo.targa;
            this.targaRimorchioBox.Text = automezzo.targaRimorchio;
            this.marcaBox.Text = automezzo.produttore;
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {
            automezzo.modello = this.modelloBox.Text;
            automezzo.produttore = this.marcaBox.Text;
            automezzo.targa = this.targaBox.Text;
            automezzo.targaRimorchio = this.targaRimorchioBox.Text;
            repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.aggiorna(automezzo);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            repoPersistenza = factoryPersistenza.GetPersistenzaAutomezzo();
            repoPersistenza.elimina(automezzo.targa);
        }

        IPersistenzaFactory factoryPersistenza = new RepositoryFactory(DbConnectionFactory.SupportedDBMS.postgresql, "TestDb");
        IPersistenzaAutomezzo repoPersistenza;
        private IAutomezzo automezzo;
    }
}
