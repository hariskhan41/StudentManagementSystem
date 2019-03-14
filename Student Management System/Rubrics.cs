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
    class Rubrics
    {
        public string Details { get; set; }

        public int Id { get; set; }

        public string CloName { get; set; }

        public int CloId { get; set; }


        public void AddToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM CLO";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }

        public int getId()
        {
            int i;
            int count;
            string cmd1 = "SELECT COUNT(*) FROM Rubric";
            count = DatabaseConnection.getInstance().getScalarData(cmd1);
            if (count != 0)
            {
                string cmd = "SELECT MAX(Id) FROM Rubric";
                i = DatabaseConnection.getInstance().getScalarData(cmd);
                return i;
            }
            else
            {
                return -1;
            }
        }

        public void Edit(int id)
        {
            string cmd = "UPDATE Rubric SET Details = '" + Details + "', CloId = '" + CloId + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated!");
            //string cmd2 = "SELECT * FROM Clo";
            //SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            //DataTable dt = new DataTable();
            //sqlDA.Fill(dt);
            //return dt;
        }


        public int getCloId(string cloName)
        {
            string cmd = "SELECT Id FROM Clo WHERE Name = '" + cloName + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public string getCloNameById(int id)
        {
            string name = "";
            string cmd = "SELECT * FROM Clo WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                name = d.GetString(1);
                break;
            }
            return name;
        }


        public void AddRubric()
        {
            string cmd = "INSERT INTO Rubric (Id, Details, CloId) VALUES ('" + Id + "','" + Details + "','" + CloId + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("CLO Is Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
        }

        public void Delete(int id)
        {
            string cmd = "DELETE FROM Rubric WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Deleted!");
        }

        public DataTable ShowInGrid()
        {
            string cmd2 = "SELECT * FROM Rubric";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


    }
}
