using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Ch8_Program2
{
    public partial class Form1 : Form
    {
        public Random Num = new Random();
        public int randNum;
        public int UserInput;
        public int R = 25;
        public int G = 144;
        public int B = 2;
        public int length;
        
        
        

        public Form1()
        {
            InitializeComponent();
            
            
            BackColor = Color.FromArgb(R, G, B);

            //BackColor = ChangeColor();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //label2.Visible = false;
            UserInput = Convert.ToInt32(textBox1.Text);
            randNum = 7;// Num.Next(1, 101);
            if (UserInput == randNum)
            {
                R = 0; G = 255; B = 0;
                label2.Text = "CORRECT! YOU GOT IT!!!";
                label2.Visible = true;
                for (int i = 0; i < 3; i++)
                {
                    R += 50; B += 50; G -= 50;
                    BackColor = Color.FromArgb(R, G, B);
                    
                    Thread.Sleep(105);
                }
                
                Thread.Sleep(100);
                
                                               
            }
            if(UserInput > randNum)
            {
                R = 255;
                G = 0;
                B = 0;
                length = (UserInput - randNum);
                label2.Text = "Lower...";
                label2.Visible = true;
                for (int i = 0; i < length; i++)
                {
                    R = (int)(R - 1.5);
                }
                
                

            }
            if(UserInput < randNum)
            {
                R = 0;
                G = 0;
                B = 255;
                length = (UserInput - randNum);
                label2.Text = "Higher...";
                label2.Visible = true;
                for (int i = 0; i < length; i++)
                {
                    B = (int)(B-1.5);
                }
                BackColor = Color.FromArgb(R, G, B);
                

            }
            bool goOn = false, flag = true;
            int timer = 0;
            while(flag)
            {
                Thread.Sleep(10);
                timer++;
                if (timer > 100)
                {
                    goOn = true; flag = false;
                }
            }           
            label2_Click(goOn, e);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2.Visible = true;
            Thread.Sleep(5000);
            //label2.ResetText();
            bool goOn = false, flag = true;
            int timer = 0;
            while (flag)
            {
                Thread.Sleep(1);
                timer++;
                if (timer > 10)
                {
                    goOn = true; flag = false;
                }
            }
            label3_Click(goOn, e);


        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            label2.BackColor = Color.DarkSlateBlue;
        }

        private void Form1_Paint(object senderer, PaintEventArgs e)
        {

            BackColor = Color.FromArgb(R, G, B);
        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {
            button1.BackColor = Color.Azure;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = true;
            label3.Text = ("It was: " + randNum);
            bool goOn = false, flag = true;
            int timer = 0;
            while (flag)
            {
                Thread.Sleep(10);
                timer++;
                if (timer > 10)
                {
                }
            }
            
        }
    }
}
