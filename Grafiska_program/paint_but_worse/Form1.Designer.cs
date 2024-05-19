namespace paint_but_worse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pxbPapper = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.background_color = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pen_tool = new System.Windows.Forms.Button();
            this.triangle_tool = new System.Windows.Forms.Button();
            this.circle_tool = new System.Windows.Forms.Button();
            this.square_tool = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pxbPapper
            // 
            this.pxbPapper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pxbPapper.Location = new System.Drawing.Point(212, 12);
            this.pxbPapper.Name = "pxbPapper";
            this.pxbPapper.Size = new System.Drawing.Size(576, 426);
            this.pxbPapper.TabIndex = 0;
            this.pxbPapper.TabStop = false;
            this.pxbPapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbPapper_Paint);
            this.pxbPapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseDown);
            this.pxbPapper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseMove);
            this.pxbPapper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxbPapper_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clear_button);
            this.groupBox4.Controls.Add(this.background_color);
            this.groupBox4.Location = new System.Drawing.Point(7, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 113);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Background";
            // 
            // clear_button
            // 
            this.clear_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_button.BackgroundImage")));
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_button.Location = new System.Drawing.Point(108, 27);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(60, 60);
            this.clear_button.TabIndex = 2;
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // background_color
            // 
            this.background_color.BackColor = System.Drawing.SystemColors.Control;
            this.background_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background_color.BackgroundImage")));
            this.background_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_color.Location = new System.Drawing.Point(21, 27);
            this.background_color.Name = "background_color";
            this.background_color.Size = new System.Drawing.Size(60, 60);
            this.background_color.TabIndex = 0;
            this.background_color.UseVisualStyleBackColor = false;
            this.background_color.Click += new System.EventHandler(this.background_color_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pen_tool);
            this.groupBox3.Controls.Add(this.triangle_tool);
            this.groupBox3.Controls.Add(this.circle_tool);
            this.groupBox3.Controls.Add(this.square_tool);
            this.groupBox3.Location = new System.Drawing.Point(7, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tools";
            // 
            // pen_tool
            // 
            this.pen_tool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pen_tool.BackgroundImage")));
            this.pen_tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pen_tool.Location = new System.Drawing.Point(138, 19);
            this.pen_tool.Name = "pen_tool";
            this.pen_tool.Size = new System.Drawing.Size(35, 35);
            this.pen_tool.TabIndex = 3;
            this.pen_tool.UseVisualStyleBackColor = true;
            this.pen_tool.Click += new System.EventHandler(this.tool_changed);
            // 
            // triangle_tool
            // 
            this.triangle_tool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle_tool.BackgroundImage")));
            this.triangle_tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangle_tool.Location = new System.Drawing.Point(97, 19);
            this.triangle_tool.Name = "triangle_tool";
            this.triangle_tool.Size = new System.Drawing.Size(35, 35);
            this.triangle_tool.TabIndex = 2;
            this.triangle_tool.UseVisualStyleBackColor = true;
            this.triangle_tool.Click += new System.EventHandler(this.image_tool);
            // 
            // circle_tool
            // 
            this.circle_tool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_tool.BackgroundImage")));
            this.circle_tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circle_tool.Location = new System.Drawing.Point(47, 19);
            this.circle_tool.Name = "circle_tool";
            this.circle_tool.Size = new System.Drawing.Size(35, 35);
            this.circle_tool.TabIndex = 1;
            this.circle_tool.UseVisualStyleBackColor = true;
            this.circle_tool.Click += new System.EventHandler(this.tool_changed);
            // 
            // square_tool
            // 
            this.square_tool.BackColor = System.Drawing.Color.Transparent;
            this.square_tool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square_tool.BackgroundImage")));
            this.square_tool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.square_tool.Location = new System.Drawing.Point(6, 19);
            this.square_tool.Name = "square_tool";
            this.square_tool.Size = new System.Drawing.Size(35, 35);
            this.square_tool.TabIndex = 0;
            this.square_tool.UseVisualStyleBackColor = false;
            this.square_tool.Click += new System.EventHandler(this.tool_changed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size/Color";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(138, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 49);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.track_bar_dragged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(146, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 22);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.pen_color_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cyan;
            this.button5.Location = new System.Drawing.Point(118, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.pen_color_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(90, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 22);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.pen_color_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(62, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.pen_color_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(34, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.pen_color_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.pen_color_click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.upload_button);
            this.groupBox5.Controls.Add(this.save_button);
            this.groupBox5.Location = new System.Drawing.Point(13, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 98);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Saving/Loading";
            // 
            // upload_button
            // 
            this.upload_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload_button.BackgroundImage")));
            this.upload_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upload_button.Location = new System.Drawing.Point(107, 19);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 73);
            this.upload_button.TabIndex = 1;
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.Location = new System.Drawing.Point(13, 19);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 73);
            this.save_button.TabIndex = 0;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pxbPapper);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pxbPapper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbPapper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button pen_tool;
        private System.Windows.Forms.Button triangle_tool;
        private System.Windows.Forms.Button circle_tool;
        private System.Windows.Forms.Button square_tool;
        private System.Windows.Forms.Button background_color;
        private System.Windows.Forms.Button clear_button;
    }
}

