using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    class AddClo
    {
        public string name { get; set; }

        public DateTime dateCreated { get; set; }

        public DateTime dateUpdated { get; set; }


        public void add()
        {
            string cmd = "INSERT INTO CLO (Name, DateCreated, DateUpdated) VALUES ('" + name + "','" + dateCreated.ToString(@"yyyy-MM-dd") + "','" + dateUpdated.ToString(@"yyyy-MM-dd") + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("CLO Is Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
        }

        public DataTable ShowInGrid()
        {
            string cmd2 = "SELECT * FROM Clo";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }

        public DataTable Edit(int id)
        {
            string cmd = "UPDATE Clo SET Name = '" + name + "', DateUpdated = '" + dateUpdated.ToString(@"yyyy-MM-dd") + "' WHERE Id = '"+ id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated!");
            string cmd2 = "SELECT * FROM Clo";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }
    }
}
