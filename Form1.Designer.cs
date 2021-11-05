namespace Fuel_Economy_Calculator
{
    partial class fuelForm
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
            this.milesDrivenLabel = new System.Windows.Forms.Label();
            this.gallonsUsedLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // milesDrivenLabel
            // 
            this.milesDrivenLabel.AutoSize = true;
            this.milesDrivenLabel.Location = new System.Drawing.Point(19, 117);
            this.milesDrivenLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.milesDrivenLabel.Name = "milesDrivenLabel";
            this.milesDrivenLabel.Size = new System.Drawing.Size(111, 13);
            this.milesDrivenLabel.TabIndex = 0;
            this.milesDrivenLabel.Text = "Enter the miles driven:";
            // 
            // gallonsUsedLabel
            // 
            this.gallonsUsedLabel.AutoSize = true;
            this.gallonsUsedLabel.Location = new System.Drawing.Point(19, 161);
            this.gallonsUsedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gallonsUsedLabel.Name = "gallonsUsedLabel";
            this.gallonsUsedLabel.Size = new System.Drawing.Size(115, 13);
            this.gallonsUsedLabel.TabIndex = 1;
            this.gallonsUsedLabel.Text = "Enter the gallons used:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(185, 117);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(129, 20);
            this.milesTextBox.TabIndex = 2;
            this.milesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(185, 158);
            this.gallonsTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(129, 20);
            this.gallonsTextBox.TabIndex = 3;
            this.gallonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Location = new System.Drawing.Point(121, 196);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(97, 13);
            this.mpgLabel.TabIndex = 4;
            this.mpgLabel.Text = "Your car\'s MPG is: ";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.Location = new System.Drawing.Point(22, 223);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(292, 40);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(0, 25);
            this.calcButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(80, 39);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "&CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(102, 25);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 39);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 25);
            this.exitButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 39);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "EXI&T";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 273);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(290, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 73);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gaddis C# \r\nTutorial 4-4 \r\nFuel Economy Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 52);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tom Bielawski\r\nFSCJ Professor Gherig\r\nIntro to C#\r\n10/18/2020";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsUsedLabel);
            this.Controls.Add(this.milesDrivenLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "fuelForm";
            this.Text = "Fuel Economy Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesDrivenLabel;
        private System.Windows.Forms.Label gallonsUsedLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

