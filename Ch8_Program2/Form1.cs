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
        public int R = 255;
        public int G = 51;
        public int B = 204;
        public int length;
        public int guessNum = 0;
        
        

        public Form1()
        {
            //button1_Click(textBox1.Multiline, e);
            InitializeComponent();
            Application.Exit();
            randNum = Num.Next(1, 101);
            BackColor = Color.FromArgb(R, G, B);

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            string CheckUserInput = textBox1.Text;
            bool goOn = false; bool emptyOrNull = String.IsNullOrEmpty(CheckUserInput);
            if (emptyOrNull)
            {
                label4.Text = "PLEASE ENTER A NUMBER BEFORE PRESSING ENTER!!!";
                label4.Visible = true;

            }
            else
            {
                
                guessNum++;
                UserInput = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                if (UserInput == randNum)
                {
                    R = 0; G = 255; B = 0;
                    label2.ResetText();
                    label2.Text = "CORRECT! YOU GOT IT!!!";
                    label2.Visible = true;
                    for (int i = 0; i < 3; i++)
                    {
                        R += 50; B += 50; G -= 50;
                        BackColor = Color.FromArgb(R, G, B);

                        Thread.Sleep(105);
                    }
                    R = 0; G = 255; B = 0;
                    BackColor = Color.FromArgb(R, G, B);
                    Thread.Sleep(1000);
                    goOn = true;
                    label2_Click(goOn, e);

                }
                if (UserInput > randNum)
                {
                    R = 255;
                    G = 0;
                    B = 0;
                    length = (UserInput - randNum);
                    label2.ResetText();
                    label2.Text = "Lower...";
                    label2.Visible = true;
                    for (int i = 0; i < length; i++)
                    {
                        R = (int)(R - 1.5);
                    }
                    BackColor = Color.FromArgb(R, G, B);
                    //Thread.Sleep(500);


                }
                if (UserInput < randNum)
                {
                    R = 0;
                    G = 0;
                    B = 255;
                    length = (UserInput - randNum);
                    label2.ResetText();
                    label2.Text = "Higher...";
                    label2.Visible = true;
                    for (int i = 0; i < length; i++)
                    {
                        B = (int)(B - 1.5);
                    }
                    BackColor = Color.FromArgb(R, G, B);
                    Thread.Sleep(100);

                }

                Thread.Sleep(500);
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Thread.Sleep(100);
            //label2.ResetText();
            bool goOn = false;
            Thread.Sleep(100); goOn = true;
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
            //label2.Visible = false;
            label3.Text = ("Nice Job! It was: " + randNum);
            label4.Text = ("It took you " + guessNum + "guess!");
            label3.Visible = true; //label4.Visible = true;
            //Exit
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
