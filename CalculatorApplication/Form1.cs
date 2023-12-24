using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String CalTotal;
        double num1; double num2;
        String option;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Calculator";
        }

        private void TextAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = TextAnswer.Text + button0.Text;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(TextAnswer.Text);
            TextAnswer.Clear();
        }
        private void btnminus_Click(object sender, EventArgs e)
        {

            option = "-";
            num1 = double.Parse(TextAnswer.Text);
            TextAnswer.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {

            option = "÷";
            num1 = double.Parse(TextAnswer.Text);
            TextAnswer.Clear();
        }

        private void btntimes_Click(object sender, EventArgs e)
        {

            option = "×";
            num1 = double.Parse(TextAnswer.Text);
            TextAnswer.Clear();
        }
        private void btnsqrt_Click(object sender, EventArgs e)
        {
            option = "√";
            num1 = double.Parse(TextAnswer.Text);
            TextAnswer.Clear();
        }
        private void btnequals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(TextAnswer.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }
            else if (option == "-")
            {
                result = num1 - num2; 
            }
            else if (option == "÷")
            {
                result = num1 / num2;
            }
            else if (option == "√")
            {
                result = Math.Sqrt(num1);
            }
            else
            {
                result = num1 * num2;   
            }
            TextAnswer.Text = result.ToString();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            TextAnswer.Clear();
        }

        
    }
}
