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
    public partial class RubricLevel : Form
    {
        private static RubricLevel instance;
        int id;
        public RubricLevel()
        {
            InitializeComponent();
        }

        public static RubricLevel getInstance()
        {
            if (instance == null)
            {
                instance = new RubricLevel();
            }
            return instance;
        }

        private void btn_AddRubrics_Click(object sender, EventArgs e)
        {
            Rubric.getInstance().Show();

            Rubrics r = new Rubrics();
            Rubric.getInstance().cmb_CLO.Items.Clear();
            r.AddToComboBox(Rubric.getInstance().cmb_CLO);

            Rubric.getInstance().Refresh();
            Rubric.getInstance().Location = this.Location;
            this.Hide();
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

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            Assessment.getInstance().Show();
            Assessment.getInstance().Refresh();
            Assessment.getInstance().Location = this.Location;
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

        private void RubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet12.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet12.RubricLevel);

            btn_RubricLevel.BackColor = Color.Gray;
            btn_RubricLevel.Enabled = false;

            RubricLevels RL = new RubricLevels();
            RL.AddToComboBox(cmb_Rubric);

            DataTable dt = RL.ShowInGrid();
            dataGridView1.DataSource = dt;
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                string s1 = RL.getDetailsFromRubricId(Convert.ToInt32(dt.Rows[i][1]));
                dataGridView1.Rows[i].Cells[2].Value = s1;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RubricLevels RL = new RubricLevels();

            lbl_ErrorMeasurementLevel.Text = RL.ValidMeasurementLevel(txt_MeasurementLevel.Text);
            lbl_ErrorMeasurementLevel.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorMeasurementLevel.Refresh();
            if (RL.DetailsAlreadyExist(txt_Details.Text) == "")
            {
                if (lbl_ErrorMeasurementLevel.Text == "")
                {
                    RL.rubricId = RL.getRubricIdFromRubricDetails(cmb_Rubric.Text);
                    RL.details = txt_Details.Text;
                    RL.measurementLevel = Convert.ToInt32(txt_MeasurementLevel.Text);

                    RL.Add();
                    DataTable dt = RL.ShowInGrid();
                    dataGridView1.DataSource = dt;
                    int count = dt.Rows.Count;
                    for (int i = 0; i < count; i++)
                    {
                        string s1 = RL.getDetailsFromRubricId(Convert.ToInt32(dt.Rows[i][1]));
                        dataGridView1.Rows[i].Cells[2].Value = s1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Details should be unique");
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                cmb_Rubric.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txt_Details.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_MeasurementLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            RubricLevels RL = new RubricLevels();

            lbl_ErrorMeasurementLevel.Text = RL.ValidMeasurementLevel(txt_MeasurementLevel.Text);
            lbl_ErrorMeasurementLevel.ForeColor = System.Drawing.Color.Gray;
            lbl_ErrorMeasurementLevel.Refresh();

            if (lbl_ErrorMeasurementLevel.Text == "")
            {
                RL.rubricId = RL.getRubricIdFromRubricDetails(cmb_Rubric.Text);
                RL.details = txt_Details.Text;
                RL.measurementLevel = Convert.ToInt32(txt_MeasurementLevel.Text);

                RL.Edit(id);
                DataTable dt = RL.ShowInGrid();
                dataGridView1.DataSource = dt;
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string s1 = RL.getDetailsFromRubricId(Convert.ToInt32(dt.Rows[i][1]));
                    dataGridView1.Rows[i].Cells[2].Value = s1;
                }
            }
        }
    }
}
