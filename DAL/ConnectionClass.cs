using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DTOAndInterfaces.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class ConnectionClass : IMySQLConnection
    {
        private static string _connectionString;

        public ConnectionClass()
        {
            _connectionString = GetConnectionString();
        }

        private  MySqlConnection connection = new MySqlConnection(_connectionString);

        public MySqlConnection OpenConnection()
        {
            connection.Open();
            return connection;
        }


        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //string builder, this way i dont have to put the string in the method itself.That way people cant mess with it.
        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }
    }
}
