namespace AutotrasportiFantini.view
{
    partial class ViewGestioneTipologieMerce
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
            this.creaTipologiaMerceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creaTipologiaMerceButton
            // 
            this.creaTipologiaMerceButton.Location = new System.Drawing.Point(595, 581);
            this.creaTipologiaMerceButton.Name = "creaTipologiaMerceButton";
            this.creaTipologiaMerceButton.Size = new System.Drawing.Size(178, 39);
            this.creaTipologiaMerceButton.TabIndex = 3;
            this.creaTipologiaMerceButton.Text = "Crea Tipologia Merce";
            this.creaTipologiaMerceButton.UseVisualStyleBackColor = true;
            this.creaTipologiaMerceButton.Click += new System.EventHandler(this.creaTipologiaMerceButton_Click);
            // 
            // ViewGestioneTipologieMerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 632);
            this.Controls.Add(this.creaTipologiaMerceButton);
            this.Name = "ViewGestioneTipologieMerce";
            this.Controls.SetChildIndex(this.creaTipologiaMerceButton, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button creaTipologiaMerceButton;
    }
}
