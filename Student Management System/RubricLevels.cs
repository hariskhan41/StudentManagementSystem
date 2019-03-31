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
    class RubricLevels
    {
        public int rubricId { get; set; }

        public string details { get; set; }

        public int measurementLevel { get; set; }

        public string errorMeasurementLevel { get; set; }

        public string ValidMeasurementLevel(string measurementLevel)
        {
            foreach (char c in measurementLevel)
            {
                if (!char.IsDigit(c))
                {
                    errorMeasurementLevel = "Invalid Measurement Level";
                }
            }
            return errorMeasurementLevel;
        }


        public void AddToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Rubric";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }

        public string DetailsAlreadyExist(string details)
        {
            string cmd = "SELECT * FROM RubricLevel WHERE Details = '" + details + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return "Details should be unique";
            }
            else
            {
                return "";
            }
        }


        public int getRubricIdFromRubricDetails(string rubricDetails)
        {
            string cmd = "SELECT Id FROM Rubric WHERE Details = '" + rubricDetails + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public string getDetailsFromRubricId(int id)
        {
            string details1 = "";
            string cmd = "SELECT * FROM Rubric WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                details1 = d.GetString(1);
                break;
            }
            return details1;
        }


        public void Add()
        {
            string cmd = "INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) VALUES ('" + rubricId + "', '" + details + "', '" + measurementLevel + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Added Successfully");
        }


        public void Edit(int id)
        {
            string cmd = "UPDATE RubricLevel SET Details = '" + details + "', MeasurementLevel = '" + measurementLevel + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated");
        }


        public DataTable ShowInGrid()
        {
            string cmd = "SELECT * FROM RubricLevel";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


    }
}
