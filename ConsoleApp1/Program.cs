using System;
using DbConnector;

namespace DBConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SQLConnection(@"SQL26362236.....")
            {
                Timeout = new TimeSpan(0, 0, 11) //11 secs timeout
            };

            var command = new SQLCommand(sqlConn);
            command.Execute("Insert into DB........");

            //var oracleConn = new OracleConnection(@"SQL26362236.....")
            //{
            //    Timeout = new TimeSpan(0, 0, 2)  //2 sec timeout
            //};

        }


    }
}
