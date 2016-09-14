using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squared
{
    public partial class Form1 : Form
    {
        double secondnum = 0;
        double overallnum = 0;
        double oldean;
        Boolean previously = false;
        Boolean secondorfirst = false;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 1;
                label3.Text = "current number is" + overallnum;
            }
            if(secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 1;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 2;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 2;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 3;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 3;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 4;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 4;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 5;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 5;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 6;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 6;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 7;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 7;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 8;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 8;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 9;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 9;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (secondorfirst == false)
            {
                overallnum = overallnum * 10;
                overallnum = overallnum + 0;
                label3.Text = "current number is" + overallnum;
            }
            if (secondorfirst == true)
            {
                secondnum = secondnum * 10;
                secondnum = secondnum + 0;
                label3.Text = "current numbers are" + overallnum + " and " + secondnum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
                secondnum = 0;
            }
            overallnum = overallnum * overallnum;
            label2.Text = "The number squared equals" + overallnum;
            if(previously == true){
                label1.Text = label1.Text + oldean + ", ";
            }
            secondorfirst = false;
            previously = true;
            oldean = overallnum;
            overallnum = 0;
            label3.Text = "current number is" + overallnum;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
                secondnum = 0;
            }
            overallnum = Math.Pow(overallnum, .5);
            label2.Text = "The number's square root equals: " + overallnum;
            if (previously == true)
            {
                label1.Text = label1.Text + oldean + ", ";
            }
            secondorfirst = false;
            previously = true;
            oldean = overallnum;
            overallnum = 0;
            label3.Text = "current number is" + overallnum;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
                secondnum = 0;
            }
            overallnum = Math.Log10(overallnum);
            label2.Text = "The log of 10 of the number is: " + overallnum;
            if (previously == true)
            {
                label1.Text = label1.Text + oldean + ", ";
            }
            secondorfirst = false;
            previously = true;
            oldean = overallnum;
            overallnum = 0;
            label3.Text = "current number is" + overallnum;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
                secondnum = 0;
            }
            overallnum = Math.Sin(overallnum);
            label2.Text = "The sin of the angle of the number is: " + overallnum;
            if (previously == true)
            {
                label1.Text = label1.Text + oldean + ", ";
            }
            secondorfirst = false;
            previously = true;
            oldean = overallnum;
            overallnum = 0;
            label3.Text = "current number is" + overallnum;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
                secondnum = 0;
            }
            secondorfirst = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (secondorfirst == true)
            {
                overallnum = overallnum + secondnum;
            }
            label2.Text = "the overall value is: " + overallnum;
            if (previously == true)
            {
                label1.Text = label1.Text + oldean + ", ";
            }
            previously = true;
            secondorfirst = false;
            oldean = overallnum;
            overallnum = 0;
            secondnum = 0;
            label3.Text = "current number is" + overallnum;
        }
    }
}
