/*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// Author: Lucas Germinari Carreira
// Last modified: 04/16/2024
// Description(backend implementation file): Implements the backend logic of Form1, the login form.
// Notes: 
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
using System;
using System.Windows.Forms;

namespace Password_Manager_SDEV265
{
    public partial class Form1 : Form
    {
        private Form3 _form3;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Get user credentials from login form
            string username = txb1.Text;
            string password = txb2.Text;

            // Create a new User instance
            User user = new User(username, password);

            // Authenticate the user
            if (user.VerifyMasterPassword(password))
            {
                //create vault for user
                Vault vault = new Vault(username, password);

                // Authentication successful
                ApplicationContext.CurrentUser = user;
                ApplicationContext.Vault = vault;
                MessageBox.Show("Login successful!");

                // Show Form3
                if (_form3 == null)
                {
                    _form3 = new Form3();
                }

                _form3.Show();
                this.Hide(); // Hide the login form (Form1)
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
