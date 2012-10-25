using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSSchoolForm2
{
    //[Serializable()]
    public class Staff : Person
    {
        private DateTime dateHired;

        public DateTime DateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }
    }
}
