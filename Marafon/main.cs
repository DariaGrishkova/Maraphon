﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marafon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckRunner CheckRunner = new CheckRunner();
            CheckRunner.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sponsor Sponsor = new Sponsor();
            Sponsor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            More More = new More();
            More.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();

        }

        private void time_Click(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2021 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " + time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2021  6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " + time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}