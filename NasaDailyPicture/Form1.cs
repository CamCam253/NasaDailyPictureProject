﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaDailyPicture
{
    public partial class Form1 : Form
    {
        //Variables:
        InformationLoader loader;

        public Form1()
        {
            InitializeComponent();
            loader = new InformationLoader();
        }

        //Button presses:
        private void todayBtn_Click(object sender, EventArgs e)
        {

        }

        private void yesterdayBtn_Click(object sender, EventArgs e)
        {

        }

        private void randomBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
