using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClockProject
{
    public partial class Form1 : Form
    {
        Clock clock;
        int adjustCount = 0;
        public Form1()
        {
            var now = DateTime.Now;
            InitializeComponent();
            timer1.Start();
            clock = new Clock(now.Hour, now.Minute, now.Second);
            numHour.ReadOnly = true;
            numMinute.ReadOnly = true;
            numSecond.ReadOnly = true;
            UpdateScreen();
        }

        private void IncreaseTime(object sender, EventArgs e)
        {
            clock.IncreaseTimeByTimer();
            UpdateScreen();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            adjustCount++;
            if (adjustCount % 4 == 1)
            {
                timer1.Stop();
                numHour.ReadOnly = false;
                numMinute.ReadOnly = true;
                numSecond.ReadOnly = true;
            }
            else if (adjustCount % 4 == 2)
            {
                numHour.ReadOnly = true;
                numMinute.ReadOnly = false;
                numSecond.ReadOnly = true;
            }
            else if(adjustCount % 4 == 3)
            {
                numHour.ReadOnly = true;
                numMinute.ReadOnly = true;
                numSecond.ReadOnly = false;
            }
            else if(adjustCount % 4 == 0)
            {
                numHour.ReadOnly = true;
                numMinute.ReadOnly = true;
                numSecond.ReadOnly = true;
                timer1.Start();
                UpdateScreen();
            }
        }

        private void UpdateScreen()
        {
            numHour.Value = clock.Hour.Value;
            numMinute.Value = clock.Minute.Value;
            numSecond.Value = clock.Second.Value;
            this.Text = clock.GetTime();
        }

        private void numHour_ValueChanged(object sender, EventArgs e)
        {
            clock.ChangeHour((int)numHour.Value);
        }

        private void numMinute_ValueChanged(object sender, EventArgs e)
        {
            clock.ChangeMinute((int)numMinute.Value);
        }

        private void numSecond_ValueChanged(object sender, EventArgs e)
        {
            clock.ChangeSecond((int)numSecond.Value);
        }
    }
}
