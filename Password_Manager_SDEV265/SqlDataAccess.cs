/*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// Author: Lucas Germinari Carreira
// Last modified: 04/16/2024
// Description(class implementation file): Implemenets a class that works as a data access layer for the application, providing methods to load and save data to the database.
// Notes:   
    - The connection string is not working properly
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/

using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_SDEV265
{
    public class SqlDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static User LoadUser(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "SELECT * FROM Users WHERE username = @Username";
                var parameters = new { Username = username };
                var user = cnn.QuerySingleOrDefault<User>(query, parameters);
                return user;
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "INSERT OR REPLACE INTO Users (username, master_password, master_salt) VALUES (@Username, @MasterPassword, @MasterSalt)";
                var parameters = new
                {
                    Username = user._username,
                    MasterPassword = user._masterCredentials.Password,
                    MasterSalt = user._masterCredentials.Notes
                };
                cnn.Execute(query, parameters);
            }
        }

        public static Vault LoadVault(string username)
        {
            User user = LoadUser(username);
            if (user == null)
            {
                return null;
            }

            Vault vault = new Vault(user._username, user._masterCredentials.Password);

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = "SELECT * FROM Credentials WHERE username = @Username";
                var parameters = new { Username = username };
                var credentials = cnn.Query<PlatformCredentialsV2>(query, parameters).ToList();
                vault._credentials.AddRange(credentials);
            }

            return vault;
        }

        public static void SaveVault(Vault vault)
        {
            string username = vault._user._username;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Credentials WHERE username = @Username", new { Username = username });

                foreach (var credential in vault._credentials)
                {
                    var query = "INSERT INTO Credentials (username, platform, password, notes) VALUES (@Username, @Platform, @Password, @Notes)";
                    var parameters = new
                    {
                        Username = username,
                        Platform = credential.Platform,
                        Password = credential.EncryptedPassword,
                        Notes = credential.Notes
                    };
                    cnn.Execute(query, parameters);
                }
            }
        }
    }
}