namespace AutotrasportiFantini.view
{
    partial class HomeDelegato
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
            this.gestioneAutomezziButton = new System.Windows.Forms.Button();
            this.gestioneSpedizioniAssegnateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Size = new System.Drawing.Size(1004, 645);
            // 
            // gestioneAutomezziButton
            // 
            this.gestioneAutomezziButton.Location = new System.Drawing.Point(244, 6);
            this.gestioneAutomezziButton.Name = "gestioneAutomezziButton";
            this.gestioneAutomezziButton.Size = new System.Drawing.Size(227, 50);
            this.gestioneAutomezziButton.TabIndex = 3;
            this.gestioneAutomezziButton.Text = "Gestione Automezzi";
            this.gestioneAutomezziButton.UseVisualStyleBackColor = true;
            this.gestioneAutomezziButton.Click += new System.EventHandler(this.gestioneAutomezziButton_Click);
            // 
            // gestioneSpedizioniAssegnateButton
            // 
            this.gestioneSpedizioniAssegnateButton.Location = new System.Drawing.Point(12, 6);
            this.gestioneSpedizioniAssegnateButton.Name = "gestioneSpedizioniAssegnateButton";
            this.gestioneSpedizioniAssegnateButton.Size = new System.Drawing.Size(227, 50);
            this.gestioneSpedizioniAssegnateButton.TabIndex = 4;
            this.gestioneSpedizioniAssegnateButton.Text = "Gestione Spedizioni Assegnate";
            this.gestioneSpedizioniAssegnateButton.UseVisualStyleBackColor = true;
            this.gestioneSpedizioniAssegnateButton.Click += new System.EventHandler(this.gestioneSpedizioniAssegnateButton_Click);
            // 
            // HomeDelegato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 706);
            this.Controls.Add(this.gestioneSpedizioniAssegnateButton);
            this.Controls.Add(this.gestioneAutomezziButton);
            this.Name = "HomeDelegato";
            this.Text = "Home Delegato";
            this.Controls.SetChildIndex(this.formPanel, 0);
            this.Controls.SetChildIndex(this.gestioneAutomezziButton, 0);
            this.Controls.SetChildIndex(this.gestioneSpedizioniAssegnateButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gestioneAutomezziButton;
        private System.Windows.Forms.Button gestioneSpedizioniAssegnateButton;
    }
}
