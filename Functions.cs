using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//****************************************************************************************************************
//****************************************************FUNCTIONS***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class MainForm
    {

        private string fileName = "Employees.csv";
        //************************************
        //************MESSAGE BOX*************
        //************************************
        private void MB(string Text, string Title, MessageBoxIcon ICON)
        {
            //Create Messagebox
            MessageBox.Show(Text, Title, MessageBoxButtons.OKCancel, ICON);
        }

        private void WriteEmpsToFile()
        {
            //Open File
            StreamWriter sw = new StreamWriter(fileName);

            //Write Employee Objects to file
            for (int i = 0; i < EmployeesListBox.Items.Count; i++)
            {
                Employee temp = (Employee)EmployeesListBox.Items[i];

                //Write to File
                sw.WriteLine(temp.FirstName + "," + temp.LastName + "," + temp.SSN + ","
                    + temp.HireDate.ToShortDateString());

            }
            //Close File
            sw.Close();

            //Tell user file saved.
            MB("Employees saved to file!", "Saved!", MessageBoxIcon.Exclamation);
        }
    }
}
