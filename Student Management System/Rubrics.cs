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
            string cmd = "SELECT MAX(Id) FROM Rubric";
            i = DatabaseConnection.getInstance().getScalarData(cmd);
            return i;
        }

        public void AddRubric()
        {
            string cmd = "INSERT INTO Rubric (Id, Details, CloId) VALUES ('" + Id + "','" + Details + "','" + CloId + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("CLO Is Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
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
