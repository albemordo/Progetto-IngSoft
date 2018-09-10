using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello;
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
        protected override void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDettagliTipologiaMerce viewDettagliTipologiaMerce = new ViewDettagliTipologiaMerce();
            viewDettagliTipologiaMerce.ShowDialog();
        }
        protected override void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {
            ViewDettagliTipologiaMerce viewDettagliTipologiaMerce = new ViewDettagliTipologiaMerce();
            viewDettagliTipologiaMerce.ShowDialog();
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
            ///List<ITipologiaMerce> tipologie = controllerTipologiaMerce.ListaTipologieMerce();
            ///CODICE REALE
            ///


            ///CODICE TEST
            ///
            TipologiaMerce tipologiaMerce = new TipologiaMerce();
            tipologiaMerce.tipologia = "legno";
            tipologiaMerce.id = 1;
            List<ITipologiaMerce> tipologie = new List<ITipologiaMerce>();
            tipologie.Add(tipologiaMerce);
            ///CODICE TEST
            ///
            foreach (TipologiaMerce sp in tipologie)
            {
                dataTable.Rows.Add(sp.tipologia);
            }
        }

        private void creaTipologiaMerceButton_Click(object sender, EventArgs e)
        {
            ViewCreazioneTipologiaMerce creaTipologiaMerce = new ViewCreazioneTipologiaMerce();
            creaTipologiaMerce.ShowDialog();
        }
    }
}
