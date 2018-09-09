using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutotrasportiFantini.view.viewRuoli
{
    public partial class HomeAutista : AutotrasportiFantini.view.HomeTemplate
    {
        public HomeAutista()
        {
            InitializeComponent();
        }

        protected override void InserisciRigheTabella()
        {
            this.dataTable.Rows.Add("five", "six", "seven", "eight");
        }

        protected override void InserisciColonneTabella()
        {
            this.dataTable.Columns.Add("1", "testo 12123123");
            this.dataTable.Columns.Add("2", "testo 2");
            this.dataTable.Columns.Add("3", "testo 3");
            this.dataTable.Columns.Add("4", "testo 4");
        }
    }
}