namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _calculatorOutput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button1.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button2.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button3.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button4.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button5.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button6.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button7.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button8.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button9.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button0.Text;
            calculationResultBox.Text = _calculatorOutput;
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            bool hasPeriod = false;

            foreach (char c in _calculatorOutput)
                if (c == '.')
                    hasPeriod = true;

            if (!hasPeriod)
            {
                _calculatorOutput = _calculatorOutput + buttonPeriod.Text;
                calculationResultBox.Text = _calculatorOutput;
            }
        }
    }
}