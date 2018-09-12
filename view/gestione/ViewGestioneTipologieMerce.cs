using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
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
            dataTable.Rows.Clear();
            tipologie = controllerTipologia.ListaTipologieMerce();
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
        IControllerTipologiaMerce controllerTipologia = new ControllerTipologiaMerce();
    }
}
