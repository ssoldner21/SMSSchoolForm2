using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSSchoolForm2
{
//[Serializable()]
    public abstract class Person  //abstract = can't JUST create a Person but those classes that inherit Person will inherit it
    {
        private String firstName;
        private String lastName;
        private Char gender;
        private DateTime birthDate;

        public String FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Count() <= 25)
                {
                    firstName = value;
                }
                else
                {
                    firstName = value.Remove(25);
                }
            }
        }

        public String LastName
        {
            get { return lastName; }
            set
            {
                if (value.Count() <= 25)
                {
                    lastName = value;
                }
                else
                {
                    lastName = value.Remove(25);
                }
            }
        }
        // triple / used to put a description in intellisense
        /// <summary> 
        /// This property allows M or F for the gender. m or f is allowed but will be saved as uppercase
        /// </summary>
        public Char Gender
        {
            get { return gender; }
            set { if (value.ToString().ToUpper() == "M" || value.ToString().ToUpper() == "F") gender = Convert.ToChar(value.ToString().ToUpper()); }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        /// <summary>
        /// Prints the first name.
        /// </summary>
        /// <param name="numTimes">Amount of times it prints firstName.</param>
        /// <returns>String of first name.</returns>

        public String PrintSummary(int numTimes = 1)
        {
            for (int i = 1; i <= numTimes; i++)
            {
                Console.WriteLine(this.firstName);
            }

            return this.FirstName;
        }
    }
}
