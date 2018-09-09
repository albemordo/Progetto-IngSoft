namespace AutotrasportiFantini.view
{
    partial class ViewCreazioneAutomezzo
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
            this.marcaLabel = new System.Windows.Forms.Label();
            this.modelloLabel = new System.Windows.Forms.Label();
            this.targaLabel = new System.Windows.Forms.Label();
            this.targaRimorchioLabel = new System.Windows.Forms.Label();
            this.marcaBox = new System.Windows.Forms.TextBox();
            this.modelloBox = new System.Windows.Forms.TextBox();
            this.targaBox = new System.Windows.Forms.TextBox();
            this.targaRimorchioBox = new System.Windows.Forms.TextBox();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Location = new System.Drawing.Point(12, 9);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(37, 13);
            this.marcaLabel.TabIndex = 0;
            this.marcaLabel.Text = "Marca";
            // 
            // modelloLabel
            // 
            this.modelloLabel.AutoSize = true;
            this.modelloLabel.Location = new System.Drawing.Point(12, 53);
            this.modelloLabel.Name = "modelloLabel";
            this.modelloLabel.Size = new System.Drawing.Size(44, 13);
            this.modelloLabel.TabIndex = 1;
            this.modelloLabel.Text = "Modello";
            // 
            // targaLabel
            // 
            this.targaLabel.AutoSize = true;
            this.targaLabel.Location = new System.Drawing.Point(12, 101);
            this.targaLabel.Name = "targaLabel";
            this.targaLabel.Size = new System.Drawing.Size(35, 13);
            this.targaLabel.TabIndex = 2;
            this.targaLabel.Text = "Targa";
            // 
            // targaRimorchioLabel
            // 
            this.targaRimorchioLabel.AutoSize = true;
            this.targaRimorchioLabel.Location = new System.Drawing.Point(12, 148);
            this.targaRimorchioLabel.Name = "targaRimorchioLabel";
            this.targaRimorchioLabel.Size = new System.Drawing.Size(85, 13);
            this.targaRimorchioLabel.TabIndex = 3;
            this.targaRimorchioLabel.Text = "Targa Rimorchio";
            // 
            // marcaBox
            // 
            this.marcaBox.Location = new System.Drawing.Point(103, 6);
            this.marcaBox.Name = "marcaBox";
            this.marcaBox.Size = new System.Drawing.Size(181, 20);
            this.marcaBox.TabIndex = 4;
            // 
            // modelloBox
            // 
            this.modelloBox.Location = new System.Drawing.Point(103, 50);
            this.modelloBox.Name = "modelloBox";
            this.modelloBox.Size = new System.Drawing.Size(181, 20);
            this.modelloBox.TabIndex = 5;
            // 
            // targaBox
            // 
            this.targaBox.Location = new System.Drawing.Point(103, 98);
            this.targaBox.Name = "targaBox";
            this.targaBox.Size = new System.Drawing.Size(181, 20);
            this.targaBox.TabIndex = 6;
            // 
            // targaRimorchioBox
            // 
            this.targaRimorchioBox.Location = new System.Drawing.Point(103, 145);
            this.targaRimorchioBox.Name = "targaRimorchioBox";
            this.targaRimorchioBox.Size = new System.Drawing.Size(181, 20);
            this.targaRimorchioBox.TabIndex = 7;
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(120, 188);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this.aggiungiButton.TabIndex = 8;
            this.aggiungiButton.Text = "Aggiungi";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            // 
            // ViewCreazioneAutomezzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 221);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.targaRimorchioBox);
            this.Controls.Add(this.targaBox);
            this.Controls.Add(this.modelloBox);
            this.Controls.Add(this.marcaBox);
            this.Controls.Add(this.targaRimorchioLabel);
            this.Controls.Add(this.targaLabel);
            this.Controls.Add(this.modelloLabel);
            this.Controls.Add(this.marcaLabel);
            this.Name = "ViewCreazioneAutomezzo";
            this.Text = "ViewCreazioneAutomezzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.Label modelloLabel;
        private System.Windows.Forms.Label targaLabel;
        private System.Windows.Forms.Label targaRimorchioLabel;
        private System.Windows.Forms.TextBox marcaBox;
        private System.Windows.Forms.TextBox modelloBox;
        private System.Windows.Forms.TextBox targaBox;
        private System.Windows.Forms.TextBox targaRimorchioBox;
        private System.Windows.Forms.Button aggiungiButton;
    }
}