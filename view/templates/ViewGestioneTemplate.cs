using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.templates
{
    public partial class ViewGestioneTemplate : Form
    {
        public ViewGestioneTemplate()
        {
            InitializeComponent();
            this.setupTable();
        }

        private void setupTable()
        {
            this.addTableColumns();
            this.addTableRows();
        }

        protected virtual void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void addTableColumns()
        {

        }

        protected virtual void addTableRows()
        {

        }

        protected virtual void mascheraDettaglioButton_Click(object sender, EventArgs e)
        {

        }
    }
}
