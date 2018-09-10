namespace AutotrasportiFantini.view
{
    partial class HomeResponsabile
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
            this.gestioneSpedizioniButton = new System.Windows.Forms.Button();
            this.gestioneTipologiaMerce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestioneSpedizioniButton
            // 
            this.gestioneSpedizioniButton.Location = new System.Drawing.Point(22, 12);
            this.gestioneSpedizioniButton.Name = "gestioneSpedizioniButton";
            this.gestioneSpedizioniButton.Size = new System.Drawing.Size(118, 23);
            this.gestioneSpedizioniButton.TabIndex = 3;
            this.gestioneSpedizioniButton.Text = "Gestione Spedizioni";
            this.gestioneSpedizioniButton.UseVisualStyleBackColor = true;
            this.gestioneSpedizioniButton.Click += new System.EventHandler(this.gestioneSpedizioniButton_Click);
            // 
            // gestioneTipologiaMerce
            // 
            this.gestioneTipologiaMerce.Location = new System.Drawing.Point(378, 12);
            this.gestioneTipologiaMerce.Name = "gestioneTipologiaMerce";
            this.gestioneTipologiaMerce.Size = new System.Drawing.Size(122, 23);
            this.gestioneTipologiaMerce.TabIndex = 4;
            this.gestioneTipologiaMerce.Text = "Gestioni Tipologie Merci";
            this.gestioneTipologiaMerce.UseVisualStyleBackColor = true;
            this.gestioneTipologiaMerce.Click += new System.EventHandler(this.gestioneTipologiaMerce_Click);
            // 
            // HomeResponsabile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.gestioneTipologiaMerce);
            this.Controls.Add(this.gestioneSpedizioniButton);
            this.Name = "HomeResponsabile";
            this.Text = "Home Responsabile";
            this.Controls.SetChildIndex(this.formPanel, 0);
            this.Controls.SetChildIndex(this.gestioneSpedizioniButton, 0);
            this.Controls.SetChildIndex(this.gestioneTipologiaMerce, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gestioneSpedizioniButton;
        private System.Windows.Forms.Button gestioneTipologiaMerce;
    }
}
