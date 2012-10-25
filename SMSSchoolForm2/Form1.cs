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
    public partial class Form1 : Form
    {
        public static School school1 = Program.school1;

        public void populateStudents()
        {
            lbStudent.Items.Clear();
            foreach (Student s in school1.Students)
            {
                lbStudent.Items.Add(s.FirstName + " " + s.LastName);   
            }
        }

        public void populateTeachers()
        {
            lbTeachers.Items.Clear();
            foreach (Teacher t in school1.Teachers)
            {
                lbTeachers.Items.Add(t.FirstName + " " + t.LastName);
            }
        }

        public void populateStaff()
        {
            lbStaff.Items.Clear();
            foreach (Staff sm in school1.StaffMembers)
            {
                lbStaff.Items.Add(sm.FirstName + " " + sm.LastName);
            }
        }

        public Form1()
        {
            InitializeComponent();
            populateStudents();
            populateTeachers();
            populateStaff();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            { 
                case 0: //student
                    Student ns = new Student();
                    NewMember addNewStudent = new NewMember(ns, tabControl1.SelectedIndex);
                    addNewStudent.ShowDialog();
                    populateStudents();
                    break;

                case 1: //teacher
                    Teacher nt = new Teacher();
                    NewMember addNewTeacher = new NewMember(nt, tabControl1.SelectedIndex);
                    addNewTeacher.ShowDialog();
                    populateTeachers();
                    break;

                case 2: //staff
                    Staff nsm = new Staff();
                    NewMember addNewStaff = new NewMember(nsm, tabControl1.SelectedIndex);
                    addNewStaff.ShowDialog();
                    populateStaff();
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            { 
                case 0:
                    EditMember editStudent = new EditMember(school1.Students[lbStudent.SelectedIndex], tabControl1.SelectedIndex);
                    editStudent.ShowDialog();
                    populateStudents();
                    break;

                case 1:
                    EditMember editTeacher = new EditMember(school1.Teachers[lbTeachers.SelectedIndex], tabControl1.SelectedIndex);
                    editTeacher.ShowDialog();
                    populateTeachers();
                    break;    

                case 2:
                    EditMember editStaffMember = new EditMember(school1.StaffMembers[lbStaff.SelectedIndex], tabControl1.SelectedIndex);
                    editStaffMember.ShowDialog();
                    populateStaff();
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    school1.Students.Remove(school1.Students[lbStudent.SelectedIndex]);
                    populateStudents();
                    break;

                case 1:
                    school1.Teachers.Remove(school1.Teachers[lbTeachers.SelectedIndex]);
                    populateTeachers();
                    break;

                case 2:
                    school1.StaffMembers.Remove(school1.StaffMembers[lbStaff.SelectedIndex]);
                    populateStaff();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
