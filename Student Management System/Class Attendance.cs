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
    public partial class Class_Attendance : Form
    {
        private static Class_Attendance instance;
        int id;

        public static Class_Attendance getInstance()
        {
            if (instance == null)
            {
                instance = new Class_Attendance();
            }
            return instance;
        }

        public Class_Attendance()
        {
            InitializeComponent();
        }

        private void Class_Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet10.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet10.ClassAttendance);

            btn_ClassAttendace.BackColor = Color.Gray;
            btn_ClassAttendace.Enabled = false;
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;

            MarkAttendance MA = new MarkAttendance();
            DataTable dt = MA.ShowClassAttInGrid();
            dataGridView1.DataSource = dt;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MarkAttendance MA = new MarkAttendance();
            MA.attendanceDate = dateCalender.SelectionEnd;

            string s = MA.DateAlreadyExist(MA.attendanceDate);
            if (s == "")
            {
                MA.AddAttendanceDate();
                DataTable dt = MA.ShowClassAttInGrid();
                dataGridView1.DataSource = dt;

                dateCalender.SetDate(DateTime.Now);
            }
            else
            {
                MessageBox.Show(s);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                btn_Update.Enabled = true;
                btn_Add.Enabled = false;
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                string date1 = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                DateTime d1 = Convert.ToDateTime(date1); 
                dateCalender.SetDate(d1);
            }
        }

        private void btn_AddStudents_Click(object sender, EventArgs e)
        {
            AddStudents.getInstance().Show();
            AddStudents.getInstance().Refresh();
            AddStudents.getInstance().Location = this.Location;
            this.Hide();
        }

        private void btn_AddClo_Click(object sender, EventArgs e)
        {
            Clo.getInstance().Show();
            Clo.getInstance().Refresh();
            Clo.getInstance().Location = this.Location;
            this.Hide();
        }

        private void btn_AddRubrics_Click(object sender, EventArgs e)
        {
            Rubric.getInstance().Show();
            Rubric.getInstance().Refresh();
            Rubric.getInstance().Location = this.Location;
            this.Hide();
        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            Assessment.getInstance().Show();
            Assessment.getInstance().Refresh();
            Assessment.getInstance().Location = this.Location;
            this.Hide();
        }

        private void btn_AssessmentComponent_Click(object sender, EventArgs e)
        {
            AssessmentComponent ass = new AssessmentComponent();
            ass.Show();
            ass.Refresh();
            ass.Location = this.Location;
            this.Hide();
        }

        private void btn_ClassAttendace_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentAttendance_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
            at.Refresh();
            at.Location = this.Location;
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MarkAttendance MA = new MarkAttendance();

            MA.attendanceDate = dateCalender.SelectionEnd;
            MA.EditClassAttDate(id);
            DataTable dt = MA.ShowClassAttInGrid();
            dataGridView1.DataSource = dt;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            dateCalender.SetDate(DateTime.Now);
        }
    }
}
