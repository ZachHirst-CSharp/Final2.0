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

        public Form1()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            balance++;
            lblNumber.Text = "" + balance;

            if(balance > 9)
            {
                pictureBox3.Visible = false;
                balance = (1 * .5) + balance;
            }
        }
    }
}
