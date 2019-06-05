namespace Assignment_2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.explainationBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.Normalbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Easy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select \r\na \r\ndifficulty";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // explainationBox
            // 
            this.explainationBox.Location = new System.Drawing.Point(125, 12);
            this.explainationBox.Multiline = true;
            this.explainationBox.Name = "explainationBox";
            this.explainationBox.ReadOnly = true;
            this.explainationBox.Size = new System.Drawing.Size(214, 39);
            this.explainationBox.TabIndex = 4;
            this.explainationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.explainationBox.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Visible = false;
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(352, 173);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(75, 23);
            this.buttonEasy.TabIndex = 6;
            this.buttonEasy.Text = "Enter";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Visible = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(345, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(56, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "No. Lives:";
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(397, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Word:";
            this.label1.Visible = false;
            // 
            // buttonNormal
            // 
            this.buttonNormal.Location = new System.Drawing.Point(354, 173);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonNormal.TabIndex = 12;
            this.buttonNormal.Text = "Enter ";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Visible = false;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(354, 174);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(77, 22);
            this.buttonHard.TabIndex = 13;
            this.buttonHard.Text = "Enter";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Visible = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // Normalbutton
            // 
            this.Normalbutton.Location = new System.Drawing.Point(175, 107);
            this.Normalbutton.Name = "Normalbutton";
            this.Normalbutton.Size = new System.Drawing.Size(75, 23);
            this.Normalbutton.TabIndex = 14;
            this.Normalbutton.Text = "Normal";
            this.Normalbutton.UseVisualStyleBackColor = true;
            this.Normalbutton.Click += new System.EventHandler(this.Normalbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 260);
            this.Controls.Add(this.Normalbutton);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.explainationBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Guess the Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox explainationBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button Normalbutton;
    }
}