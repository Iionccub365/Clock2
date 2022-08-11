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
        private Clock _clock = new Clock();
        
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
            _clock.UpdateClock();

            label1.Text = $"{_clock.Hours:D2}:{_clock.Minutes:D2}:{_clock.Seconds:D3}";
            label2.Text = $"{_clock.MonthLabel}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
