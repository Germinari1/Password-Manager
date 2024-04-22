using System;
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
    public partial class Form4 : Form
    {
        private Form5 _form5;
        public Form4()
        {
            InitializeComponent();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txb7.Text == ApplicationContext.CurrentUser._masterCredentials.Platform && ApplicationContext.CurrentUser.VerifyMasterPassword(txb8.Text))
            {
                // Authentication successful

                // Show Form5
                if (_form5 == null)
                {
                    _form5 = new Form5();
                }

                _form5.Show();
                this.Hide(); // Hide the current form (Form4)
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
