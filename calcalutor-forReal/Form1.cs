using System.Data;

namespace calcalutor_forReal
{
    public partial class Form1 : Form
    {
        double val1;
        double val2;
        string temp;
        double result = 0;
        string op;

        public double eval(double v1, double v2, string o)
        {


            switch (o)
            {
                case "+":
                    return v1 + v2;
                case "-":
                    return v1 - v2;
                case "/":
                    return v1 / v2;
                case "*":
                    return v1 * v2;
                default:
                    return 000000;
            }



        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getInt(object sender, EventArgs e)
        {
            //temp = sender.ToString();
            //temp = temp.Split(":")[1];
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void getOp(object sender, EventArgs e)
        {
            //string op = sender.ToString();
            //op = op.Split(":")[1];

            Button tempOp = (Button)sender;
            op = tempOp.Text;
            if (textBox1.Text.Length > 0)
            {
                val1 = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            label1.Text = Convert.ToString(val1);
            label1.Text += op;
        }

        private void equalTofun(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            val2 = Convert.ToDouble(textBox1.Text);
            label1.Text += Convert.ToString(val2);
            double result = eval(val1, val2, op);
            textBox1.Text = Convert.ToString(result);
        }

        private void allClear(object sender, EventArgs e)
        {
            val1 = 0; val2 = 0; op = "";
            textBox1.Text = "";
            label1.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
/*
 

 
 */