namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculation _calcAction = Calculation.NONE;
        private decimal _firstNumber = 0M;
        private decimal _secondNumber = 0M;
        private decimal _result = 0M;
        
        public Form1()
        {
            InitializeComponent();
            ResetCalcBox();
        }

        private void ResetCalcBox() => calcBox.Text = "0";
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "1";
            }
            else
            {
                calcBox.Text = calcBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "2";
            }
            else
            {
                calcBox.Text = calcBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "3";
            }
            else
            {
                calcBox.Text = calcBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "4";
            }
            else
            {
                calcBox.Text = calcBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "5";
            }
            else
            {
                calcBox.Text = calcBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "6";
            }
            else
            {
                calcBox.Text = calcBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "7";
            }
            else
            {
                calcBox.Text = calcBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "8";
            }
            else
            {
                calcBox.Text = calcBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcBox.Text == "0" && calcBox.Text != null)
            {
                calcBox.Text = "9";
            }
            else
            {
                calcBox.Text = calcBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calcBox.Text = calcBox.Text + "0";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            bool hasPeriod = false;

            foreach (char c in calcBox.Text)
                if (c == '.')
                    hasPeriod = true;

            if (!hasPeriod)
            {
                calcBox.Text = calcBox.Text + ".";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDecimal(calcBox.Text);
            _calcAction = Calculation.ADD;
            ResetCalcBox();
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDecimal(calcBox.Text);
            _calcAction = Calculation.SUBTRACT;
            ResetCalcBox();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDecimal(calcBox.Text);
            _calcAction = Calculation.MULTIPLY;
            ResetCalcBox();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDecimal(calcBox.Text);
            _calcAction = Calculation.DIVIDE;
            ResetCalcBox();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            _secondNumber = Convert.ToDecimal(calcBox.Text);

            switch (_calcAction)
            {
                case Calculation.NONE:
                    break;
                case Calculation.ADD:
                    _result = _firstNumber + _secondNumber;
                    calcBox.Text = _result.ToString();
                    break;
                case Calculation.SUBTRACT:
                    _result = _firstNumber - _secondNumber;
                    calcBox.Text = _result.ToString();
                    break;
                case Calculation.MULTIPLY:
                    _result = _firstNumber * _secondNumber;
                    calcBox.Text = _result.ToString();
                    break;
                case Calculation.DIVIDE:
                    _result = _firstNumber / _secondNumber;
                    calcBox.Text = _result.ToString();
                    break;
            }

            _calcAction = Calculation.NONE;
            _firstNumber = _result;
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