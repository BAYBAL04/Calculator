namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string operation;
        public string num1;
        public bool flagNum2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (flagNum2)
            {
                flagNum2 = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num1 = textBox1.Text;
            flagNum2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(num1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (operation == "+")
            {
                res = dn1 + dn2;
            }
            if (operation == "-")
            {
                res = dn1 - dn2;
            }
            if (operation == "×")
            {
                res = dn1 * dn2;
            }
            if (operation == "÷")
            {
                res = dn1 / dn2;
            }
            if (operation == "%")
            {
                res = dn1 * dn2 / 100;
            }
            operation = "=";
            flagNum2 = true;
            textBox1.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = dn * (-1);
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
        
    }
}