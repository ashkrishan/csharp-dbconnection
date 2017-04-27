//This class is not implemented at the moment but shown as an example for future DI to showcase loose coupling

namespace DbConnector
{
    class DbCommand
    {
        private readonly IDbCommand _command;
        public DbCommand(IDbCommand dbCommand) //dependency injection and OCP (Open close programming)
        {
            _command = dbCommand;
        }
    }
}
