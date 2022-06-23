using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if ((TextStore.Text != ""))
            {
                num = float.Parse(TextStore.Text);
                TextResulta.Text = TextStore.Text + "/";
                TextStore.Clear();
                count = 4;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + ",";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TextStore.Text = TextStore.Text + "9";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextStore.Clear();
            TextResulta.Clear();
        }
        float num;
        int count;
        private void BtnMinis_Click(object sender, EventArgs e)
        {

            if ((TextStore.Text != ""))
            {
                num = float.Parse(TextStore.Text);
                TextResulta.Text = TextStore.Text + "-";
                TextStore.Clear();
                count = 1;
            }

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if ((TextStore.Text != ""))
            {
                num = float.Parse(TextStore.Text);
                TextResulta.Text = TextStore.Text + "+";
                TextStore.Clear();
                count = 2;
            }
        }

        private void BtnFoi_Click(object sender, EventArgs e)
        {
            if ((TextStore.Text != ""))
            {
                num = float.Parse(TextStore.Text);
                TextResulta.Text = TextStore.Text + "*";
                TextStore.Clear();
                count = 3;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(TextStore.Text);
                    TextResulta.Text = TextResulta.Text + TextStore.Text + "=" + ans;
                    TextStore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(TextStore.Text);
                    TextResulta.Text = TextResulta.Text + TextStore.Text + "=" + ans;
                    TextStore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(TextStore.Text);
                    TextResulta.Text = TextResulta.Text + TextStore.Text + "=" + ans;
                    TextStore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(TextStore.Text);
                    TextResulta.Text = TextResulta.Text + TextStore.Text + "=" + ans;
                    TextStore.Text = ans.ToString();
                    break;

                case 5:
                    ans = num % float.Parse(TextStore.Text);
                    TextResulta.Text = TextResulta.Text + TextStore.Text + "=" + ans;
                    TextStore.Text = ans.ToString();
                    break;
            }
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            if ((TextStore.Text != ""))
            {
                num = float.Parse(TextStore.Text);
                TextResulta.Text = TextStore.Text + "%";
                TextStore.Clear();
                count = 5;
            }
        }
    }
}
