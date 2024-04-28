using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_AD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total;
        int num1;
        int num2;
        string option;
        int result;

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Console.ReadKey();  
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =txtDisplay.Text + btn1.Text;  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 =int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btssub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            num2 =int.Parse(txtDisplay.Text);

            if (option == "+")
            {
                result=num1+ num2;
            }
            if (option == "-")
            {
                result = num1 - num2;
            }
            if (option == "*")
            {
                result = num1 * num2;
            }
            if (option == "/")
            {
                result = num1 / num2;
            }
            txtDisplay.Text = result +"";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            /*option = ".";
            txtDisplay = btnd.Text;
            //txtDisplay.Clear();*/
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            

        }
    }
}
