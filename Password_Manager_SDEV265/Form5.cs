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
    }
}
