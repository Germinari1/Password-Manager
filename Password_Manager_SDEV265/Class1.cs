using System;
using System.Security.Cryptography;
using System.Text;

namespace Password_Manager_SDEV265
{
    /// <summary>
    /// Represents a user of the password manager application.
    /// </summary>
    public class User
    {
        private PlatformCredentials _masterCredentials;

        /// <summary>
        /// Initializes a new instance of the User class with the provided username and master password.
        /// </summary>
        /// <param name="username">The user's username or email address.</param>
        /// <param name="masterPassword">The user's master password for securing the vault.</param>
        public User(string username, string masterPassword)
        {
            // Hash and salt the master password
            byte[] salt = GenerateSalt();
            byte[] hashedPassword = HashPassword(masterPassword, salt);

            _masterCredentials = new PlatformCredentials(username, Convert.ToBase64String(hashedPassword), Convert.ToBase64String(salt));
        }

        /// <summary>
        /// Verifies the entered password against the stored hashed and salted master password.
        /// </summary>
        /// <param name="enteredPassword">The password entered by the user.</param>
        /// <returns>True if the entered password matches the stored master password, false otherwise.</returns>
        public bool VerifyMasterPassword(string enteredPassword)
        {
            byte[] salt = Convert.FromBase64String(_masterCredentials.Notes);
            byte[] hashedPassword = HashPassword(enteredPassword, salt);

            return Convert.ToBase64String(hashedPassword) == _masterCredentials.Password;
        }

        /// <summary>
        /// Hashes the master password using the provided salt and returns the hashed value.
        /// </summary>
        /// <param name="masterPassword">The master password to be hashed.</param>
        /// <param name="salt">The salt value used for hashing.</param>
        /// <returns>The hashed password.</returns>
        private byte[] HashPassword(string masterPassword, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(masterPassword, salt, iterations: 10000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32); // Get a 32-byte (256-bit) hash
            }
        }

        /// <summary>
        /// Generates a random salt value for hashing.
        /// </summary>
        /// <returns>The generated salt value.</returns>
        private byte[] GenerateSalt()
        {
            using (var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                var saltBytes = new byte[16]; // 16 bytes (128 bits) is a reasonable salt length
                randomNumberGenerator.GetBytes(saltBytes);
                return saltBytes;
            }
        }

        /// <summary>
        /// Changes the user's master password by hashing and salting the new password.
        /// </summary>
        /// <param name="newMasterPassword">The new master password.</param>
        public void HashMasterPassword(string newMasterPassword)
        {
            byte[] salt = GenerateSalt();
            byte[] hashedPassword = HashPassword(newMasterPassword, salt);

            _masterCredentials.EncryptPassword(Convert.ToBase64String(hashedPassword));
            _masterCredentials.Notes = Convert.ToBase64String(salt);
        }
    }
}