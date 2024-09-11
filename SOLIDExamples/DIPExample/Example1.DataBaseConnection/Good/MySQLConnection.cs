using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPExample.Example1.DataBaseConnection.Good
{
    public interface IDbConnection
    {
        public bool Connect();
    }

    public class DbConnection : IDbConnection
    {
        public bool Connect()
        {
            //Коннектимся к MYSQL бд
            return true;
        }
    }

    public class PasswordReminder
    {
        private IDbConnection _dbConnection;

        public PasswordReminder(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
