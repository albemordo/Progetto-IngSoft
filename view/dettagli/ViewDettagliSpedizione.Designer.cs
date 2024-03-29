﻿namespace AutotrasportiFantini.view.dettagli
{
    partial class ViewDettagliSpedizione
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
            this.quantitaBox = new System.Windows.Forms.TextBox();
            this.distanzaBox = new System.Windows.Forms.TextBox();
            this.quantitaLabel = new System.Windows.Forms.Label();
            this.distanzaStimataLabel = new System.Windows.Forms.Label();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.modificaButton = new System.Windows.Forms.Button();
            this.luogoPartenzaLabel = new System.Windows.Forms.Label();
            this.luogoArrivoLabel = new System.Windows.Forms.Label();
            this.provinciaPartenzaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.localitaPartenzaBox = new System.Windows.Forms.TextBox();
            this.nomePartenzaBox = new System.Windows.Forms.TextBox();
            this.qualificatorePartenzaBox = new System.Windows.Forms.TextBox();
            this.provinciaArrivoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.localitaArrivoBox = new System.Windows.Forms.TextBox();
            this.nomeArrivoBox = new System.Windows.Forms.TextBox();
            this.qualificatoreArrivoBox = new System.Windows.Forms.TextBox();
            this.civicoPartenzaBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.capPartenzaBox = new System.Windows.Forms.TextBox();
            this.civicoArrivoBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.capArrivoBox = new System.Windows.Forms.TextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.distanzaEffettivaBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.delegaButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerPartenzaEffettivo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPartenzaPrevisto = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivoPrevisto = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivoEffettivo = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tempoStimatoBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.listBoxAutista = new System.Windows.Forms.ListBox();
            this.listBoxDelegato = new System.Windows.Forms.ListBox();
            this.listBoxAutomezzo = new System.Windows.Forms.ListBox();
            this.merceListBox = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.aggiornaTabellaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // quantitaBox
            // 
            this.quantitaBox.Location = new System.Drawing.Point(722, 106);
            this.quantitaBox.Name = "quantitaBox";
            this.quantitaBox.Size = new System.Drawing.Size(108, 20);
            this.quantitaBox.TabIndex = 24;
            // 
            // distanzaBox
            // 
            this.distanzaBox.Location = new System.Drawing.Point(722, 28);
            this.distanzaBox.Name = "distanzaBox";
            this.distanzaBox.Size = new System.Drawing.Size(108, 20);
            this.distanzaBox.TabIndex = 22;
            // 
            // quantitaLabel
            // 
            this.quantitaLabel.AutoSize = true;
            this.quantitaLabel.Location = new System.Drawing.Point(621, 106);
            this.quantitaLabel.Name = "quantitaLabel";
            this.quantitaLabel.Size = new System.Drawing.Size(80, 13);
            this.quantitaLabel.TabIndex = 17;
            this.quantitaLabel.Text = "Quantità Merce";
            // 
            // distanzaStimataLabel
            // 
            this.distanzaStimataLabel.AutoSize = true;
            this.distanzaStimataLabel.Location = new System.Drawing.Point(621, 28);
            this.distanzaStimataLabel.Name = "distanzaStimataLabel";
            this.distanzaStimataLabel.Size = new System.Drawing.Size(86, 13);
            this.distanzaStimataLabel.TabIndex = 15;
            this.distanzaStimataLabel.Text = "Distanza Stimata";
            // 
            // eliminaButton
            // 
            this.eliminaButton.Location = new System.Drawing.Point(701, 360);
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.Size = new System.Drawing.Size(101, 26);
            this.eliminaButton.TabIndex = 26;
            this.eliminaButton.Text = "Elimina";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click_1);
            // 
            // modificaButton
            // 
            this.modificaButton.Location = new System.Drawing.Point(578, 360);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(101, 26);
            this.modificaButton.TabIndex = 25;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = true;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click_1);
            // 
            // luogoPartenzaLabel
            // 
            this.luogoPartenzaLabel.AutoSize = true;
            this.luogoPartenzaLabel.Location = new System.Drawing.Point(15, 18);
            this.luogoPartenzaLabel.Name = "luogoPartenzaLabel";
            this.luogoPartenzaLabel.Size = new System.Drawing.Size(92, 13);
            this.luogoPartenzaLabel.TabIndex = 13;
            this.luogoPartenzaLabel.Text = "Luogo di partenza";
            // 
            // luogoArrivoLabel
            // 
            this.luogoArrivoLabel.AutoSize = true;
            this.luogoArrivoLabel.Location = new System.Drawing.Point(12, 213);
            this.luogoArrivoLabel.Name = "luogoArrivoLabel";
            this.luogoArrivoLabel.Size = new System.Drawing.Size(78, 13);
            this.luogoArrivoLabel.TabIndex = 14;
            this.luogoArrivoLabel.Text = "Luogo di Arrivo";
            // 
            // provinciaPartenzaBox
            // 
            this.provinciaPartenzaBox.Location = new System.Drawing.Point(122, 79);
            this.provinciaPartenzaBox.Name = "provinciaPartenzaBox";
            this.provinciaPartenzaBox.Size = new System.Drawing.Size(97, 20);
            this.provinciaPartenzaBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Qualificatore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Località";
            // 
            // localitaPartenzaBox
            // 
            this.localitaPartenzaBox.Location = new System.Drawing.Point(122, 43);
            this.localitaPartenzaBox.Name = "localitaPartenzaBox";
            this.localitaPartenzaBox.Size = new System.Drawing.Size(97, 20);
            this.localitaPartenzaBox.TabIndex = 31;
            // 
            // nomePartenzaBox
            // 
            this.nomePartenzaBox.Location = new System.Drawing.Point(316, 43);
            this.nomePartenzaBox.Name = "nomePartenzaBox";
            this.nomePartenzaBox.Size = new System.Drawing.Size(86, 20);
            this.nomePartenzaBox.TabIndex = 32;
            // 
            // qualificatorePartenzaBox
            // 
            this.qualificatorePartenzaBox.Location = new System.Drawing.Point(316, 82);
            this.qualificatorePartenzaBox.Name = "qualificatorePartenzaBox";
            this.qualificatorePartenzaBox.Size = new System.Drawing.Size(86, 20);
            this.qualificatorePartenzaBox.TabIndex = 33;
            // 
            // provinciaArrivoBox
            // 
            this.provinciaArrivoBox.Location = new System.Drawing.Point(97, 272);
            this.provinciaArrivoBox.Name = "provinciaArrivoBox";
            this.provinciaArrivoBox.Size = new System.Drawing.Size(97, 20);
            this.provinciaArrivoBox.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Qualificatore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Località";
            // 
            // localitaArrivoBox
            // 
            this.localitaArrivoBox.Location = new System.Drawing.Point(98, 236);
            this.localitaArrivoBox.Name = "localitaArrivoBox";
            this.localitaArrivoBox.Size = new System.Drawing.Size(97, 20);
            this.localitaArrivoBox.TabIndex = 39;
            // 
            // nomeArrivoBox
            // 
            this.nomeArrivoBox.Location = new System.Drawing.Point(310, 236);
            this.nomeArrivoBox.Name = "nomeArrivoBox";
            this.nomeArrivoBox.Size = new System.Drawing.Size(86, 20);
            this.nomeArrivoBox.TabIndex = 40;
            // 
            // qualificatoreArrivoBox
            // 
            this.qualificatoreArrivoBox.Location = new System.Drawing.Point(310, 272);
            this.qualificatoreArrivoBox.Name = "qualificatoreArrivoBox";
            this.qualificatoreArrivoBox.Size = new System.Drawing.Size(86, 20);
            this.qualificatoreArrivoBox.TabIndex = 41;
            // 
            // civicoPartenzaBox
            // 
            this.civicoPartenzaBox.Location = new System.Drawing.Point(316, 120);
            this.civicoPartenzaBox.Name = "civicoPartenzaBox";
            this.civicoPartenzaBox.Size = new System.Drawing.Size(86, 20);
            this.civicoPartenzaBox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Civico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cap";
            // 
            // capPartenzaBox
            // 
            this.capPartenzaBox.Location = new System.Drawing.Point(122, 117);
            this.capPartenzaBox.Name = "capPartenzaBox";
            this.capPartenzaBox.Size = new System.Drawing.Size(97, 20);
            this.capPartenzaBox.TabIndex = 42;
            // 
            // civicoArrivoBox
            // 
            this.civicoArrivoBox.Location = new System.Drawing.Point(310, 310);
            this.civicoArrivoBox.Name = "civicoArrivoBox";
            this.civicoArrivoBox.Size = new System.Drawing.Size(86, 20);
            this.civicoArrivoBox.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Civico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Cap";
            // 
            // capArrivoBox
            // 
            this.capArrivoBox.Location = new System.Drawing.Point(98, 310);
            this.capArrivoBox.Name = "capArrivoBox";
            this.capArrivoBox.Size = new System.Drawing.Size(97, 20);
            this.capArrivoBox.TabIndex = 46;
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(56, 412);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(814, 266);
            this.dataTable.TabIndex = 50;
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            // 
            // distanzaEffettivaBox
            // 
            this.distanzaEffettivaBox.Location = new System.Drawing.Point(722, 67);
            this.distanzaEffettivaBox.Name = "distanzaEffettivaBox";
            this.distanzaEffettivaBox.Size = new System.Drawing.Size(108, 20);
            this.distanzaEffettivaBox.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(621, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Distanza Effettiva";
            // 
            // delegaButton
            // 
            this.delegaButton.Location = new System.Drawing.Point(837, 360);
            this.delegaButton.Name = "delegaButton";
            this.delegaButton.Size = new System.Drawing.Size(101, 26);
            this.delegaButton.TabIndex = 53;
            this.delegaButton.Text = "Delega";
            this.delegaButton.UseVisualStyleBackColor = true;
            this.delegaButton.Click += new System.EventHandler(this.delegaButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(621, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Autista";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(765, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Delegato";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "Orario Previsto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(319, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Orario Effettivo";
            // 
            // dateTimePickerPartenzaEffettivo
            // 
            this.dateTimePickerPartenzaEffettivo.Location = new System.Drawing.Point(278, 166);
            this.dateTimePickerPartenzaEffettivo.Name = "dateTimePickerPartenzaEffettivo";
            this.dateTimePickerPartenzaEffettivo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPartenzaEffettivo.TabIndex = 60;
            // 
            // dateTimePickerPartenzaPrevisto
            // 
            this.dateTimePickerPartenzaPrevisto.Location = new System.Drawing.Point(72, 166);
            this.dateTimePickerPartenzaPrevisto.Name = "dateTimePickerPartenzaPrevisto";
            this.dateTimePickerPartenzaPrevisto.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPartenzaPrevisto.TabIndex = 61;
            // 
            // dateTimePickerArrivoPrevisto
            // 
            this.dateTimePickerArrivoPrevisto.Location = new System.Drawing.Point(54, 360);
            this.dateTimePickerArrivoPrevisto.Name = "dateTimePickerArrivoPrevisto";
            this.dateTimePickerArrivoPrevisto.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerArrivoPrevisto.TabIndex = 65;
            // 
            // dateTimePickerArrivoEffettivo
            // 
            this.dateTimePickerArrivoEffettivo.Location = new System.Drawing.Point(260, 360);
            this.dateTimePickerArrivoEffettivo.Name = "dateTimePickerArrivoEffettivo";
            this.dateTimePickerArrivoEffettivo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerArrivoEffettivo.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(308, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Orario Effettivo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(100, 344);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "Orario Previsto";
            // 
            // tempoStimatoBox
            // 
            this.tempoStimatoBox.Location = new System.Drawing.Point(722, 143);
            this.tempoStimatoBox.Name = "tempoStimatoBox";
            this.tempoStimatoBox.Size = new System.Drawing.Size(108, 20);
            this.tempoStimatoBox.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(621, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 66;
            this.label20.Text = "Tempo Stimato";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(904, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 13);
            this.label21.TabIndex = 68;
            this.label21.Text = "Automezzo";
            // 
            // listBoxAutista
            // 
            this.listBoxAutista.FormattingEnabled = true;
            this.listBoxAutista.Location = new System.Drawing.Point(578, 236);
            this.listBoxAutista.Name = "listBoxAutista";
            this.listBoxAutista.Size = new System.Drawing.Size(137, 95);
            this.listBoxAutista.TabIndex = 70;
            // 
            // listBoxDelegato
            // 
            this.listBoxDelegato.FormattingEnabled = true;
            this.listBoxDelegato.Location = new System.Drawing.Point(722, 236);
            this.listBoxDelegato.Name = "listBoxDelegato";
            this.listBoxDelegato.Size = new System.Drawing.Size(137, 95);
            this.listBoxDelegato.TabIndex = 71;
            this.listBoxDelegato.SelectedIndexChanged += new System.EventHandler(this.listBoxDelegato_SelectedIndexChanged);
            // 
            // listBoxAutomezzo
            // 
            this.listBoxAutomezzo.FormattingEnabled = true;
            this.listBoxAutomezzo.Location = new System.Drawing.Point(865, 236);
            this.listBoxAutomezzo.Name = "listBoxAutomezzo";
            this.listBoxAutomezzo.Size = new System.Drawing.Size(137, 95);
            this.listBoxAutomezzo.TabIndex = 72;
            // 
            // merceListBox
            // 
            this.merceListBox.FormattingEnabled = true;
            this.merceListBox.Location = new System.Drawing.Point(433, 236);
            this.merceListBox.Name = "merceListBox";
            this.merceListBox.Size = new System.Drawing.Size(137, 95);
            this.merceListBox.TabIndex = 131;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(456, 220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 130;
            this.label22.Text = "Tipologia Merce";
            // 
            // aggiornaTabellaButton
            // 
            this.aggiornaTabellaButton.Location = new System.Drawing.Point(876, 412);
            this.aggiornaTabellaButton.Name = "aggiornaTabellaButton";
            this.aggiornaTabellaButton.Size = new System.Drawing.Size(102, 33);
            this.aggiornaTabellaButton.TabIndex = 132;
            this.aggiornaTabellaButton.Text = "Aggiorna Tabella";
            this.aggiornaTabellaButton.UseVisualStyleBackColor = true;
            this.aggiornaTabellaButton.Click += new System.EventHandler(this.aggiornaTabellaButton_Click);
            // 
            // ViewDettagliSpedizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.aggiornaTabellaButton);
            this.Controls.Add(this.merceListBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.listBoxAutomezzo);
            this.Controls.Add(this.listBoxDelegato);
            this.Controls.Add(this.listBoxAutista);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tempoStimatoBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePickerArrivoPrevisto);
            this.Controls.Add(this.dateTimePickerArrivoEffettivo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dateTimePickerPartenzaPrevisto);
            this.Controls.Add(this.dateTimePickerPartenzaEffettivo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.delegaButton);
            this.Controls.Add(this.distanzaEffettivaBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.civicoArrivoBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.capArrivoBox);
            this.Controls.Add(this.civicoPartenzaBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.capPartenzaBox);
            this.Controls.Add(this.qualificatoreArrivoBox);
            this.Controls.Add(this.nomeArrivoBox);
            this.Controls.Add(this.localitaArrivoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.provinciaArrivoBox);
            this.Controls.Add(this.qualificatorePartenzaBox);
            this.Controls.Add(this.nomePartenzaBox);
            this.Controls.Add(this.localitaPartenzaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.quantitaBox);
            this.Controls.Add(this.distanzaBox);
            this.Controls.Add(this.provinciaPartenzaBox);
            this.Controls.Add(this.quantitaLabel);
            this.Controls.Add(this.distanzaStimataLabel);
            this.Controls.Add(this.luogoArrivoLabel);
            this.Controls.Add(this.luogoPartenzaLabel);
            this.MaximizeBox = false;
            this.Name = "ViewDettagliSpedizione";
            this.Text = "Dettagli Spedizione";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox quantitaBox;
        private System.Windows.Forms.TextBox distanzaBox;
        private System.Windows.Forms.Label quantitaLabel;
        private System.Windows.Forms.Label distanzaStimataLabel;
        private System.Windows.Forms.Button eliminaButton;
        private System.Windows.Forms.Button modificaButton;
        private System.Windows.Forms.Label luogoPartenzaLabel;
        private System.Windows.Forms.Label luogoArrivoLabel;
        private System.Windows.Forms.TextBox provinciaPartenzaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox localitaPartenzaBox;
        private System.Windows.Forms.TextBox nomePartenzaBox;
        private System.Windows.Forms.TextBox qualificatorePartenzaBox;
        private System.Windows.Forms.TextBox provinciaArrivoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox localitaArrivoBox;
        private System.Windows.Forms.TextBox nomeArrivoBox;
        private System.Windows.Forms.TextBox qualificatoreArrivoBox;
        private System.Windows.Forms.TextBox civicoPartenzaBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox capPartenzaBox;
        private System.Windows.Forms.TextBox civicoArrivoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox capArrivoBox;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TextBox distanzaEffettivaBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button delegaButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerPartenzaEffettivo;
        private System.Windows.Forms.DateTimePicker dateTimePickerPartenzaPrevisto;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivoPrevisto;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivoEffettivo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tempoStimatoBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox listBoxAutista;
        private System.Windows.Forms.ListBox listBoxDelegato;
        private System.Windows.Forms.ListBox listBoxAutomezzo;
        private System.Windows.Forms.ListBox merceListBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button aggiornaTabellaButton;
    }
}