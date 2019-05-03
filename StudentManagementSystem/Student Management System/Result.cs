using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet13.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet13.StudentResult);
            btn_Result.BackColor = Color.Gray;
            btn_Result.Enabled = false;

            Results R = new Results();
            R.AddStudentsToComboBox(cmb_Student);
            R.AddAssessmentToComboBox(cmb_Assessment);

            DataTable dt = R.ShowInGrid();
            dataGridView1.DataSource = dt;

            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = R.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][0]));

                int k1 = R.getRubricIdFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));
                dataGridView1.Rows[i].Cells[5].Value = R.getRubDetailsFromRubId(k1);

                dataGridView1.Rows[i].Cells[6].Value = R.getAssessmentCompNameFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));

                dataGridView1.Rows[i].Cells[7].Value = R.getTotalMarksFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));

                dataGridView1.Rows[i].Cells[8].Value = R.getMeasurementLevelFromRubricLevelId(Convert.ToInt32(dt.Rows[i][2]));

                decimal ObtainedMarks = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[8].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value)) / 4;
                dataGridView1.Rows[i].Cells[9].Value = ObtainedMarks;

                
                
                

            }


        }

        private void btn_AddStudents_Click(object sender, EventArgs e)
        {
            AddStudents.getInstance().Show();
            AddStudents.getInstance().Refresh();
            AddStudents.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_AddClo_Click(object sender, EventArgs e)
        {
            Clo.getInstance().Show();
            Clo.getInstance().Refresh();
            Clo.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_AddRubrics_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();
            ass.Show();
            ass.Refresh();
            ass.Location = this.Location;
            this.Close();
        }

        private void btn_AssessmentComponent_Click(object sender, EventArgs e)
        {
            AssessmentComponent ass = new AssessmentComponent();
            ass.Show();
            ass.Refresh();
            ass.Location = this.Location;
            this.Close();
        }

        private void btn_ClassAttendance_Click(object sender, EventArgs e)
        {
            Class_Attendance.getInstance().Show();
            Class_Attendance.getInstance().Refresh();
            Class_Attendance.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_StudentAttendance_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
            at.Refresh();
            at.Location = this.Location;
            this.Close();
        }

        private void btn_RubricLevel_Click(object sender, EventArgs e)
        {
            RubricLevel RL = new RubricLevel();
            RL.Show();
            RL.Refresh();
            RL.Location = this.Location;
            this.Close();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Assessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Results R = new Results();
            R.AddAssessmentComponentToComboBox(cmb_AssessmentComponent, cmb_Assessment.Text);
        }

        private void cmb_AssessmentComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Results R = new Results();
            R.AddRubricToComboBox(cmb_Rubrics, cmb_AssessmentComponent.Text);
        }

        private void cmb_Rubrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Results R = new Results();
            R.AddRubricLevelToComboBox(cmb_RubricLevel, cmb_Rubrics.Text);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Results R = new Results();

            R.studentId = R.getStudentIdFromReg(cmb_Student.Text);
            R.assessmentComponentId = R.getAssessmentComponentIdFromName(cmb_AssessmentComponent.Text);
            R.rubricMeasurementId = R.getRubricLevelIdFromRubricLevelDetails(cmb_RubricLevel.Text);

            R.Add();

            DataTable dt = R.ShowInGrid();
            dataGridView1.DataSource = dt;

            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = R.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][0]));

                int k1 = R.getRubricIdFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));
                dataGridView1.Rows[i].Cells[5].Value = R.getRubDetailsFromRubId(k1);

                dataGridView1.Rows[i].Cells[6].Value = R.getAssessmentCompNameFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));

                dataGridView1.Rows[i].Cells[7].Value = R.getTotalMarksFromAssessmentCompId(Convert.ToInt32(dt.Rows[i][1]));

                dataGridView1.Rows[i].Cells[8].Value = R.getMeasurementLevelFromRubricLevelId(Convert.ToInt32(dt.Rows[i][2]));

                float ObtainedMarks = (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value)) / 4;
                dataGridView1.Rows[i].Cells[9].Value = ObtainedMarks;
            }


        }

        private void btn_AddRubric_Click(object sender, EventArgs e)
        {
            //Rubric.getInstance().Show();

            //Rubrics r = new Rubrics();
            //Rubric.getInstance().cmb_CLO.Items.Clear();
            //r.AddToComboBox(Rubric.getInstance().cmb_CLO);

            //Rubric.getInstance().Refresh();
            //Rubric.getInstance().Location = this.Location;
            //this.Hide();
        }

        private void cmb_RubricLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
