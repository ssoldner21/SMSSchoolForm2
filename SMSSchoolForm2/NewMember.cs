using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSSchoolForm2
{
    public partial class NewMember : Form
    {
        public static School school1 = Program.school1;
        public Student newStudent = new Student();
        public Teacher newTeacher = new Teacher();
        public Staff newStaffMember = new Staff();
        public Int32 tabIndex;

        public NewMember(Student s, int index)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = index;
            s = newStudent;
            tabIndex = index;
            lblClassesPassed.Visible = true;
            lblGPA.Visible = true;
            lblMajor.Visible = true;
            cbMajor.Visible = true;
            txtClassesPassed.Visible = true;
            txtGPA.Visible = true;
        }

        public NewMember(Teacher t, int index)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = index;
            t = newTeacher;
            tabIndex = index;
            lblDepartment.Visible = true;
            lblDateHiredTeacher.Visible = true;
            dateTimeTeacherHired.Visible = true;
            cbTeacherDepartment.Visible = true;
        }

        public NewMember(Staff sm, int index)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = index;
            sm = newStaffMember;
            tabIndex = index;
            lblDateHiredStaff.Visible = true;
            dateTimeStaffHired.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (tabIndex)
            { 
                case 0:
                    newStudent.FirstName = textBox1.Text;
                    newStudent.LastName = textBox2.Text;
                    newStudent.GradePointAverage = 0.0;
                    newStudent.Major = cbMajor.SelectedText;
                    school1.Students.Add(newStudent);
                    Close();
                    break;
                case 1:
                    newTeacher.FirstName = textBox1.Text;
                    newTeacher.LastName = textBox2.Text;
                    newTeacher.DateHired = dateTimeTeacherHired.Value;
                    newTeacher.Department = cbTeacherDepartment.SelectedText;
                    school1.Teachers.Add(newTeacher);
                    Close();
                    break;
                case 2:
                    newStaffMember.FirstName = textBox1.Text;
                    newStaffMember.LastName = textBox2.Text;
                    school1.StaffMembers.Add(newStaffMember);
                    Close();
                    break;
            }
        }
    }
}
