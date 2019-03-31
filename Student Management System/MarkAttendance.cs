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
    class MarkAttendance
    {
        public int attendanceId { get; set; }

        public int studentId { get; set; }

        public int attendanceStatus { get; set; }

        public int id { get; set; }

        public DateTime attendanceDate { get; set; }


        /// <summary>
        /// Add Registration number from Student table to combobox.
        /// </summary>
        /// <param name="cmb">Combobox to which registration numbers are added.</param>
        public void AddRegToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Student";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(5);
                cmb.Items.Add(n);
            }
        }



        /// <summary>
        /// Add Status from Lookup table to combobox.
        /// </summary>
        /// <param name="cmb">Combobox to which Status are added.</param>
        public void AddStatusToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM Lookup WHERE Category = 'ATTENDANCE_STATUS'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while (d.Read())
            {
                string n = d.GetString(1);
                cmb.Items.Add(n);
            }
        }


        /// <summary>
        /// Add Dates from ClassAttendance table to combobox.
        /// </summary>
        /// <param name="cmb">Combobox to which Dates are added.</param>
        public void AddDatesToComboBox(ComboBox cmb)
        {
            string cmd = "SELECT * FROM ClassAttendance";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            cmb.Items.Clear();
            while(d.Read())
            {
                DateTime n = d.GetDateTime(1);
                cmb.Items.Add(n);
            }

        }


        /// <summary>
        /// Gets Attendance Id from ClassAttendance Table
        /// </summary>
        /// <param name="date">Date selected by user coressponding to which Id is found</param>
        /// <returns>returns id coressponding to selected date</returns>
        public int getAttIdFromDate(DateTime date)
        {
            string cmd = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = '" + date.ToString(@"yyyy-MM-dd") + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        /// <summary>
        /// Get student id from Student table
        /// </summary>
        /// <param name="regNo">Registration number selected by user.</param>
        /// <returns>Returns Student id coressponding to registration number</returns>
        public int getStudentIdFromReg(string regNo)
        {
            string cmd = "SELECT Id FROM Student WHERE RegistrationNumber = '" + regNo + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        /// <summary>
        /// Get Lookup id from Lookup table
        /// </summary>
        /// <param name="regNo">Status selected by user.</param>
        /// <returns>Returns Lookup id coressponding to Status</returns>
        public int getlookupIdFromAttStatus(string status)
        {
            string cmd = "SELECT LookupId FROM Lookup WHERE Name = '" + status + "'";
            int id = DatabaseConnection.getInstance().getScalarData(cmd);
            return id;
        }


        /// <summary>
        /// Gets date from ClassAttendance table
        /// </summary>
        /// <param name="id">id of row clicked by user</param>
        /// <returns>returns date corresponding to particular id</returns>
        public DateTime getDateFromAttId(int id)
        {
            DateTime date = new DateTime();
            string cmd = "SELECT * FROM ClassAttendance WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                date = d.GetDateTime(1);
                break;
            }
            return date;
        }


        /// <summary>
        /// Gets registration number from Student table
        /// </summary>
        /// <param name="id">id selected by user</param>
        /// <returns>returns registration number of student corresponding ot id</returns>
        public string getRegNoFromStudentId(int id)
        {
            string reg = "";
            string cmd = "SELECT * FROM Student WHERE Id = '" + id + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                reg = d.GetString(5);
                break;
            }
            return reg;
        }


        /// <summary>
        /// Gets status from Lookup table
        /// </summary>
        /// <param name="lookupId">id selected by user</param>
        /// <returns>returns status corresponding to given id</returns>
        public string getStatusFromLookupId(int lookupId)
        {
            string status = "";
            string cmd = "SELECT * FROM Lookup WHERE lookupId = '" + lookupId + "'";
            SqlDataReader d = DatabaseConnection.getInstance().getData(cmd);
            while (d.Read())
            {
                status = d.GetString(1);
                break;
            }
            return status;
        }




        
        /// <summary>
        /// Checks if Date is already present in database.
        /// </summary>
        /// <param name="date">Date selected by user</param>
        /// <returns>return a string which tells date exist otherwise an empty string is returned.</returns>
        public string DateAlreadyExist(DateTime date)
        {
            string cmd = "SELECT * FROM ClassAttendance WHERE AttendanceDate = '" + attendanceDate.ToString(@"yyyy-MM-dd") + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return "Date Already exists, you can mark attendance.";
            }
            else
            {
                return "";
            }
        }


        /// <summary>
        /// checks if studentId and AttendanceId pair already exists
        /// </summary>
        /// <returns>returns string telling record already exists if record is present in table
        /// otherwise returns empty string</returns>
        public string StudentAttAlreadyExist()
        {
            string cmd = "SELECT * FROM StudentAttendance WHERE AttendanceId = '" + attendanceId + "' AND StudentId = '" + studentId + "'";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return "Student's attendance is already marked";
            }
            else
            {
                return "";
            }
        }


        


        /// <summary>
        /// Adds Attendance Date to Class Attendance table in database.
        /// </summary>
        public void AddAttendanceDate()
        {
            string cmd = "INSERT INTO ClassAttendance (AttendanceDate) VALUES ('" + attendanceDate.ToString(@"yyyy-MM-dd") + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Date Added Successfully! Now you can mark attendance for today's date");
        }


        /// <summary>
        /// Add Data to StudentAttendance table.
        /// </summary>
        public void AddStatus()
        {
            string cmd = "INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) VALUES ('" + attendanceId + "', '" + studentId + "', '" + attendanceStatus + "')";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Added Successfully");
        }



        /// <summary>
        /// Update the date coressponding to given id.
        /// </summary>
        /// <param name="id">id of row clicked by user.</param>
        public void EditClassAttDate(int id)
        {
            string cmd = "UPDATE ClassAttendance SET AttendanceDate = '" + attendanceDate.ToString(@"yyyy-MM-dd") + "' WHERE Id = '" + id + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated Successfully!");
        }


        /// <summary>
        /// Update student attendance in StudentAttance table
        /// </summary>
        /// <param name="idReg">StudentId selected by user</param>
        /// <param name="idDate">AttendanceId selected by user.</param>
        public void EditStudentAtt(int idReg, int idDate)
        {
            string cmd = "UPDATE StudentAttendance SET AttendanceStatus = '" + attendanceStatus + "' WHERE AttendanceId = '" + idDate + "' AND StudentId = '" + idReg + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data Updated Successfully!");
        }


        /// <summary>
        /// Delete student attendance in StudentAttance table
        /// </summary>
        /// <param name="idReg">StudentId selected by user</param>
        /// <param name="idDate">AttendanceId selected by user.</param>
        public void DeleteStudentAtt(int idReg, int idDate)
        {
            string cmd = "DELETE FROM StudentAttendance WHERE AttendanceId = '" + idDate + "' AND StudentId = '" + idReg + "'";
            DatabaseConnection.getInstance().exectuteQuery(cmd);
            MessageBox.Show("Data deleted!");
        }




        /// <summary>
        /// Get data from ClassAttendance table show in grid.
        /// </summary>
        /// <returns>returns datatable containing required data.</returns>
        public DataTable ShowClassAttInGrid()
        {
            string cmd = "SELECT * FROM ClassAttendance";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }


        /// <summary>
        /// Get data from StudentAttendance table show in grid.
        /// </summary>
        /// <returns>returns datatable containing required data.</returns>
        public DataTable ShowStudentAttendanceInGrid()
        {
            string cmd = "SELECT * FROM StudentAttendance";
            SqlDataAdapter sqlDA = DatabaseConnection.getInstance().Query(cmd);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            return dt;
        }







    }
}
