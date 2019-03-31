namespace Student_Management_System
{
    partial class Attendance
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddStudents = new System.Windows.Forms.Button();
            this.btn_AddClo = new System.Windows.Forms.Button();
            this.btn_Assessment = new System.Windows.Forms.Button();
            this.btn_AssessmentComponent = new System.Windows.Forms.Button();
            this.btn_AddRubrics = new System.Windows.Forms.Button();
            this.btn_ClassAttendance = new System.Windows.Forms.Button();
            this.btn_StudentAttendance = new System.Windows.Forms.Button();
            this.btn_RubricLevel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_RegNo = new System.Windows.Forms.Label();
            this.cmb_RegNo = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.cmb_Date = new System.Windows.Forms.ComboBox();
            this.btn_Mark = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet9 = new Student_Management_System.ProjectBDataSet9();
            this.projectBDataSet6 = new Student_Management_System.ProjectBDataSet6();
            this.projectBDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new Student_Management_System.ProjectBDataSet8();
            this.projectBDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendanceTableAdapter = new Student_Management_System.ProjectBDataSet9TableAdapters.StudentAttendanceTableAdapter();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Result = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8BindingSource)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1224F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1224, 60);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management System";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Controls.Add(this.btn_AddStudents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddClo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Assessment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_AssessmentComponent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddRubrics, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_ClassAttendance, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_StudentAttendance, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_RubricLevel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 577);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // btn_AddStudents
            // 
            this.btn_AddStudents.CausesValidation = false;
            this.btn_AddStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddStudents.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStudents.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudents.Location = new System.Drawing.Point(3, 23);
            this.btn_AddStudents.Name = "btn_AddStudents";
            this.btn_AddStudents.Size = new System.Drawing.Size(231, 44);
            this.btn_AddStudents.TabIndex = 0;
            this.btn_AddStudents.Text = "Add Students";
            this.btn_AddStudents.UseVisualStyleBackColor = true;
            this.btn_AddStudents.Click += new System.EventHandler(this.btn_AddStudents_Click);
            // 
            // btn_AddClo
            // 
            this.btn_AddClo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddClo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddClo.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddClo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddClo.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddClo.Location = new System.Drawing.Point(3, 73);
            this.btn_AddClo.Name = "btn_AddClo";
            this.btn_AddClo.Size = new System.Drawing.Size(231, 44);
            this.btn_AddClo.TabIndex = 1;
            this.btn_AddClo.Text = "Add CLOs";
            this.btn_AddClo.UseVisualStyleBackColor = true;
            this.btn_AddClo.Click += new System.EventHandler(this.btn_AddClo_Click);
            // 
            // btn_Assessment
            // 
            this.btn_Assessment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Assessment.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Assessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Assessment.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assessment.Location = new System.Drawing.Point(3, 172);
            this.btn_Assessment.Name = "btn_Assessment";
            this.btn_Assessment.Size = new System.Drawing.Size(231, 40);
            this.btn_Assessment.TabIndex = 4;
            this.btn_Assessment.Text = "Assessment";
            this.btn_Assessment.UseVisualStyleBackColor = true;
            this.btn_Assessment.Click += new System.EventHandler(this.btn_Assessment_Click);
            // 
            // btn_AssessmentComponent
            // 
            this.btn_AssessmentComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AssessmentComponent.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AssessmentComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssessmentComponent.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssessmentComponent.Location = new System.Drawing.Point(3, 219);
            this.btn_AssessmentComponent.Name = "btn_AssessmentComponent";
            this.btn_AssessmentComponent.Size = new System.Drawing.Size(231, 37);
            this.btn_AssessmentComponent.TabIndex = 5;
            this.btn_AssessmentComponent.Text = "Assessment Component";
            this.btn_AssessmentComponent.UseVisualStyleBackColor = true;
            this.btn_AssessmentComponent.Click += new System.EventHandler(this.btn_AssessmentComponent_Click);
            // 
            // btn_AddRubrics
            // 
            this.btn_AddRubrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddRubrics.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddRubrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRubrics.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRubrics.Location = new System.Drawing.Point(3, 123);
            this.btn_AddRubrics.Name = "btn_AddRubrics";
            this.btn_AddRubrics.Size = new System.Drawing.Size(231, 43);
            this.btn_AddRubrics.TabIndex = 2;
            this.btn_AddRubrics.Text = "Add Rubrics";
            this.btn_AddRubrics.UseVisualStyleBackColor = true;
            this.btn_AddRubrics.Click += new System.EventHandler(this.btn_AddRubrics_Click);
            // 
            // btn_ClassAttendance
            // 
            this.btn_ClassAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassAttendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClassAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClassAttendance.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassAttendance.Location = new System.Drawing.Point(3, 264);
            this.btn_ClassAttendance.Name = "btn_ClassAttendance";
            this.btn_ClassAttendance.Size = new System.Drawing.Size(231, 35);
            this.btn_ClassAttendance.TabIndex = 7;
            this.btn_ClassAttendance.Text = "Class Attendance";
            this.btn_ClassAttendance.UseVisualStyleBackColor = true;
            this.btn_ClassAttendance.Click += new System.EventHandler(this.btn_ClassAttendance_Click);
            // 
            // btn_StudentAttendance
            // 
            this.btn_StudentAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StudentAttendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_StudentAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StudentAttendance.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentAttendance.Location = new System.Drawing.Point(3, 309);
            this.btn_StudentAttendance.Name = "btn_StudentAttendance";
            this.btn_StudentAttendance.Size = new System.Drawing.Size(231, 35);
            this.btn_StudentAttendance.TabIndex = 6;
            this.btn_StudentAttendance.Text = "Student Attendance";
            this.btn_StudentAttendance.UseVisualStyleBackColor = true;
            this.btn_StudentAttendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // btn_RubricLevel
            // 
            this.btn_RubricLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RubricLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_RubricLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RubricLevel.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RubricLevel.Location = new System.Drawing.Point(3, 352);
            this.btn_RubricLevel.Name = "btn_RubricLevel";
            this.btn_RubricLevel.Size = new System.Drawing.Size(231, 35);
            this.btn_RubricLevel.TabIndex = 8;
            this.btn_RubricLevel.Text = "Rubric Level";
            this.btn_RubricLevel.UseVisualStyleBackColor = true;
            this.btn_RubricLevel.Click += new System.EventHandler(this.btn_RubricLevel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 868F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Date, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_RegNo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmb_RegNo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Status, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Status, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Date, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(243, 86);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(969, 95);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 8);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(95, 13);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_RegNo
            // 
            this.lbl_RegNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RegNo.AutoSize = true;
            this.lbl_RegNo.Location = new System.Drawing.Point(3, 39);
            this.lbl_RegNo.Name = "lbl_RegNo";
            this.lbl_RegNo.Size = new System.Drawing.Size(95, 13);
            this.lbl_RegNo.TabIndex = 2;
            this.lbl_RegNo.Text = "Registration #";
            // 
            // cmb_RegNo
            // 
            this.cmb_RegNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_RegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RegNo.FormattingEnabled = true;
            this.cmb_RegNo.Location = new System.Drawing.Point(104, 35);
            this.cmb_RegNo.Name = "cmb_RegNo";
            this.cmb_RegNo.Size = new System.Drawing.Size(862, 21);
            this.cmb_RegNo.TabIndex = 3;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(3, 72);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(95, 13);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(104, 68);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(862, 21);
            this.cmb_Status.TabIndex = 5;
            // 
            // cmb_Date
            // 
            this.cmb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Date.FormattingEnabled = true;
            this.cmb_Date.Location = new System.Drawing.Point(104, 4);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(862, 21);
            this.cmb_Date.TabIndex = 6;
            this.cmb_Date.SelectedIndexChanged += new System.EventHandler(this.cmb_Date_SelectedIndexChanged);
            this.cmb_Date.TextUpdate += new System.EventHandler(this.cmb_Date_TextUpdate);
            // 
            // btn_Mark
            // 
            this.btn_Mark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Mark.Location = new System.Drawing.Point(3, 3);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(314, 23);
            this.btn_Mark.TabIndex = 33;
            this.btn_Mark.Text = "Mark Attendance";
            this.btn_Mark.UseVisualStyleBackColor = true;
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Update, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Cancel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Mark, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(243, 216);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(969, 29);
            this.tableLayoutPanel4.TabIndex = 34;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(658, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(308, 23);
            this.btn_Update.TabIndex = 36;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(323, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(329, 23);
            this.btn_Cancel.TabIndex = 34;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(243, 286);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(969, 341);
            this.tableLayoutPanel5.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn,
            this.RegistrationNumber,
            this.Status,
            this.Date,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.studentAttendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            this.attendanceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
            this.attendanceStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.HeaderText = "RegistrationNumber";
            this.RegistrationNumber.Name = "RegistrationNumber";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "AttendanceId";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "AttendanceId";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet9;
            // 
            // projectBDataSet9
            // 
            this.projectBDataSet9.DataSetName = "ProjectBDataSet9";
            this.projectBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBDataSet6BindingSource
            // 
            this.projectBDataSet6BindingSource.DataSource = this.projectBDataSet6;
            this.projectBDataSet6BindingSource.Position = 0;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBDataSet8BindingSource
            // 
            this.projectBDataSet8BindingSource.DataSource = this.projectBDataSet8;
            this.projectBDataSet8BindingSource.Position = 0;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Result, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 395);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(231, 43);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // btn_Result
            // 
            this.btn_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Result.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Result.Location = new System.Drawing.Point(3, 3);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(225, 35);
            this.btn_Result.TabIndex = 11;
            this.btn_Result.Text = "Result";
            this.btn_Result.UseVisualStyleBackColor = true;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 628);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8BindingSource)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_AddStudents;
        private System.Windows.Forms.Button btn_AddClo;
        private System.Windows.Forms.Button btn_AddRubrics;
        private System.Windows.Forms.Button btn_Assessment;
        private System.Windows.Forms.Button btn_AssessmentComponent;
        private System.Windows.Forms.Button btn_StudentAttendance;
        private System.Windows.Forms.Button btn_ClassAttendance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_RegNo;
        private System.Windows.Forms.ComboBox cmb_RegNo;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Mark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projectBDataSet8BindingSource;
        private ProjectBDataSet8 projectBDataSet8;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource projectBDataSet6BindingSource;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet9TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox cmb_Date;
        private System.Windows.Forms.Button btn_RubricLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_Result;
    }
}