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

        public string errorName { get; set; }

        public string ErrorName(string name)
        {
            errorName = "";
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && c != ' ')
                {
                    errorName = "Invalid Name";
                }
            }
            return errorName;
        }

        public bool CloAlreadyExist(string name)
        {
            string cmd = "SELECT * FROM Clo WHERE Name = '" + name + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


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

        public void Delete(int id)
        {
            string cmd = "DELETE FROM Rubric WHERE CloId = '" + id + "'";
            string cmd2 = "DELETE FROM Clo WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            DatabaseConnection.getInstance().exectuteQuery(cmd2);
            MessageBox.Show("CLO is deleted along with all of rubrics against this CLO");
        }
    }
}
