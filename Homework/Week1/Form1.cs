﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome!!!");
            lblWelcome.Text = "Welcome!";
        }
    }
}
