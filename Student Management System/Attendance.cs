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
            btn_Attendance.BackColor = Color.Gray;
            btn_Attendance.Enabled = false;
        }
    }
}
