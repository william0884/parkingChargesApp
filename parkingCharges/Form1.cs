namespace parkingCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentButton.Checked == true)
            {
                richTextBox1.Text = "Pay $2 per for each hour. Max 24 hours";

            }
            else if (staffButton.Checked == true)
            {

                richTextBox1.Text = "Pay $2 per for 10 hours. Then $2 a hour. Max 24 hours";
            }
            else
            {
                richTextBox1.Text = "Please select a role";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (studentButton.Checked == true)
            {
                
                Int32 val1 = Convert.ToInt32(HoursInput.Text);
                if (val1 >= 24)
                {
                    FeeDisplay.Text = "Towed";
                }
                else
                {
                    Int32 val3 = val1 * 2;
                    FeeDisplay.Text = val3.ToString();
                }
            }
            else if (staffButton.Checked == true)
            {
                Int32 val1 = Convert.ToInt32(HoursInput.Text);
                if (val1 <= 10)
                    {
                    FeeDisplay.Text = "2";

                }
                else if (val1 <= 24)
                {
                    Int32 val3 = (val1 - 10) * 2;
                    FeeDisplay.Text = val3.ToString();
                }
                else
                {
                    FeeDisplay.Text = "Towed";
                }    


            }
        }
    

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HoursInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeeDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
