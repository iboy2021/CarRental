﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Form2 : Form
    {
        //This is the constructor
        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmSetReturn_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
