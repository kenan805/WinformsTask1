using HomeworkWindowsFormsApp1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentTwoClockCity
{
    public partial class Form1 : Form
    {
        public bool IsCityChoise { get; set; }
        public Timer Timer { get; set; }
        public Form1()
        {
            InitializeComponent();
            Text = "City clock";
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsCityChoise)
                Lbl2.Text = DateTime.Now.AddHours(-3).ToString();
            else
                Lbl2.Text = DateTime.Now.ToString();
        }

        private void Btn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackgroundImage = Resources.cR9GJe;
                IsCityChoise = false;
            }
        }

        private void Btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackgroundImage = Resources.london_800x600_1;
                IsCityChoise = true;
            }
        }
    }
}
