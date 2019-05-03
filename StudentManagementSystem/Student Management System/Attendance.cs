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
    public partial class Attendance : Form
    {
        int idReg;
        int idDate;

        public Attendance()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {

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

        private void btn_AssessmentComponent_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();
            ass.Show();
            ass.Refresh();
            ass.Location = this.Location;
            this.Close();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet9.StudentAttendance' table. You can move, or remove it, as needed.
            this.studentAttendanceTableAdapter.Fill(this.projectBDataSet9.StudentAttendance);
            btn_StudentAttendance.BackColor = Color.Gray;
            btn_StudentAttendance.Enabled = false;
            btn_Update.Enabled = false;
            btn_Mark.Enabled = true;


            MarkAttendance MA = new MarkAttendance();
            MA.AddRegToComboBox(cmb_RegNo);
            MA.AddStatusToComboBox(cmb_Status);
            MA.AddDatesToComboBox(cmb_Date);

            cmb_Date.Enabled = true;
            cmb_RegNo.Enabled = true;

            //cmb_Date.Enabled = false;


            
            //cmb_RegNo.Text = cmb_RegNo.Items[0].ToString();
            //cmb_Status.Text = cmb_Status.Items[0].ToString();
            
            //string a = cmb_Date.Items[0].ToString();
            //DateTime dt1 = Convert.ToDateTime(a);
            //cmb_Date.Text = dt1.ToString(@"yyyy-MM-dd");

            //MarkAttendance MA = new MarkAttendance();
            DataTable dt = MA.ShowStudentAttendanceInGrid();
            //cmb_Date.Text = a;
            dataGridView1.DataSource = dt;
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DateTime s1 = MA.getDateFromAttId(Convert.ToInt32(dt.Rows[i][0]));
                dataGridView1.Rows[i].Cells[5].Value = s1.ToString(@"yyyy-MM-dd");

                string s2 = MA.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][1]));
                dataGridView1.Rows[i].Cells[3].Value = s2;

                string s3 = MA.getStatusFromLookupId(Convert.ToInt32(dt.Rows[i][2]));
                dataGridView1.Rows[i].Cells[4].Value = s3;
            }


        }

        private void btn_ClassAttendance_Click(object sender, EventArgs e)
        {
            Class_Attendance.getInstance().Show();
            Class_Attendance.getInstance().Refresh();
            Class_Attendance.getInstance().Location = this.Location;
            this.Close();
        }

        private void btn_Mark_Click(object sender, EventArgs e)
        {
            if (cmb_Date.Text == "" || cmb_RegNo.Text == "" || cmb_Status.Text == "")
            {
                MessageBox.Show("Select an option from all of the lists");
            }
            else
            {
                MarkAttendance MA = new MarkAttendance();

                MA.attendanceId = MA.getAttIdFromDate(Convert.ToDateTime(cmb_Date.Text));
                MA.studentId = MA.getStudentIdFromReg(cmb_RegNo.Text);
                MA.attendanceStatus = MA.getlookupIdFromAttStatus(cmb_Status.Text);

                string t = MA.StudentAttAlreadyExist();

                if (t == "")
                {
                    MA.AddStatus();
                    DataTable dt = MA.ShowStudentAttendanceInGrid();
                    dataGridView1.DataSource = dt;
                    int count = dt.Rows.Count;
                    for (int i = 0; i < count; i++)
                    {
                        DateTime s1 = MA.getDateFromAttId(Convert.ToInt32(dt.Rows[i][0]));
                        dataGridView1.Rows[i].Cells[5].Value = s1.ToString(@"yyyy-MM-dd");

                        string s2 = MA.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][1]));
                        dataGridView1.Rows[i].Cells[3].Value = s2;

                        string s3 = MA.getStatusFromLookupId(Convert.ToInt32(dt.Rows[i][2]));
                        dataGridView1.Rows[i].Cells[4].Value = s3;
                    }
                    cmb_Date.Text = "";
                    cmb_RegNo.Text = "";
                    cmb_Status.Text = "";
                }
                else
                {
                    MessageBox.Show("Attendance already marked!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                btn_Mark.Enabled = false;
                btn_Update.Enabled = true;
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                idDate = Convert.ToInt32(id1);

                string id2 = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                idReg = Convert.ToInt32(id2);

                cmb_Date.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                cmb_RegNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmb_Status.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                cmb_Date.Enabled = false;
                cmb_RegNo.Enabled = false;

            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                idDate = Convert.ToInt32(id1);

                string id2 = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                idReg = Convert.ToInt32(id2);

                MarkAttendance MA = new MarkAttendance();
                MA.DeleteStudentAtt(idReg, idDate);
                DataTable dt = MA.ShowStudentAttendanceInGrid();
                dataGridView1.DataSource = dt;
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DateTime s1 = MA.getDateFromAttId(Convert.ToInt32(dt.Rows[i][0]));
                    dataGridView1.Rows[i].Cells[5].Value = s1.ToString(@"yyyy-MM-dd");

                    string s2 = MA.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][1]));
                    dataGridView1.Rows[i].Cells[3].Value = s2;

                    string s3 = MA.getStatusFromLookupId(Convert.ToInt32(dt.Rows[i][2]));
                    dataGridView1.Rows[i].Cells[4].Value = s3;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MarkAttendance MA = new MarkAttendance();
            MA.attendanceStatus = MA.getlookupIdFromAttStatus(cmb_Status.Text);
            MA.EditStudentAtt(idReg, idDate);
            DataTable dt = MA.ShowStudentAttendanceInGrid();
            dataGridView1.DataSource = dt;
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DateTime s1 = MA.getDateFromAttId(Convert.ToInt32(dt.Rows[i][0]));
                dataGridView1.Rows[i].Cells[5].Value = s1.ToString(@"yyyy-MM-dd");

                string s2 = MA.getRegNoFromStudentId(Convert.ToInt32(dt.Rows[i][1]));
                dataGridView1.Rows[i].Cells[3].Value = s2;

                string s3 = MA.getStatusFromLookupId(Convert.ToInt32(dt.Rows[i][2]));
                dataGridView1.Rows[i].Cells[4].Value = s3;
            }
            btn_Update.Enabled = false;
            btn_Mark.Enabled = true;
            cmb_Date.Text = "";
            cmb_RegNo.Text = "";
            cmb_Status.Text = "";
            cmb_Date.Enabled = true;
            cmb_RegNo.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = false;
            btn_Mark.Enabled = true;
            cmb_Date.Enabled = true;
            cmb_RegNo.Enabled = true;

            cmb_Date.Text = "";
            cmb_RegNo.Text = "";
            cmb_Status.Text = "";
        }

        private void cmb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Date_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot write here");
            cmb_Date.Text = "";
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
            Result R = new Result();
            R.Show();
            R.Refresh();
            R.Location = this.Location;
            this.Close();
        }
        //RubricLevel RL = new RubricLevel();
        //RL.Show();
        //    RL.Refresh();
        //    RL.Location = this.Location;
        //    this.Hide();
    }
}
