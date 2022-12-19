namespace connect4.graphics.trial
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
            this.Start = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(357, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.one.Location = new System.Drawing.Point(242, 58);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 40);
            this.one.TabIndex = 1;
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.five.Location = new System.Drawing.Point(425, 58);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(40, 40);
            this.five.TabIndex = 5;
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.four.Location = new System.Drawing.Point(380, 58);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(40, 40);
            this.four.TabIndex = 6;
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.three.Location = new System.Drawing.Point(334, 58);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(40, 40);
            this.three.TabIndex = 7;
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.two.Location = new System.Drawing.Point(288, 58);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(40, 40);
            this.two.TabIndex = 8;
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seven.Location = new System.Drawing.Point(517, 58);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(40, 40);
            this.seven.TabIndex = 11;
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.six.Location = new System.Drawing.Point(471, 58);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(40, 40);
            this.six.TabIndex = 12;
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
    }
}

