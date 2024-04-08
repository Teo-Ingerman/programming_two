namespace test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pen_color_button = new System.Windows.Forms.Button();
            this.background_color_button = new System.Windows.Forms.Button();
            this.pxbPapper = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pxbPapper);
            this.panel1.Location = new System.Drawing.Point(267, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 425);
            this.panel1.TabIndex = 1;
            // 
            // pen_color_button
            // 
            this.pen_color_button.BackColor = System.Drawing.Color.Black;
            this.pen_color_button.Location = new System.Drawing.Point(13, 13);
            this.pen_color_button.Name = "pen_color_button";
            this.pen_color_button.Size = new System.Drawing.Size(75, 23);
            this.pen_color_button.TabIndex = 2;
            this.pen_color_button.UseVisualStyleBackColor = false;
            this.pen_color_button.Click += new System.EventHandler(this.pen_color_button_Click);
            // 
            // background_color_button
            // 
            this.background_color_button.BackColor = System.Drawing.Color.White;
            this.background_color_button.Location = new System.Drawing.Point(13, 43);
            this.background_color_button.Name = "background_color_button";
            this.background_color_button.Size = new System.Drawing.Size(75, 23);
            this.background_color_button.TabIndex = 3;
            this.background_color_button.UseVisualStyleBackColor = false;
            this.background_color_button.Click += new System.EventHandler(this.background_color_button_Click);
            // 
            // pxbPapper
            // 
            this.pxbPapper.Location = new System.Drawing.Point(0, 0);
            this.pxbPapper.Name = "pxbPapper";
            this.pxbPapper.Size = new System.Drawing.Size(521, 425);
            this.pxbPapper.TabIndex = 0;
            this.pxbPapper.TabStop = false;
            this.pxbPapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbPapper_Paint);
            this.pxbPapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseDown);
            this.pxbPapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseMove);
            this.pxbPapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background_color_button);
            this.Controls.Add(this.pen_color_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pen_color_button;
        private System.Windows.Forms.Button background_color_button;
        private System.Windows.Forms.PictureBox pxbPapper;
    }
}

