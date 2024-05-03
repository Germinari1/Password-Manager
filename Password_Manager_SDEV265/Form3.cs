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
    public partial class Form3 : Form
    {
        //instance of form4, later used to transition between the forms
        private Form4 _form4;
        
        private void Lstb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Method that retrieves a PlatformCredentials from the PlatformCredentialsMap and assings it to the _selectedCredential field of the ApplicationContext class.
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
            if (lstb1.SelectedItem != null)
            {
                string platformLabelStdState = "Selected Platform: ";
                
                string selectedPlatform = lstb1.SelectedItem.ToString();
                if (ApplicationContext.PlatformCredentialsMap.TryGetValue(selectedPlatform, out PlatformCredentialsV2 credential))
                {
                    //update selected credential on application context
                    ApplicationContext.SelectedCredential = credential;
                    
                    //reset platform label text to its standard state
                    selectedPlatformLabel.Text = platformLabelStdState;

                    //update platform label with selected credential
                    selectedPlatformLabel.Text += credential.Platform;
                }
                else
                {
                    ApplicationContext.SelectedCredential = null;
                }
            }
            else
            {
                ApplicationContext.SelectedCredential = null;
            }
        }

        public Form3()
        {
            InitializeComponent();
            
            //subscribe the text box to the Lstb1_SelectedIndexChanged event handler. This is triggered en the user selects an item in the listbox.
            lstb1.SelectedIndexChanged += Lstb1_SelectedIndexChanged;

            //populate listbox with platform names
            foreach (string platform in ApplicationContext.PlatformCredentialsMap.Keys)
            {
                lstb1.Items.Add(platform);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //generate random password and display to user
            string randomPsw = PlatformCredentialsV2.GeneratePassword();
            txb6.Text = randomPsw;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Adds a new credential to the vault and updates the listbox
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
            //create and store new credential if platform and password field are not empty
            if (txb3.Text.Length != 0 && txb4.Text.Length != 0) {

                //check if platform name already exists, add credential if checking returns false
                if (!ApplicationContext.Vault.CredentialExists(txb3.Text)) { 
                    //add credential to vault
                    ApplicationContext.Vault.AddCredential(txb3.Text, txb4.Text, txb5.Text);
                    //add credential to PlatformCredentialsMap
                    ApplicationContext.PlatformCredentialsMap.Add(txb3.Text, new PlatformCredentialsV2(txb3.Text, txb4.Text, txb5.Text));

                    //add credential to listbox
                    lstb1.Items.Add(txb3.Text);
                    txb3.Text = "";
                    txb4.Text = "";
                    txb5.Text = "";

                    //update datagridview
                    //dgv3.DataSource = ApplicationContext.Vault._credentials;
                }
                else //if not possible to add credentials to list, display error message
                {
                    platformNameValidationLabel.Visible = true;
                    platformNameValidationLabel.Text = "Platform names should be unique.";
                }
            }
        }

        private void displayCredentials_Click(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Takes user to form 4, where they will be prompted for authentication.
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
            if(_form4 == null)
            {
                _form4 = new Form4();
            }
            _form4.Show();
            this.Hide();
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            // Exits/closes the application
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
            Application.Exit();
        }
    }
}
