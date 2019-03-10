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
        int id;
        public AddStudents()
        {
            InitializeComponent();
        }

        private void lbl_Status_Click(object sender, EventArgs e)
        {

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {/*
                string firstName = txt_FirstName.Text;
                string lastName = txt_LastName.Text;
                string contact = txt_Contact.Text;
                string email = txt_Email.Text;
                string registrationNo = txt_RegistrationNo.Text;
                string status = txt_Status.Text;*/

                AddStudent s = new AddStudent();
                
                s.firstName = txt_FirstName.Text;
                s.lastName = txt_LastName.Text;
                s.contact = txt_Contact.Text;
                s.email = txt_Email.Text;
                s.registrationNo = txt_RegistrationNo.Text;
                string s1 = txt_Status.Text;

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

                lbl_ErrorStatus.Text = s.ErrorStatus(s1);
                lbl_ErrorStatus.ForeColor = System.Drawing.Color.Red;
                lbl_ErrorStatus.Refresh();
                //s.status = Convert.ToInt32(s1);


                if (lbl_ErrorFirstName.Text == "" && lbl_ErrorLastName.Text == "" && lbl_ErrorContact.Text == "" && lbl_ErrorEmail.Text == "" && lbl_ErrorRegistrationNo.Text == "" && lbl_ErrorStatus.Text == "")
                {
                    s.status = Convert.ToInt32(s1);
                    DataTable dt = new DataTable();
                    dt = s.addStudent();
                    dataGridView1.DataSource = dt;
                    /*dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.ColumnCount = 8;

                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[0].DataPropertyName = "id";

                    dataGridView1.Columns[1].HeaderText = "First Name";
                    dataGridView1.Columns[1].DataPropertyName = "FirstName";

                    dataGridView1.Columns[2].HeaderText = "Last Name";
                    dataGridView1.Columns[2].DataPropertyName = "LastName";

                    dataGridView1.Columns[3].HeaderText = "Contact";
                    dataGridView1.Columns[3].DataPropertyName = "Contact";

                    dataGridView1.Columns[4].HeaderText = "Email";
                    dataGridView1.Columns[4].DataPropertyName = "Email";

                    dataGridView1.Columns[5].HeaderText = "Registration Number";
                    dataGridView1.Columns[5].DataPropertyName = "RegistrationNumber";

                    dataGridView1.Columns[6].HeaderText = "status";
                    dataGridView1.Columns[6].DataPropertyName = "Status";

                    dataGridView1.DataSource = dt;*/

                    /*
                    DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                    editBtn.Name = "Edit";
                    editBtn.Text = "Edit";
                    if (dataGridView1.Columns["Edit"] == null)
                    {
                        dataGridView1.Columns.Insert(7, editBtn);
                    }

                    dataGridView1.CellClick += dataGridView1_CellContentClick;*/

                }




                /*string cmd = "INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES ('" + s.firstName + "', '" + s.lastName + "', '" + s.contact + "', '" + s.email + "', '" + s.registrationNo + "', '" + s.status + "')";
                DatabaseConnection.getInstance().exectuteQuery(cmd);*/
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            if (value == "Edit")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                id = Convert.ToInt32(id1);
                txt_FirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txt_LastName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txt_Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                txt_RegistrationNo.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                txt_Status.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

                

            }
            else if (value == "Delete")
            {
                string id1 = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                id = Convert.ToInt32(id1);

                AddStudent s = new AddStudent();
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
            string s1 = txt_Status.Text;

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

            lbl_ErrorStatus.Text = s.ErrorStatus(s1);
            lbl_ErrorStatus.ForeColor = System.Drawing.Color.Red;
            lbl_ErrorStatus.Refresh();


            if (lbl_ErrorFirstName.Text == "" && lbl_ErrorLastName.Text == "" && lbl_ErrorContact.Text == "" && lbl_ErrorEmail.Text == "" && lbl_ErrorRegistrationNo.Text == "" && lbl_ErrorStatus.Text == "")
            {
                s.status = Convert.ToInt32(s1);
                DataTable dt = new DataTable();
                dt = s.Edit(id);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
