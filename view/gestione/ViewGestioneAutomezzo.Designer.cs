namespace AutotrasportiFantini.view
{
    partial class ViewGestioneAutomezzo
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
            this.creaAutomezzoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creaAutomezzoButton
            // 
            this.creaAutomezzoButton.Location = new System.Drawing.Point(513, 583);
            this.creaAutomezzoButton.Name = "creaAutomezzoButton";
            this.creaAutomezzoButton.Size = new System.Drawing.Size(227, 50);
            this.creaAutomezzoButton.TabIndex = 2;
            this.creaAutomezzoButton.Text = "Crea Automezzo";
            this.creaAutomezzoButton.UseVisualStyleBackColor = true;
            this.creaAutomezzoButton.Click += new System.EventHandler(this.creaAutomezzoButton_Click);
            // 
            // ViewGestioneAutomezzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.creaAutomezzoButton);
            this.Name = "ViewGestioneAutomezzo";
            this.Controls.SetChildIndex(this.creaAutomezzoButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button creaAutomezzoButton;
    }
}
