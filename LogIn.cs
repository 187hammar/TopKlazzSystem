﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopKlassSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            this.Hide();
            hf.ShowDialog();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
