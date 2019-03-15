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
    class AddStudent
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string contact { get; set; }

        public string email { get; set; }

        public string registrationNo { get; set; }

        public int status { get; set; }

        public string errorFirstName { get; set; }

        public string errorLastName { get; set; }

        public string errorContact { get; set; }

        public string errorEmail { get; set; }

        public string errorRegistrationNo { get; set; }

        public string errorStatus { get; set; }


        /// <summary>
        /// Add items to combobox from sql table.
        /// </summary>
        /// <param name="cmb">ComboBox object in which item list is to be stored</param>
        public void AddToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Lookup";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }

        /// <summary>
        /// Get Lookup Id from Lookup Table using status
        /// </summary>
        /// <param name="input">Status as input. Status has value: Active, Inavtive, Present, Absent etc.</param>
        /// <returns></returns>
        public int getLookupIdByStatus(string input)
        {
            int Lid = 0;
            string cmd = "SELECT * FROM Lookup WHERE Name = '" + input + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                Lid = d.GetInt32(0);
                break;
            }
            return Lid;
        }


        /// <summary>
        /// Finds Name of status i.e Active, Inactive, Present, Absent etc from Lookup table using Lookup Id.
        /// </summary>
        /// <param name="id">Lookup Id coming from Students' table, status</param>
        /// <returns>Return Name coressponding to lookup Id</returns>
        public string getCategoryNameById(int id)
        {
            string CategoryName = "";
            string cmd = "SELECT * FROM Lookup WHERE LookupId = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                CategoryName = d.GetString(1);
                break;
            }
            return CategoryName;
        }


        /// <summary>
        /// Checks if Entered string contains digit or not
        /// </summary>
        /// <param name="input">Input string by user to be checked</param>
        /// <returns>Returns false if string has digit</returns>
        public bool isDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) == true)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if contact number is valid i.e it only have digits.
        /// </summary>
        /// <param name="input">Contact number string entered by user</param>
        /// <returns>Returns true if string has anything other than digits</returns>
        public bool isContact(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) == false)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if email is in correct format.
        /// </summary>
        /// <param name="input">Input email string by user.</param>
        /// <returns>Returns treu if email is in correct format.</returns>
        public bool isEmail(string input)
        {
            int c1 = 0;
            int c2 = 0;
            
            foreach (char c in input)
            {
                if (c == '@')
                {
                    c1++;
                }
                else if (c == '.')
                {
                    c2++;
                }
            }
            if (c1 != 1 || c2 != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        /// <summary>
        /// Checks if first Name is in correct format i.e it only have ketters
        /// </summary>
        /// <param name="input">input first name string entered by user</param>
        /// <returns>Return Invalid first name if name has anything other than letters</returns>
        public string ErrorFirstName(string input)
        {
            errorFirstName = "";
            if (isDigit(firstName) == false || string.IsNullOrEmpty(input))
            {
                errorFirstName = "Invalid First Name!";
            }
            return errorFirstName;
        }


        /// <summary>
        /// Checks if Last Name is in correct format i.e it only have ketters
        /// </summary>
        /// <param name="input">input Last name string entered by user</param>
        /// <returns>Return Invalid Last name if name has anything other than letters</returns>
        public string ErrorLastName(string input)
        {
            errorLastName = "";
            if (isDigit(lastName) == false || string.IsNullOrEmpty(input))
            {
                errorLastName = "Invalid Last Name!";
            }
            return errorLastName;
        }

        /// <summary>
        /// Checks if contact number is correct.
        /// </summary>
        /// <param name="input">input contact number string by user.</param>
        /// <returns>Returns Invalid contact string if contact is not correct</returns>
        public string ErrorContact(string input)
        {
            errorContact = "";
            if (isContact(contact) == true || contact.Length != 11 || string.IsNullOrEmpty(input))
            {
                errorContact = "Invalid Contact";
            }
            return errorContact;
        }

        /// <summary>
        /// Checks if Email is in correct format
        /// </summary>
        /// <param name="input">input Email string entered by user</param>
        /// <returns>Return Invalid Email if email has anything other than letters</returns>
        public string ErrorEmail(string input)
        {
            errorEmail = "";
            if (isEmail(input) == false || string.IsNullOrEmpty(input))
            {
                errorEmail = "Invalid Email! (syntax: abc@example.com)";
            }
            return errorEmail;
        }

        /// <summary>
        /// Checks if Registration No is in correct format i.e it only have ketters
        /// </summary>
        /// <param name="input">input Registration string entered by user</param>
        /// <returns>Return Invalid Registration Number if it has anything other than letters</returns>
        public string ErrorRegistrationNo(string input)
        {
            errorRegistrationNo = "";
            char[] arr1 = new char[12];
            int count = input.Length;
            //char[] arr2;
            if (count != 11 && count != 12)
            {
                errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                return errorRegistrationNo;
            }
            else if (string.IsNullOrEmpty(input))
            {
                errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                return errorRegistrationNo;
            }
            else
            {
                int i = 0;
                foreach (char c in input)
                {
                    arr1[i] = c;
                    i++;
                }
                if (input.Length == 11)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (!char.IsDigit(arr1[j]))
                        {
                            errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XX-999)";
                            return errorRegistrationNo;
                        }
                    }
                    if (arr1[4] != '-' || arr1[7] != '-')
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XX-999)";
                        return errorRegistrationNo;
                    }
                    else if (char.IsDigit(arr1[5]) || char.IsDigit(arr1[6]))
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XX-999)";
                        return errorRegistrationNo;
                    }
                    else if (!char.IsDigit(arr1[8]) || !char.IsDigit(arr1[9]) || !char.IsDigit(arr1[10]))
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XX-999)";
                        return errorRegistrationNo;
                    }
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (!char.IsDigit(arr1[j]))
                        {
                            errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                            return errorRegistrationNo;
                        }
                    }
                    if (arr1[4] != '-' || arr1[8] != '-')
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                        return errorRegistrationNo;
                    }
                    else if (char.IsDigit(arr1[5]) || char.IsDigit(arr1[6]) || char.IsDigit(arr1[7]))
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                        return errorRegistrationNo;
                    }
                    else if (!char.IsDigit(arr1[9]) || !char.IsDigit(arr1[10]) || !char.IsDigit(arr1[11]))
                    {
                        errorRegistrationNo = "Invalid Registration No. (syntax: 2016-XXX-999)";
                        return errorRegistrationNo;
                    }
                }
                return errorRegistrationNo;
            }
        }

        public string ErrorStatus(string input)
        {
            errorStatus = "";
            if (input.Length != 1)
            {
                errorStatus = "Invalid status";
            }
            else if (isDigit(input))
            {
                errorStatus = "Invalid status";
            }
            else if (input != "0" && input != "1")
            {
                errorStatus = "Invalid status";
            }
            return errorStatus;

        }

        /// <summary>
        /// Checks if Registration nummber or email already exist in table
        /// </summary>
        /// <returns>Returns true if record exists in table</returns>
        public bool recordAlreadyExist()
        {
            string cmd = "SELECT * FROM Student WHERE RegistrationNumber='" + registrationNo + "'OR Email='" + email + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Add students' data tu Students table and then show data in grid.
        /// </summary>
        /// <returns>Returns DataTable containing data fetched from Students Table</returns>
        public DataTable addStudent()
        {
            try
            {

                if (recordAlreadyExist())
                {
                    MessageBox.Show("Registration No or email already exist");
                }
                else
                {
                    string cmd = "INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES ('" + firstName + "', '" + lastName + "', '" + contact + "', '" + email + "', '" + registrationNo + "', '" + status + "')";
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                    MessageBox.Show("Student Added Successfully");
                }
                string cmd2 = "SELECT * FROM Student";
                SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);


                return dt;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// Update data of particular record and then show updated record in grid
        /// </summary>
        /// <param name="id">Id of particular row clicked by user whose data is to be edited</param>
        /// <returns>Returns DataTable Containing data fetched from table after updation.</returns>
        public DataTable Edit(int id)
        {
            string cmd = "UPDATE Student SET FirstName = '" + firstName + "', LastName = '" + lastName + "', Contact = '" + contact + "', Email = '" + email + "', RegistrationNumber = '" + registrationNo + "', Status = '" + status + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated!");
            string cmd2 = "SELECT * FROM Student";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Delete data of particular record and then show updated record in grid
        /// </summary>
        /// <param name="id">Id of particular row clicked by user whose data is to be Deleted</param>
        /// <returns>Returns DataTable Containing data fetched from table after deletion.</returns>
        public DataTable Delete(int id)
        {
            string cmd = "DELETE FROM Student WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Deleted!");
            string cmd2 = "SELECT * FROM Student";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd2);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;

        }


    }
}
