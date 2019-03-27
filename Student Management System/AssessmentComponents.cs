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
    class AssessmentComponents
    {
        public string name { get; set; }

        public string assessmentTitle { get; set; }

        public string rubricDetails { get; set; }

        public int totalMarks { get; set; }

        public int RubricId { get; set; }

        public int AssessmentId { get; set; }

        public string errorName { get; set; }

        public string errorTotalMarks { get; set; }


        /// <summary>
        /// Check if name is valid i.e it should only contain letters.
        /// </summary>
        /// <param name="name">Name entered by user</param>
        /// <returns>returns 'invalid name' string if name is not correct</returns>
        public string ValidName(string name)
        {
            errorName = "";

            if (string.IsNullOrEmpty(name))
            {
                errorName = "Invalid Name";
            }
            else
            {
                foreach (char c in name)
                {
                    if (char.IsDigit(c))
                    {
                        errorName = "Invalid Name";
                        break;
                    }
                    else if (char.IsPunctuation(c))
                    {
                        errorName = "Invalid Name";
                        break;
                    }
                    else if (c == '@')
                    {
                        errorName = "Invalid Name";
                        break;
                    }
                }
            }
            return errorName;
        }

        /// <summary>
        /// Checks if total marks entered by user are valid i.e it should only contain numbers
        /// </summary>
        /// <param name="totalMarks">Marks entered by user</param>
        /// <returns>return invalid marks string if marks entered are not correct</returns>
        public string ValidTotalMarks(string totalMarks)
        {
            errorTotalMarks = "";

            if (string.IsNullOrEmpty(totalMarks) || string.IsNullOrWhiteSpace(totalMarks))
            {
                errorTotalMarks = "Invalid Total Marks";
            }
            else
            {
                foreach (char c in totalMarks)
                {
                    if (!char.IsDigit(c))
                    {
                        errorTotalMarks = "Invalid Total Marks";
                        break;
                    }
                }
            }
            return errorTotalMarks;
        }

        /// <summary>
        /// Add all Titles from Assessment table to combo box.
        /// </summary>
        /// <param name="cmb">combobox in which data is to be shown.</param>
        public void AddAssessmentTitleToCombobox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Assessment";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while(d.Read())
            {
                string title = d.GetString(1);
                cmb.Items.Add(title);
            }
        }


        /// <summary>
        /// Add all rubric details from Rubric table to combo box.
        /// </summary>
        /// <param name="cmb">combobox in which data is to be shown.</param>
        public void AddRubricDetailsToCombobox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Rubric";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while(d.Read())
            {
                string rubricDetails = d.GetString(1);
                cmb.Items.Add(rubricDetails);
            }
        }

        /// <summary>
        /// Find Id from Assessment table from title.
        /// </summary>
        /// <param name="title">Title selected by user</param>
        /// <returns>Returns Id coressponding to particular title.</returns>
        public int getAssessmentIdFromTitle(string title)
        {
            string cmd = "SELECT Id FROM Assessment WHERE Title = '" + title + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }

        /// <summary>
        /// Find Id from Rubric table from details.
        /// </summary>
        /// <param name="details">Details selected by user</param>
        /// <returns>Return Id coressponding to details.</returns>
        public int getRubricIdFromDetails(string details)
        {
            string cmd = "SELECT Id FROM Rubric WHERE Details = '" + details + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }

        /// <summary>
        /// Find title from Assessment table from Id.
        /// </summary>
        /// <param name="id">Id given from which title is to be find</param>
        /// <returns>Returns title coressponding to Id</returns>
        public string getAssessmentTitleFromId(int id)
        {
            string title = "";
            string cmd = "SELECT * FROM Assessment WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while(d.Read())
            {
                title = d.GetString(1);
                break;
            }
            return title;
        }

        /// <summary>
        /// Find Details from Rubric table from Id.
        /// </summary>
        /// <param name="id">Id given from which titel is to be find</param>
        /// <returns>Returns Details coressponding to Id</returns>
        public string getRubricDetailFromId(int id)
        {
            string details = "";
            string cmd = "SELECT * FROM Rubric WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                details = d.GetString(1);
                break;
            }
            return details;
        }


        /// <summary>
        /// Add assessment component data to database.
        /// </summary>
        public void Add()
        {
            string cmd = "INSERT INTO AssessmentComponent (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES ('" + name + "', '" + RubricId + "', '" + totalMarks + "', '" + DateTime.Now.ToString(@"yyyy-MM-dd") + "', '" + DateTime.Now.ToString(@"yyyy-MM-dd") + "', '" + AssessmentId + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Assessment Component is added");
            DatabaseConnection.getInstance().closeConnection();
        }


        /// <summary>
        /// Update data of particular row
        /// </summary>
        /// <param name="id">row id selected by user to edit</param>
        public void Edit(int id)
        {
            string cmd = "UPDATE AssessmentComponent SET Name = '" + name + "', RubricId = '" + RubricId + "', TotalMarks = '" + totalMarks + "', DateUpdated = '" + DateTime.Now.ToString(@"yyyy-MM-dd") + "', AssessmentId = '" + AssessmentId + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated!");

        }



        /// <summary>
        /// Show all data from AssessmentComponent table in grid.
        /// </summary>
        /// <returns>Returns Data table containing data from database.</returns>
        public DataTable ShowInGrid()
        {
            string cmd = "SELECT * FROM AssessmentComponent";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }
    }
}
