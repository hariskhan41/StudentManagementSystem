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
    public partial class AssessmentComponent : Form
    {
        int id;
        private static AssessmentComponent instance;
        public AssessmentComponent()
        {
            InitializeComponent();
        }


        public static AssessmentComponent getInstance()
        {
            if (instance == null)
            {
                instance = new AssessmentComponent();
            }
            return instance;
        }


        private void btn_AssessmentComponent_Click(object sender, EventArgs e)
        {
            
        }

        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet5.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter1.Fill(this.projectBDataSet5.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet4.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet4.AssessmentComponent);
            btn_AssessmentComponent.BackColor = Color.Gray;
            btn_AssessmentComponent.Enabled = false;
            btn_Update.Enabled = false;
            btn_Add.Enabled = true;

            AssessmentComponents ass = new AssessmentComponents();
            ass.AddAssessmentTitleToCombobox(cmb_AssessmentTitle);
            ass.AddRubricDetailsToCombobox(cmb_RubricDetails);



            DataTable dt = ass.ShowInGrid();
            int count = dt.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                string s = ass.getAssessmentTitleFromId(Convert.ToInt32(dt.Rows[i][6]));
                string s1 = ass.getRubricDetailFromId(Convert.ToInt32(dt.Rows[i][2]));

                dataGridView1.Rows[i].Cells[3].Value = s1;
                dataGridView1.Rows[i].Cells[2].Value = s;
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
            Rubric.getInstance().Show();
            Rubric.getInstance().Refresh();
            Rubric.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            Assessment.getInstance().Show();
            Assessment.getInstance().Refresh();
            Assessment.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AssessmentComponents ass = new AssessmentComponents();

            lbl_ErrorName.Text = ass.ValidName(txt_Name.Text);
            lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorName.Refresh();


            lbl_ErrorTotalMarks.Text = ass.ValidTotalMarks(txt_TotalMarks.Text);
            lbl_ErrorTotalMarks.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalMarks.Refresh();

            if (lbl_ErrorName.Text == "" && lbl_ErrorTotalMarks.Text == "")
            {
                ass.name = txt_Name.Text;
                ass.assessmentTitle = cmb_AssessmentTitle.Text;
                ass.rubricDetails = cmb_RubricDetails.Text;
                ass.totalMarks = Convert.ToInt32(txt_TotalMarks.Text);
                ass.AssessmentId = ass.getAssessmentIdFromTitle(ass.assessmentTitle);
                ass.RubricId = ass.getRubricIdFromDetails(ass.rubricDetails);
                ass.Add();
                DataTable dt = ass.ShowInGrid();
                int count = dt.Rows.Count;
                dataGridView1.DataSource = dt;
                for (int i = 0; i < count; i++)
                {
                    string s = ass.getAssessmentTitleFromId(Convert.ToInt32(dt.Rows[i][6]));
                    string s1 = ass.getRubricDetailFromId(Convert.ToInt32(dt.Rows[i][2]));

                    dataGridView1.Rows[i].Cells[3].Value = s1;
                    dataGridView1.Rows[i].Cells[2].Value = s;
                }
                txt_Name.Clear();
                txt_TotalMarks.Clear();
                cmb_AssessmentTitle.Text = "";
                cmb_RubricDetails.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmb_AssessmentTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                cmb_RubricDetails.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_TotalMarks.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

                btn_Update.Enabled = true;
                btn_Add.Enabled = false;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            AssessmentComponents ass = new AssessmentComponents();

            lbl_ErrorName.Text = ass.ValidName(txt_Name.Text);
            lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorName.Refresh();

            lbl_ErrorTotalMarks.Text = ass.ValidTotalMarks(txt_TotalMarks.Text);
            lbl_ErrorTotalMarks.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalMarks.Refresh();

            if (lbl_ErrorName.Text == "" || lbl_ErrorTotalMarks.Text == "")
            {
                ass.name = txt_Name.Text;
                ass.totalMarks = Convert.ToInt32(txt_TotalMarks.Text);

                ass.AssessmentId = ass.getAssessmentIdFromTitle(cmb_AssessmentTitle.Text);
                ass.RubricId = ass.getRubricIdFromDetails(cmb_RubricDetails.Text);

                ass.Edit(id);

                DataTable dt = ass.ShowInGrid();
                int count = dt.Rows.Count;
                dataGridView1.DataSource = dt;
                for (int i = 0; i < count; i++)
                {
                    string s = ass.getAssessmentTitleFromId(Convert.ToInt32(dt.Rows[i][6]));
                    string s1 = ass.getRubricDetailFromId(Convert.ToInt32(dt.Rows[i][2]));

                    dataGridView1.Rows[i].Cells[3].Value = s1;
                    dataGridView1.Rows[i].Cells[2].Value = s;
                }
                txt_Name.Clear();
                txt_TotalMarks.Clear();
                cmb_AssessmentTitle.Text = "";
                cmb_RubricDetails.Text = "";

                btn_Add.Enabled = true;
                btn_Update.Enabled = false;
            }
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
            at.Refresh();
            at.Location = this.Location;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_TotalMarks.Clear();
            cmb_AssessmentTitle.Text = "";
            cmb_RubricDetails.Text = "";
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void btn_ClassAttendance_Click(object sender, EventArgs e)
        {
            Class_Attendance.getInstance().Show();
            Class_Attendance.getInstance().Refresh();
            Class_Attendance.getInstance().Location = this.Location;
            this.Close();
        }
    }
}
