namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _calculatorOutput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateResultBox()
        {
            calculationResultBox.Text = _calculatorOutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button1.Text;
            UpdateResultBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button2.Text;
            UpdateResultBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button3.Text;
            UpdateResultBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button4.Text;
            UpdateResultBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button5.Text;
            UpdateResultBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button6.Text;
            UpdateResultBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button7.Text;
            UpdateResultBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button8.Text;
            UpdateResultBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button9.Text;
            UpdateResultBox();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            _calculatorOutput = _calculatorOutput + button0.Text;
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
                _calculatorOutput = _calculatorOutput + buttonPeriod.Text;
                UpdateResultBox();
            }
        }
    }
}