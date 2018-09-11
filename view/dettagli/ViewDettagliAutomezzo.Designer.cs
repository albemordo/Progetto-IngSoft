namespace AutotrasportiFantini.view.dettagli
{
    partial class ViewDettagliAutomezzo
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
            this.targaRimorchioBox = new System.Windows.Forms.TextBox();
            this.targaBox = new System.Windows.Forms.TextBox();
            this.modelloBox = new System.Windows.Forms.TextBox();
            this.marcaBox = new System.Windows.Forms.TextBox();
            this.targaRimorchioLabel = new System.Windows.Forms.Label();
            this.targaLabel = new System.Windows.Forms.Label();
            this.modelloLabel = new System.Windows.Forms.Label();
            this.marcaLabel = new System.Windows.Forms.Label();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.modificaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targaRimorchioBox
            // 
            this.targaRimorchioBox.Location = new System.Drawing.Point(121, 168);
            this.targaRimorchioBox.Name = "targaRimorchioBox";
            this.targaRimorchioBox.Size = new System.Drawing.Size(181, 20);
            this.targaRimorchioBox.TabIndex = 15;
            // 
            // targaBox
            // 
            this.targaBox.Location = new System.Drawing.Point(121, 121);
            this.targaBox.Name = "targaBox";
            this.targaBox.Size = new System.Drawing.Size(181, 20);
            this.targaBox.TabIndex = 14;
            // 
            // modelloBox
            // 
            this.modelloBox.Location = new System.Drawing.Point(121, 73);
            this.modelloBox.Name = "modelloBox";
            this.modelloBox.Size = new System.Drawing.Size(181, 20);
            this.modelloBox.TabIndex = 13;
            // 
            // marcaBox
            // 
            this.marcaBox.Location = new System.Drawing.Point(121, 29);
            this.marcaBox.Name = "marcaBox";
            this.marcaBox.Size = new System.Drawing.Size(181, 20);
            this.marcaBox.TabIndex = 12;
            // 
            // targaRimorchioLabel
            // 
            this.targaRimorchioLabel.AutoSize = true;
            this.targaRimorchioLabel.Location = new System.Drawing.Point(30, 171);
            this.targaRimorchioLabel.Name = "targaRimorchioLabel";
            this.targaRimorchioLabel.Size = new System.Drawing.Size(85, 13);
            this.targaRimorchioLabel.TabIndex = 11;
            this.targaRimorchioLabel.Text = "Targa Rimorchio";
            // 
            // targaLabel
            // 
            this.targaLabel.AutoSize = true;
            this.targaLabel.Location = new System.Drawing.Point(30, 124);
            this.targaLabel.Name = "targaLabel";
            this.targaLabel.Size = new System.Drawing.Size(35, 13);
            this.targaLabel.TabIndex = 10;
            this.targaLabel.Text = "Targa";
            // 
            // modelloLabel
            // 
            this.modelloLabel.AutoSize = true;
            this.modelloLabel.Location = new System.Drawing.Point(30, 76);
            this.modelloLabel.Name = "modelloLabel";
            this.modelloLabel.Size = new System.Drawing.Size(44, 13);
            this.modelloLabel.TabIndex = 9;
            this.modelloLabel.Text = "Modello";
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Location = new System.Drawing.Point(30, 32);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(37, 13);
            this.marcaLabel.TabIndex = 8;
            this.marcaLabel.Text = "Marca";
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(235, 215);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(101, 26);
            this.eliminaButton.TabIndex = 17;
            this.eliminaButton.Text = "Elimina";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // modificaButton
            // 
            this.modificaButton.Location = new System.Drawing.Point(58, 215);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(101, 26);
            this.modificaButton.TabIndex = 16;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = true;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click);
            // 
            // ViewDettagliAutomezzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.targaRimorchioBox);
            this.Controls.Add(this.targaBox);
            this.Controls.Add(this.modelloBox);
            this.Controls.Add(this.marcaBox);
            this.Controls.Add(this.targaRimorchioLabel);
            this.Controls.Add(this.targaLabel);
            this.Controls.Add(this.modelloLabel);
            this.Controls.Add(this.marcaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ViewDettagliAutomezzo";
            this.Text = "Dettagli Automezzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targaRimorchioBox;
        private System.Windows.Forms.TextBox targaBox;
        private System.Windows.Forms.TextBox modelloBox;
        private System.Windows.Forms.TextBox marcaBox;
        private System.Windows.Forms.Label targaRimorchioLabel;
        private System.Windows.Forms.Label targaLabel;
        private System.Windows.Forms.Label modelloLabel;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button modificaButton;
    }
}