using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memeClicker
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); //shows main game form 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) // opens secret buttons for secret memes
        {
            hdnbtn1.Visible = true; //secret meme buttons
            hdnbtn2.Visible = true;
            hdnbtn3.Visible = true;
            hdnbtn4.Visible = true;
            hdnbtn5.Visible = true;
        }

        private void hdnbtn1_Click(object sender, EventArgs e) // shows hidden meme that probably isnt school appropriate lol
        {
            hidden1.Visible = true;
        }

        private void hdnbtn2_Click(object sender, EventArgs e)  // shows different hidden meme that probably isnt school appropriate 
        {
            hidden2.Visible = true;
        }

        private void hdnbtn3_Click(object sender, EventArgs e) // shows different hidden meme that probably isnt school appropriate 
        {
            hidden3.Visible = true;
        }

        private void hdnbtn4_Click(object sender, EventArgs e) // shows different hidden meme that probably isnt school appropriate 
        {
            hidden4.Visible = true;
        }

        private void hdnbtn5_Click(object sender, EventArgs e) // shows different hidden meme that probably isnt school appropriate 
        {
            hidden5.Visible = true;
        }
    }
}
