using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.view.dettagli;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewGestioneAutomezzo : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneAutomezzo()
        {
            InitializeComponent();
        }

        private void createViewDettagliAutomezzo()
        {
            automezzo = automezzi[dataTable.CurrentCell.RowIndex];
            viewDettagliAutomezzo = new ViewDettagliAutomezzo(automezzo);
            viewDettagliAutomezzo.ShowDialog();
        }

        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createViewDettagliAutomezzo();
        }

        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            createViewDettagliAutomezzo();
        }

        private void creaAutomezzoButton_Click(object sender, EventArgs e)
        {
            viewCreazioneAutomezzo = new ViewCreazioneAutomezzo();
            viewCreazioneAutomezzo.ShowDialog();
        }

        protected override void addTableColumns()
        {
            dataTable.Columns.Add("marca", "Marca");
            dataTable.Columns.Add("modello", "Modello");
            dataTable.Columns.Add("targa", "Targa");
            dataTable.Columns.Add("targaRimorchio", "Targa Rimorchio");
        }

        protected override void addTableRows()
        {
            ///CODICE DI PROVA
            ///
            Automezzo automezzo = new Automezzo();
            automezzo.targa = "randomTarga";
            automezzo.produttore = "randomproduttore";
            automezzo.modello = "randommodello";
            automezzo.targaRimorchio = "random targa rimorchio";
            automezzo.codiceDelegato = "random code";
            automezzi = new List<IAutomezzo>();
            automezzi.Add(automezzo);
            automezzo = new Automezzo();
            automezzo.targa = "MORDO";
            automezzo.produttore = "ALBERTO";
            automezzo.modello = "albertoCamion";
            automezzo.targaRimorchio = "targaRimorchioMordo";
            automezzo.codiceDelegato = "3";
            automezzi.Add(automezzo);
            ///CODICE DI PROVA
            //////CODICE DI PROVA

            ///CODICE REALE
            ///
            ///IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
            ///IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
            ///List<IAutomezzo> automezzi = controllerAutomezzi.ListaAutomezzi((Delegato) Controller.GetUtenteAutenticato());
            ///CODICE REALE
            ///

            dataTable.Rows.Clear();
            foreach (Automezzo sp in automezzi)
            {
                dataTable.Rows.Add(sp.produttore, sp.modello, sp.targa, sp.targaRimorchio);
            }
        }

        List<IAutomezzo> automezzi;
        ViewDettagliAutomezzo viewDettagliAutomezzo;
        ViewCreazioneAutomezzo viewCreazioneAutomezzo;
        IAutomezzo automezzo = new RisorseFactory().GetAutomezzo();
    }
}
