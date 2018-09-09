using AutotrasportiFantini.view.templates;
using System.Windows.Forms;


//Va bene fatto cosi il riempi tabella? Bella domanda, da verificare //Funzione che sarà poi sovrascritta dalle varie home
//Anche CellDoubleClick dovrebbe essere abstract per essere successivamente implementato dalle altre 3 home? 

namespace AutotrasportiFantini.view
{
    public partial class HomeTemplate : Form
    {
        public HomeTemplate()
        {
            InitializeComponent();
            RiempiTabella();
        }

        private void RiempiTabella()
        {
            InserisciColonneTabella();
            InserisciRigheTabella();
        }

        protected virtual void InserisciColonneTabella()
        {

        }

        protected virtual void InserisciRigheTabella()
        {

        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDettagliTemplate ViewDettagli = new ViewDettagliTemplate();
            ViewDettagli.Show();
        }
    }
}
