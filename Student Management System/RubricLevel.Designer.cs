namespace Student_Management_System
{
    partial class RubricLevel
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddStudents = new System.Windows.Forms.Button();
            this.btn_AddClo = new System.Windows.Forms.Button();
            this.btn_AddRubrics = new System.Windows.Forms.Button();
            this.btn_RubricLevel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.btn_RubricLevel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.259528F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
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
            this.btn_AddStudents.Location = new System.Drawing.Point(3, 65);
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
            this.btn_AddClo.Location = new System.Drawing.Point(3, 115);
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
            this.btn_AddRubrics.Location = new System.Drawing.Point(3, 165);
            this.btn_AddRubrics.Name = "btn_AddRubrics";
            this.btn_AddRubrics.Size = new System.Drawing.Size(231, 44);
            this.btn_AddRubrics.TabIndex = 2;
            this.btn_AddRubrics.Text = "Add Rubrics";
            this.btn_AddRubrics.UseVisualStyleBackColor = true;
            this.btn_AddRubrics.Click += new System.EventHandler(this.btn_AddRubrics_Click);
            // 
            // btn_RubricLevel
            // 
            this.btn_RubricLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RubricLevel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_RubricLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RubricLevel.Font = new System.Drawing.Font("Myriad Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RubricLevel.Location = new System.Drawing.Point(3, 215);
            this.btn_RubricLevel.Name = "btn_RubricLevel";
            this.btn_RubricLevel.Size = new System.Drawing.Size(231, 40);
            this.btn_RubricLevel.TabIndex = 3;
            this.btn_RubricLevel.Text = "Rubric Level";
            this.btn_RubricLevel.UseVisualStyleBackColor = true;
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RubricLevel";
            this.Text = "RubricLevel";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_AddStudents;
        private System.Windows.Forms.Button btn_AddClo;
        private System.Windows.Forms.Button btn_AddRubrics;
        private System.Windows.Forms.Button btn_RubricLevel;
    }
}