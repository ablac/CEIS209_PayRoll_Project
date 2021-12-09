using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEIS209_PayRoll_Project
{
    internal class Hourly : Employee
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        private float hourlyRate;
        private float hoursWorked;

        //*************************************************************
        //*************************CONSTRUCTORS**************************
        //*************************************************************

        public Hourly() : base()
        {
            hourlyRate = 0.0f;
            hoursWorked = 0.0f;
        }

        public Hourly(string firstName, string lastName, string ssn, DateTime hireDate,
            Benefits benefits, float hourlyRate, float hoursWorked) 
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        //*************************************************************
        //*************************BEHAVIORS**************************
        //*************************************************************

        public override string ToString()
        {
            return base.ToString() + $", HourlyRate: {hourlyRate.ToString("C")}, Hoursworked: {hoursWorked.ToString()}";
        }

        public override double CalculatePay()
        {
            double pay = 0.0;

            if (HoursWorked > 40.0f)
            {
                double basePay = hourlyRate * 40f;
                double overTime = (hoursWorked - 40.0f) * hourlyRate * 1.5f;
                pay = basePay + overTime;
            }
            else
            {
                pay = hoursWorked * hourlyRate;
            }
            return pay;
        }

        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************

        //************************************
        //************HOURLY RATE*************
        //************************************
        public float HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value > 0.0f && value <= 1000.0f)
                    hourlyRate = value;
                else
                    hourlyRate = 0.0f;
            }
        }
        //************************************
        //************HOURS WORKED************
        //************************************
        public float HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value > 0.0f && value <= 160.0f)
                    hoursWorked = value;
                else
                    hoursWorked = 0.0f;
            }
        }
    }
}
}
