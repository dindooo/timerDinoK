﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerDinoK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrSad.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        
    }
}
