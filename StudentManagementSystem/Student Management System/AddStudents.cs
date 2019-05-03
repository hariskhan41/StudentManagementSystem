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
    public partial class AddStudents : Form
    {
        private static AddStudents instance;
        int id;
        public AddStudents()
        {
            InitializeComponent();
        }

        public static AddStudents getInstance()
        {
            if (instance == null)
            {
                instance = new AddStudents();
            }
            return instance;
        }
        

        private void lbl_Status_Click(object sender, EventArgs e)
        {

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

            AddStudent s = new AddStudent();
            s.AddToComboBox(cmb_Status);
            cmb_Status.Text = cmb_Status.Items[0].ToString();

            btn_AddStudents.Enabled = false;
            btn_Update.Enabled = false;
            btn_AddStudents.BackColor = Color.Gray;
            lbl_ErrorFirstName.Text = "";
            lbl_ErrorLastName.Text = "";
            lbl_ErrorRegistrationNo.Text = "";
            lbl_ErrorEmail.Text = "";
            lbl_ErrorContact.Text = "";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                AddStudent s = new AddStudent();
                
                s.firstName = txt_FirstName.Text;
                s.lastName = txt_LastName.Text;
                s.contact = txt_Contact.Text;
                s.email = txt_Email.Text;
                s.registrationNo = txt_RegistrationNo.Text;
                //string s1 = txt_Status.Text;

                lbl_ErrorFirstName.Text = s.ErrorFirstName(s.firstName);
                lbl_ErrorFirstName.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorFirstName.Refresh();
                
                lbl_ErrorLastName.Text = s.ErrorLastName(s.lastName);
                lbl_ErrorLastName.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorLastName.Refresh();

                lbl_ErrorContact.Text = s.ErrorContact(s.contact);
                lbl_ErrorContact.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorContact.Refresh();

                lbl_ErrorEmail.Text = s.ErrorEmail(s.email);
                lbl_ErrorEmail.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorEmail.Refresh();

                lbl_ErrorRegistrationNo.Text = s.ErrorRegistrationNo(s.registrationNo);
                lbl_ErrorRegistrationNo.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorRegistrationNo.Refresh();
                
                if (lbl_ErrorFirstName.Text == "" && lbl_ErrorLastName.Text == "" && lbl_ErrorContact.Text == "" && lbl_ErrorEmail.Text == "" && lbl_ErrorRegistrationNo.Text == "")
                {
                    //s.status = Convert.ToInt32(s1);
                    s.status = s.getLookupIdByStatus(cmb_Status.Text);
                    DataTable dt = new DataTable();
                    dt = s.addStudent();

                    dataGridView1.DataSource = dt;

                    txt_FirstName.Clear();
                    txt_LastName.Clear();
                    txt_Contact.Clear();
                    txt_Email.Clear();
                    txt_RegistrationNo.Clear();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            AddStudent s = new AddStudent();
            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_FirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txt_LastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txt_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txt_RegistrationNo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                cmb_Status.Text = s.getCategoryNameById(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString()));
                //txt_Status.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                btn_Add.Enabled = false;
                btn_Update.Enabled = true;
            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                
                DataTable dt = new DataTable();
                dt = s.Delete(id);
                dataGridView1.DataSource = dt;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            AddStudent s = new AddStudent();

            s.firstName = txt_FirstName.Text;
            s.lastName = txt_LastName.Text;
            s.contact = txt_Contact.Text;
            s.email = txt_Email.Text;
            s.registrationNo = txt_RegistrationNo.Text;

            lbl_ErrorFirstName.Text = s.ErrorFirstName(s.firstName);
            lbl_ErrorFirstName.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorFirstName.Refresh();

            lbl_ErrorLastName.Text = s.ErrorLastName(s.lastName);
            lbl_ErrorLastName.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorLastName.Refresh();

            lbl_ErrorContact.Text = s.ErrorContact(s.contact);
            lbl_ErrorContact.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorContact.Refresh();

            lbl_ErrorEmail.Text = s.ErrorEmail(s.email);
            lbl_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorEmail.Refresh();

            lbl_ErrorRegistrationNo.Text = s.ErrorRegistrationNo(s.registrationNo);
            lbl_ErrorRegistrationNo.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorRegistrationNo.Refresh();
            

            if (lbl_ErrorFirstName.Text == "" && lbl_ErrorLastName.Text == "" && lbl_ErrorContact.Text == "" && lbl_ErrorEmail.Text == "" && lbl_ErrorRegistrationNo.Text == "")
            {
                s.status = s.getLookupIdByStatus(cmb_Status.Text);
                //s.status = Convert.ToInt32(s1);
                DataTable dt = new DataTable();
                dt = s.Edit(id);
                dataGridView1.DataSource = dt;
                txt_FirstName.Clear();
                txt_LastName.Clear();
                txt_Contact.Clear();
                txt_Email.Clear();
                txt_RegistrationNo.Clear();
                btn_Add.Enabled = true;
                btn_Update.Enabled = false;
            }
        }

        private void btn_AddStudents_Click(object sender, EventArgs e)
        {
            
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

            Rubrics r = new Rubrics();
            Rubric.getInstance().cmb_CLO.Items.Clear();
            r.AddToComboBox(Rubric.getInstance().cmb_CLO);

            Rubric.getInstance().Refresh();
            Rubric.getInstance().Location = this.Location;
            this.Hide();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Contact.Clear();
            txt_Email.Clear();
            txt_RegistrationNo.Clear();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void btn_RubricLevel_Click(object sender, EventArgs e)
        {
            RubricLevel.getInstance().Show();
            RubricLevel.getInstance().Refresh();
            RubricLevel.getInstance().Location = this.Location;
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

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
            at.Refresh();
            at.Location = this.Location;
            this.Hide();
        }

        private void btn_ClassAttendance_Click(object sender, EventArgs e)
        {
            Class_Attendance.getInstance().Show();
            Class_Attendance.getInstance().Refresh();
            Class_Attendance.getInstance().Location = this.Location;
            this.Hide();
        }

        private void btn_RubricLevel_Click_1(object sender, EventArgs e)
        {
            RubricLevel RL = new RubricLevel();
            RL.Show();
            RL.Refresh();
            RL.Location = this.Location;
            this.Hide();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            Result R = new Result();
            R.Show();
            R.Refresh();
            R.Location = this.Location;
            this.Hide();
        }
    }
}
