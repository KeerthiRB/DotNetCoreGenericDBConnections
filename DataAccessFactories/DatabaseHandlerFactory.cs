using DataAccessHandler;
using Microsoft.Extensions.Configuration;
using MysqlDBOperation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccessFactories
{
    class DatabaseHandlerFactory
    {
        private ConnectionStringSettings connectionStringSettings;
        public DatabaseHandlerFactory(string connectionStringName, IConfiguration configuration)
        {
            connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
            {
                var connectionString = configuration.GetConnectionString(connectionStringName);
                string[] splitConnectionString = connectionString.Split(new string[] { "ProviderName=" }, StringSplitOptions.None);
                connectionStringSettings = new ConnectionStringSettings();
                connectionStringSettings.ConnectionString = splitConnectionString[0];
                connectionStringSettings.Name = connectionStringName;
                connectionStringSettings.ProviderName = splitConnectionString[1];
            }
        }
        public IDatabaseHandler CreateDatabase()
        {
            IDatabaseHandler database = null;
            switch (connectionStringSettings.ProviderName.ToLower())
            {
                case "mysql.data.mysqlclient":
                    database = new MySqlDataAccess(connectionStringSettings.ConnectionString);
                    break;
                default:
                    break;
            }
            return database;
        }
        public string GetProviderName() { return connectionStringSettings.ProviderName; }
    }
}
