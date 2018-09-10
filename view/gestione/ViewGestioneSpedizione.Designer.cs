namespace AutotrasportiFantini.view
{
    partial class ViewGestioneSpedizione
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creaSpedizioneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creaSpedizioneButton
            // 
            this.creaSpedizioneButton.Location = new System.Drawing.Point(516, 583);
            this.creaSpedizioneButton.Name = "creaSpedizioneButton";
            this.creaSpedizioneButton.Size = new System.Drawing.Size(227, 50);
            this.creaSpedizioneButton.TabIndex = 2;
            this.creaSpedizioneButton.Text = "Crea Spedizione";
            this.creaSpedizioneButton.UseVisualStyleBackColor = true;
            this.creaSpedizioneButton.Click += new System.EventHandler(this.creaSpedizioneButton_Click);
            // 
            // ViewGestioneSpedizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.creaSpedizioneButton);
            this.Name = "ViewGestioneSpedizione";
            this.Text = "View Gestione Spedizione";
            this.Controls.SetChildIndex(this.creaSpedizioneButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button creaSpedizioneButton;
    }
}
