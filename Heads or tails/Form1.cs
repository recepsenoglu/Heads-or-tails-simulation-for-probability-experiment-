using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_tails   //    This program written by Recep Oğuzhan Şenoğlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            flips = 0;
            heads = 0;
            tails = 0;
            headsseries = 0;
            tailsseries = 0;
            lblflips.Text = flips.ToString();
            lblheads.Text = heads.ToString();
            lbltails.Text = tails.ToString();
            lblheadsseries.Text = "0";
            lbltailsseries.Text = "0";
            lblmostdistance.Text = "0";
        }
        int number;
        int flips = 0;
        int distance = 0;
        int heads = 0;
        int tails = 0;
        int headsseries = 0;
        int tailsseries = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            number = flipthecoin();
            if(number == 0)
            {
                heads++;
                headsseries++;
                tailsseries = 0;
            }
            else if(number == 1)
            {
                tails++;
                tailsseries++;
                headsseries = 0;
            }
            distance = Math.Abs(heads - tails);
            lblflips.Text = flips.ToString();
            lblheads.Text = heads.ToString();
            lbltails.Text = tails.ToString();
            if (headsseries > int.Parse(lblheadsseries.Text)) lblheadsseries.Text = headsseries.ToString();
            if (tailsseries > int.Parse(lbltailsseries.Text)) lbltailsseries.Text = tailsseries.ToString();
            if (distance > int.Parse(lblmostdistance.Text)) lblmostdistance.Text = distance.ToString();
        }
        int flipthecoin()
        {
            flips++;
            int randomnumber;
            Random random = new Random();
            randomnumber = random.Next(0, 2);
            return randomnumber;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnstart.Enabled = false;
            btnstop.Enabled = true;
            btnflip.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnstop.Enabled = false;
            btnstart.Enabled = true;
            btnflip.Enabled = true;
        }

        private void btnflip_Click(object sender, EventArgs e)
        {
            number = flipthecoin();
            if (number == 0)
            {
                heads++;
                headsseries++;
                tailsseries = 0;
            }
            else if (number == 1)
            {
                tails++;
                tailsseries++;
                headsseries = 0;
            }
            distance = Math.Abs(heads - tails);
            lblflips.Text = flips.ToString();
            lblheads.Text = heads.ToString();
            lbltails.Text = tails.ToString();
            if (headsseries > int.Parse(lblheadsseries.Text)) lblheadsseries.Text = headsseries.ToString();
            if (tailsseries > int.Parse(lbltailsseries.Text)) lbltailsseries.Text = tailsseries.ToString();
            if (distance > int.Parse(lblmostdistance.Text)) lblmostdistance.Text = distance.ToString();
        }

        private void btnslower_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 1) timer1.Interval /= 10;
            if (timer1.Interval == 1) btnslower.Enabled = false;
            if (timer1.Interval < 1000) btnfaster.Enabled = true;
            if(timer1.Interval == 1)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            if(timer1.Interval == 10)
            {
                label5.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            if(timer1.Interval == 100)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void btnfaster_Click(object sender, EventArgs e)
        {
            if (timer1.Interval < 1000 ) timer1.Interval *= 10;
            if (timer1.Interval == 1000 ) btnfaster.Enabled = false;
            if (timer1.Interval > 1) btnslower.Enabled = true;

            if (timer1.Interval == 1000)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = true;
            }
            if (timer1.Interval == 100)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
                label8.Visible = true;
            }
            if (timer1.Interval == 10)
            {
                label5.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }
    }
}
