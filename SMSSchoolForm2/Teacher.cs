using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSSchoolForm2
{
    public class Teacher : Staff
    {
        private String department;

        public String Department
        {
            get { return department; }
            set { if (value.ToUpper() == "IT" || value.ToUpper() == "Medical" || value.ToUpper() == "Business" || value.ToUpper() == "CJ") department = value.ToUpper(); }
        }

    }
}
