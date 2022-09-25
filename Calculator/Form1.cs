namespace Calculator
{
    public partial class Form1 : Form
    {
        Double ResultValue = 0;
        String OperationPerformed = "";
        bool isOperationPerformed=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (isOperationPerformed))
                Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!Result.Text.Contains("."))
                    Result.Text = Result.Text + button.Text;

            }
            else
            Result.Text = Result.Text + button.Text;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(ResultValue !=0)
            {
                button2.PerformClick();
                OperationPerformed = button.Text;
                label.Text = ResultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                OperationPerformed = button.Text;
                ResultValue = Double.Parse(Result.Text);
                label.Text = ResultValue + " " + OperationPerformed;
                isOperationPerformed = true;
            }  
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            ResultValue = 0;
            label.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(OperationPerformed)
            {
                case "+":
                    Result.Text = (ResultValue+ Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (ResultValue - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (ResultValue * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (ResultValue / Double.Parse(Result.Text)).ToString();
                    break;
                    default:
                    break;
            }
            ResultValue=Double.Parse(Result.Text);
            label.Text = "";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}