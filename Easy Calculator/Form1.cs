//Basic Calculator
//============================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Easy_Calculator
{
    public partial class Form1 : Form
    {
        
        double var1,temp=0.0,mul=1.0,sub=0.0;
        int status=0;
        double div=1.0;
        public Form1()
        {
            InitializeComponent();
        }

       /* private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1 .Text .Length -1);
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            var1 = double.Parse (textBox1.Text );
            enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            var1 = double.Parse (textBox1 .Text );
            enable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            var1 = double.Parse (textBox1.Text);
            enable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            var1 = double.Parse (textBox1.Text);
            enable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            var1 =double.Parse ( textBox1.Text);
            enable();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            var1 = double.Parse(textBox1.Text);
            enable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            var1 = double.Parse(textBox1.Text);
            enable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            var1 =double.Parse ( textBox1.Text);
            enable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            var1 = double.Parse(textBox1.Text);
            enable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            var1 = double.Parse (textBox1.Text);
            enable();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            if (textBox1.Text == ".")
            {

            }
            else
            {
                var1 = double.Parse(textBox1.Text);
            }
            enable();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
            }
            else
            {
                var1 *= -1;
                textBox1.Text = var1.ToString();
            }
            enable();
        }

        //addition
        //========================================================
        private void button12_Click(object sender, EventArgs e)
        {

           
                if (status == 3)
                {
                    mul *= var1;
                    temp = mul;
                    div = mul;
                    sub = mul;
                    textBox1.Text = "";
                    textBox2.Text = mul.ToString();
                }
                else if (status == 4)
                {
                    if (var1 == 0)
                    {
                        textBox2.Text = "Can't devide by zero!!";
                    }
                    else
                    {
                        if (status == 0)
                            div = var1 / div;
                        else
                        
                            div /= var1;
                            temp = div;
                            mul = div;
                            sub = div;
                            textBox1.Text = "";
                            textBox2.Text = div.ToString();
                        
                    }
                }
                else if (status == 2)
                {
                    if (status == 0)
                        sub = var1 - sub;
                    else
                        sub = sub - var1;
                    temp = sub;
                    mul = sub;
                    div = sub;
                    textBox1.Text = "";
                    textBox2.Text = sub.ToString();
                }
                else
                {
                    temp += var1;
                    textBox1.Text = "";
                    textBox2.Text = temp.ToString();
                }
                status = 1;
                disable();
                
                
              
            }
        
        //substraction
        //================================================================
        private void button13_Click(object sender, EventArgs e)
        {
            if (status == 3)
            {
                mul *= var1;
                temp = mul;
                div = mul;
                sub = mul;
                textBox1.Text = "";
                textBox2.Text = mul.ToString();
            }
            else if (status == 4)
            {
                if (var1 == 0)
                {
                    textBox2.Text = "Can't devide by zero!!";
                }
                else
                {
                    if (status == 0)
                        div = var1 / div;
                    else

                        div /= var1;
                    temp = div;
                    mul = div;
                    sub = div;
                    textBox1.Text = "";
                    textBox2.Text = div.ToString();

                }
            }
            else if (status == 1)
            {
                temp += var1;
                mul = temp;
                div = temp;
                sub = temp;
                textBox1.Text = "";
                textBox2.Text = temp.ToString();
            }
            else
            {
                if (status == 0)
                    sub = var1 - sub;
                else
                    sub = sub - var1;
                textBox1.Text = "";
                textBox2.Text = sub.ToString();
            }
            status = 2;
            disable();
        }
        //multiplication
        //================================================================
        private void button14_Click(object sender, EventArgs e)
        {
            
                if (status == 1)
                {

                    temp += var1;
                    mul = temp;
                    div = temp;
                    sub = temp;
                    textBox1.Text = "";
                    textBox2.Text = temp.ToString();
                }
                else if (status == 2)
                {
                    if (status == 0)
                        sub = var1 - sub;
                    else
                        sub = sub - var1;
                    temp = sub;
                    mul = sub;
                    div = sub;
                    textBox1.Text = "";
                    textBox2.Text = sub.ToString();
                }
                else if(status==4)
                {
                    if (status == 0)
                        div = var1 / div;
                    else
                    div /= var1;
                    mul = div;
                    temp = div;
                    sub = div;
                    textBox1.Text = "";
                    textBox2.Text = div.ToString();
                }
                else
                {
                    
                        mul *= var1;
                        textBox1.Text = "";
                        textBox2.Text = mul.ToString();
                    
                }
                status = 3;
                disable();
            }
        
        //Division
        //==============================================================
        private void button15_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {

                temp += var1;
                mul = temp;
                div = temp;
                sub = temp;
                textBox1.Text = "";
                textBox2.Text = temp.ToString();
            }
            else if (status == 2)
            {
                if (status == 0)
                    sub = var1 - sub;
                else
                    sub = sub - var1;
                temp = sub;
                mul = sub;
                div = sub;
                textBox1.Text = "";
                textBox2.Text = sub.ToString();
            }
            else if(status== 3)
            {
                mul *= var1;
                temp = mul;
                div = mul;
                sub = mul;
                textBox1.Text = "";
                textBox2.Text = mul.ToString();
            }
            else
            {
                    if (status == 0)
                    {
                        if(var1==0)
                        div = var1 / div;
                        else
                            div = var1 / div;
                    }
                    else
                    {
                        if (var1 == 0)
                            textBox2.Text = "can't devide by zero";
                        else
                        div /= var1;
                    }
                    textBox1 .Text = "";
                    textBox2.Text = div.ToString();
               }
            status = 4;
            disable();
        }
        //Equal
        //=======================================================

        private void button16_Click(object sender, EventArgs e)
        {
            calculate ();
        }
        //clear
        //========================================================
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            temp = 0.0;
            status = 0;
            mul = 1.0;
            div = 1.0;
            sub = 0.0;
            enable();
        }
        void calculate()
        {
            switch (status)
            {
                case 1:
                    if (textBox1.Text == "")
                    {
                    }
                    else
                    {
                        temp += var1;
                        textBox2.Text =temp.ToString();
                        textBox1.Text = "";
                        //disable();
                        var1 = 0;
                        
                    }
                    break;
                case 2:
                    if (textBox1.Text == "")
                    {
                    }
                    else
                    {
                        
                        sub = sub - var1;
                        textBox2.Text = sub.ToString();
                        textBox1.Text = "";
                        //disable();
                        var1 = 0;
                       
                    }
                    break;
                case 3:
                    if (textBox1.Text == "")
                    {
                    }
                    else
                    {
                        mul = mul * var1;
                        textBox2.Text = mul.ToString();
                        textBox1.Text = "";
                        var1 = 1;
                    }
                    break;
                case 4:
                    if (textBox1.Text == "")
                    {
                    }
                    else
                    {
                        if (var1 == 0)
                            textBox2.Text = "Can't devide by zero";
                        else
                        {
                            div /= var1;
                            textBox2.Text = div.ToString();
                            textBox1.Text = "";
                            var1 = 1;
                        }
                    }
                    break;
            }
        }
        void enable()
        {
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }
        void disable()
        {
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }
    }
}
