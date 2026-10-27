namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        private void allBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                Display.Text = "";
                newOperation = false;
            }
            if (btn.Text ==",")
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
    }
}