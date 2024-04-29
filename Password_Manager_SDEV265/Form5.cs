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
    public partial class Form5 : Form
    {
        //private Form3 _form3;
        public Form5()
        {
            InitializeComponent();
            //update text boxes when form loads
            platformLabel_.Text = ApplicationContext.SelectedCredential.Platform;
            passwordLabel_.Text = ApplicationContext.SelectedCredential.Password;
            descriptionLabel_.Text = ApplicationContext.SelectedCredential.Notes;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Saves changes made to the credential
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/

            //create a new PlatformCredentials with the updated info
            PlatformCredentialsV2 updatedCredential = new PlatformCredentialsV2(platformLabel_.Text, passwordLabel_.Text, descriptionLabel_.Text);

            //update the Vault (and update the PlatformCredentialsMap and selected credential if succeeds)
            if (ApplicationContext.Vault.UpdateCredential(ApplicationContext.SelectedCredential.Platform, updatedCredential))
            {
                // Get the old key
                string oldKey = ApplicationContext.SelectedCredential.Platform;

                // Get the new key
                string newKey = platformLabel_.Text;

                // Remove the old key-value pair
                ApplicationContext.PlatformCredentialsMap.Remove(oldKey);

                // Add the new key-value pair
                ApplicationContext.PlatformCredentialsMap.Add(newKey, updatedCredential);

                //update the selected credential in the ApplicationContext
                ApplicationContext.SelectedCredential = updatedCredential;
            }

            //tempDebug.Text = ApplicationContext.Vault.UpdateCredential(platformLabel_.Text, updatedCredential).ToString();
        }

        private void returnMainMenu_Click(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Returns to the main menu (Form3)
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
            
            // Show Form3
            new Form3().Show();

            // Hide the current form (Form5)
            this.Hide();
        }
    }
}
