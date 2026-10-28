namespace DesktopApp1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        string operation = "";      
        double firstValue = 0;       
        double secondValue = 0;     
        bool newOperation = false;
        double result = 0;
        private void allBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                Display.Text = "";
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = Display.Text.IndexOf(",");
                if (val > 0) ;
                return;
            }
            Display.Text += btn.Text;
            if (btn.Text != ",")
            {
                firstValue = Convert.ToDouble(btn.Text);
            }
        }
            
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void operationClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            firstValue = Convert.ToDouble(Display.Text);
            newOperation = true;
        }
        private void btn_equal(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(Display.Text);
            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "X":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                    {
                        result = firstValue / secondValue;
                    }
                    else
                    {
                        Display.Text = "Деление на ноль";
                    }
                    break;
            }
            Display.Text = result.ToString();
            newOperation = true;
        }
    }
}