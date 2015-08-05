using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.servicios
{
    public class MySQLContection
    {
        private NotificationMessagess notificationMessages;

        public void setNotificationMessages(NotificationMessagess notification)
        {
            notificationMessages = notification;
        }

        private MySQLContection Connection = null;

        private MySqlConnection connection;


        private void keepConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
            string StrCon = string.Format("Server=localhost; database=codicedb; UID=root; password=");
            connection = new MySqlConnection(StrCon);
            connection.Open();
        }

        public MySqlConnection getConnection()
        {
            keepConnection();

            return connection;
        }

        public void performNoQueryWithSQLComandAndNotification(MySqlCommand sqlCommand, String[] notification)
        {
            try
            {
                if (sqlCommand.Connection == null)
                    sqlCommand.Connection = getConnection();

                sqlCommand.ExecuteNonQuery();

                notificationMessages.showTitleAndMessage("Exito", notification[0]);
            }
            catch (Exception e)
            {
                notificationMessages.showTitleAndMessage("Error", notification[1] + " " + e.Message);
            }

        }

        public MySqlDataReader performQueryWithSQLComand(MySqlCommand sqlCommand)
        {
            try
            {
                if (sqlCommand.Connection == null)
                    sqlCommand.Connection = getConnection();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                return reader;
            }
            catch (Exception e)
            {
                notificationMessages.showTitleAndMessage("Error ", e.Message);

                return null;
            }
        }

        public void performNoQueryWithSQLComandAndNotification(MySqlCommand command)
        {
            String[] casos = new String[2];
            casos[0] = "Exito";
            casos[1] = "Fallo";

            performNoQueryWithSQLComandAndNotification(command, casos);
        }
    }
}
