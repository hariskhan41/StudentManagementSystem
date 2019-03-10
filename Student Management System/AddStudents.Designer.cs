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
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_ErrorFirstName = new System.Windows.Forms.Label();
            this.lbl_ErrorContact = new System.Windows.Forms.Label();
            this.lbl_ErrorRegistrationNo = new System.Windows.Forms.Label();
            this.lbl_ErrorLastName = new System.Windows.Forms.Label();
            this.lbl_ErrorEmail = new System.Windows.Forms.Label();
            this.lbl_ErrorStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_RegistrationNo = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_RegistrationNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_FirstName.Location = new System.Drawing.Point(99, 3);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(171, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_LastName.Location = new System.Drawing.Point(99, 3);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(171, 20);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Contact.Location = new System.Drawing.Point(99, 49);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(171, 20);
            this.txt_Contact.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Email.Location = new System.Drawing.Point(99, 49);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(171, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(36, 5);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 7;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(35, 5);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 8;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Location = new System.Drawing.Point(49, 51);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(44, 13);
            this.lbl_Contact.TabIndex = 9;
            this.lbl_Contact.Text = "Contact";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(61, 51);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_ErrorFirstName
            // 
            this.lbl_ErrorFirstName.AutoSize = true;
            this.lbl_ErrorFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorFirstName.Location = new System.Drawing.Point(99, 23);
            this.lbl_ErrorFirstName.Name = "lbl_ErrorFirstName";
            this.lbl_ErrorFirstName.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorFirstName.TabIndex = 14;
            this.lbl_ErrorFirstName.Text = "zxc";
            // 
            // lbl_ErrorContact
            // 
            this.lbl_ErrorContact.AutoSize = true;
            this.lbl_ErrorContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorContact.Location = new System.Drawing.Point(99, 69);
            this.lbl_ErrorContact.Name = "lbl_ErrorContact";
            this.lbl_ErrorContact.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorContact.TabIndex = 15;
            this.lbl_ErrorContact.Text = "zxc";
            // 
            // lbl_ErrorRegistrationNo
            // 
            this.lbl_ErrorRegistrationNo.AutoSize = true;
            this.lbl_ErrorRegistrationNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorRegistrationNo.Location = new System.Drawing.Point(99, 115);
            this.lbl_ErrorRegistrationNo.Name = "lbl_ErrorRegistrationNo";
            this.lbl_ErrorRegistrationNo.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorRegistrationNo.TabIndex = 16;
            this.lbl_ErrorRegistrationNo.Text = "zxc";
            // 
            // lbl_ErrorLastName
            // 
            this.lbl_ErrorLastName.AutoSize = true;
            this.lbl_ErrorLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorLastName.Location = new System.Drawing.Point(99, 23);
            this.lbl_ErrorLastName.Name = "lbl_ErrorLastName";
            this.lbl_ErrorLastName.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorLastName.TabIndex = 17;
            this.lbl_ErrorLastName.Text = "asd";
            // 
            // lbl_ErrorEmail
            // 
            this.lbl_ErrorEmail.AutoSize = true;
            this.lbl_ErrorEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorEmail.Location = new System.Drawing.Point(99, 69);
            this.lbl_ErrorEmail.Name = "lbl_ErrorEmail";
            this.lbl_ErrorEmail.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorEmail.TabIndex = 18;
            this.lbl_ErrorEmail.Text = "asd";
            // 
            // lbl_ErrorStatus
            // 
            this.lbl_ErrorStatus.AutoSize = true;
            this.lbl_ErrorStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ErrorStatus.Location = new System.Drawing.Point(99, 115);
            this.lbl_ErrorStatus.Name = "lbl_ErrorStatus";
            this.lbl_ErrorStatus.Size = new System.Drawing.Size(171, 13);
            this.lbl_ErrorStatus.TabIndex = 19;
            this.lbl_ErrorStatus.Text = "asd";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(35, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 142);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(499, 196);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 25);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_RegistrationNo
            // 
            this.txt_RegistrationNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_RegistrationNo.Location = new System.Drawing.Point(99, 95);
            this.txt_RegistrationNo.Name = "txt_RegistrationNo";
            this.txt_RegistrationNo.Size = new System.Drawing.Size(171, 20);
            this.txt_RegistrationNo.TabIndex = 4;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(56, 97);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 12;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.Click += new System.EventHandler(this.lbl_Status_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Status.Location = new System.Drawing.Point(99, 95);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(171, 20);
            this.txt_Status.TabIndex = 5;
            // 
            // lbl_RegistrationNo
            // 
            this.lbl_RegistrationNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_RegistrationNo.AutoSize = true;
            this.lbl_RegistrationNo.Location = new System.Drawing.Point(20, 97);
            this.lbl_RegistrationNo.Name = "lbl_RegistrationNo";
            this.lbl_RegistrationNo.Size = new System.Drawing.Size(73, 13);
            this.lbl_RegistrationNo.TabIndex = 11;
            this.lbl_RegistrationNo.Text = "Registration #";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_FirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_FirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Contact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Contact, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_RegistrationNo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ErrorFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ErrorRegistrationNo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_RegistrationNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ErrorContact, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 141);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_LastName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_LastName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Email, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_Status, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Status, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_Email, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorLastName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorEmail, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorStatus, 1, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(314, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(273, 141);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(398, 196);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 395);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddStudents";
            this.Text = "AddStudents";
            this.Load += new System.EventHandler(this.AddStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_ErrorFirstName;
        private System.Windows.Forms.Label lbl_ErrorContact;
        private System.Windows.Forms.Label lbl_ErrorRegistrationNo;
        private System.Windows.Forms.Label lbl_ErrorLastName;
        private System.Windows.Forms.Label lbl_ErrorEmail;
        private System.Windows.Forms.Label lbl_ErrorStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_RegistrationNo;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_RegistrationNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btn_Update;
    }
}