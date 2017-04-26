using System;

namespace DBConnector
{
    class Start
    {
        static void Main(string[]  args)
        {
            var sqlConn = new SQLConnection(@"SQL26362236.....")
            {
                Timeout = new TimeSpan(0, 0, 11) //11 secs timeout
            };
            sqlConn.Open();


            var oracleConn = new OracleConnection(@"SQL26362236.....")
            {
                Timeout = new TimeSpan(0, 0, 2)  //2 sec timeout
            };
            oracleConn.Open();
            oracleConn.Close();
        }


    }
}
