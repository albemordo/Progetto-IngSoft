namespace AutotrasportiFantini.view
{
    partial class ViewCreazioneTipologiaMerce
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
            this.nomeTipologiaLabel = new System.Windows.Forms.Label();
            this.nomeTipologiaBox = new System.Windows.Forms.TextBox();
            this.confermaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeTipologiaLabel
            // 
            this.nomeTipologiaLabel.AutoSize = true;
            this.nomeTipologiaLabel.Location = new System.Drawing.Point(12, 30);
            this.nomeTipologiaLabel.Name = "nomeTipologiaLabel";
            this.nomeTipologiaLabel.Size = new System.Drawing.Size(81, 13);
            this.nomeTipologiaLabel.TabIndex = 0;
            this.nomeTipologiaLabel.Text = "Nome Tipologia";
            // 
            // nomeTipologiaBox
            // 
            this.nomeTipologiaBox.Location = new System.Drawing.Point(109, 27);
            this.nomeTipologiaBox.Name = "nomeTipologiaBox";
            this.nomeTipologiaBox.Size = new System.Drawing.Size(197, 20);
            this.nomeTipologiaBox.TabIndex = 1;
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(109, 63);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(75, 23);
            this.confermaButton.TabIndex = 2;
            this.confermaButton.Text = "Aggiungi";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // ViewCreazioneTipologiaMerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 98);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.nomeTipologiaBox);
            this.Controls.Add(this.nomeTipologiaLabel);
            this.Name = "ViewCreazioneTipologiaMerce";
            this.Text = "Crea Tipologia Merce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeTipologiaLabel;
        private System.Windows.Forms.TextBox nomeTipologiaBox;
        private System.Windows.Forms.Button confermaButton;
    }
}