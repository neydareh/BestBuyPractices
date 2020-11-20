using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = GetConnection("appsettings.json", "DefaultConnection");
        }
        public static IDbConnection GetConnection(string appJSONConfig, string connectionName)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appJSONConfig)
                .Build();
            string connectionString = config.GetConnectionString(connectionName);
            IDbConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
