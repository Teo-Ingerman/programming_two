namespace paint_program
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
            this.color_group = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.background_group = new System.Windows.Forms.GroupBox();
            this.background_image_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.background_color_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pen_group = new System.Windows.Forms.GroupBox();
            this.pen_size_combo_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pen_color_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.background_group.SuspendLayout();
            this.pen_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // color_group
            // 
            this.color_group.Controls.Add(this.groupBox1);
            this.color_group.Controls.Add(this.background_group);
            this.color_group.Controls.Add(this.pen_group);
            this.color_group.Location = new System.Drawing.Point(12, 12);
            this.color_group.Name = "color_group";
            this.color_group.Size = new System.Drawing.Size(91, 426);
            this.color_group.TabIndex = 0;
            this.color_group.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(7, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "shapes";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // background_group
            // 
            this.background_group.Controls.Add(this.background_image_button);
            this.background_group.Controls.Add(this.label4);
            this.background_group.Controls.Add(this.background_color_button);
            this.background_group.Controls.Add(this.label3);
            this.background_group.Location = new System.Drawing.Point(7, 138);
            this.background_group.Name = "background_group";
            this.background_group.Size = new System.Drawing.Size(78, 120);
            this.background_group.TabIndex = 1;
            this.background_group.TabStop = false;
            this.background_group.Text = "background";
            // 
            // background_image_button
            // 
            this.background_image_button.Location = new System.Drawing.Point(6, 84);
            this.background_image_button.Name = "background_image_button";
            this.background_image_button.Size = new System.Drawing.Size(66, 23);
            this.background_image_button.TabIndex = 3;
            this.background_image_button.Text = "Browse";
            this.background_image_button.UseVisualStyleBackColor = true;
            this.background_image_button.Click += new System.EventHandler(this.background_image_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Image:";
            // 
            // background_color_button
            // 
            this.background_color_button.BackColor = System.Drawing.Color.White;
            this.background_color_button.Location = new System.Drawing.Point(6, 37);
            this.background_color_button.Name = "background_color_button";
            this.background_color_button.Size = new System.Drawing.Size(66, 23);
            this.background_color_button.TabIndex = 1;
            this.background_color_button.UseVisualStyleBackColor = false;
            this.background_color_button.Click += new System.EventHandler(this.background_color_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color:";
            // 
            // pen_group
            // 
            this.pen_group.Controls.Add(this.pen_size_combo_box);
            this.pen_group.Controls.Add(this.label2);
            this.pen_group.Controls.Add(this.label1);
            this.pen_group.Controls.Add(this.pen_color_button);
            this.pen_group.Location = new System.Drawing.Point(7, 20);
            this.pen_group.Name = "pen_group";
            this.pen_group.Size = new System.Drawing.Size(78, 100);
            this.pen_group.TabIndex = 0;
            this.pen_group.TabStop = false;
            this.pen_group.Text = "Pen";
            // 
            // pen_size_combo_box
            // 
            this.pen_size_combo_box.FormattingEnabled = true;
            this.pen_size_combo_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.pen_size_combo_box.Location = new System.Drawing.Point(6, 33);
            this.pen_size_combo_box.Name = "pen_size_combo_box";
            this.pen_size_combo_box.Size = new System.Drawing.Size(66, 21);
            this.pen_size_combo_box.TabIndex = 3;
            this.pen_size_combo_box.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size:";
            // 
            // pen_color_button
            // 
            this.pen_color_button.BackColor = System.Drawing.Color.Black;
            this.pen_color_button.Location = new System.Drawing.Point(3, 71);
            this.pen_color_button.Name = "pen_color_button";
            this.pen_color_button.Size = new System.Drawing.Size(69, 23);
            this.pen_color_button.TabIndex = 0;
            this.pen_color_button.UseVisualStyleBackColor = false;
            this.pen_color_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 426);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_mouse_down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_mouse_move);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_mouse_up);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.color_group);
            this.Name = "Form1";
            this.Text = "Form1";
            this.color_group.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.background_group.ResumeLayout(false);
            this.background_group.PerformLayout();
            this.pen_group.ResumeLayout(false);
            this.pen_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox color_group;
        private System.Windows.Forms.Button pen_color_button;
        private System.Windows.Forms.GroupBox pen_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pen_size_combo_box;
        private System.Windows.Forms.GroupBox background_group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button background_color_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button background_image_button;
        private System.Windows.Forms.Panel panel1;
    }
}

