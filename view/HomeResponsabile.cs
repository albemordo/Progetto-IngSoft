using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.viewRuoli
{
    public partial class HomeResponsabile : AutotrasportiFantini.view.HomeTemplate
    {
        public HomeResponsabile()
        {
            InitializeComponent();
        }

        protected override void InserisciColonneTabella()
        {
            this.dataTable.Columns.Add("1", "testo asd");
            this.dataTable.Columns.Add("2", "testo 2");
            this.dataTable.Columns.Add("3", "testo 3");
            this.dataTable.Columns.Add("4", "testo 4");
        }

        protected override void InserisciRigheTabella()
        {
            this.dataTable.Rows.Add("five", "six", "seven", "eight");
        }
    }
}
