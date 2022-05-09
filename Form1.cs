namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculation _calcAction = Calculation.NONE;
        private decimal _firstNumber = 0M;
        private decimal _secondNumber = 0M;
        
        public Form1()
        {
            InitializeComponent();
            ResetStringInput();
        }

        private void ResetStringInput() => calculationResultBox.Text = "0";
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "1";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "2";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "3";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "4";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "5";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "6";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "7";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "8";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calculationResultBox.Text == "0" && calculationResultBox.Text != null)
            {
                calculationResultBox.Text = "9";
            }
            else
            {
                calculationResultBox.Text = calculationResultBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calculationResultBox.Text = calculationResultBox.Text + "0";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            bool hasPeriod = false;

            foreach (char c in calculationResultBox.Text)
                if (c == '.')
                    hasPeriod = true;

            if (!hasPeriod)
            {
                calculationResultBox.Text = calculationResultBox.Text + ".";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _calcAction = Calculation.ADD;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

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