using System;
using System.IO;
//****************************************************************************************************************
//****************************************************FUNCTIONS***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class MainForm
    {
        //FileName for Saved Data
        private const String FILENAME = "Employees.csv";
        //************************************
        //***********WRITE TO FILE************
        //************************************
        private void WriteEmpsToFile(string message)
        {
            //Open File
            StreamWriter sw = new StreamWriter(FILENAME);
            using (sw)
            {
                //Write Employee Objects to file
                foreach (Employee temp in EmployeesListBox.Items)
                {
                    //Write to File
                    sw.WriteLine(temp.FirstName + ',' + temp.LastName + ',' + temp.SSN + ','
                        + temp.HireDate.ToShortDateString() + ',' 
                        + temp.BenefitsPackage.HealthInsurance + ',' + temp.BenefitsPackage.LifeInsurance 
                        + ',' + temp.BenefitsPackage.Vacation);

                    //Display Message to user
                    displayLabel.Text = $"{message}";
                }
            }
        }
        //************************************
        //*************READ FILE**************
        //************************************
        private void ReadEmpsFromFile()
        {
            //Read all employee data from file
            StreamReader sr = new StreamReader(FILENAME);

            using (sr)
            {
                while (sr.Peek() != -1)
                {
                    //Read line, and break into parts
                    string line = sr.ReadLine();

                    //Split Data
                    string[] parts = line.Split(',');

                    //Import EMP Data
                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);
                    //Import Benefits
                    string healthINS = parts[4];
                    double lifeINS = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    //Create Employee Object
                    Employee emp = new Employee(fName, lName, ssn, hireDate, 
                        new Benefits(healthINS, lifeINS, vacation));
                    EmployeesListBox.Items.Add(emp);

                    //Display message to user
                    displayLabel.Text = $"{FILENAME} loaded successfully!";
                }
            }
        }
        //************************************
        //*********READ FILE ON LOAD**********
        //************************************
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load Employees from file
            this.ReadEmpsFromFile();
        }
    }
}