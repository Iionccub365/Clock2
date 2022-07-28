using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ints
            int s = DateTime.Now.Second;
            int m = DateTime.Now.Minute;
            int h = DateTime.Now.Hour;
            //math
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


            //actual part that has meaning in life 😁
            //label1.Text = $"😁 {h}:{m}:{s}";
            label1.Text = $"{hour:D2}:{minute:D2}:{seconds:D3}";
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
