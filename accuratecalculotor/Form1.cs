using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accuratecalculotor
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void txt_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_box.Text = "";
            Form f = new Form();
        }

        private void add_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "  +  " ;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "-";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "X";
        }

        private void div_Click(object sender, EventArgs e)
        {
            txt_box.Text = txt_box.Text + "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(txt_box.Text=="")
            {
                MessageBox.Show("please enter the values ...");
            }


            string bord = txt_box.Text;
            string str1 = "";
            string str2 = "";
            int i;
            for( i=0;i<bord.Length-1;i++)
            {

                if ((bord[i] == '+') || (bord[i] == '-') || (bord[i] == 'X') || (bord[i] == '/'))
                {
                    break;
                }
           }
            str1 = bord.Substring(0, i);
            str2 = bord.Substring(i + 1);
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);
            if (bord[i] == '+')
            {
                int add = num1 + num2;
                txt_box.Text = add.ToString();
            }
            else if(bord[i]=='-')
            {
                int sub = num1 - num2;
                txt_box.Text = sub.ToString();
            }
            else if (bord[i] == 'X')
            {
                int mult = num1 * num2;
                txt_box.Text = mult.ToString();
            }
            else if (bord[i] == '/')
            {
                float numf1 = (float)num1;
                float numf2 = (float)num2;
                float div = numf1 / numf2;
                txt_box.Text = div.ToString();
            }
            else
            {
                MessageBox.Show("ERROR PLEASE ENTER A VALID FORMAT....");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            string bord = txt_box.Text;
            string str1 = "";

            str1 = bord.Substring(0, bord.Length - 1);
            txt_box.Text = str1;
        }

       
    }
}
