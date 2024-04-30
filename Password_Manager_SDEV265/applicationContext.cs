/*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// Author: Lucas Germinari Carreira
// Last modified: 04/22/2024
// Description(class implementation file): Class that keeps track of the current user and the vault, making those objects accessible throughout the application.
    It also keeps a dictionary of platform credentials to map platform names to PlatformCredentialsV2 objects.
// Notes: 
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_SDEV265
{
    public static class ApplicationContext
    {
        private static User _currentUser;
        private static Vault _vault;
        private static Dictionary<string, PlatformCredentialsV2> platformCredentialsMap = new Dictionary<string, PlatformCredentialsV2>();
        private static PlatformCredentialsV2 _selectedCredential;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static Vault Vault
        {
            get { return _vault; }
            set { _vault = value; }
        }

        public static Dictionary<string, PlatformCredentialsV2> PlatformCredentialsMap
        {
            get { return platformCredentialsMap; }
            set { platformCredentialsMap = value; }
        }
        public static PlatformCredentialsV2 SelectedCredential
        {
            get { return _selectedCredential; }
            set { _selectedCredential = value; }
        }
    }
}
