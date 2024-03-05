namespace parkingCharges
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NextButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            HoursInput = new TextBox();
            CalcButton = new Button();
            studentButton = new RadioButton();
            staffButton = new RadioButton();
            FeeDisplay = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // NextButton
            // 
            NextButton.Location = new Point(248, 82);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(79, 23);
            NextButton.TabIndex = 0;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(333, 82);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(79, 23);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(481, 472);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(79, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 322);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Hours parked";
            label1.Click += label1_Click;
            // 
            // HoursInput
            // 
            HoursInput.Location = new Point(199, 314);
            HoursInput.Name = "HoursInput";
            HoursInput.Size = new Size(100, 23);
            HoursInput.TabIndex = 4;
            HoursInput.TextChanged += HoursInput_TextChanged;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(199, 357);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(79, 23);
            CalcButton.TabIndex = 5;
            CalcButton.Text = "Calculate";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += button4_Click;
            // 
            // studentButton
            // 
            studentButton.AutoSize = true;
            studentButton.Location = new Point(199, 57);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(66, 19);
            studentButton.TabIndex = 8;
            studentButton.TabStop = true;
            studentButton.Text = "Student";
            studentButton.UseVisualStyleBackColor = true;
            // 
            // staffButton
            // 
            staffButton.AutoSize = true;
            staffButton.Location = new Point(278, 57);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(49, 19);
            staffButton.TabIndex = 9;
            staffButton.TabStop = true;
            staffButton.Text = "Staff";
            staffButton.UseVisualStyleBackColor = true;
            // 
            // FeeDisplay
            // 
            FeeDisplay.BackColor = SystemColors.InactiveCaption;
            FeeDisplay.Location = new Point(199, 420);
            FeeDisplay.Name = "FeeDisplay";
            FeeDisplay.Size = new Size(100, 23);
            FeeDisplay.TabIndex = 10;
            FeeDisplay.Text = "Fee";
            FeeDisplay.TextChanged += FeeDisplay_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 28);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "No parking for more than 24 hours";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(199, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(213, 113);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 528);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(FeeDisplay);
            Controls.Add(staffButton);
            Controls.Add(studentButton);
            Controls.Add(CalcButton);
            Controls.Add(HoursInput);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(NextButton);
            Name = "Form1";
            Text = "Parking Charges";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label label1;
        private TextBox HoursInput;
        private Button CalcButton;
        private RadioButton studentButton;
        private RadioButton staffButton;
        private TextBox FeeDisplay;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
    }
}
