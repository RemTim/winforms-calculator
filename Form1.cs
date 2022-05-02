namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _calculatorStringInput = "";
        private decimal _calculatorNumberValue = 0M;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateStringInputToNumberValue() => _calculatorNumberValue = Convert.ToDecimal(_calculatorStringInput);

        private void AppendToStringInput(string stringDigit) => _calculatorStringInput += stringDigit;

        private void UpdateResultBox()
        {
            calculationResultBox.Text = _calculatorStringInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button1.Text);
            UpdateResultBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button2.Text);
            UpdateResultBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button3.Text);
            UpdateResultBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button4.Text);
            UpdateResultBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button5.Text);
            UpdateResultBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button6.Text);
            UpdateResultBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button7.Text);
            UpdateResultBox();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button8.Text);
            UpdateResultBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button9.Text);
            UpdateResultBox();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button0.Text);
            UpdateResultBox();
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            bool hasPeriod = false;

            foreach (char c in _calculatorStringInput)
                if (c == '.')
                    hasPeriod = true;

            if (!hasPeriod)
            {
                AppendToStringInput(buttonPeriod.Text);
                UpdateResultBox();
            }
        }
    }

    enum Calculation
    {
        NONE,
        ADD,
        SUBTRACT,
        MULTIPLY,
        DIVIDE
    }
}