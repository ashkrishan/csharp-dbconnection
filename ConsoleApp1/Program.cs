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
                Timeout = new TimeSpan(0, 0, 5) //secs timeout
            };

            var command1 = new DbCommand(sqlConn);
            command1.Execute("Insert into DB........");

            var oracleConn = new OracleConnection(@"ORACLe3838383....")
            {
                Timeout = new TimeSpan(0, 0, 2)  //secs timeout
            };

            var command2 = new DbCommand(oracleConn);
            command2.Execute("Insert into DB........");


        }


    }
}
