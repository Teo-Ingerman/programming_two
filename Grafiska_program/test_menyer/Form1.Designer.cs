namespace test_menyer
{
    partial class Form1
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
            this.btnfärg = new System.Windows.Forms.Button();
            this.btnsökväg = new System.Windows.Forms.Button();
            this.btnteckensnitt = new System.Windows.Forms.Button();
            this.dlgcolor = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnfärg
            // 
            this.btnfärg.Location = new System.Drawing.Point(142, 96);
            this.btnfärg.Name = "btnfärg";
            this.btnfärg.Size = new System.Drawing.Size(75, 23);
            this.btnfärg.TabIndex = 0;
            this.btnfärg.Text = "Välj färg";
            this.btnfärg.UseVisualStyleBackColor = true;
            this.btnfärg.Click += new System.EventHandler(this.btnfärg_Click);
            // 
            // btnsökväg
            // 
            this.btnsökväg.Location = new System.Drawing.Point(160, 190);
            this.btnsökväg.Name = "btnsökväg";
            this.btnsökväg.Size = new System.Drawing.Size(75, 23);
            this.btnsökväg.TabIndex = 1;
            this.btnsökväg.Text = "Välj Sökväg";
            this.btnsökväg.UseVisualStyleBackColor = true;
            this.btnsökväg.Click += new System.EventHandler(this.btnsökväg_Click);
            // 
            // btnteckensnitt
            // 
            this.btnteckensnitt.Location = new System.Drawing.Point(151, 281);
            this.btnteckensnitt.Name = "btnteckensnitt";
            this.btnteckensnitt.Size = new System.Drawing.Size(93, 23);
            this.btnteckensnitt.TabIndex = 2;
            this.btnteckensnitt.Text = "Välj teckensnitt";
            this.btnteckensnitt.UseVisualStyleBackColor = true;
            this.btnteckensnitt.Click += new System.EventHandler(this.btnteckensnitt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnteckensnitt);
            this.Controls.Add(this.btnsökväg);
            this.Controls.Add(this.btnfärg);
            this.Name = "Form1";
            this.Text = "Menyer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfärg;
        private System.Windows.Forms.Button btnsökväg;
        private System.Windows.Forms.Button btnteckensnitt;
        private System.Windows.Forms.ColorDialog dlgcolor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

