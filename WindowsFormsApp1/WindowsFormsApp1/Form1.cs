using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool isfunctionclicked = false;
        public Form1()
        {
            InitializeComponent();
        }
        //Button 0 - 9 start
        private void Btn0_Click(object sender, EventArgs e)
        {
            Displaynumber("0");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Displaynumber("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Displaynumber("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Displaynumber("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Displaynumber("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Displaynumber("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Displaynumber("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Displaynumber("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Displaynumber("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Displaynumber("9");
        }
        //Button 0 - 9 End

        //Opertor Start 
        private void Btnadd_Click(object sender, EventArgs e)
        {
            Numeratoraction("+");
        }

        private void Btnsub_Click(object sender, EventArgs e)
        {
            Numeratoraction("-");
        }

        private void Btnmul_Click(object sender, EventArgs e)
        {
            Numeratoraction("*");
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            Numeratoraction("/");
        }

        private void Btnequ_Click(object sender, EventArgs e)
        {
            Displaybox.Text = Convert.ToString(total);
        }
        //Opertor End
        

        private void Btnce_Click(object sender, EventArgs e)
        {

        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            Displaybox.Text = "0";
        }

        private void Btnerase_Click(object sender, EventArgs e)
        {

        }

        private void Displaybox_TextChanged(object sender, EventArgs e)
        {

        }
        /// Methods starts
        private void Displaynumber(string btnnumber)
        {
            string displayvalue = Displaybox.Text;
            if (displayvalue == "0" || isfunctionclicked)
            {
                Displaybox.Text = btnnumber;
                isfunctionclicked = false;
            }
            else
            {
                Displaybox.Text +=  btnnumber;
            }
        }

        private void Numeratoraction(string _operatortype) 
        {
            isfunctionclicked = true;
            double typednumber = Convert.ToDouble(Displaybox.Text);

            if (total == 0)
            {
                total = typednumber;
            }
            else
            {
                switch (_operatortype)
                {
                    case "+":
                        total += typednumber;
                        break;
                    case "-":
                        total -= typednumber;
                        break;
                    case "*":
                        total *= typednumber;
                        break;
                    case "/":
                        total /= typednumber;
                        break;
                }
                
            }
            Displaybox.Text = Convert.ToString(total);
        }

    }
}
