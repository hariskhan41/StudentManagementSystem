namespace Student_Management_System
{
    partial class AddStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_RegistrationNo = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_RegistrationNo = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_ErrorFirstName = new System.Windows.Forms.Label();
            this.lbl_ErrorContact = new System.Windows.Forms.Label();
            this.lbl_ErrorRegistrationNo = new System.Windows.Forms.Label();
            this.lbl_ErrorLastName = new System.Windows.Forms.Label();
            this.lbl_ErrorEmail = new System.Windows.Forms.Label();
            this.lbl_ErrorStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(148, 47);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(137, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(480, 47);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(137, 20);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(148, 111);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(137, 20);
            this.txt_Contact.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(480, 111);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(137, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_RegistrationNo
            // 
            this.txt_RegistrationNo.Location = new System.Drawing.Point(148, 171);
            this.txt_RegistrationNo.Name = "txt_RegistrationNo";
            this.txt_RegistrationNo.Size = new System.Drawing.Size(137, 20);
            this.txt_RegistrationNo.TabIndex = 4;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(480, 171);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(137, 20);
            this.txt_Status.TabIndex = 5;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(30, 47);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 7;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(362, 47);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 8;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Location = new System.Drawing.Point(30, 111);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(44, 13);
            this.lbl_Contact.TabIndex = 9;
            this.lbl_Contact.Text = "Contact";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(362, 111);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_RegistrationNo
            // 
            this.lbl_RegistrationNo.AutoSize = true;
            this.lbl_RegistrationNo.Location = new System.Drawing.Point(30, 171);
            this.lbl_RegistrationNo.Name = "lbl_RegistrationNo";
            this.lbl_RegistrationNo.Size = new System.Drawing.Size(83, 13);
            this.lbl_RegistrationNo.TabIndex = 11;
            this.lbl_RegistrationNo.Text = "Registration No.";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(362, 171);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 12;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.Click += new System.EventHandler(this.lbl_Status_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(529, 256);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 29);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_ErrorFirstName
            // 
            this.lbl_ErrorFirstName.AutoSize = true;
            this.lbl_ErrorFirstName.Location = new System.Drawing.Point(148, 81);
            this.lbl_ErrorFirstName.Name = "lbl_ErrorFirstName";
            this.lbl_ErrorFirstName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorFirstName.TabIndex = 14;
            this.lbl_ErrorFirstName.Text = "label1";
            // 
            // lbl_ErrorContact
            // 
            this.lbl_ErrorContact.AutoSize = true;
            this.lbl_ErrorContact.Location = new System.Drawing.Point(148, 147);
            this.lbl_ErrorContact.Name = "lbl_ErrorContact";
            this.lbl_ErrorContact.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorContact.TabIndex = 15;
            this.lbl_ErrorContact.Text = "label1";
            // 
            // lbl_ErrorRegistrationNo
            // 
            this.lbl_ErrorRegistrationNo.AutoSize = true;
            this.lbl_ErrorRegistrationNo.Location = new System.Drawing.Point(148, 214);
            this.lbl_ErrorRegistrationNo.Name = "lbl_ErrorRegistrationNo";
            this.lbl_ErrorRegistrationNo.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorRegistrationNo.TabIndex = 16;
            this.lbl_ErrorRegistrationNo.Text = "label2";
            // 
            // lbl_ErrorLastName
            // 
            this.lbl_ErrorLastName.AutoSize = true;
            this.lbl_ErrorLastName.Location = new System.Drawing.Point(485, 81);
            this.lbl_ErrorLastName.Name = "lbl_ErrorLastName";
            this.lbl_ErrorLastName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorLastName.TabIndex = 17;
            this.lbl_ErrorLastName.Text = "label3";
            // 
            // lbl_ErrorEmail
            // 
            this.lbl_ErrorEmail.AutoSize = true;
            this.lbl_ErrorEmail.Location = new System.Drawing.Point(485, 147);
            this.lbl_ErrorEmail.Name = "lbl_ErrorEmail";
            this.lbl_ErrorEmail.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorEmail.TabIndex = 18;
            this.lbl_ErrorEmail.Text = "label4";
            // 
            // lbl_ErrorStatus
            // 
            this.lbl_ErrorStatus.AutoSize = true;
            this.lbl_ErrorStatus.Location = new System.Drawing.Point(485, 214);
            this.lbl_ErrorStatus.Name = "lbl_ErrorStatus";
            this.lbl_ErrorStatus.Size = new System.Drawing.Size(35, 13);
            this.lbl_ErrorStatus.TabIndex = 19;
            this.lbl_ErrorStatus.Text = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 223);
            this.dataGridView1.TabIndex = 20;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_ErrorStatus);
            this.Controls.Add(this.lbl_ErrorEmail);
            this.Controls.Add(this.lbl_ErrorLastName);
            this.Controls.Add(this.lbl_ErrorRegistrationNo);
            this.Controls.Add(this.lbl_ErrorContact);
            this.Controls.Add(this.lbl_ErrorFirstName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_RegistrationNo);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_RegistrationNo);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "AddStudents";
            this.Text = "AddStudents";
            this.Load += new System.EventHandler(this.AddStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_RegistrationNo;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_RegistrationNo;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_ErrorFirstName;
        private System.Windows.Forms.Label lbl_ErrorContact;
        private System.Windows.Forms.Label lbl_ErrorRegistrationNo;
        private System.Windows.Forms.Label lbl_ErrorLastName;
        private System.Windows.Forms.Label lbl_ErrorEmail;
        private System.Windows.Forms.Label lbl_ErrorStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}