using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.templates
{
    public partial class ViewGestioneTemplate : Form
    {
        public ViewGestioneTemplate()
        {
            InitializeComponent();
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
    }
}
