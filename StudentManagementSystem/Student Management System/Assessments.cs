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
    class Assessments
    {
        public string title { get; set; }

        public int totalMarks { get; set; }

        public int totalWeightage { get; set; }

        public string errorTitle { get; set; }

        public string errorTotalMarks { get; set; }

        public string errorTotalWeightage { get; set; }


        /// <summary>
        /// Check if title entered is valid i.e it should not contain numbers.
        /// </summary>
        /// <param name="title">Title entered by user</param>
        /// <returns>Returns string of 'invalid error' if title is not valid</returns>
        public string ValidTitle(string title)
        {
            errorTitle = "";
            if (string.IsNullOrEmpty(title))
            {
                errorTitle = "Invalid Title";
                return errorTitle;
            }
            else
            {
                foreach (char c in title)
                {
                    if (char.IsDigit(c))
                    {
                        errorTitle = "Invalid Title";
                        break;
                    }
                }
                return errorTitle;
            }
        }


        /// <summary>
        /// Check if Total Marks entered is valid i.e it should have numbers only.
        /// </summary>
        /// <param name="totalMarks">Total marks entered by user</param>
        /// <returns>Returns string 'Invalid Total Marks' if not valid otherwise empty string</returns>
        public string ValidTotalMarks(string totalMarks)
        {
            if (string.IsNullOrEmpty(totalMarks))
            {
                errorTotalMarks = "Invalid Total Marks";
                return totalMarks;
            }
            else
            {
                errorTotalMarks = "";
                foreach (char c in totalMarks)
                {
                    if (char.IsLetter(c))
                    {
                        errorTotalMarks = "Invalid Total Marks";
                        break;
                    }
                }
                return errorTotalMarks;
            }
        }

        /// <summary>
        /// Check if Total Weightage entered is valid i.e it should have numbers only.
        /// </summary>
        /// <param name="totalWeightage">Total Weightage entered by user</param>
        /// <returns>Returns string 'Invalid Total Weightage' if not valid, otherwise empty string</returns>
        public string ValidTotalWeight(string totalWeightage)
        {
            if (string.IsNullOrEmpty(totalWeightage))
            {
                errorTotalWeightage = "Invalid Total Weightage";
                return errorTotalWeightage;
            }
            else
            {
                errorTotalWeightage = "";
                foreach (char c in totalWeightage)
                {
                    if (char.IsLetter(c))
                    {
                        errorTotalWeightage = "Invalid Total Weightage";
                        break;
                    }
                }
                return errorTotalWeightage;
            }
        }


        /// <summary>
        /// Checks if title exist in Assessment table.
        /// </summary>
        /// <param name="title">Title entered by user which is to be checked</param>
        /// <returns>Returns string telling title already exist if title is in database, otherwise an empty string.</returns>
        public string TitleAlreadyExist(string title)
        {
            string cmd = "SELECT * FROM Assessment WHERE Title = '" + title + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return "Title already exists";
            }
            else
            {
                return "";
            }
        }


        public int getAssessmentComponentIdFromAssessmentId(int id)
        {
            string cmd = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + id + "'";
            int i = DatabaseConnection.getInstance().getScalarData(cmd);
            return i;
        }



        public DataTable ShowInGrid()
        {
            string cmd = "SELECT * FROM Assessment";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


        /// <summary>
        /// Add assessments data to database with insert query.
        /// </summary>
        public void Add()
        {
            string cmd = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES ('" + title + "','" + DateTime.Now.ToString(@"yyyy-MM-dd") + "','" + totalMarks + "','" + totalWeightage + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Added Successfully");
            DatabaseConnection.getInstance().closeConnection();
        }

        /// <summary>
        /// Edit data of a particular row.
        /// </summary>
        /// <param name="id">id given of which data is to be editied.</param>
        public void Edit(int id)
        {
            string cmd = "UPDATE Assessment SET Title = '" + title + "', TotalMarks = '" + totalMarks + "', TotalWeightage = '" + totalWeightage + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated Successfully!");
            DatabaseConnection.getInstance().closeConnection();
        }


        public void Delete(int id)
        {
            int assCompId = getAssessmentComponentIdFromAssessmentId(id);

            string cmd1 = "DELETE FROM StudentResult WHERE AssessmentComponentId = '" + assCompId + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd1);

            string cmd2 = "DELETE FROM AssessmentComponent WHERE AssessmentId = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd2);

            string cmd = "DELETE FROM Assessment WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Deleted!");
        }





    }
}
