using System;
using DBConnector;

namespace DbConnector
{

    public class DbCommand : IDbCommand
    {
        private readonly IDBConnection _connection;
        public DbCommand(IDBConnection connection)   //dependency injection and OCP (Open close programming)
        {
            _connection = connection;
        }

        public void Execute(string command)
        {
            _connection.Open();
            Console.WriteLine("Command execution {0}", command);
            _connection.Close();
        }

    }
}
