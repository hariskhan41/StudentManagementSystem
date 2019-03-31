namespace Student_Management_System
{
    partial class Result
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
            this.btn_AddRubrics = new System.Windows.Forms.Button();
            this.btn_Assessment = new System.Windows.Forms.Button();
            this.btn_AssessmentComponent = new System.Windows.Forms.Button();
            this.btn_ClassAttendance = new System.Windows.Forms.Button();
            this.btn_StudentAttendance = new System.Windows.Forms.Button();
            this.btn_RubricLevel = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Result = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Student = new System.Windows.Forms.Label();
            this.lbl_Assessment = new System.Windows.Forms.Label();
            this.lbl_AssessmentComponent = new System.Windows.Forms.Label();
            this.lbl_Rubric = new System.Windows.Forms.Label();
            this.lbl_RubricLevel = new System.Windows.Forms.Label();
            this.cmb_Student = new System.Windows.Forms.ComboBox();
            this.cmb_Assessment = new System.Windows.Forms.ComboBox();
            this.cmb_AssessmentComponent = new System.Windows.Forms.ComboBox();
            this.cmb_Rubrics = new System.Windows.Forms.ComboBox();
            this.cmb_RubricLevel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectBDataSet13 = new Student_Management_System.ProjectBDataSet13();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentResultTableAdapter = new Student_Management_System.ProjectBDataSet13TableAdapters.StudentResultTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1224, 60);
            this.tableLayoutPanel2.TabIndex = 28;
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
            this.tableLayoutPanel1.Controls.Add(this.btn_AddRubrics, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Assessment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_AssessmentComponent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_ClassAttendance, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_StudentAttendance, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_RubricLevel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 577);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // btn_AddStudents
            // 
            this.btn_AddStudents.CausesValidation = false;
            this.btn_AddStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddStudents.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStudents.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudents.Location = new System.Drawing.Point(3, 61);
            this.btn_AddStudents.Name = "btn_AddStudents";
            this.btn_AddStudents.Size = new System.Drawing.Size(231, 42);
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
            this.btn_AddClo.Location = new System.Drawing.Point(3, 109);
            this.btn_AddClo.Name = "btn_AddClo";
            this.btn_AddClo.Size = new System.Drawing.Size(231, 42);
            this.btn_AddClo.TabIndex = 1;
            this.btn_AddClo.Text = "Add CLOs";
            this.btn_AddClo.UseVisualStyleBackColor = true;
            this.btn_AddClo.Click += new System.EventHandler(this.btn_AddClo_Click);
            // 
            // btn_AddRubrics
            // 
            this.btn_AddRubrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddRubrics.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddRubrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRubrics.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRubrics.Location = new System.Drawing.Point(3, 157);
            this.btn_AddRubrics.Name = "btn_AddRubrics";
            this.btn_AddRubrics.Size = new System.Drawing.Size(231, 31);
            this.btn_AddRubrics.TabIndex = 2;
            this.btn_AddRubrics.Text = "Add Rubrics";
            this.btn_AddRubrics.UseVisualStyleBackColor = true;
            this.btn_AddRubrics.Click += new System.EventHandler(this.btn_AddRubrics_Click);
            // 
            // btn_Assessment
            // 
            this.btn_Assessment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Assessment.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Assessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Assessment.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assessment.Location = new System.Drawing.Point(3, 194);
            this.btn_Assessment.Name = "btn_Assessment";
            this.btn_Assessment.Size = new System.Drawing.Size(231, 39);
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
            this.btn_AssessmentComponent.Location = new System.Drawing.Point(3, 239);
            this.btn_AssessmentComponent.Name = "btn_AssessmentComponent";
            this.btn_AssessmentComponent.Size = new System.Drawing.Size(231, 37);
            this.btn_AssessmentComponent.TabIndex = 5;
            this.btn_AssessmentComponent.Text = "Assessment Component";
            this.btn_AssessmentComponent.UseVisualStyleBackColor = true;
            this.btn_AssessmentComponent.Click += new System.EventHandler(this.btn_AssessmentComponent_Click);
            // 
            // btn_ClassAttendance
            // 
            this.btn_ClassAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassAttendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ClassAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClassAttendance.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassAttendance.Location = new System.Drawing.Point(3, 284);
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
            this.btn_StudentAttendance.Location = new System.Drawing.Point(3, 329);
            this.btn_StudentAttendance.Name = "btn_StudentAttendance";
            this.btn_StudentAttendance.Size = new System.Drawing.Size(231, 35);
            this.btn_StudentAttendance.TabIndex = 6;
            this.btn_StudentAttendance.Text = "Student Attendance";
            this.btn_StudentAttendance.UseVisualStyleBackColor = true;
            this.btn_StudentAttendance.Click += new System.EventHandler(this.btn_StudentAttendance_Click);
            // 
            // btn_RubricLevel
            // 
            this.btn_RubricLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RubricLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_RubricLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RubricLevel.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RubricLevel.Location = new System.Drawing.Point(3, 377);
            this.btn_RubricLevel.Name = "btn_RubricLevel";
            this.btn_RubricLevel.Size = new System.Drawing.Size(231, 35);
            this.btn_RubricLevel.TabIndex = 9;
            this.btn_RubricLevel.Text = "Rubric Level";
            this.btn_RubricLevel.UseVisualStyleBackColor = true;
            this.btn_RubricLevel.Click += new System.EventHandler(this.btn_RubricLevel_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Result, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 420);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(231, 41);
            this.tableLayoutPanel6.TabIndex = 10;
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
            this.btn_Result.TabIndex = 10;
            this.btn_Result.Text = "Result";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Controls.Add(this.cmb_RubricLevel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Rubrics, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cmb_AssessmentComponent, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Assessment, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Student, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Assessment, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_AssessmentComponent, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Rubric, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_RubricLevel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Student, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(243, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(969, 145);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // lbl_Student
            // 
            this.lbl_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Student.AutoSize = true;
            this.lbl_Student.Location = new System.Drawing.Point(3, 7);
            this.lbl_Student.Name = "lbl_Student";
            this.lbl_Student.Size = new System.Drawing.Size(90, 13);
            this.lbl_Student.TabIndex = 0;
            this.lbl_Student.Text = "Student";
            // 
            // lbl_Assessment
            // 
            this.lbl_Assessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Assessment.AutoSize = true;
            this.lbl_Assessment.Location = new System.Drawing.Point(3, 36);
            this.lbl_Assessment.Name = "lbl_Assessment";
            this.lbl_Assessment.Size = new System.Drawing.Size(90, 13);
            this.lbl_Assessment.TabIndex = 1;
            this.lbl_Assessment.Text = "Assessment";
            // 
            // lbl_AssessmentComponent
            // 
            this.lbl_AssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AssessmentComponent.AutoSize = true;
            this.lbl_AssessmentComponent.Location = new System.Drawing.Point(3, 60);
            this.lbl_AssessmentComponent.Name = "lbl_AssessmentComponent";
            this.lbl_AssessmentComponent.Size = new System.Drawing.Size(90, 26);
            this.lbl_AssessmentComponent.TabIndex = 2;
            this.lbl_AssessmentComponent.Text = "Assessment Component";
            // 
            // lbl_Rubric
            // 
            this.lbl_Rubric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Rubric.AutoSize = true;
            this.lbl_Rubric.Location = new System.Drawing.Point(3, 96);
            this.lbl_Rubric.Name = "lbl_Rubric";
            this.lbl_Rubric.Size = new System.Drawing.Size(90, 13);
            this.lbl_Rubric.TabIndex = 3;
            this.lbl_Rubric.Text = "Rubrics";
            // 
            // lbl_RubricLevel
            // 
            this.lbl_RubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RubricLevel.AutoSize = true;
            this.lbl_RubricLevel.Location = new System.Drawing.Point(3, 125);
            this.lbl_RubricLevel.Name = "lbl_RubricLevel";
            this.lbl_RubricLevel.Size = new System.Drawing.Size(90, 13);
            this.lbl_RubricLevel.TabIndex = 4;
            this.lbl_RubricLevel.Text = "RubricLevel";
            // 
            // cmb_Student
            // 
            this.cmb_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Student.FormattingEnabled = true;
            this.cmb_Student.Location = new System.Drawing.Point(99, 3);
            this.cmb_Student.Name = "cmb_Student";
            this.cmb_Student.Size = new System.Drawing.Size(867, 21);
            this.cmb_Student.TabIndex = 5;
            // 
            // cmb_Assessment
            // 
            this.cmb_Assessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Assessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Assessment.FormattingEnabled = true;
            this.cmb_Assessment.Location = new System.Drawing.Point(99, 32);
            this.cmb_Assessment.Name = "cmb_Assessment";
            this.cmb_Assessment.Size = new System.Drawing.Size(867, 21);
            this.cmb_Assessment.TabIndex = 6;
            this.cmb_Assessment.SelectedIndexChanged += new System.EventHandler(this.cmb_Assessment_SelectedIndexChanged);
            // 
            // cmb_AssessmentComponent
            // 
            this.cmb_AssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_AssessmentComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AssessmentComponent.FormattingEnabled = true;
            this.cmb_AssessmentComponent.Location = new System.Drawing.Point(99, 62);
            this.cmb_AssessmentComponent.Name = "cmb_AssessmentComponent";
            this.cmb_AssessmentComponent.Size = new System.Drawing.Size(867, 21);
            this.cmb_AssessmentComponent.TabIndex = 7;
            this.cmb_AssessmentComponent.SelectedIndexChanged += new System.EventHandler(this.cmb_AssessmentComponent_SelectedIndexChanged);
            // 
            // cmb_Rubrics
            // 
            this.cmb_Rubrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Rubrics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rubrics.FormattingEnabled = true;
            this.cmb_Rubrics.Location = new System.Drawing.Point(99, 92);
            this.cmb_Rubrics.Name = "cmb_Rubrics";
            this.cmb_Rubrics.Size = new System.Drawing.Size(867, 21);
            this.cmb_Rubrics.TabIndex = 8;
            this.cmb_Rubrics.SelectedIndexChanged += new System.EventHandler(this.cmb_Rubrics_SelectedIndexChanged);
            // 
            // cmb_RubricLevel
            // 
            this.cmb_RubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_RubricLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RubricLevel.FormattingEnabled = true;
            this.cmb_RubricLevel.Location = new System.Drawing.Point(99, 121);
            this.cmb_RubricLevel.Name = "cmb_RubricLevel";
            this.cmb_RubricLevel.Size = new System.Drawing.Size(867, 21);
            this.cmb_RubricLevel.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Cancel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Update, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(243, 254);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(969, 29);
            this.tableLayoutPanel4.TabIndex = 31;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(243, 335);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(969, 281);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(295, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(304, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(352, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(662, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(304, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
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
            this.studentIdDataGridViewTextBoxColumn,
            this.assessmentComponentIdDataGridViewTextBoxColumn,
            this.rubricMeasurementIdDataGridViewTextBoxColumn,
            this.evaluationDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectBDataSet13
            // 
            this.projectBDataSet13.DataSetName = "ProjectBDataSet13";
            this.projectBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet13;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // assessmentComponentIdDataGridViewTextBoxColumn
            // 
            this.assessmentComponentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Name = "assessmentComponentIdDataGridViewTextBoxColumn";
            // 
            // rubricMeasurementIdDataGridViewTextBoxColumn
            // 
            this.rubricMeasurementIdDataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.HeaderText = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.Name = "rubricMeasurementIdDataGridViewTextBoxColumn";
            // 
            // evaluationDateDataGridViewTextBoxColumn
            // 
            this.evaluationDateDataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.Name = "evaluationDateDataGridViewTextBoxColumn";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 628);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_ClassAttendance;
        private System.Windows.Forms.Button btn_StudentAttendance;
        private System.Windows.Forms.Button btn_RubricLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cmb_RubricLevel;
        private System.Windows.Forms.ComboBox cmb_Rubrics;
        private System.Windows.Forms.ComboBox cmb_AssessmentComponent;
        private System.Windows.Forms.ComboBox cmb_Assessment;
        private System.Windows.Forms.Label lbl_Student;
        private System.Windows.Forms.Label lbl_Assessment;
        private System.Windows.Forms.Label lbl_AssessmentComponent;
        private System.Windows.Forms.Label lbl_Rubric;
        private System.Windows.Forms.Label lbl_RubricLevel;
        private System.Windows.Forms.ComboBox cmb_Student;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet13 projectBDataSet13;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet13TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDateDataGridViewTextBoxColumn;
    }
}