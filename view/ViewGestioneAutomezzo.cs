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

        private void creaAutomezzoButton_Click(object sender, EventArgs e)
        {
            ViewCreazioneAutomezzo viewCreazioneAutomezzo = new ViewCreazioneAutomezzo();
            viewCreazioneAutomezzo.ShowDialog();
        }
    }
}
