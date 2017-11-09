﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameTracker
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ScoreEntry();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void linkToStatsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ViewStats();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
    }
}
