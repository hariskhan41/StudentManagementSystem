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
    class Results
    {
        public int studentId { get; set; }

        public int assessmentComponentId { get; set; }

        public int rubricMeasurementId { get; set; }



        public void AddStudentsToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Student";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(5);
                cmb.Items.Add(n);
            }
        }


        public void AddAssessmentToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Assessment";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }


        public int getAssessmentIdFromTitle(string title)
        {
            string cmd = "SELECT Id FROM Assessment WHERE title = '" + title + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public void AddAssessmentComponentToComboBox(ComboBox cmb, string assessment)
        {
            int assId = getAssessmentIdFromTitle(assessment);
            string cmd = "SELECT * FROM AssessmentComponent WHERE AssessmentId = '" + assId + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }
        

        public int getRubricIdFromAssessmentComponent(string name)
        {
            string cmd = "SELECT RubricId FROM AssessmentComponent WHERE name = '" + name + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public void AddRubricToComboBox(ComboBox cmb, string assessmentComponent)
        {
            int assCmpId = getRubricIdFromAssessmentComponent(assessmentComponent);
            string cmd = "SELECT * FROM Rubric WHERE Id = '" + assCmpId + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }


        public int getRubricLevelIdFromRubricDetails(string details)
        {
            string cmd = "SELECT Id FROM Rubric WHERE Details = '" + details + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }



        public void AddRubricLevelToComboBox(ComboBox cmb, string rubric)
        {
            int RubLvlId = getRubricLevelIdFromRubricDetails(rubric);
            string cmd = "SELECT * FROM RubricLevel WHERE RubricId = '" + RubLvlId + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                int n = d.GetInt32(3);
                cmb.Items.Add(n);
            }
        }


        /// <summary>
        /// Get student id from Student table
        /// </summary>
        /// <param name="regNo">Registration number selected by user.</param>
        /// <returns>Returns Student id coressponding to registration number</returns>
        public int getStudentIdFromReg(string regNo)
        {
            string cmd = "SELECT Id FROM Student WHERE RegistrationNumber = '" + regNo + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public int getAssessmentComponentIdFromName(string name)
        {
            string cmd = "SELECT Id FROM AssessmentComponent WHERE Name = '" + name + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public int getRubricLevelIdFromRubricLevelDetails(string level)
        {
            string cmd = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = '" + level + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        public void Add()
        {
            string cmd = "INSERT INTO StudentResult (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) VALUES ('" + studentId + "', '" + assessmentComponentId + "', '" + rubricMeasurementId + "', '" + DateTime.Now.ToString(@"yyyy-MM-dd") + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Added Successfully");
        }

        public DataTable ShowInGrid()
        {
            string cmd = "SELECT * FROM StudentResult";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


    }
}
