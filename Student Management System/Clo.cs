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
    public partial class Clo : Form
    {
        int id;
        string dateCreated;

        private static Clo instance;

        public Clo()
        {
            InitializeComponent();
        }

        public static Clo getInstance()
        {
            if (instance == null)
            {
                instance = new Clo();
            }
            return instance;
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddClo c = new AddClo();
            c.name = txt_CloName.Text;
            c.dateCreated = DateTime.Now;
            c.dateUpdated = DateTime.Now;

            lbl_ErrorName.Text = c.ErrorName(c.name);
            lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorName.Refresh();
            if (string.IsNullOrEmpty(txt_CloName.Text))
            {
                lbl_ErrorName.Text = "Invalid Clo Name";
                lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorName.Refresh();
            }
            else if (lbl_ErrorName.Text == "")
            {
                
                if (c.CloAlreadyExist(txt_CloName.Text))
                {
                    MessageBox.Show("CLO Aready Exists");
                }
                else
                {
                    c.add();
                    txt_CloName.Clear();
                    DataTable dt = c.ShowInGrid();
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void Clo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);

            lbl_ErrorName.Text = "";

            btn_AddClo.Enabled = false;
            btn_AddClo.BackColor = Color.Gray;

            AddClo c = new AddClo();
            DataTable dt = c.ShowInGrid();
            dataGridView1.DataSource = dt;

            btn_Update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            AddClo c = new AddClo();
            c.name = txt_CloName.Text;
            c.dateUpdated = DateTime.Now;
            DataTable dt = c.Edit(id);
            dataGridView1.DataSource = dt;
            txt_CloName.Clear();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                btn_Add.Enabled = false;
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_CloName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                dateCreated = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                btn_Add.Enabled = false;
                btn_Update.Enabled = true;
            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                AddClo c = new AddClo();
                c.Delete(id);
                //c.ShowInGrid();
                DataTable dt = c.ShowInGrid();
                dataGridView1.DataSource = dt;
                btn_Update.Enabled = false;
            }
        }

        private void btn_AddStudents_Click(object sender, EventArgs e)
        {
            AddStudents.getInstance().Show();
            AddStudents.getInstance().Refresh();
            AddStudents.getInstance().Location = this.Location;
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_CloName.Clear();
            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
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

        private void btn_RubricLevel_Click(object sender, EventArgs e)
        {
            RubricLevel RL = new RubricLevel();
            RL.Show();
            RL.Refresh();
            RL.Location = this.Location;
            this.Hide();
        }
    }
}
