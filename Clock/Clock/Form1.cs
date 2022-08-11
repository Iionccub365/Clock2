using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            move.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ints for the time
            int s = DateTime.Now.Second;
            int m = DateTime.Now.Minute;
            int h = DateTime.Now.Hour;
            //ints for the day
            int d = DateTime.Now.DayOfYear;
            //int d = 364;
            //math for the time
            int secondOfDay = s + m * 60 + h * 3600;
            int hour = secondOfDay / 4320;
            int secondsAfterHour = secondOfDay - hour * 4320;
            int minute = secondsAfterHour / 216;
            int seconds = secondsAfterHour - minute * 216;
            hour++;
            minute++;
            seconds++;
            Console.WriteLine(hour);
            Console.WriteLine(secondsAfterHour);
            //maths for the day :D
            int month = d / 30;
            int day = d - month * 30 + 1;
            month++;

            //Texts
            //label1.Text = $"😁 {h}:{m}:{s}";
            label1.Text = $"{hour:D2}:{minute:D2}:{seconds:D3}";
            if (d == 365)
            {
                label2.Text = "January, 1";
            }
            if (month == 1)
            {
                label2.Text = $"January, {day}";
            }
            if (month == 2)
            {
                label2.Text = $"Febuary, {day}";
            }
            if (month == 3)
            {
                label2.Text = $"Marchuary, {day}";
            }
            if (month == 4)
            {
                label2.Text = $"Apuary, {day}";
            }
            if (month == 5)
            {
                label2.Text = $"Jmay, {day}";
            }
            if (month == 6)
            {
                label2.Text = $"June, {day}";
            }
            if (month == 7)
            {
                label2.Text = $"July, {day}";
            }
            if (month == 8)
            {
                label2.Text = $"Jaugust, {day}";
            }
            if (month == 9)
            {
                label2.Text = $"September, {day}";
            }
            if (month == 10)
            {
                label2.Text = $"October, {day}";
            }
            if (month == 11)
            {
                label2.Text = $"November, {day}";
            }
            if (month == 12)
            {
                label2.Text = $"December, {day}";
            }
            if (month == 13)
            {
                label2.Text = $"Bonus Weekend, {day}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void drag(object sender, MouseEventArgs e)
        {
            var t = new Form1();
            if (e.Button == MouseButtons.Left)
            {
                t.Top = e.Y;
                t.Left = e.X;
            }
        }
        private void move_Tick(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
