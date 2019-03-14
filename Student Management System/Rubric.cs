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
        public Rubric()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Rubrics r = new Rubrics();
            id = r.getId();
            r.Id = id;
            r.Details = txt_Details.Text;
            

        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            Rubrics r = new Rubrics();
            r.AddToComboBox(cmb_CLO);
        }
    }
}
