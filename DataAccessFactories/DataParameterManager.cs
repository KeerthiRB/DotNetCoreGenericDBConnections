using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataAccessFactories
{
    public class DataParameterManager
    {
        public static IDbDataParameter CreateParameter(string providerName, string name, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            IDbDataParameter parameter = null;
            switch (providerName.ToLower())
            {
                case "mysql.data.mysqlclient":
                    return CreateMySqlParameter(name, value, dbType, direction);
                default:
                    break;
            }
            return parameter;
        }
        public static IDbDataParameter CreateParameter(string providerName, string name, int size, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            IDbDataParameter parameter = null;
            switch (providerName.ToLower())
            {
                case "mysql.data.mysqlclient":
                    return CreateMySqlParameter(name, size, value, dbType, direction);
                default:
                    break;
            }
            return parameter;
        }

        private static IDbDataParameter CreateMySqlParameter(string name, object value, DbType dbType, ParameterDirection direction)
        {
            return 
                new MySqlParameter()
                {
                    DbType = dbType,
                    ParameterName = name,
                    Direction = direction,
                    Value = value
                };
        }

        private static IDbDataParameter CreateMySqlParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
        {
            return 
                new MySqlParameter()
                {
                    DbType = dbType,
                    Size = size,
                    ParameterName = name,
                    Direction = direction,
                    Value = value
                };
        }
    }
}
