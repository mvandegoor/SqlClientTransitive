using System;
using Microsoft.Data.SqlClient;

namespace Library
{
    public static class Connector
    {
        public static void Connect()
        {
            var connection = new SqlConnection(@"Server=localhost;Database=master;Trusted_Connection=True;");
            connection.Open();
        }
    }
}
