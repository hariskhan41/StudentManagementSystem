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

        /// <summary>
        /// Checks if name is valid
        /// </summary>
        /// <param name="name">Name entered by user</param>
        /// <returns>Retruns string 'Invalid Name' if name is not in correct format i.e. name should not have punctuation</returns>
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

        /// <summary>
        /// Checks if Clo Name is already in record
        /// </summary>
        /// <param name="name">Clo name entered by user</param>
        /// <returns>Returns true if record exist</returns>
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


        /// <summary>
        /// Add Data in Clo table
        /// </summary>
        public void add()
        {
            string cmd = "INSERT INTO CLO (Name, DateCreated, DateUpdated) VALUES ('" + name + "','" + dateCreated.ToString(@"yyyy-MM-dd") + "','" + dateUpdated.ToString(@"yyyy-MM-dd") + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("CLO Is Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
        }

        /// <summary>
        /// Shows data in grid view
        /// </summary>
        /// <returns>Returns DataTable containing data fetched from sql table</returns>
        public DataTable ShowInGrid()
        {
            string cmd2 = "SELECT * FROM Clo";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Edits the data from record and then show updated data in grid view.
        /// </summary>
        /// <param name="id">Id of particular row user has clicked</param>
        /// <returns>Returns DataTable containing data fetched from sql table after updation </returns>
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

        /// <summary>
        /// Delete data from sql table.
        /// </summary>
        /// <param name="id">Id of particular row user clicked to delete</param>
        public void Delete(int id)
        {
            int rubId = getRubricIdFromCloId(id);
            int rubLvlId = getRubricLvlIdFromRubricId(rubId);
            int assCompId = getAssessmentComponentIdFromRubricId(rubId);

            string cmd1 = "DELETE FROM StudentResult WHERE RubricMeasurementId = '" + rubLvlId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd1);

            string cmd2 = "DELETE FROM StudentResult WHERE AssessmentComponentId = '" + assCompId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd2);

            string cmd3 = "DELETE FROM RubricLevel WHERE RubricId = '" + rubId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd3);

            string cmd4 = "DELETE FROM AssessmentComponent WHERE RubricId = '" + rubId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd4);


            string cmd5 = "DELETE FROM Rubric WHERE CloId = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd5);

            string cmd = "DELETE FROM Clo WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);

            MessageBox.Show("CLO is deleted along with all of rubrics against this CLO");
        }

        public int getRubricIdFromCloId(int cloId)
        {
            string cmd = "SELECT Id FROM Rubric WHERE CloId = '" + cloId + "'";
            int i = DatabaseConnection.getInstance().getScalarData(cmd);
            return i;
        }

        public int getRubricLvlIdFromRubricId(int rubId)
        {
            string cmd = "SELECT Id FROM RubricLevel WHERE RubricId = '" + rubId + "'";
            int i = DatabaseConnection.getInstance().getScalarData(cmd);
            return i;
        }


        public int getAssessmentComponentIdFromRubricId(int rubId)
        {
            string cmd = "SELECT Id FROM AssessmentComponent WHERE RubricId = '" + rubId + "'";
            int i = DatabaseConnection.getInstance().getScalarData(cmd);
            return i;
        }



    }
}
