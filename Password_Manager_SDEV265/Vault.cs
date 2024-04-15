using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_SDEV265
{
    /// <summary>
    /// The Vault class is responsible for managing the user's credentials and providing secure access to the vault (will work as our "database"?).
    /// It stores the user's information and a list of platform credentials, and provides methods for authentication,
    /// credential management, and encryption/decryption of the vault data.
    /// </summary>
    public class Vault
    {
        public User _user;
        private List<PlatformCredentialsV2> _credentials;

        /// <summary>
        /// Initializes a new instance of the Vault class with the provided username and master password.
        /// </summary>
        /// <param name="username">The user's username or email address.</param>
        /// <param name="masterPassword">The user's master password for securing the vault.</param>
        public Vault(string username, string masterPassword)
        {
            _user = new User(username, masterPassword);
            _credentials = new List<PlatformCredentialsV2>();
        }

        /// <summary>
        /// Authenticates the user by verifying the entered password against the stored master password.
        /// </summary>
        /// <param name="enteredPassword">The password entered by the user.</param>
        /// <returns>True if the entered password matches the stored master password, false otherwise.</returns>
        public bool AuthenticateUser(string enteredPassword)
        {
            return _user.VerifyMasterPassword(enteredPassword);
        }

        /// <summary>
        /// Adds a new platform credential to the vault.
        /// </summary>
        /// <param name="platform">The name of the platform or website.</param>
        /// <param name="password">The password for the platform.</param>
        /// <param name="notes">Optional notes or additional information related to the credential.</param>
        public void AddCredential(string platform, string password, string notes = null)
        {
            PlatformCredentialsV2 credential = new PlatformCredentialsV2(platform, password, notes);
            _credentials.Add(credential);
        }

        /// <summary>
        /// Retrieves the list of platform credentials stored in the vault.
        /// </summary>
        /// <returns>A list of PlatformCredentials objects.</returns>
        public List<PlatformCredentialsV2> GetCredentials()
        {
            return _credentials;
        }

        /// <summary>
        /// Changes the user's master password for securing the vault.
        /// </summary>
        /// <param name="newMasterPassword">The new master password.</param>
        public void ChangeUserMasterPassword(string newMasterPassword)
        {
            _user.HashMasterPassword(newMasterPassword);
        }

        /// <summary>
        /// Encrypts the credentials stored in the vault using the provided master password.
        /// </summary>
        /// <param name="masterPassword">The master password used for encryption.</param>
        /// <exception cref="Exception">Thrown when an invalid master password is provided.</exception>
        public void EncryptVault(string masterPassword)
        {
            if (_user.VerifyMasterPassword(masterPassword))
            {
                foreach (PlatformCredentialsV2 credential in _credentials)
                {
                    credential.EncryptPassword(credential.Password);
                }
            }
            else
            {
                throw new Exception("Invalid master password.");
            }
        }

        /// <summary>
        /// Decrypts the credentials stored in the vault using the provided master password.
        /// </summary>
        /// <param name="masterPassword">The master password used for decryption.</param>
        /// <exception cref="Exception">Thrown when an invalid master password is provided.</exception>
        public void DecryptVault(string masterPassword)
        {
            if (_user.VerifyMasterPassword(masterPassword))
            {
                foreach (PlatformCredentialsV2 credential in _credentials)
                {
                    string _ = credential.Password; // Trigger decryption without using the decrypted value
                }
            }
            else
            {
                throw new Exception("Invalid master password.");
            }
        }
    }
}