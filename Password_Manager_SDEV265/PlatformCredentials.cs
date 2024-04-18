using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

/*
 *  THIS IS AN OBSOLETE CLASS, WHICH HAS BEEN REPLACED BY THE PlatformCredentialsV2 CLASS. AFTER TEAM ALIGNMENT, THIS CLASS WILL BE REMOVED OR SIMPLE NOT USED
*/

namespace Password_Manager_SDEV265
{
    /// <summary>
    /// Represents a platform credential with its associated password and notes.
    /// The password is stored in an encrypted format.
    /// </summary>
    public class PlatformCredentials
    {
        private string _platform;
        private byte[] _encryptedPassword;
        private string _notes;
        private string _encryptedKey;
        private string _encryptedIV;

        /// <summary>
        /// Initializes a new instance of the PlatformCredentials class with the provided platform, password, and optional notes.
        /// </summary>
        /// <param name="platform">The name of the platform or website.</param>
        /// <param name="password">The password for the platform.</param>
        /// <param name="notes">Optional notes or additional information related to the credential.</param>
        public PlatformCredentials(string platform, string password, string notes = null)
        {
            _platform = platform;
            _notes = notes;
            EncryptPassword(password);
        }

        /// <summary>
        /// Gets the name of the platform or website.
        /// </summary>
        public string Platform => _platform;

        /// <summary>
        /// Gets the password for the platform in decrypted format.
        /// </summary>
        public string Password
        {
            get
            {
                try
                {
                    return DecryptPassword();
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately, e.g., log the error
                    Console.WriteLine($"Error decrypting password: {ex.Message}");
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets or sets the notes or additional information related to the credential.
        /// </summary>
        public string Notes
        {
            get => _notes;
            set => _notes = value;
        }

        /// <summary>
        /// Encrypts the provided password using AES encryption and stores the encrypted value.
        /// </summary>
        /// <param name="password">The password to be encrypted.</param>
        public void EncryptPassword(string password)
        {
            // Generate a secure key and IV (Initialization Vector)
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 256; // Recommended key size
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(password);
                        }
                    }
                    _encryptedPassword = msEncrypt.ToArray();
                }

                // Store the key and IV in encrypted form using DPAPI
                _encryptedKey = Convert.ToBase64String(ProtectedData.Protect(aesAlg.Key, null, DataProtectionScope.CurrentUser));
                _encryptedIV = Convert.ToBase64String(ProtectedData.Protect(aesAlg.IV, null, DataProtectionScope.CurrentUser));
            }
        }

        /// <summary>
        /// Decrypts the stored encrypted password using AES decryption and returns the decrypted password.
        /// </summary>
        /// <returns>The decrypted password.</returns>
        public string DecryptPassword()
        {
            // Retrieve the key and IV from secure storage (DPAPI)
            byte[] key = ProtectedData.Unprotect(Convert.FromBase64String(_encryptedKey), null, DataProtectionScope.CurrentUser);
            byte[] iv = ProtectedData.Unprotect(Convert.FromBase64String(_encryptedIV), null, DataProtectionScope.CurrentUser);

            // Decrypt the password using the retrieved key and IV
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.KeySize = 256; // Recommended key size
                aesAlg.Key = key;
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(_encryptedPassword))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}