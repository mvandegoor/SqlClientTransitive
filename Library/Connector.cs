using System;
using Microsoft.Data.SqlClient;

namespace Library
{
    public static class Connector
    {
        public static void Connect()
        {
            var connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=CacheTestDb;Trusted_Connection=True;");
            connection.Open();
        }
    }
}
