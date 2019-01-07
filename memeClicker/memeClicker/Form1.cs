using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace memeClicker
{
    public partial class Form1 : Form
    {
        
        public double balance = 0;
        public int tick1 = 0;
        public double upgradestrength = 0;

        public Form1()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            balance++;
            lblNumber.Text = "" + balance;
            balance = (1 * (tick1 * upgradestrength)) + balance;
            lblmultiplier.Text = "Multiplier = " + upgradestrength;

            if (balance > 9 && balance < 25)
            {
                pictureBox3.Visible = false;
                meme1.Visible = true;
            }
            else if(balance >= 25)
            {
                pictureBox4.Visible = false;
                meme2.Visible = true;
            }
        }

        private void meme1_Click(object sender, EventArgs e)
        {
           if(balance < 10)
            {

            }
           else if(balance >= 10)
            {
                upgradestrength += .1;
                ++tick1;
                balance -= 10;
                lblNumber.Text = "" + balance;
            }
        }

        private void meme2_Click(object sender, EventArgs e)
        {
            if(balance < 100)
            {

            }
            else if(balance >= 100)
            {
                upgradestrength += .8;
                balance -= 75;
                lblNumber.Text = "" + balance;
            }
        } //relook at the tick counter
    }
}
