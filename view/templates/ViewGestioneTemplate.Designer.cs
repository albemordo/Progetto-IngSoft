﻿namespace AutotrasportiFantini.view.templates
{
    partial class ViewGestioneTemplate
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.mascheraDettaglioButton = new System.Windows.Forms.Button();
            this.aggiornaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AllowUserToResizeRows = false;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(-1, 0);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(1009, 575);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            // 
            // mascheraDettaglioButton
            // 
            this.mascheraDettaglioButton.Location = new System.Drawing.Point(769, 583);
            this.mascheraDettaglioButton.Name = "mascheraDettaglioButton";
            this.mascheraDettaglioButton.Size = new System.Drawing.Size(227, 50);
            this.mascheraDettaglioButton.TabIndex = 1;
            this.mascheraDettaglioButton.Text = "Maschera Dettaglio";
            this.mascheraDettaglioButton.UseVisualStyleBackColor = true;
            this.mascheraDettaglioButton.Click += new System.EventHandler(this.mascheraDettaglioButton_Click);
            // 
            // aggiornaButton
            // 
            this.aggiornaButton.Location = new System.Drawing.Point(542, 583);
            this.aggiornaButton.Name = "aggiornaButton";
            this.aggiornaButton.Size = new System.Drawing.Size(211, 50);
            this.aggiornaButton.TabIndex = 3;
            this.aggiornaButton.Text = "Aggiorna Tabella";
            this.aggiornaButton.UseVisualStyleBackColor = true;
            this.aggiornaButton.Click += new System.EventHandler(this.aggiornaButton_Click);
            // 
            // ViewGestioneTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 645);
            this.Controls.Add(this.aggiornaButton);
            this.Controls.Add(this.mascheraDettaglioButton);
            this.Controls.Add(this.dataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGestioneTemplate";
            this.Text = "View Dettagli Template";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mascheraDettaglioButton;
        protected System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button aggiornaButton;
    }
}