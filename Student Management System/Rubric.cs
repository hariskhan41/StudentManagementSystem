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
        public Rubric()
        {
            InitializeComponent();
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
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);
            Rubrics r = new Rubrics();
            r.AddToComboBox(cmb_CLO);
            DataTable dt = r.ShowInGrid();
            dataGridView1.DataSource = dt;
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
        }
    }
}
