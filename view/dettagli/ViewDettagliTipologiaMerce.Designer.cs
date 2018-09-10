namespace AutotrasportiFantini.view
{
    partial class ViewDettagliTipologiaMerce
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
            this.nomeTipologiaMerceLabel = new System.Windows.Forms.Label();
            this.nomeTipologiaMerceBox = new System.Windows.Forms.TextBox();
            this.modificaButton = new System.Windows.Forms.Button();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeTipologiaMerceLabel
            // 
            this.nomeTipologiaMerceLabel.AutoSize = true;
            this.nomeTipologiaMerceLabel.Location = new System.Drawing.Point(12, 36);
            this.nomeTipologiaMerceLabel.Name = "nomeTipologiaMerceLabel";
            this.nomeTipologiaMerceLabel.Size = new System.Drawing.Size(114, 13);
            this.nomeTipologiaMerceLabel.TabIndex = 0;
            this.nomeTipologiaMerceLabel.Text = "Nome Tipologia Merce";
            // 
            // nomeTipologiaMerceBox
            // 
            this.nomeTipologiaMerceBox.Location = new System.Drawing.Point(132, 33);
            this.nomeTipologiaMerceBox.Name = "nomeTipologiaMerceBox";
            this.nomeTipologiaMerceBox.Size = new System.Drawing.Size(225, 20);
            this.nomeTipologiaMerceBox.TabIndex = 1;
            // 
            // modificaButton
            // 
            this.modificaButton.Location = new System.Drawing.Point(79, 85);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(101, 26);
            this.modificaButton.TabIndex = 2;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = true;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click);
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(256, 85);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(101, 26);
            this.eliminaButton.TabIndex = 3;
            this.eliminaButton.Text = "Elimina";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // ViewDettagliTipologiaMerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 123);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.nomeTipologiaMerceBox);
            this.Controls.Add(this.nomeTipologiaMerceLabel);
            this.Name = "ViewDettagliTipologiaMerce";
            this.Text = "Dettagli Tipologia Merce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeTipologiaMerceLabel;
        private System.Windows.Forms.TextBox nomeTipologiaMerceBox;
        private System.Windows.Forms.Button modificaButton;
        private System.Windows.Forms.Button eliminaButton;
    }
}