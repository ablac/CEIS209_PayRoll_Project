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

            //Write Employee Objects to file
            for (int i = 0; i < EmployeesListBox.Items.Count; i++)
            {
                Employee temp = (Employee)EmployeesListBox.Items[i];

                //Write to File
                sw.WriteLine(temp.FirstName + "," + temp.LastName + "," + temp.SSN + ","
                    + temp.HireDate.ToShortDateString());

                //Display Message to user
                displayLabel.Text = $"{message}";
            }
            //Close File
            sw.Close();
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

                    //Import Data
                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hireDate = DateTime.Parse(parts[3]);

                    //Create Employee Object
                    Employee emp = new Employee(fName, lName, ssn, hireDate);
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
