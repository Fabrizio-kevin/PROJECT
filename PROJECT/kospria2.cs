﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class kospria2 : Form
    {
        public kospria2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KosPria kospria = new KosPria();
            kospria.Show();
            this.Hide();
        }
    }
}
