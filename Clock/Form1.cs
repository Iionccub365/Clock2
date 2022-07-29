using System;
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
            //Current time
            int s = DateTime.Now.Second;
            int m = DateTime.Now.Minute;
            int h = DateTime.Now.Hour;

            //Math
            int secondOfDay = s + m * 60 + h * 3600;
            int hour = secondOfDay / 4320;
            int secondsAfterHour = secondOfDay - hour * 4320;
            int minute = secondsAfterHour / 216;
            int seconds = secondsAfterHour - minute * 216;

            //All times are 1 (not zero) based
            hour++;
            minute++;
            seconds++;

            //Actual part that has meaning in life 😁
            timeLabel.Text = $"{hour:D2}:{minute:D2}:{seconds:D3}";
            dateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
