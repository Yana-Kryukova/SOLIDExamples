namespace DIPExample.Example1.DataBaseConnection.Bad
{
    public class MySQLConnection
    {
        public bool Connect()
        {
            //Коннектимся к MYSQL бд
            return true;
        }
    }

    public class PasswordReminder
    {
        private MySQLConnection _dbConnection;

        public PasswordReminder(MySQLConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
