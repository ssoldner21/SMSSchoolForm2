using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSSchoolForm2
{
    //[Serializable()]
    public class Student : Person
    {
        private String major;
        private Double gpa;
        private List<String> classesPassed = new List<String>();

        public String Major //IT, MOS, HIT, MA, CJ, BAMM, BAA
        {
            get { return major; }
            set { if (value.ToUpper() == "IT" || value.ToUpper() == "MOS" || value.ToUpper() == "HIT" || value.ToUpper() == "MA" || value.ToUpper() == "CJ" || value.ToUpper() == "BAMM" || value.ToUpper() == "BAA") major = value.ToUpper(); }
        }

        public Double GradePointAverage //0.0 - 4.0
        {
            get { return gpa; }
            set { if (value >= 0.0 || value <= 4.0) gpa = value; }
        }

        public List<String> ClassesPassed
        {
            get { return classesPassed; }
            set { classesPassed = value; }
        }

    }
}
