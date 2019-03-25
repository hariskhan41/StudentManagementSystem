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
    public partial class RubricLevel : Form
    {
        private static RubricLevel instance;
        public RubricLevel()
        {
            InitializeComponent();
        }

        public static RubricLevel getInstance()
        {
            if (instance == null)
            {
                instance = new RubricLevel();
            }
            return instance;
        }

        private void RubricLevel_Load(object sender, EventArgs e)
        {
            btn_RubricLevel.Enabled = false;
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
    }
}
