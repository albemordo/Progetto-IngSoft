using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.interfacce;
using AutotrasportiFantini.view.dettagli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewGestioneAutomezzo : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneAutomezzo()
        {
            InitializeComponent();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDettagliAutomezzo viewDettagliAutomezzo = new ViewDettagliAutomezzo();
            viewDettagliAutomezzo.ShowDialog();
        }
        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            ViewDettagliAutomezzo viewDettagliAutomezzo = new ViewDettagliAutomezzo();
            viewDettagliAutomezzo.ShowDialog();
        }
        private void creaAutomezzoButton_Click(object sender, EventArgs e)
        {
            ViewCreazioneAutomezzo viewCreazioneAutomezzo = new ViewCreazioneAutomezzo();
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
            List<IAutomezzo> automezzi = new List<IAutomezzo>();
            ///CODICE DI PROVA
            //////CODICE DI PROVA

            ///CODICE REALE
            ///
            /// IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
            ///IControllerAutomezzi controllerAutomezzi = new ControllerAutomezzi();
            ///List<IAutomezzo> automezzi = controllerAutomezzi.ListaAutomezzi((Delegato) Controller.GetUtenteAutenticato());
            ///CODICE REALE
            ///

            automezzi = new List<IAutomezzo>();
            automezzi.Add(automezzo);
            foreach (Automezzo sp in automezzi)
            {
                dataTable.Rows.Add(sp.produttore, sp.modello, sp.targa, sp.targaRimorchio);
            }
        }
    }
}
