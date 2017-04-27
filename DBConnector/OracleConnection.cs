using System;
using System.Threading.Tasks;
using System.Threading;

namespace DBConnector
{
   public class OracleConnection : DBConnection, IDBConnection
    {
        public OracleConnection(string connectionString)
             :base(connectionString)
        {

        }

        private void OpenConnection()
        {
            var task = Task.Run(() => SetupConnection());

            if (!task.Wait(Timeout))
            {
                throw new TimeoutException("Connection timed out! Unable to open!");
            }
            else
            {
                Console.WriteLine("connection success\n Connection Opened!");
            }
        }


        private void SetupConnection()
        {
            Thread.Sleep(20000);  // 20 sec delay. Create timeout delay to demonstrate task didn't complete of opening connection 

        }


        public void Open()
        {

            OpenConnection();

        }

        public void Close()
        {
            Console.WriteLine("SQL server connection closed!\n");
        }
    }
}
