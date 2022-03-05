using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204024
{
    public partial class Form1 : Form
    {
        decimal a;
        decimal b;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = button1.Text;
            if(label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += "2";
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text != " ")
            {
                label1.Text += "0";
            }
        }

        // tambah
        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(label1.Text);
            label2.Text = "+";
            label1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }
        //hasil
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (opr_selesai == true && label1.Text != " ")
            {
                b = Convert.ToDecimal(label1.Text);
                switch (opr)
                {
                    case 1:
                        label1.Text = Convert.ToString(a + b);
                        break;
                }
                opr_selesai = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
