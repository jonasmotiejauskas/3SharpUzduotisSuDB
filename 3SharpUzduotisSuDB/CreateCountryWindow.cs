﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3SharpUzduotisSuDB
{
    public partial class CreateCountryWindow : Form
    {

        DatabaseInterface dbInter;

        public CreateCountryWindow()
        {
            InitializeComponent();
            dbInter = DatabaseInterface.Instance;
        }

        private void createCountryButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cancelCreateCountryButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}