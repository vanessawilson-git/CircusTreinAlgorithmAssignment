using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTOAndInterfaces;
using DTOAndInterfaces.Interfaces;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AccountRepo : IAccountRepo
    {
       private readonly IMySQLConnection _connClass;

        //Again due to dependecy injection, my code will talk to an interface eventhough they will get an actuall connection class
        public AccountRepo(IMySQLConnection connectionClass)
        {
            _connClass = connectionClass;
        }

        public void CreateAccount(AccountDTO account)
        {
            string query = "INSERT INTO users(UserId, EmailAddress, UserName, Password) VALUES (@UserName, @Email, @Password);";
            using (_connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, _connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@UserName", account.UserName);
                    sqlCommand.Parameters.AddWithValue("@Email", account.Email);
                    sqlCommand.Parameters.AddWithValue("@Password", account.Password);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAccount(int userID)
        {
            string query = "DELETE FROM users WHERE UserId = @UserId;";
            using (_connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, _connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@UserId", userID);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public AccountDTO GetAccountByEmail(string email)
        {
            AccountDTO account = new AccountDTO();
            
            string query = "Select * FROM users WHERE EmailAddress = @Email;";
            using (_connClass.OpenConnection())
            {
                using (MySqlCommand sqlCommand = new MySqlCommand(query, _connClass.GetConnection()))
                {
                    //This makes sure noone can mess with the query. This basically says when you see this @Thing you mean the Dto.thing
                    sqlCommand.Parameters.AddWithValue("@Email", email);

                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        account.UserId = (int) reader["UserId"];
                        account.UserName = (string) reader["UserName"];
                        account.Email = (string) reader["EmailAsdress"];
                        account.Password = (string) reader["Password"];
                    }

                    
                }
            }

            return account;
        }

      
    }
}
