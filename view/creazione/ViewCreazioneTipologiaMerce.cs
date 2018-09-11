using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewCreazioneTipologiaMerce : Form
    {
        public ViewCreazioneTipologiaMerce()
        {
            InitializeComponent();
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            IControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
            controllerTipologiaMerce.CreaTipologiaMerce(this.nomeTipologiaBox.Text);
        }
    }
}
