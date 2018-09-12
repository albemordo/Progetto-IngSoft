using AutotrasportiFantini.modello;
using AutotrasportiFantini.modello.factory;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewGestioneTipologieMerce : AutotrasportiFantini.view.templates.ViewGestioneTemplate
    {
        public ViewGestioneTipologieMerce()
        {
            InitializeComponent();
        }
        private void createViewDettaglitipologiaMerce()
        {
            tipologiaMerce = tipologie[dataTable.CurrentCell.RowIndex];
            viewDettagliTipologiaMerce = new ViewDettagliTipologiaMerce(tipologiaMerce);
            viewDettagliTipologiaMerce.ShowDialog();
        }
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            createViewDettaglitipologiaMerce();
        }
        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            createViewDettaglitipologiaMerce();
        }
        protected override void addTableColumns()
        {
           dataTable.Columns.Add("nomeTipologiaMerce", "Nome Tipologia Merce");
        }
        protected override void addTableRows()
        {
            ///CODICE REALE
            ///
            ///IControllerAutenticazione Controller = ControllerAutenticazione.GetIstanza();
            ///ControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
            ///tipologie = controllerTipologiaMerce.ListaTipologieMerce();
            ///CODICE REALE
            ///


            ///CODICE TEST
            ///
            TipologiaMerce tipologiaMerce1 = new TipologiaMerce();
            tipologiaMerce1.tipologia = "legno";
            tipologiaMerce1.id = 1;
            tipologie = new List<ITipologiaMerce>();
            tipologie.Add(tipologiaMerce1);
            TipologiaMerce tipologiaMerce2 = new TipologiaMerce();
            tipologiaMerce2.tipologia = "droga";
            tipologiaMerce2.id = 2;
            tipologie.Add(tipologiaMerce2);
            ///CODICE TEST
            ///

            dataTable.Rows.Clear();
            foreach (TipologiaMerce sp in tipologie)
            {
                dataTable.Rows.Add(sp.tipologia);
            }
        }
        private void creaTipologiaMerceButton_Click(object sender, EventArgs e)
        {
            creaTipologiaMerce = new ViewCreazioneTipologiaMerce();
            creaTipologiaMerce.ShowDialog();
        }

        List<ITipologiaMerce> tipologie;
        ViewDettagliTipologiaMerce viewDettagliTipologiaMerce;
        ViewCreazioneTipologiaMerce creaTipologiaMerce;
        ITipologiaMerce tipologiaMerce = new RisorseFactory().GetTipologiaMerce();

        private void ViewGestioneTipologieMerce_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Ho il focus nella gestione tipologie", "Errore Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
