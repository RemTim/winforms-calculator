namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculation _calcAction = Calculation.NONE;

        private string _calculatorStringInput = "";

        private decimal _calculatorStoredNumber = 0M;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetStringInput() => _calculatorStringInput = "";

        private void SetStringInputToNumberValueOne() => _calculatorStoredNumber = GetStringInputNumber();

        private decimal GetStringInputNumber() => Convert.ToDecimal(_calculatorStringInput);

        private void AppendToStringInput(string text) => _calculatorStringInput += text;

        private void UpdateResultBox(string text) => calculationResultBox.Text = text;
        

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button1.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button2.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button3.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button4.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button5.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button6.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button7.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button8.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button9.Text);
            UpdateResultBox(_calculatorStringInput);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AppendToStringInput(button0.Text);
            UpdateResultBox(_calculatorStringInput);
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
                UpdateResultBox(_calculatorStringInput);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SetStringInputToNumberValueOne();
            _calcAction = Calculation.ADD;
            ResetStringInput();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)  // broken down mess
        {
            decimal result = 0M;
            if (_calcAction == Calculation.ADD)
            {
                result = _calculatorStoredNumber + Convert.ToDecimal(_calculatorStringInput);
            }
            calculationResultBox.Text = result.ToString();
            ResetStringInput();
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