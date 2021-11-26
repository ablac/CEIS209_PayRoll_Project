﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//****************************************************************************************************************
//*****************************************************MAINFORM***************************************************
//****************************************************************************************************************
namespace CEIS209_PayRoll_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //************************************
        //************ADD BUTTON**************
        //************************************
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add item to the employee listbox
            EmployeesListBox.Items.Add("New Employee");
        }
        //************************************
        //***********REMOVE BUTTON************
        //************************************
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove the selected item from the employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;
            if(itemNumber > -1)
            {
                //Remove Selected Employee
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                //Display message
                MB("Please Select employee to remove.", "Error!", MessageBoxIcon.Error);
            }
        }
        //************************************
        //**********DISPLAY BUTTON************
        //************************************
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //Display all Employees
            MB("Displaying all employees...", "Display All", MessageBoxIcon.Exclamation);
        }
        //************************************
        //************PRINT BUTTON************
        //************************************
        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            //Print Paychecks
            MB("Printing paychecks for all employees...", "Printing", MessageBoxIcon.Exclamation);
            Employee emp = new Employee();
        }
    }
}
