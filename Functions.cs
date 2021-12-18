using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Translator to Binary
//****************************************************************************************************************
//****************************************************FUNCTIONS***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class messageLogForm
    {
        private System.Windows.Forms.ListBox messageLog;

        //FileName for Saved Data
        private const String FILENAME = "Employees.dat";
        //************************************
        //***********WRITE TO FILE************
        //************************************
        private void WriteEmpsToFile(string message)
        {
            displayLabel.Text = $"Searching for {FILENAME}";
            //Convert the listbox items - Generic Collection
            List<Employee> emplist = new List<Employee>();

            foreach (Employee emp in EmployeesListBox.Items)
            {
                emplist.Add(emp);
                displayLabel.Text = "Update Employee Data";
            }
            displayLabel.Text = "Update Employee Data Successful";

            //Open/Create File
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            //write the Generic List to file
            formatter.Serialize(fs, emplist);

            //Save/Close FIle
            fs.Close();
            displayLabel.Text = $"{message}";
        }
        //************************************
        //*************READ FILE**************
        //************************************
        private void ReadEmpsFromFile()
        {
            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                displayLabel.Text = $"Searching for {FILENAME}";
                //Open/Translate FIle
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                //Read all employee Data
                List<Employee> emplist = (List<Employee>)formatter.Deserialize(fs);

                //Close the File
                fs.Close();

                //Copy Employee Objects -> Listbox
                foreach (Employee emp in emplist)
                {
                    EmployeesListBox.Items.Add(emp);
                }
                displayLabel.Text = $"Loaded {FILENAME} - Successfully";
            }
            else
            {
                displayLabel.Text = $"{FILENAME} not found!";
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