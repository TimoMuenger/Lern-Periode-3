using System.Diagnostics.Eventing.Reader;

namespace LP3
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationOngoing = false;
        public Form1()
        {
            InitializeComponent();
        }

        // verlinkt mit Taste 9 verlinkt
        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 7 verlinkt
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 6 verlinkt
        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //ist mit * verlinkt
        private void button13_Click(object sender, EventArgs e)
        {
            if (operationOngoing)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationOngoing = true;
        }
        //ist mit Taste 8 verlinkt
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 4 verlinkt
        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 5 verlinkt
        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 1 verlinkt
        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 2 verlinkt
        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 3 verlinkt
        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        //ist mit Taste 0 verlinkt
        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = "";
            result = 0;
            operation = "";
            operationOngoing = false;
            textBox1.Text = " ";
        }
        //ist mit + verlinkt
        private void button12_Click(object sender, EventArgs e)
        {
            if (operationOngoing)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationOngoing = true;
        }
        //ist mit = verlinkt
        private void button15_Click(object sender, EventArgs e)
        {
            if (operationOngoing)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationOngoing = true;
        }
        //ist mit / verlinkt
        private void button16_Click(object sender, EventArgs e)
        {
            if (operationOngoing)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationOngoing = true;
        }


        private void Evaluate()
        {
            if (operationOngoing)
            {
                double secondNumber = double.Parse(currentInput);
                switch (operation)
                {
                    case "+":
                        result += secondNumber; break;
                    case "-":
                        result -= secondNumber; break;
                    case "*":
                        result *= secondNumber; break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Error"; return;
                        }
                        {
                            break;
                        }
                }

            }
        }
        //ist mit - verlinkt
        private void button14_Click(object sender, EventArgs e)
        {
            if (operationOngoing)
            {
                Evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationOngoing = true;
        }
    }
}


    