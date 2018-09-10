using AutotrasportiFantini.modello;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//TODO
//Solamente il nome da mostrare? 
//Da dove prendo l'elenco completo delle tipologie emrci presenti nel nostro sistema?
//Come trasferisco i valori alla schermata successiva?
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

        protected override void addTableColumns()
        {
           dataTable.Columns.Add("nomeTipologiaMerce", "Nome Tipologia Merce");
        }

        protected override void addTableRows()
        {
            dataTable.Rows.Add("Droga");
        }

        private void creaTipologiaMerceButton_Click(object sender, EventArgs e)
        {
            ViewCreazioneTipologiaMerce creaTipologiaMerce = new ViewCreazioneTipologiaMerce();
            creaTipologiaMerce.ShowDialog();
        }
    }
}
