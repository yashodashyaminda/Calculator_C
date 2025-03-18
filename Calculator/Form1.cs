namespace Calculator
{
    public partial class Calculator : Form
    {
        string operation = "";
        double result_Value = 0;
        bool is_Operation_Performed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // Initialize display to 0
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || is_Operation_Performed)
            {
                textBox1.Clear();
            }

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += btn.Text;
                }
            }
            else
            {
                textBox1.Text += btn.Text;
            }

            is_Operation_Performed = false;
        }

        private void operation_Performed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (result_Value != 0)
            {
                button18.PerformClick(); // Perform previous operation
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + " " + operation;
                is_Operation_Performed = true;
            }
            else
            {
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + " " + operation;
                is_Operation_Performed = true;
            }

            textBox1.Text = "0"; // Reset input for next number
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            result_Value = 0;
            operation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                double secondOperand = double.Parse(textBox1.Text);

                switch (operation)
                {
                    case "+":
                        result_Value += secondOperand;
                        break;

                    case "-":
                        result_Value -= secondOperand;
                        break;

                    case "*":
                        result_Value *= secondOperand;
                        break;

                    case "/":
                        if (secondOperand == 0)
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        result_Value /= secondOperand;
                        break;

                    default:
                        return;
                }

                textBox1.Text = result_Value.ToString();
                label1.Text = "";
                operation = ""; // Reset operation after calculation
                is_Operation_Performed = true;
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }
    }
}
