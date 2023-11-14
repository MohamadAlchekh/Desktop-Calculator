namespace Calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool is_operating = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = double.Parse(textBox1.Text);
            is_operating = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || is_operating == true) { textBox1.Clear(); }
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            is_operating = false;
        }



        private void button16_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}