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
    public partial class EditMember : Form
    {
        public int STSmSwitch;
        public Student editStudent = new Student();
        public Teacher editTeacher = new Teacher();
        public Staff editStaffMember = new Staff();

        public EditMember(Student s, int tabIndexSwitch)
        {
            InitializeComponent();
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtGPA.Text = Convert.ToString(s.GradePointAverage);
            cbMajor.SelectedItem = s.Major;
            editStudent = s;
            STSmSwitch = tabIndexSwitch;
            tabControl1.SelectedIndex = STSmSwitch;
            lblGPA.Visible = true;
            txtGPA.Visible = true;            
            lblMajor.Visible = true;
            cbMajor.Visible = true;
            lblClassesPassed.Visible = true;
            txtClassesPassed.Visible = true;

        }

        public EditMember(Teacher t, int tabIndexSwitch)
        {
            
            InitializeComponent();
            txtFirstName.Text = t.FirstName;
            txtLastName.Text = t.LastName;
            dateTimeTeacherHired.Value = t.DateHired;
            cbTeacherDepartment.Text = t.Department;
            editTeacher = t;
            STSmSwitch = tabIndexSwitch;
            tabControl1.SelectedIndex = STSmSwitch;
            lblDateHiredTeacher.Visible = true;
            dateTimeTeacherHired.Visible = true;
            lblDepartment.Visible = true;
            cbTeacherDepartment.Visible = true;
        }

        public EditMember(Staff sm, int tabIndexSwitch)
        {
            InitializeComponent();
            txtFirstName.Text = sm.FirstName;
            txtLastName.Text = sm.LastName;
            dateTimeStaffHired.Value = sm.DateHired;
            editStaffMember = sm;
            STSmSwitch = tabIndexSwitch;
            tabControl1.SelectedIndex = STSmSwitch;
            lblDateHiredStaff.Visible = true;
            dateTimeStaffHired.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (STSmSwitch)
            { 
                case 0:
                    editStudent.FirstName = txtFirstName.Text;
                    editStudent.LastName = txtLastName.Text;
                    editStudent.GradePointAverage = Convert.ToDouble(txtGPA.Text);
                    editStudent.Major = cbMajor.SelectedItem.ToString();
                    break;

                case 1:
                    editTeacher.FirstName = txtFirstName.Text;
                    editTeacher.LastName = txtLastName.Text;
                    editTeacher.DateHired = dateTimeTeacherHired.Value;
                    editTeacher.Department = cbTeacherDepartment.SelectedItem.ToString();
                    break;

                case 2:
                    editStaffMember.FirstName = txtFirstName.Text;
                    editStaffMember.LastName = txtLastName.Text;
                    editStaffMember.DateHired = dateTimeStaffHired.Value;
                    break;
            }
            this.Close();
        }
    }
}
