namespace GUI_Task
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
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Welcome_Text_Box = new System.Windows.Forms.TextBox();
            this.First_Number = new System.Windows.Forms.TextBox();
            this.Second_Number = new System.Windows.Forms.TextBox();
            this.Add_Radio = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Button = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Runner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(39, 54);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(100, 20);
            this.Name_Box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj swoje imie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guzik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome_Text_Box
            // 
            this.Welcome_Text_Box.Location = new System.Drawing.Point(39, 109);
            this.Welcome_Text_Box.Name = "Welcome_Text_Box";
            this.Welcome_Text_Box.Size = new System.Drawing.Size(100, 20);
            this.Welcome_Text_Box.TabIndex = 4;
            // 
            // First_Number
            // 
            this.First_Number.Location = new System.Drawing.Point(272, 83);
            this.First_Number.Name = "First_Number";
            this.First_Number.Size = new System.Drawing.Size(100, 20);
            this.First_Number.TabIndex = 5;
            // 
            // Second_Number
            // 
            this.Second_Number.Location = new System.Drawing.Point(412, 83);
            this.Second_Number.Name = "Second_Number";
            this.Second_Number.Size = new System.Drawing.Size(100, 20);
            this.Second_Number.TabIndex = 6;
            // 
            // Add_Radio
            // 
            this.Add_Radio.AutoSize = true;
            this.Add_Radio.Checked = true;
            this.Add_Radio.Location = new System.Drawing.Point(378, 56);
            this.Add_Radio.Name = "Add_Radio";
            this.Add_Radio.Size = new System.Drawing.Size(31, 17);
            this.Add_Radio.TabIndex = 7;
            this.Add_Radio.TabStop = true;
            this.Add_Radio.Text = "+";
            this.Add_Radio.UseVisualStyleBackColor = true;
            this.Add_Radio.CheckedChanged += new System.EventHandler(this.Add_Radio_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(378, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(378, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(29, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "*";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(378, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(30, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "/";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(540, 83);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 11;
            this.Button.Text = "=";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(634, 85);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 12;
            // 
            // Runner
            // 
            this.Runner.BackColor = System.Drawing.Color.Red;
            this.Runner.Location = new System.Drawing.Point(936, 227);
            this.Runner.Name = "Runner";
            this.Runner.Size = new System.Drawing.Size(50, 50);
            this.Runner.TabIndex = 13;
            this.Runner.UseVisualStyleBackColor = false;
            this.Runner.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 631);
            this.Controls.Add(this.Runner);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Add_Radio);
            this.Controls.Add(this.Second_Number);
            this.Controls.Add(this.First_Number);
            this.Controls.Add(this.Welcome_Text_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Welcome_Text_Box;
        private System.Windows.Forms.TextBox First_Number;
        private System.Windows.Forms.TextBox Second_Number;
        private System.Windows.Forms.RadioButton Add_Radio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Runner;
    }
}

