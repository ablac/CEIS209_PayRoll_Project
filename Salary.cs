using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEIS209_PayRoll_Project
{
    internal class Salary : Employee
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        private double annualSalary;

        //*************************************************************
        //*************************CONSTRUCTORS**************************
        //*************************************************************

        public Salary() : base()
        {
            annualSalary = 0.0;
        }
        
        public Salary(string firstName, string lastName, string ssn, DateTime hireDate,
            Benefits benefits, double annualSalary) : base(firstName, lastName, ssn, hireDate, benefits)
        {
            AnnualSalary = annualSalary;
        }

        //*************************************************************
        //*************************BEHAVIORS**************************
        //*************************************************************

        public override string ToString()
        {
            return base.ToString() + $", Salary {annualSalary.ToString("C")}";
        }

        public override double CalculatePay()
        {
            return annualSalary / 26.0;
        }

        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************

        //************************************
        //************SALARY*************
        //************************************
        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if (value > 0.0 && value < 10000000.0)
                    annualSalary = value;
                else
                    annualSalary = 0.0;
            }
        }
    }
}
