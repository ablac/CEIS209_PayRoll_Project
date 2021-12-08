using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEIS209_PayRoll_Project
{
    internal class Benefits
    {
        //*************************************************************
        //*************************ATTRIBUTES**************************
        //*************************************************************
        private string healthInsurance;
        private double lifeInsurance;
        private int vacation;
        //*************************************************************
        //************************CONSTRUCTORS*************************
        //*************************************************************
        public Benefits()
        {
            healthInsurance = "Unknown";
            lifeInsurance = 0.0;
            vacation = 0;
        }

        public Benefits(string healthInsurance, double lifeInsurance, int vacation)
        {
            HealthInsurance = healthInsurance;
            LifeInsurance = lifeInsurance;
            Vacation = vacation;
        }
        //*************************************************************
        //*************************BEHAVIORS***************************
        //*************************************************************
        public override string ToString()
        {
            return $"HealthInsurance: {healthInsurance}, Life Insurance: {lifeInsurance}, VacationDays: {vacation}";
        }

        //*************************************************************
        //*************************PROPERTIES**************************
        //*************************************************************

        //************************************
        //**********HEALTH INSURANCE**********
        //************************************
        public string HealthInsurance
        {
            get { return healthInsurance; }
            set
            {
                if (value.Length > 0)
                    healthInsurance = value;
                else
                    healthInsurance = "Unknown";
            }
        }
        //************************************
        //***********LIFE INSURANCE***********
        //************************************
        public double LifeInsurance
        {
            get { return lifeInsurance; }
            set
            {
                if (value > 0.0 && value <= 10000000.0)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0.0;
            }
        }
        //************************************
        //**************VACATION**************
        //************************************
        public double Vacation
        {
            get { return vacation; }
            set
            {
                if (value > 0 && value <= 40)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0;
            }
        }
    }
}
