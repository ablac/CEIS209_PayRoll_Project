using System;
//****************************************************************************************************************
//****************************************************EMPLOYEE****************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    [Serializable]
    class Employee
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        protected string firstName;
        protected string lastName;
        protected string ssn;
        protected DateTime hireDate;
        protected Benefits benefits;

        //*************************************************************
        //************************CONSTRUCTORS*************************
        //*************************************************************

        //************************************
        //************SET DEFAULT*************
        //************************************
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = DateTime.MinValue;
        }
        //************************************
        //************SET INPUTS**************
        //************************************
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            HireDate = hireDate;
            BenefitsPackage = benefits;
        }
        //*************************************************************
        //**************************BEHAVIORS**************************
        //*************************************************************

        //************************************
        //************RETURN DATA*************
        //************************************
        public override string ToString()
        {
            //Name, SSS: (Number), Hire Date: (Date)
            return $"{firstName} {lastName}, SSN: {ssn}, Hiredate: {hireDate.ToShortDateString()}";
        }
        //************************************
        //***********CALCULATE PAY************
        //************************************
        public virtual double CalculatePay()
        {
            return 0.0;
        }
        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************

        //************************************
        //*************FIRSTNAME**************
        //************************************
        public string FirstName
        {
            get{return firstName;}
            set
            {
                //verify input exists
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = "Unknown";
            }
        }
        //************************************
        //*************LASTNAME***************
        //************************************
        public string LastName
        {
            get{return lastName;}
            set
            {
                //Verify input exists
                if (value.Length > 0)
                    lastName = value;
                else
                    lastName = "Unknown";
            }
        }
        //************************************
        //****************SSN*****************
        //************************************
        public string SSN
        {
            get{return ssn;}
            set
            {
                //SSN = 222222222 or 222-22-22222
                if (value.Length == 9 || value.Length == 11)
                    ssn = value;
                else
                    ssn = "Unknown";
            }
        }
        //************************************
        //*************HIREDATE***************
        //************************************
        public DateTime HireDate
        {
            get{return hireDate;}
            set
            {
                //Verify Date is not to Old or in the Future.
                if (value.Year > 1950 && value.Year < DateTime.Now.Year + 1)
                    hireDate = value;
                else
                    hireDate = DateTime.MinValue;
            }
        }
        //************************************
        //*********BENEFITS PACKAGE***********
        //************************************
        public Benefits BenefitsPackage
        {
            get { return benefits;}
            set { benefits = value; }
        }
    }
}