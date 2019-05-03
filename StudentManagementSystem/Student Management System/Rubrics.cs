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


        /// <summary>
        /// Add items to combobox from sql table.
        /// </summary>
        /// <param name="cmb">ComboBox object in which item list is to be stored</param>
        public void AddToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM CLO";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }

        /// <summary>
        /// Get highest id from Rubric table if any
        /// </summary>
        /// <returns>Returns highest id if any otherwise returns -1</returns>
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

        public string DetailsAlreadyExist(string details)
        {
            string cmd = "SELECT * FROM Rubric WHERE details = '" + details + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return "Details must be unique";
            }
            else
            {
                return "";
            }
        }


        /// <summary>
        /// Update data of particular record
        /// </summary>
        /// <param name="id">Id of particular row clicked by user whose data is to be edited</param>
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


        /// <summary>
        /// Gets clo id Corresponding to particular name from Clo table to be stored in combobox
        /// </summary>
        /// <param name="cloName">Name string against which id is to be get</param>
        /// <returns>returns id against entered name</returns>
        public int getCloId(string cloName)
        {
            string cmd = "SELECT Id FROM Clo WHERE Name = '" + cloName + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }

        /// <summary>
        /// Gets clo name Corresponding to particular id from Clo table to be stored in combobox
        /// </summary>
        /// <param name="cloName">id against which clo name is to be get</param>
        /// <returns>returns clo name against entered id</returns>
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

        /// <summary>
        /// Add Rubrics' data tu Rubric table.
        /// </summary>
        public void AddRubric()
        {
            string cmd = "INSERT INTO Rubric (Id, Details, CloId) VALUES ('" + Id + "','" + Details + "','" + CloId + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("CLO Is Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
        }

        /// <summary>
        /// Delete particular row record from table.
        /// </summary>
        /// <param name="id">Id agains which record is to be deleted</param>
        public void Delete(int id)
        {
            int rubLvlId = getRubricLevelIdFromRubricId(id);
            int assCompId = getAssessmentComponentIdFromRubricId(id);

            string cmd1 = "DELETE FROM StudentResult WHERE RubricMeasurementId = '" + rubLvlId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd1);

            string cmd2 = "DELETE FROM StudentResult WHERE AssessmentComponentId = '" + assCompId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd2);

            string cmd3 = "DELETE FROM RubricLevel WHERE RubricId = '" + id + "'";


            string cmd = "DELETE FROM Rubric WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Deleted!");
        }

        /// <summary>
        /// Fetch data from table
        /// </summary>
        /// <returns>Return datatable containing data that is fetched.</returns>
        public DataTable ShowInGrid()
        {
            string cmd2 = "SELECT * FROM Rubric";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


        public int getRubricLevelIdFromRubricId(int rubId)
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
