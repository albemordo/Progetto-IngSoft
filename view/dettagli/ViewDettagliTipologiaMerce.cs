using AutotrasportiFantini.controller;
using AutotrasportiFantini.controller.interfacce;
using AutotrasportiFantini.modello.interfacce;
using System;
using System.Windows.Forms;

namespace AutotrasportiFantini.view
{
    public partial class ViewDettagliTipologiaMerce : Form
    {
        public ViewDettagliTipologiaMerce(ITipologiaMerce tipologiaMerce)
        {
            InitializeComponent();
            this.tipologiaMerce = tipologiaMerce;
            setup();
            
        }
        private void setup()
        {
            this.nomeTipologiaMerceBox.Text = tipologiaMerce.tipologia;
        }
        private void modificaButton_Click(object sender, EventArgs e)
        {
            controllerTipologiaMerce.ModificaTipologiaMerce(tipologiaMerce, this.nomeTipologiaMerceBox.Text);
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            controllerTipologiaMerce.EliminaTipologiaMerce(tipologiaMerce);
        }

        IControllerTipologiaMerce controllerTipologiaMerce = new ControllerTipologiaMerce();
        ITipologiaMerce tipologiaMerce;
    }
}
