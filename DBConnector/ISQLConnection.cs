namespace DBConnector
{
    interface ISQLConnection
    {
        void Close();
        void Open();
    }
}