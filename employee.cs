using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEIS209_PayRoll_Project
{
    class Employee
    {
        //Attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;

        //Constructors
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = DateTime.MinValue;
        }
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            SSN = ssn;
            HireDate = hireDate;
        }
        //Behaviors
        public override string ToString()
        {
            //Name, SSS: (Number), Hire Date: (Date)
            return firstName + " " + lastName + " " + ", SSN: " + ssn + ", Hire Date: " + hireDate.ToShortDateString();
        }
        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = "Unknown";
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 0)
                    lastName = value;
                else
                    lastName = "Unknown";
            }
        }
        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length == 9 || value.Length == 11)
                    ssn = value;
                else
                    ssn = "Unknown";
            }
        }
        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                if (value.Year > 1950 && value.Year < DateTime.Now.Year + 1)
                    hireDate = value;
                else
                    hireDate = DateTime.MinValue;
            }
        }
    }
}
