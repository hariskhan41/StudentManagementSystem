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
    public partial class Assessment : Form
    {
        private static Assessment instance;
        int id;

        public Assessment()
        {
            InitializeComponent();
        }


        public static Assessment getInstance()
        {
            if (instance == null)
            {
                instance = new Assessment();
            }
            return instance;
        }


        private void Assessment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet3.Assessment);

            lbl_ErrorTitle.Text = "";
            lbl_ErrorTotalMarks.Text = "";
            lbl_ErrorTotalWeightage.Text = "";

            btn_Assessment.BackColor = Color.Gray;

            btn_Assessment.Enabled = false;
            btn_Update.Enabled = false;
            btn_Add.Enabled = true;
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

            Rubrics r = new Rubrics();
            Rubric.getInstance().cmb_CLO.Items.Clear();
            r.AddToComboBox(Rubric.getInstance().cmb_CLO);

            Rubric.getInstance().Refresh();
            Rubric.getInstance().Location = this.Location;
            this.Hide();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Assessments a = new Assessments();

            lbl_ErrorTitle.Text = a.ValidTitle(txt_Title.Text);
            lbl_ErrorTitle.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTitle.Refresh();


            lbl_ErrorTotalMarks.Text = a.ValidTotalMarks(txt_TotalMarks.Text);
            lbl_ErrorTotalMarks.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalMarks.Refresh();


            lbl_ErrorTotalWeightage.Text = a.ValidTotalWeight(txt_TotalWeightage.Text);
            lbl_ErrorTotalWeightage.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalWeightage.Refresh();

            if (lbl_ErrorTitle.Text == "" && lbl_ErrorTotalMarks.Text == "" && lbl_ErrorTotalWeightage.Text == "")
            {
                a.title = txt_Title.Text;
                a.totalMarks = Convert.ToInt32(txt_TotalMarks.Text);
                a.totalWeightage = Convert.ToInt32(txt_TotalWeightage.Text);

                a.Add();
                txt_Title.Clear();
                txt_TotalMarks.Clear();
                txt_TotalWeightage.Clear();
                DataTable dt = a.ShowInGrid();
                dataGridView1.DataSource = dt;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_Title.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txt_TotalMarks.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_TotalWeightage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                Assessments a = new Assessments();
                a.Delete(id);
                DataTable dt = a.ShowInGrid();
                dataGridView1.DataSource = dt;
            }
            btn_Add.Enabled = false;
            btn_Update.Enabled = true;
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            Assessments a = new Assessments();

            lbl_ErrorTitle.Text = a.ValidTitle(txt_Title.Text);
            lbl_ErrorTitle.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTitle.Refresh();


            lbl_ErrorTotalMarks.Text = a.ValidTotalMarks(txt_TotalMarks.Text);
            lbl_ErrorTotalMarks.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalMarks.Refresh();


            lbl_ErrorTotalWeightage.Text = a.ValidTotalWeight(txt_TotalWeightage.Text);
            lbl_ErrorTotalWeightage.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorTotalWeightage.Refresh();

            if (lbl_ErrorTitle.Text == "" && lbl_ErrorTotalMarks.Text == "" && lbl_ErrorTotalWeightage.Text == "")
            {
                a.title = txt_Title.Text;
                a.totalMarks = Convert.ToInt32(txt_TotalMarks.Text);
                a.totalWeightage = Convert.ToInt32(txt_TotalWeightage.Text);

                a.Edit(id);
                DataTable dt = a.ShowInGrid();
                dataGridView1.DataSource = dt;
                txt_Title.Clear();
                txt_TotalMarks.Clear();
                txt_TotalWeightage.Clear();
                btn_Update.Enabled = false;
                btn_Add.Enabled = true;
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Title.Clear();
            txt_TotalMarks.Clear();
            txt_TotalWeightage.Clear();
            btn_Update.Enabled = false;
            btn_Add.Enabled = true;
        }

        private void btn_AssessmentComponent_Click(object sender, EventArgs e)
        {
            AssessmentComponent ass = new AssessmentComponent();
            ass.Show();
            ass.Refresh();
            ass.Location = this.Location;
            this.Hide();
        }
    }
}
