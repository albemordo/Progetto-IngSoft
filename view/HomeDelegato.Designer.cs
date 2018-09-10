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
            this.SuspendLayout();
            // 
            // gestioneAutomezziButton
            // 
            this.gestioneAutomezziButton.Location = new System.Drawing.Point(330, 12);
            this.gestioneAutomezziButton.Name = "gestioneAutomezziButton";
            this.gestioneAutomezziButton.Size = new System.Drawing.Size(231, 23);
            this.gestioneAutomezziButton.TabIndex = 3;
            this.gestioneAutomezziButton.Text = "Gestione Automezzi";
            this.gestioneAutomezziButton.UseVisualStyleBackColor = true;
            this.gestioneAutomezziButton.Click += new System.EventHandler(this.gestioneAutomezziButton_Click);
            // 
            // HomeDelegato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.gestioneAutomezziButton);
            this.Name = "HomeDelegato";
            this.Text = "Home Delegato";
            this.Controls.SetChildIndex(this.formPanel, 0);
            this.Controls.SetChildIndex(this.gestioneAutomezziButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gestioneAutomezziButton;
    }
}
