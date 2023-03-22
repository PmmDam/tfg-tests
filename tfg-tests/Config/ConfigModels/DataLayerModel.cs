using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFG_Test.Config.ConfigModels
{
    internal class DataLayerModel
    {
        #region properties
        
        public string ServerName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string DbName { get; set; }
        public string ConnectionString { get; set; }

        #endregion properties

        #region constructors

        public DataLayerModel(string serverName, string login, string password, string dbName, string connectionString)
        {
            ServerName = serverName;
            Login = login;
            Password = password;
            DbName = dbName;
            ConnectionString = connectionString;
        }

        public DataLayerModel(){}

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Server name:");
            sb.Append(ServerName);
            sb.AppendLine();


            sb.Append("Database name:");
            sb.Append(DbName);
            sb.AppendLine();


            sb.Append("Login:");
            sb.Append(Login);
            sb.AppendLine();


            sb.Append("Password:");
            sb.Append(Password);
            sb.AppendLine();


            sb.Append("Connection String:");
            sb.Append(ConnectionString);
            sb.AppendLine();

            return sb.ToString();   

        }

 
        #endregion constructors
    }
}
