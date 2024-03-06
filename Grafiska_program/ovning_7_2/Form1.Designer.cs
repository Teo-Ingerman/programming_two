namespace ovning_7_2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.age_input = new System.Windows.Forms.TextBox();
            this.cost_output = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ålder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // age_input
            // 
            this.age_input.Location = new System.Drawing.Point(424, 229);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(100, 20);
            this.age_input.TabIndex = 1;
            this.age_input.TextChanged += new System.EventHandler(this.age_input_TextChanged);
            // 
            // cost_output
            // 
            this.cost_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cost_output.Location = new System.Drawing.Point(424, 273);
            this.cost_output.Name = "cost_output";
            this.cost_output.Size = new System.Drawing.Size(163, 23);
            this.cost_output.TabIndex = 2;
            this.cost_output.Click += new System.EventHandler(this.cost_output_Click);
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 10;
            // 
            // tmr2
            // 
            this.tmr2.Enabled = true;
            this.tmr2.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 732);
            this.Controls.Add(this.cost_output);
            this.Controls.Add(this.age_input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox age_input;
        private System.Windows.Forms.Label cost_output;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr1;
        public System.Windows.Forms.Timer tmr2;
    }
}

