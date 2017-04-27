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
