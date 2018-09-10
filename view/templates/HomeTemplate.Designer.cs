namespace AutotrasportiFantini.view.templates
{
    partial class HomeTemplate
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Location = new System.Drawing.Point(2, 61);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1004, 618);
            this.formPanel.TabIndex = 1;
            // 
            // HomeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "HomeTemplate";
            this.Text = "Home Template";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel formPanel;
    }
}