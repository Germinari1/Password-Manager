﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_SDEV265
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string randomPsw = PlatformCredentialsV2.GeneratePassword();
            txb6.Text = randomPsw;
        }
    }
}
