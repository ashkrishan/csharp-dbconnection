using System;

namespace DBConnector
{
    public abstract class DBConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }


        public DBConnection(string connectionString)
        {
            
            if (String.IsNullOrEmpty(connectionString) || String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection String is not valid. Please correct the connection string.");

            ConnectionString = connectionString;

        }

               
        
    }

}
