namespace SMSSchoolForm2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.lbStaff = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabTeachers);
            this.tabControl1.Controls.Add(this.tabStaff);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.lbStudent);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(251, 211);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.Location = new System.Drawing.Point(7, 11);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(238, 186);
            this.lbStudent.TabIndex = 0;
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.lbTeachers);
            this.tabTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeachers.Size = new System.Drawing.Size(251, 211);
            this.tabTeachers.TabIndex = 1;
            this.tabTeachers.Text = "Teachers";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // lbTeachers
            // 
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.Location = new System.Drawing.Point(6, 12);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(238, 186);
            this.lbTeachers.TabIndex = 1;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.lbStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Size = new System.Drawing.Size(251, 211);
            this.tabStaff.TabIndex = 2;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // lbStaff
            // 
            this.lbStaff.FormattingEnabled = true;
            this.lbStaff.Location = new System.Drawing.Point(3, 9);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(238, 199);
            this.lbStaff.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "School CRUD";
            this.tabControl1.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabTeachers.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.ListBox lbTeachers;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.ListBox lbStaff;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

