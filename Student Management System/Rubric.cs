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
    public partial class Rubric : Form
    {
        int id;
        int idEdit;

        private static Rubric instance;
        public Rubric()
        {
            InitializeComponent();
        }

        public static Rubric getInstance()
        {
            if (instance == null)
            {
                instance = new Rubric();
            }
            return instance;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Rubrics r = new Rubrics();
            id = r.getId();
            if (id == -1)
            {
                id = 0;
            }
            else
            {
                id++;
            }
            r.Id = id;
            r.Details = txt_Details.Text;
            r.CloId = r.getCloId(cmb_CLO.Text);
            r.AddRubric();
            DataTable dt = r.ShowInGrid();
            dataGridView1.DataSource = dt;
            txt_Details.Clear();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);

            btn_AddRubrics.Enabled = false;
            btn_AddRubrics.BackColor = Color.Gray;

            Rubrics r = new Rubrics();
            r.AddToComboBox(cmb_CLO);
            DataTable dt = r.ShowInGrid();
            dataGridView1.DataSource = dt;

            btn_Update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            if (value == "Edit")
            {
                Rubrics r1 = new Rubrics();
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                idEdit = Convert.ToInt32(id1);

                txt_Details.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                int cloid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());

                string CloName = r1.getCloNameById(cloid);

                cmb_CLO.Text = CloName;
                btn_Add.Enabled = false;
                btn_Update.Enabled = true;
                //cmb_CLO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                idEdit = Convert.ToInt32(id1);

                Rubrics r = new Rubrics();
                r.Delete(idEdit);
                DataTable dt = r.ShowInGrid();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Rubrics r2 = new Rubrics();
            r2.Details = txt_Details.Text;
            r2.CloId = r2.getCloId(cmb_CLO.Text);
            r2.Edit(idEdit);
            DataTable dt = r2.ShowInGrid();
            dataGridView1.DataSource = dt;
            txt_Details.Clear();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Details.Clear();
            btn_Update.Enabled = false;
            btn_Add.Enabled = true;
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
    }
}
