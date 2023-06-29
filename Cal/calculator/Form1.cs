namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string operation;
        int result;


        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button0.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (operation.Equals("+"))
                result = num1 + num2;

            if (operation.Equals("-"))
                result = num1 - num2;

            if (operation.Equals("*"))
                result = num1 * num2;

            if (operation.Equals("/"))
                result = num1 / num2;

            txtTotal.Text = result + "";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}