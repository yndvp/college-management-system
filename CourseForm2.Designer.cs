namespace CollegeManagementSystem
{
    partial class CourseForm2
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
            this.degreeBox = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.Label();
            this.numberofsemestersBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coursenameBox = new System.Windows.Forms.TextBox();
            this.coursename = new System.Windows.Forms.Label();
            this.coursecodeBox = new System.Windows.Forms.TextBox();
            this.coursecode = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.sqlTable = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.CourseManagementTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlTable)).BeginInit();
            this.SuspendLayout();
            // 
            // degreeBox
            // 
            this.degreeBox.Location = new System.Drawing.Point(90, 193);
            this.degreeBox.Name = "degreeBox";
            this.degreeBox.Size = new System.Drawing.Size(100, 20);
            this.degreeBox.TabIndex = 46;
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Location = new System.Drawing.Point(17, 196);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(45, 13);
            this.degree.TabIndex = 45;
            this.degree.Text = "Degree ";
            // 
            // numberofsemestersBox
            // 
            this.numberofsemestersBox.Location = new System.Drawing.Point(132, 167);
            this.numberofsemestersBox.Name = "numberofsemestersBox";
            this.numberofsemestersBox.Size = new System.Drawing.Size(58, 20);
            this.numberofsemestersBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Number of semesters ";
            // 
            // coursenameBox
            // 
            this.coursenameBox.Location = new System.Drawing.Point(90, 141);
            this.coursenameBox.Name = "coursenameBox";
            this.coursenameBox.Size = new System.Drawing.Size(100, 20);
            this.coursenameBox.TabIndex = 42;
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Location = new System.Drawing.Point(17, 144);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(69, 13);
            this.coursename.TabIndex = 41;
            this.coursename.Text = "Course name";
            // 
            // coursecodeBox
            // 
            this.coursecodeBox.Location = new System.Drawing.Point(446, 294);
            this.coursecodeBox.Name = "coursecodeBox";
            this.coursecodeBox.Size = new System.Drawing.Size(100, 20);
            this.coursecodeBox.TabIndex = 40;
            // 
            // coursecode
            // 
            this.coursecode.AutoSize = true;
            this.coursecode.Location = new System.Drawing.Point(373, 297);
            this.coursecode.Name = "coursecode";
            this.coursecode.Size = new System.Drawing.Size(67, 13);
            this.coursecode.TabIndex = 39;
            this.coursecode.Text = "Course code";
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnreset.Location = new System.Drawing.Point(90, 295);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(72, 31);
            this.btnreset.TabIndex = 38;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(12, 295);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(72, 31);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "Save Info";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // sqlTable
            // 
            this.sqlTable.AllowUserToAddRows = false;
            this.sqlTable.AllowUserToDeleteRows = false;
            this.sqlTable.AllowUserToResizeColumns = false;
            this.sqlTable.AllowUserToResizeRows = false;
            this.sqlTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sqlTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sqlTable.Location = new System.Drawing.Point(219, 35);
            this.sqlTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sqlTable.Name = "sqlTable";
            this.sqlTable.RowHeadersWidth = 51;
            this.sqlTable.RowTemplate.Height = 27;
            this.sqlTable.Size = new System.Drawing.Size(433, 253);
            this.sqlTable.TabIndex = 71;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.editButton.Location = new System.Drawing.Point(219, 296);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(72, 31);
            this.editButton.TabIndex = 72;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(297, 296);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 31);
            this.deleteButton.TabIndex = 73;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CourseManagementTitle
            // 
            this.CourseManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseManagementTitle.Location = new System.Drawing.Point(12, 9);
            this.CourseManagementTitle.Name = "CourseManagementTitle";
            this.CourseManagementTitle.Size = new System.Drawing.Size(202, 22);
            this.CourseManagementTitle.TabIndex = 74;
            this.CourseManagementTitle.Text = "Course Management";
            this.CourseManagementTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(565, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 31);
            this.backButton.TabIndex = 75;
            this.backButton.Text = "Main from";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CourseForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 337);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.CourseManagementTitle);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.sqlTable);
            this.Controls.Add(this.degreeBox);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.numberofsemestersBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coursenameBox);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.coursecodeBox);
            this.Controls.Add(this.coursecode);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsave);
            this.Name = "CourseForm2";
            this.Text = "CourseForm2";
            this.Load += new System.EventHandler(this.CourseForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox degreeBox;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.TextBox numberofsemestersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coursenameBox;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.TextBox coursecodeBox;
        private System.Windows.Forms.Label coursecode;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView sqlTable;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label CourseManagementTitle;
        private System.Windows.Forms.Button backButton;
    }
}