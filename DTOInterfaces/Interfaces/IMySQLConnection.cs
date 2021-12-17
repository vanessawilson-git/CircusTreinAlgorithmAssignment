using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DTOAndInterfaces.Interfaces
{
    public interface IMySQLConnection
    {
        MySqlConnection OpenConnection();
        MySqlConnection GetConnection();

    }
}
