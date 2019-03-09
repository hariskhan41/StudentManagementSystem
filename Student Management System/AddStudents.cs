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
                    s.addStudent();
                }




                /*string cmd = "INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES ('" + s.firstName + "', '" + s.lastName + "', '" + s.contact + "', '" + s.email + "', '" + s.registrationNo + "', '" + s.status + "')";
                DatabaseConnection.getInstance().exectuteQuery(cmd);*/
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }
    }
}
