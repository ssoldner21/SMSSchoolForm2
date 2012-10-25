using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSSchoolForm2
{
    //[Serializable()]
    public class School //added static
    {
        private String name;
        private String address1;
        private String address2;
        private String city;
        private String state;
        private Int32 zip;
        private String phoneNumber;
        private String fax;
        public List<Staff> StaffMembers = new List<Staff>();
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Student> Students = new List<Student>();

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public String Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        public Int32 Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public String Fax
        {
            get { return fax; }
            set { fax = value; }
        }
    }
}
