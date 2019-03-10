using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Management_System
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        public String ConnectionString = @"Data Source=ABULHARIS\MSSQLSERVER1;Initial Catalog=ProjectB;Integrated Security=True";
        private SqlConnection connection;

        /// <summary>
        /// Allows to make only one object of class.
        /// </summary>
        /// <returns> Instance of class. </returns>
        public static DatabaseConnection getInstance()
        {
            if (instance == null)
                instance = new DatabaseConnection();
            return instance;
        }

        private DatabaseConnection()
        {

        }

        /// <summary>
        /// Opens SQL Connection
        /// </summary>
        /// <returns> SQL connection object </returns>
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }



        /// <summary>
        /// Reads the data from SQL database.
        /// </summary>
        /// <param name="commnadText"> String in string.Format style. It is the string that goes in query. </param>
        /// <returns> SQL Reader Object </returns>
        public SqlDataReader getData(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// Executes the commands in query and calculates number of rows effected.
        /// </summary>
        /// <param name="commnadText"> String in string.Format style. It is the string that goes in query. </param>
        /// <returns> number of affected rows. </returns>
        public int exectuteQuery(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText, connection);
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }


        public SqlDataAdapter Query(String commandText)
        {
            connection = getConnection();
            //SqlCommand cmd = new SqlCommand(commandText, connection);
            SqlDataAdapter sqlDA = new SqlDataAdapter(commandText, connection);
            return sqlDA;
        }

        /// <summary>
        /// Close the connection.
        /// </summary>
        public void closeConnection()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
