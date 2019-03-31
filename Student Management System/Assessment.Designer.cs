namespace Student_Management_System
{
    partial class Assessment
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
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_TotalMarks = new System.Windows.Forms.Label();
            this.lbl_TotalWeightage = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_TotalMarks = new System.Windows.Forms.TextBox();
            this.txt_TotalWeightage = new System.Windows.Forms.TextBox();
            this.lbl_ErrorTitle = new System.Windows.Forms.Label();
            this.lbl_ErrorTotalMarks = new System.Windows.Forms.Label();
            this.lbl_ErrorTotalWeightage = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new Student_Management_System.ProjectBDataSet3();
            this.assessmentTableAdapter = new Student_Management_System.ProjectBDataSet3TableAdapters.AssessmentTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.btn_Result, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Attendance, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.259528F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253F));
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
            this.btn_AddStudents.Location = new System.Drawing.Point(3, 5);
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
            this.btn_AddClo.Location = new System.Drawing.Point(3, 55);
            this.btn_AddClo.Name = "btn_AddClo";
            this.btn_AddClo.Size = new System.Drawing.Size(231, 44);
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
            this.btn_AddRubrics.Location = new System.Drawing.Point(3, 105);
            this.btn_AddRubrics.Name = "btn_AddRubrics";
            this.btn_AddRubrics.Size = new System.Drawing.Size(231, 44);
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
            this.btn_Assessment.Location = new System.Drawing.Point(3, 155);
            this.btn_Assessment.Name = "btn_Assessment";
            this.btn_Assessment.Size = new System.Drawing.Size(231, 40);
            this.btn_Assessment.TabIndex = 3;
            this.btn_Assessment.Text = "Assessment";
            this.btn_Assessment.UseVisualStyleBackColor = true;
            // 
            // btn_AssessmentComponent
            // 
            this.btn_AssessmentComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AssessmentComponent.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AssessmentComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssessmentComponent.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssessmentComponent.Location = new System.Drawing.Point(3, 201);
            this.btn_AssessmentComponent.Name = "btn_AssessmentComponent";
            this.btn_AssessmentComponent.Size = new System.Drawing.Size(231, 36);
            this.btn_AssessmentComponent.TabIndex = 7;
            this.btn_AssessmentComponent.Text = "Assessment Component";
            this.btn_AssessmentComponent.UseVisualStyleBackColor = true;
            this.btn_AssessmentComponent.Click += new System.EventHandler(this.btn_AssessmentComponent_Click);
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Attendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Attendance.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.Location = new System.Drawing.Point(3, 286);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(231, 35);
            this.btn_Attendance.TabIndex = 8;
            this.btn_Attendance.Text = "Student Attendance";
            this.btn_Attendance.UseVisualStyleBackColor = true;
            this.btn_Attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Result.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Font = new System.Drawing.Font("Myriad Hebrew", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Result.Location = new System.Drawing.Point(3, 243);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(231, 35);
            this.btn_Result.TabIndex = 9;
            this.btn_Result.Text = "Class Attendance";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(3, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(95, 13);
            this.lbl_Title.TabIndex = 30;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_TotalMarks
            // 
            this.lbl_TotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalMarks.AutoSize = true;
            this.lbl_TotalMarks.Location = new System.Drawing.Point(3, 58);
            this.lbl_TotalMarks.Name = "lbl_TotalMarks";
            this.lbl_TotalMarks.Size = new System.Drawing.Size(95, 13);
            this.lbl_TotalMarks.TabIndex = 31;
            this.lbl_TotalMarks.Text = "Total Marks";
            // 
            // lbl_TotalWeightage
            // 
            this.lbl_TotalWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalWeightage.AutoSize = true;
            this.lbl_TotalWeightage.Location = new System.Drawing.Point(3, 109);
            this.lbl_TotalWeightage.Name = "lbl_TotalWeightage";
            this.lbl_TotalWeightage.Size = new System.Drawing.Size(95, 13);
            this.lbl_TotalWeightage.TabIndex = 32;
            this.lbl_TotalWeightage.Text = "Total Weightage";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 868F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Title, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_TotalWeightage, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_TotalMarks, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_Title, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_TotalMarks, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_TotalWeightage, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorTitle, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorTotalMarks, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_ErrorTotalWeightage, 1, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(243, 89);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(969, 160);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // txt_Title
            // 
            this.txt_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Title.Location = new System.Drawing.Point(104, 3);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(862, 20);
            this.txt_Title.TabIndex = 33;
            // 
            // txt_TotalMarks
            // 
            this.txt_TotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalMarks.Location = new System.Drawing.Point(104, 52);
            this.txt_TotalMarks.Name = "txt_TotalMarks";
            this.txt_TotalMarks.Size = new System.Drawing.Size(862, 20);
            this.txt_TotalMarks.TabIndex = 34;
            // 
            // txt_TotalWeightage
            // 
            this.txt_TotalWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalWeightage.Location = new System.Drawing.Point(104, 105);
            this.txt_TotalWeightage.Name = "txt_TotalWeightage";
            this.txt_TotalWeightage.Size = new System.Drawing.Size(862, 20);
            this.txt_TotalWeightage.TabIndex = 35;
            // 
            // lbl_ErrorTitle
            // 
            this.lbl_ErrorTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ErrorTitle.AutoSize = true;
            this.lbl_ErrorTitle.Location = new System.Drawing.Point(104, 29);
            this.lbl_ErrorTitle.Name = "lbl_ErrorTitle";
            this.lbl_ErrorTitle.Size = new System.Drawing.Size(862, 13);
            this.lbl_ErrorTitle.TabIndex = 36;
            this.lbl_ErrorTitle.Text = "label5";
            // 
            // lbl_ErrorTotalMarks
            // 
            this.lbl_ErrorTotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ErrorTotalMarks.AutoSize = true;
            this.lbl_ErrorTotalMarks.Location = new System.Drawing.Point(104, 80);
            this.lbl_ErrorTotalMarks.Name = "lbl_ErrorTotalMarks";
            this.lbl_ErrorTotalMarks.Size = new System.Drawing.Size(862, 13);
            this.lbl_ErrorTotalMarks.TabIndex = 37;
            this.lbl_ErrorTotalMarks.Text = "label6";
            // 
            // lbl_ErrorTotalWeightage
            // 
            this.lbl_ErrorTotalWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ErrorTotalWeightage.AutoSize = true;
            this.lbl_ErrorTotalWeightage.Location = new System.Drawing.Point(104, 130);
            this.lbl_ErrorTotalWeightage.Name = "lbl_ErrorTotalWeightage";
            this.lbl_ErrorTotalWeightage.Size = new System.Drawing.Size(862, 13);
            this.lbl_ErrorTotalWeightage.TabIndex = 38;
            this.lbl_ErrorTotalWeightage.Text = "label7";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel5.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Update, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Cancel, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(243, 275);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(969, 43);
            this.tableLayoutPanel5.TabIndex = 34;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(3, 9);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(307, 25);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(316, 10);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(329, 23);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(651, 10);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(315, 23);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(240, 343);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(972, 280);
            this.tableLayoutPanel4.TabIndex = 35;
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
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.assessmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 628);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.Load += new System.EventHandler(this.Assessment_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_AddStudents;
        private System.Windows.Forms.Button btn_AddClo;
        private System.Windows.Forms.Button btn_AddRubrics;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_TotalMarks;
        private System.Windows.Forms.Label lbl_TotalWeightage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_TotalMarks;
        private System.Windows.Forms.TextBox txt_TotalWeightage;
        private System.Windows.Forms.Label lbl_ErrorTitle;
        private System.Windows.Forms.Label lbl_ErrorTotalMarks;
        private System.Windows.Forms.Label lbl_ErrorTotalWeightage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet3TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Button btn_Assessment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btn_AssessmentComponent;
        private System.Windows.Forms.Button btn_Attendance;
        private System.Windows.Forms.Button btn_Result;
    }
}