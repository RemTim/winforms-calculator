namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _calculatorOutput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendToOutput(string text)
        {
            _calculatorOutput = _calculatorOutput + text;
        }

        private void UpdateResultBox()
        {
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToOutput(button1.Text);
            UpdateResultBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToOutput(button2.Text);
            UpdateResultBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToOutput(button3.Text);
            UpdateResultBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToOutput(button4.Text);
            UpdateResultBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToOutput(button5.Text);
            UpdateResultBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToOutput(button6.Text);
            UpdateResultBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToOutput(button7.Text);
            UpdateResultBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToOutput(button8.Text);
            UpdateResultBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToOutput(button9.Text);
            UpdateResultBox();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendToOutput(button0.Text);
            UpdateResultBox();
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            bool hasPeriod = false;

            foreach (char c in _calculatorOutput)
                if (c == '.')
                    hasPeriod = true;

            if (!hasPeriod)
            {
                AppendToOutput(buttonPeriod.Text);
                UpdateResultBox();
            }
        }
    }
}