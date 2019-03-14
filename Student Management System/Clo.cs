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

        public Clo()
        {
            InitializeComponent();
        }





        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddClo c = new AddClo();
            c.name = txt_CloName.Text;
            c.dateCreated = DateTime.Now;
            c.dateUpdated = DateTime.Now;
            c.add();
            DataTable dt = c.ShowInGrid();
            dataGridView1.DataSource = dt;
        }

        private void Clo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);
            AddClo c = new AddClo();
            DataTable dt = c.ShowInGrid();
            dataGridView1.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            AddClo c = new AddClo();
            c.name = txt_CloName.Text;
            c.dateUpdated = DateTime.Now;
            DataTable dt = c.Edit(id);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_CloName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                dateCreated = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                AddStudent s = new AddStudent();
                DataTable dt = new DataTable();
                dt = s.Delete(id);
                dataGridView1.DataSource = dt;

            }
        }
    }
}
