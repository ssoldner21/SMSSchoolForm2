namespace SMSSchoolForm2
{
    partial class EditMember
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblClassesPassed = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.txtClassesPassed = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.cbTeacherDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dateTimeTeacherHired = new System.Windows.Forms.DateTimePicker();
            this.lblDateHiredTeacher = new System.Windows.Forms.Label();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.dateTimeStaffHired = new System.Windows.Forms.DateTimePicker();
            this.lblDateHiredStaff = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabTeacher.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(3, 22);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(33, 13);
            this.lblMajor.TabIndex = 5;
            this.lblMajor.Text = "Major";
            this.lblMajor.Visible = false;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(3, 48);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.Text = "GPA";
            this.lblGPA.Visible = false;
            // 
            // lblClassesPassed
            // 
            this.lblClassesPassed.AutoSize = true;
            this.lblClassesPassed.Location = new System.Drawing.Point(6, 75);
            this.lblClassesPassed.Name = "lblClassesPassed";
            this.lblClassesPassed.Size = new System.Drawing.Size(81, 13);
            this.lblClassesPassed.TabIndex = 7;
            this.lblClassesPassed.Text = "Classes Passed";
            this.lblClassesPassed.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudent);
            this.tabControl1.Controls.Add(this.tabTeacher);
            this.tabControl1.Controls.Add(this.tabStaff);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 190);
            this.tabControl1.TabIndex = 8;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.cbMajor);
            this.tabStudent.Controls.Add(this.txtClassesPassed);
            this.tabStudent.Controls.Add(this.txtGPA);
            this.tabStudent.Controls.Add(this.lblMajor);
            this.tabStudent.Controls.Add(this.lblClassesPassed);
            this.tabStudent.Controls.Add(this.lblGPA);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(252, 164);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Student";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Items.AddRange(new object[] {
            "IT",
            "MOS",
            "HIT",
            "MA",
            "CJ",
            "BAMM",
            "BAA"});
            this.cbMajor.Location = new System.Drawing.Point(144, 19);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(100, 21);
            this.cbMajor.TabIndex = 12;
            this.cbMajor.Visible = false;
            // 
            // txtClassesPassed
            // 
            this.txtClassesPassed.Enabled = false;
            this.txtClassesPassed.Location = new System.Drawing.Point(144, 72);
            this.txtClassesPassed.Name = "txtClassesPassed";
            this.txtClassesPassed.Size = new System.Drawing.Size(100, 20);
            this.txtClassesPassed.TabIndex = 10;
            this.txtClassesPassed.Visible = false;
            // 
            // txtGPA
            // 
            this.txtGPA.Enabled = false;
            this.txtGPA.Location = new System.Drawing.Point(144, 45);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 9;
            this.txtGPA.Visible = false;
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.cbTeacherDepartment);
            this.tabTeacher.Controls.Add(this.lblDepartment);
            this.tabTeacher.Controls.Add(this.dateTimeTeacherHired);
            this.tabTeacher.Controls.Add(this.lblDateHiredTeacher);
            this.tabTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacher.Size = new System.Drawing.Size(252, 164);
            this.tabTeacher.TabIndex = 1;
            this.tabTeacher.Text = "Teacher";
            this.tabTeacher.UseVisualStyleBackColor = true;
            // 
            // cbTeacherDepartment
            // 
            this.cbTeacherDepartment.FormattingEnabled = true;
            this.cbTeacherDepartment.Items.AddRange(new object[] {
            "IT",
            "Medical",
            "Business",
            "CJ"});
            this.cbTeacherDepartment.Location = new System.Drawing.Point(13, 93);
            this.cbTeacherDepartment.Name = "cbTeacherDepartment";
            this.cbTeacherDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbTeacherDepartment.TabIndex = 3;
            this.cbTeacherDepartment.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(10, 66);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.Visible = false;
            // 
            // dateTimeTeacherHired
            // 
            this.dateTimeTeacherHired.Location = new System.Drawing.Point(10, 39);
            this.dateTimeTeacherHired.Name = "dateTimeTeacherHired";
            this.dateTimeTeacherHired.Size = new System.Drawing.Size(234, 20);
            this.dateTimeTeacherHired.TabIndex = 1;
            this.dateTimeTeacherHired.Visible = false;
            // 
            // lblDateHiredTeacher
            // 
            this.lblDateHiredTeacher.AutoSize = true;
            this.lblDateHiredTeacher.Location = new System.Drawing.Point(7, 13);
            this.lblDateHiredTeacher.Name = "lblDateHiredTeacher";
            this.lblDateHiredTeacher.Size = new System.Drawing.Size(58, 13);
            this.lblDateHiredTeacher.TabIndex = 0;
            this.lblDateHiredTeacher.Text = "Date Hired";
            this.lblDateHiredTeacher.Visible = false;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.dateTimeStaffHired);
            this.tabStaff.Controls.Add(this.lblDateHiredStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Size = new System.Drawing.Size(252, 164);
            this.tabStaff.TabIndex = 2;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // dateTimeStaffHired
            // 
            this.dateTimeStaffHired.Location = new System.Drawing.Point(6, 49);
            this.dateTimeStaffHired.Name = "dateTimeStaffHired";
            this.dateTimeStaffHired.Size = new System.Drawing.Size(234, 20);
            this.dateTimeStaffHired.TabIndex = 3;
            this.dateTimeStaffHired.Visible = false;
            // 
            // lblDateHiredStaff
            // 
            this.lblDateHiredStaff.AutoSize = true;
            this.lblDateHiredStaff.Location = new System.Drawing.Point(3, 23);
            this.lblDateHiredStaff.Name = "lblDateHiredStaff";
            this.lblDateHiredStaff.Size = new System.Drawing.Size(58, 13);
            this.lblDateHiredStaff.TabIndex = 2;
            this.lblDateHiredStaff.Text = "Date Hired";
            this.lblDateHiredStaff.Visible = false;
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSubmit);
            this.Name = "EditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Member";
            this.tabControl1.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.tabTeacher.ResumeLayout(false);
            this.tabTeacher.PerformLayout();
            this.tabStaff.ResumeLayout(false);
            this.tabStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblClassesPassed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabTeacher;
        private System.Windows.Forms.TextBox txtClassesPassed;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.ComboBox cbTeacherDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DateTimePicker dateTimeTeacherHired;
        private System.Windows.Forms.Label lblDateHiredTeacher;
        private System.Windows.Forms.DateTimePicker dateTimeStaffHired;
        private System.Windows.Forms.Label lblDateHiredStaff;
        private System.Windows.Forms.ComboBox cbMajor;
    }
}