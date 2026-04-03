namespace RollOfTheDiceList
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
            this.RollDice = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RollDisplay = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RollDice
            // 
            this.RollDice.AccessibleDescription = "Roll two six sided die";
            this.RollDice.AccessibleName = "Roll Dice";
            this.RollDice.Location = new System.Drawing.Point(7, 39);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(75, 23);
            this.RollDice.TabIndex = 1;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleDescription = "Closes the Program";
            this.ExitButton.AccessibleName = "Exit Button";
            this.ExitButton.Location = new System.Drawing.Point(107, 39);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RollDice);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Location = new System.Drawing.Point(218, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RollDisplay
            // 
            this.RollDisplay.AccessibleDescription = "Keeps track of how many times a number is rolled";
            this.RollDisplay.AccessibleName = "Rolls Display";
            this.RollDisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RollDisplay.FormattingEnabled = true;
            this.RollDisplay.HorizontalExtent = 12;
            this.RollDisplay.HorizontalScrollbar = true;
            this.RollDisplay.ItemHeight = 16;
            this.RollDisplay.Location = new System.Drawing.Point(97, 31);
            this.RollDisplay.MultiColumn = true;
            this.RollDisplay.Name = "RollDisplay";
            this.RollDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RollDisplay.Size = new System.Drawing.Size(335, 148);
            this.RollDisplay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RollDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox RollDisplay;
    }
}

