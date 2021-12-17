using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//****************************************************************************************************************
//****************************************************BENEFITS****************************************************
//****************************************************************************************************************

namespace CEIS209_PayRoll_Project
{
    [Serializable]
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

        //************************************
        //***********SET DEFAULTS*************
        //************************************
        public Benefits()
        {
            healthInsurance = "Unknown";
            lifeInsurance = 0.0;
            vacation = 0;
        }
        //************************************
        //************SET INPUTS**************
        //************************************
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
                if (value > 0.0 && value < 10000000.1)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0.0;
            }
        }
        //************************************
        //**************VACATION**************
        //************************************
        public int Vacation
        {
            get { return vacation; }
            set
            {
                if (value > 0 && value < 41)
                    vacation = value;
                else
                    vacation = 0;
            }
        }
    }
}
